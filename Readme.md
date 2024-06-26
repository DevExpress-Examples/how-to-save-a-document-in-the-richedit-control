<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611105/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1401)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomCommand.cs](./CS/SaveDocument/CustomCommand.cs) (VB: [CustomCommand.vb](./VB/SaveDocument/CustomCommand.vb))
* [Form1.cs](./CS/SaveDocument/Form1.cs) (VB: [Form1.vb](./VB/SaveDocument/Form1.vb))
<!-- default file list end -->
# How to save a document in the RichEdit control


<p>This example illustrates how a document can be saved in the RichEditControl. <br />
Note that by handling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_BeforeExporttopic"><u>BeforeExport</u></a> event you can check whether the exporter should possess specific capabilities to preserve the document formatting. <br />
Another useful feature illustrated in this example is the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditExportRtfDocumentExporterCompatibilityOptions_DuplicateObjectAsMetafiletopic"><u>RtfDocumentExporterCompatibilityOptions.DuplicateObjectAsMetafile</u></a> property which determines whether an embedded object is saved two times - in the native format and as a metafile. By setting its value to <strong>false</strong> you can reduce the file size while reducing the file portability across different text editors.</p><p>See also the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument5889"><u>How to Save a Document in the RichEdit Control</u></a> document.</p>


<h3>Description</h3>

<p>In this version you can learn how to implement a custom SaveAs command to adjust settings of the SaveAs file selection dialog. It enables you to specify default folder, filename and format for saving a document when the user clicks the Save As... button or presses F12 key.<br />
A custom command inherits from the <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditCommandsSaveDocumentAsCommandtopic"><u>SaveDocumentAsCommand</u></a> class and overrides the protected <strong>ExecuteCore</strong><strong> </strong>method. To substitute default command with a custom command, create a new command factory - the class that implements the <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditServicesIRichEditCommandFactoryServicetopic"><u>IRichEditCommandFactoryService</u></a> interface and intercepts a call that creates a <strong>SaveDocumentAsCommand</strong> command. Register the new command factory via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_ReplaceService[T]topic"><u>RichEditControl.ReplaceService&lt;T&gt;</u></a> method and the RichEditControl will execute a custom command instead of the default SaveAs command.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-save-a-document-in-the-richedit-control&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-save-a-document-in-the-richedit-control&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
