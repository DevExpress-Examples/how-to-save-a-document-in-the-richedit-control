Imports Microsoft.VisualBasic
Imports System
Namespace SaveDocument
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnSaveToFile = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.Location = New System.Drawing.Point(0, 38)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(644, 372)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
'			Me.richEditControl1.BeforeExport += New DevExpress.XtraRichEdit.BeforeExportEventHandler(Me.richEditControl1_BeforeExport);
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnSaveToFile)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(644, 38)
			Me.panelControl1.TabIndex = 1
			' 
			' btnSaveToFile
			' 
			Me.btnSaveToFile.Location = New System.Drawing.Point(12, 7)
			Me.btnSaveToFile.Name = "btnSaveToFile"
			Me.btnSaveToFile.Size = New System.Drawing.Size(124, 23)
			Me.btnSaveToFile.TabIndex = 0
			Me.btnSaveToFile.Text = "Save Document To File"
'			Me.btnSaveToFile.Click += New System.EventHandler(Me.btnSaveToFile_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(644, 410)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnSaveToFile As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

