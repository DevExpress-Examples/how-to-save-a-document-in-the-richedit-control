Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Export
Imports DevExpress.XtraRichEdit.Services
#End Region ' #usings

Namespace SaveDocumentSample
	Partial Public Class Form1
		Inherits Form
#Region "#savecommandaddservice"
		Public Sub New()
			InitializeComponent()

			Dim commandFactory As New CustomRichEditCommandFactoryService(richEditControl1, richEditControl1.GetService(Of IRichEditCommandFactoryService)())
			richEditControl1.ReplaceService(Of IRichEditCommandFactoryService)(commandFactory)
		End Sub
		#End Region ' #savecommandaddservice

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			richEditControl1.LoadDocument("TextWithImages.rtf", DocumentFormat.Rtf)
		End Sub
#Region "#save"
Private Sub btnSaveToFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveToFile.Click
	richEditControl1.SaveDocument("SavedDocument.rtf", DocumentFormat.Rtf)
	Dim fi As New System.IO.FileInfo("SavedDocument.rtf")
	Dim msg As String = String.Format("The size of the file is {0:#,#} bytes.", fi.Length.ToString("#,#"))
	MessageBox.Show(msg)
End Sub

Private Sub richEditControl1_BeforeExport(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.BeforeExportEventArgs) Handles richEditControl1.BeforeExport
	Dim checkDocument As DocumentExportCapabilities = richEditControl1.Document.RequiredExportCapabilities
	If (e.DocumentFormat = DocumentFormat.Rtf) AndAlso checkDocument.InlinePictures Then
		Dim reduceFileSize As DialogResult = MessageBox.Show("This document contains inline pictures." & Constants.vbLf & "You can embed the same picture in two different types (original and Windows Metafile) for better compatibility" & " although it increases the file size. By default a picture is saved in original format only." & Constants.vbLf & "Enable dual picture format in a saved file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

		Dim options As RtfDocumentExporterOptions = TryCast(e.Options, RtfDocumentExporterOptions)
		If options IsNot Nothing Then
			Select Case reduceFileSize
			Case System.Windows.Forms.DialogResult.Yes
					options.Compatibility.DuplicateObjectAsMetafile = True
			Case System.Windows.Forms.DialogResult.No
					options.Compatibility.DuplicateObjectAsMetafile = False
			End Select
		End If
	End If
End Sub
#End Region '  #save
	End Class
End Namespace