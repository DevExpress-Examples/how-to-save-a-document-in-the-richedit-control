using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
#region #usings
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Export;
using DevExpress.XtraRichEdit.Services;
#endregion #usings

namespace SaveDocumentSample
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region #savecommandaddservice
        public Form1()
        {
            InitializeComponent();

            CustomRichEditCommandFactoryService commandFactory =
                new CustomRichEditCommandFactoryService(richEditControl1,
                    richEditControl1.GetService<IRichEditCommandFactoryService>());
            richEditControl1.ReplaceService<IRichEditCommandFactoryService>(commandFactory);
        }
        #endregion #savecommandaddservice

        private void Form1_Load(object sender, EventArgs e)
        {
            richEditControl1.LoadDocument("TextWithImages.rtf", DocumentFormat.Rtf);
        }
        #region #save
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            richEditControl1.SaveDocument("SavedDocument.rtf", DocumentFormat.Rtf);
            System.IO.FileInfo fi = new System.IO.FileInfo("SavedDocument.rtf");
            string msg = String.Format("The size of the file is {0:#,#} bytes.", fi.Length.ToString("#,#"));
            XtraMessageBox.Show(msg);
        }

        private void richEditControl1_BeforeExport(object sender, DevExpress.XtraRichEdit.BeforeExportEventArgs e)
        {
            if (e.DocumentFormat == DocumentFormat.Rtf)
            {
                DialogResult reduceFileSize = XtraMessageBox.Show("Do you want to reduce the file size and avoid exporting the document theme and properties?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                RtfDocumentExporterOptions options = e.Options as RtfDocumentExporterOptions;
                if (options != null)
                {
                    switch (reduceFileSize)
                    {
                        case DialogResult.Yes:
                            options.ExportTheme = false;
                            options.ExportedDocumentProperties = DocumentPropertyNames.None;
                            break;
                        case DialogResult.No:
                            options.ExportTheme = true;
                            options.ExportedDocumentProperties = DocumentPropertyNames.All;
                            break;
                    }
                }
            }
        }
        #endregion  #save
    }
}