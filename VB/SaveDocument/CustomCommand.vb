Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Commands
Imports System.Windows.Forms

Namespace SaveDocumentSample
	#Region "#savecommand"
	Public Class CustomRichEditCommandFactoryService
		Implements IRichEditCommandFactoryService
		Private ReadOnly service As IRichEditCommandFactoryService
		Private ReadOnly control As RichEditControl
		Public Sub New(ByVal control As RichEditControl, ByVal service As IRichEditCommandFactoryService)
			DevExpress.Utils.Guard.ArgumentNotNull(control, "control")
			DevExpress.Utils.Guard.ArgumentNotNull(service, "service")
			Me.control = control
			Me.service = service
		End Sub
		Public Function CreateCommand(ByVal id As RichEditCommandId) As RichEditCommand Implements IRichEditCommandFactoryService.CreateCommand
			If id = RichEditCommandId.FileSaveAs Then
				Return New CustomSaveDocumentAsCommand(control)
			End If

			Return service.CreateCommand(id)
		End Function
	End Class

	Public Class CustomSaveDocumentAsCommand
		Inherits SaveDocumentAsCommand
		Public Sub New(ByVal control As IRichEditControl)
			MyBase.New(control)
		End Sub

		Protected Overrides Sub ExecuteCore()
			Dim dialog As SaveFileDialog = New SaveFileDialog With {.Filter = "Rich Text Format Files (*.rtf)|*.rtf|All Files (*.*)|*.*", .FileName = "SavedDocument.rtf", .RestoreDirectory = True, .CheckFileExists = False, .CheckPathExists = True, .OverwritePrompt = True, .DereferenceLinks = True, .ValidateNames = True, .AddExtension = False, .FilterIndex = 1}
			dialog.InitialDirectory = "C:\Temp"
			If dialog.ShowDialog() = DialogResult.OK Then
				CType(Me.Control, RichEditControl).SaveDocument(dialog.FileName, DocumentFormat.Rtf)
			End If
			'base.ExecuteCore();
		End Sub
	End Class
		#End Region ' #savecommand
End Namespace
