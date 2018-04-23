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
#End Region ' #usings

Namespace SaveDocument
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			richEditControl1.LoadDocument("TextWithImages.rtf", DocumentFormat.Rtf)
		End Sub
#Region "#save"
Private Sub btnSaveToFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveToFile.Click
	richEditControl1.SaveDocument("SavedDocument.rtf", DocumentFormat.Rtf)
End Sub

Private Sub richEditControl1_BeforeExport(ByVal sender As Object, ByVal e As BeforeExportEventArgs) _
Handles richEditControl1.BeforeExport
	Dim checkDocument As DocumentExportCapabilities = richEditControl1.Document.RequiredExportCapabilities
	If (e.DocumentFormat = DocumentFormat.Rtf) AndAlso checkDocument.InlinePictures Then
		Dim reduceFileSize As DialogResult = MessageBox.Show("This document contains inline pictures."  _
& Constants.vbLf  _
& "You can reduce the file size by preventing dual picture saving although it affects file portability."  _
& Constants.vbLf _
& "Specify the compact format for a saved file?", _
 "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
		If reduceFileSize = System.Windows.Forms.DialogResult.Yes Then
			Dim options As RtfDocumentExporterOptions = TryCast(e.Options, RtfDocumentExporterOptions)
			If options IsNot Nothing Then
				options.Compatibility.DuplicateObjectAsMetafile = False
			End If
		End If
	End If
End Sub
#End Region '  #save   
	End Class
End Namespace