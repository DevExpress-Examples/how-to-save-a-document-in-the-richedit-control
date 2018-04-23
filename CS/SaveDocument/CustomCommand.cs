using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using System.Windows.Forms;

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
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Rich Text Format Files (*.rtf)|*.rtf|All Files (*.*)|*.*",
                FileName = "SavedDocument.rtf",
                RestoreDirectory = true,
                CheckFileExists = false,
                CheckPathExists = true,
                OverwritePrompt = true,
                DereferenceLinks = true,
                ValidateNames = true,
                AddExtension = false,
                FilterIndex = 1
            };
            dialog.InitialDirectory = "C:\\Temp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ((RichEditControl)this.Control).SaveDocument(dialog.FileName, DocumentFormat.Rtf);
            }
            //base.ExecuteCore();
        }
    }
        #endregion #savecommand
}
