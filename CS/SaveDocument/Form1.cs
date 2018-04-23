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
#endregion #usings

namespace SaveDocument {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            richEditControl1.LoadDocument("TextWithImages.rtf", DocumentFormat.Rtf);
        }
#region #save
private void btnSaveToFile_Click(object sender, EventArgs e) {
	richEditControl1.SaveDocument("SavedDocument.rtf", DocumentFormat.Rtf);
}

private void richEditControl1_BeforeExport(object sender, DevExpress.XtraRichEdit.BeforeExportEventArgs e) {
	DocumentExportCapabilities checkDocument = richEditControl1.Document.RequiredExportCapabilities;
	if((e.DocumentFormat == DocumentFormat.Rtf) && checkDocument.InlinePictures ) {
		DialogResult reduceFileSize = MessageBox.Show("This document contains inline pictures.\n" +
		"You can reduce the file size by preventing dual picture saving although it affects file portability.\n" +
		"Specify the compact format for a saved file?",
		"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
		if(reduceFileSize == DialogResult.Yes) {
			RtfDocumentExporterOptions options = e.Options as RtfDocumentExporterOptions;
			if(options != null) options.Compatibility.DuplicateObjectAsMetafile = false;
		}
	}
}
#endregion  #save  
    }
}