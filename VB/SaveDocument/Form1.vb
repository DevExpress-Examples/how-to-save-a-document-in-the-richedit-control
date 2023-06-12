Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
'#Region "#usings"
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Export
Imports DevExpress.XtraRichEdit.Services

'#End Region  ' #usings
Namespace SaveDocumentSample

    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        '#Region "#savecommandaddservice"
        Public Sub New()
            InitializeComponent()
            Dim commandFactory As CustomRichEditCommandFactoryService = New CustomRichEditCommandFactoryService(richEditControl1, richEditControl1.GetService(Of IRichEditCommandFactoryService)())
            richEditControl1.ReplaceService(Of IRichEditCommandFactoryService)(commandFactory)
        End Sub

        '#End Region  ' #savecommandaddservice
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            richEditControl1.LoadDocument("TextWithImages.rtf", DocumentFormat.Rtf)
        End Sub

        '#Region "#save"
        Private Sub btnSaveToFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveToFile.Click
            richEditControl1.SaveDocument("SavedDocument.rtf", DocumentFormat.Rtf)
            Dim fi As IO.FileInfo = New IO.FileInfo("SavedDocument.rtf")
            Dim msg As String = String.Format("The size of the file is {0:#,#} bytes.", fi.Length.ToString("#,#"))
            XtraMessageBox.Show(msg)
        End Sub

        Private Sub richEditControl1_BeforeExport(ByVal sender As Object, ByVal e As BeforeExportEventArgs) Handles richEditControl1.BeforeExport
            If e.DocumentFormat = DocumentFormat.Rtf Then
                Dim reduceFileSize As DialogResult = XtraMessageBox.Show("Do you want to reduce the file size and avoid exporting the document theme and properties?",
                                                                         "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Dim options As RtfDocumentExporterOptions = TryCast(e.Options, RtfDocumentExporterOptions)
                If options IsNot Nothing Then
                    Select Case reduceFileSize
                        Case DialogResult.Yes
                            options.ExportTheme = False
                            options.ExportedDocumentProperties = DocumentPropertyNames.None
                        Case DialogResult.No
                            options.ExportTheme = True
                            options.ExportedDocumentProperties = DocumentPropertyNames.All
                    End Select
                End If
            End If
        End Sub
        '#End Region  ' #save
    End Class
End Namespace
