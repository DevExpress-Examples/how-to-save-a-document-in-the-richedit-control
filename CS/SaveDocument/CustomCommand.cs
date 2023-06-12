using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SaveDocumentSample
{
    #region #savecommand
    public class CustomRichEditCommandFactoryService : IRichEditCommandFactoryService
    {
        readonly IRichEditCommandFactoryService service;
        readonly RichEditControl control;
        public CustomRichEditCommandFactoryService(RichEditControl control, IRichEditCommandFactoryService service)
        {
            DevExpress.Utils.Guard.ArgumentNotNull(control, "control");
            DevExpress.Utils.Guard.ArgumentNotNull(service, "service");
            this.control = control;
            this.service = service;
        }
        public RichEditCommand CreateCommand(RichEditCommandId id)
        {
            if (id == RichEditCommandId.FileSaveAs)
                return new CustomSaveDocumentAsCommand(control);

            return service.CreateCommand(id);
        }
    }

    public class CustomSaveDocumentAsCommand : SaveDocumentAsCommand
    {
        public CustomSaveDocumentAsCommand(IRichEditControl control)
            : base(control) {}

        protected override void ExecuteCore()
        {
            using (XtraSaveFileDialog dialog = new XtraSaveFileDialog())
            {
                dialog.Filter = "Rich Text Format Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
                dialog.FileName = "SavedDocument.rtf";
                dialog.RestoreDirectory = true;
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;
                dialog.OverwritePrompt = true;
                dialog.DereferenceLinks = true;
                dialog.ValidateNames = true;
                dialog.AddExtension = false;
                dialog.FilterIndex = 1;
                dialog.InitialDirectory = "C:\\Temp";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ((RichEditControl)this.Control).SaveDocument(dialog.FileName, DocumentFormat.Rtf);
                }
            }
            //base.ExecuteCore();
        }
    }
        #endregion #savecommand
}
