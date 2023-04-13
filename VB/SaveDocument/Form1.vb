Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
'#Region "#usings"
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Export
Imports DevExpress.XtraRichEdit.Services

'#End Region  ' #usings
Namespace SaveDocumentSample

    Public Partial Class Form1
        Inherits Form

'#Region "#savecommandaddservice"
        Public Sub New()
            InitializeComponent()
            Dim commandFactory As CustomRichEditCommandFactoryService = New CustomRichEditCommandFactoryService(richEditControl1, richEditControl1.GetService(Of IRichEditCommandFactoryService)())
            richEditControl1.ReplaceService(Of IRichEditCommandFactoryService)(commandFactory)
        End Sub

'#End Region  ' #savecommandaddservice
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.LoadDocument("TextWithImages.rtf", DocumentFormat.Rtf)
        End Sub

'#Region "#save"
        Private Sub btnSaveToFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.SaveDocument("SavedDocument.rtf", DocumentFormat.Rtf)
            Dim fi As IO.FileInfo = New IO.FileInfo("SavedDocument.rtf")
            Dim msg As String = String.Format("The size of the file is {0:#,#} bytes.", fi.Length.ToString("#,#"))
            MessageBox.Show(msg)
        End Sub

        Private Sub richEditControl1_BeforeExport(ByVal sender As Object, ByVal e As BeforeExportEventArgs)
            Dim checkDocument As DocumentExportCapabilities = richEditControl1.Document.RequiredExportCapabilities
            If e.DocumentFormat = DocumentFormat.Rtf AndAlso checkDocument.InlinePictures Then
                Dim reduceFileSize As DialogResult = MessageBox.Show("This document contains inline pictures." & Microsoft.VisualBasic.Constants.vbLf & "You can embed the same picture in two different types (original and Windows Metafile) for better compatibility" & " although it increases the file size. By default a picture is saved in original format only." & Microsoft.VisualBasic.Constants.vbLf & "Enable dual picture format in a saved file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Dim options As RtfDocumentExporterOptions = TryCast(e.Options, RtfDocumentExporterOptions)
                If options IsNot Nothing Then
                    Select Case reduceFileSize
                        Case DialogResult.Yes
                            options.Compatibility.DuplicateObjectAsMetafile = True
                        Case DialogResult.No
                            options.Compatibility.DuplicateObjectAsMetafile = False
                    End Select
                End If
            End If
        End Sub
'#End Region  ' #save
    End Class
End Namespace
