<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/SaveDocument/Form1.cs) (VB: [Form1.vb](./VB/SaveDocument/Form1.vb))
<!-- default file list end -->
# How to save a document in the RichEdit control


<p>This example illustrates how a document can be saved in the RichEditControl. <br />
Note that by handling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_BeforeExporttopic"><u>BeforeExport</u></a> event you can check whether the exporter should possess specific capabilities to preserve the document formatting. <br />
Another useful feature illustrated in this example is the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditExportRtfDocumentExporterCompatibilityOptions_DuplicateObjectAsMetafiletopic"><u>RtfDocumentExporterCompatibilityOptions.DuplicateObjectAsMetafile</u></a> property which determines whether an embedded object is saved two times - in the native format and as a metafile. By setting its value to <strong>false</strong> you can reduce the file size while reducing the file portability across different text editors.</p><p>See also the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument5889"><u>How to Save a Document in the RichEdit Control</u></a> document.</p>

<br/>


