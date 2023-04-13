Namespace SaveDocumentSample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.btnSaveToFile = New DevExpress.XtraEditors.SimpleButton()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 180)
            Me.richEditControl1.MenuManager = Me.ribbonControl1
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.MailMerge.KeepLastParagraph = False
            Me.richEditControl1.Size = New System.Drawing.Size(853, 436)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            AddHandler Me.richEditControl1.BeforeExport, New DevExpress.XtraRichEdit.BeforeExportEventHandler(AddressOf Me.richEditControl1_BeforeExport)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.btnSaveToFile)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 142)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(853, 38)
            Me.panelControl1.TabIndex = 1
            ' 
            ' btnSaveToFile
            ' 
            Me.btnSaveToFile.Location = New System.Drawing.Point(12, 7)
            Me.btnSaveToFile.Name = "btnSaveToFile"
            Me.btnSaveToFile.Size = New System.Drawing.Size(168, 23)
            Me.btnSaveToFile.TabIndex = 0
            Me.btnSaveToFile.Text = "Save Document to File"
            AddHandler Me.btnSaveToFile.Click, New System.EventHandler(AddressOf Me.btnSaveToFile_Click)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 10
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.fileRibbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(853, 142)
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.printItem1)
            Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.Control = Me.richEditControl1
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.commonRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' fileNewItem1
            ' 
            Me.fileNewItem1.Id = 1
            Me.fileNewItem1.Name = "fileNewItem1"
            ' 
            ' fileOpenItem1
            ' 
            Me.fileOpenItem1.Id = 2
            Me.fileOpenItem1.Name = "fileOpenItem1"
            ' 
            ' fileSaveItem1
            ' 
            Me.fileSaveItem1.Id = 3
            Me.fileSaveItem1.Name = "fileSaveItem1"
            ' 
            ' fileSaveAsItem1
            ' 
            Me.fileSaveAsItem1.Id = 4
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            ' 
            ' quickPrintItem1
            ' 
            Me.quickPrintItem1.Id = 5
            Me.quickPrintItem1.Name = "quickPrintItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 6
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 7
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' undoItem1
            ' 
            Me.undoItem1.Id = 8
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            Me.redoItem1.Id = 9
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(853, 616)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private btnSaveToFile As DevExpress.XtraEditors.SimpleButton

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem

        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem

        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem

        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem

        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem

        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem

        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem

        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem

        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem

        Private fileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage

        Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
    End Class
End Namespace
