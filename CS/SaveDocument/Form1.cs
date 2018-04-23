using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Export;
using DevExpress.XtraRichEdit.Services;
#endregion #usings

namespace SaveDocumentSample {
    public partial class Form1 : Form
    {
#region #savecommandaddservice
        public Form1() {
            InitializeComponent();

            CustomRichEditCommandFactoryService commandFactory = 
                new CustomRichEditCommandFactoryService(richEditControl1, 
                    richEditControl1.GetService<IRichEditCommandFactoryService>());
            richEditControl1.ReplaceService<IRichEditCommandFactoryService>(commandFactory);
        }
        #endregion #savecommandaddservice

        private void Form1_Load(object sender, EventArgs e) {
            richEditControl1.LoadDocument("TextWithImages.rtf", DocumentFormat.Rtf);
        }
#region #save
private void btnSaveToFile_Click(object sender, EventArgs e) {
	richEditControl1.SaveDocument("SavedDocument.rtf", DocumentFormat.Rtf);
    System.IO.FileInfo fi = new System.IO.FileInfo("SavedDocument.rtf");
    string msg = String.Format("The size of the file is {0:#,#} bytes.", fi.Length.ToString("#,#"));
    MessageBox.Show(msg);
}

private void richEditControl1_BeforeExport(object sender, DevExpress.XtraRichEdit.BeforeExportEventArgs e) {
	DocumentExportCapabilities checkDocument = richEditControl1.Document.RequiredExportCapabilities;
	if((e.DocumentFormat == DocumentFormat.Rtf) && checkDocument.InlinePictures ) {
		DialogResult reduceFileSize = MessageBox.Show("This document contains inline pictures.\n" +
        "You can embed the same picture in two different types (original and Windows Metafile) for better compatibility" +
        " although it increases the file size. By default a picture is saved in original format only.\n" +
		"Enable dual picture format in a saved file?",
		"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        RtfDocumentExporterOptions options = e.Options as RtfDocumentExporterOptions;
        if(options != null) {
            switch (reduceFileSize) {
            case DialogResult.Yes:
                    options.Compatibility.DuplicateObjectAsMetafile = true;
                    break;
            case System.Windows.Forms.DialogResult.No:
                    options.Compatibility.DuplicateObjectAsMetafile = false;
                    break;
            }
        }
    }
}
#endregion  #save
    }
}