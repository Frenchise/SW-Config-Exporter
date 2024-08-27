<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.SaveAs = New System.Windows.Forms.Button()
		Me.Export_File_Type = New System.Windows.Forms.ComboBox()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.SaveAsPartWarning = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'SaveAs
		'
		Me.SaveAs.Location = New System.Drawing.Point(29, 41)
		Me.SaveAs.Name = "SaveAs"
		Me.SaveAs.Size = New System.Drawing.Size(75, 23)
		Me.SaveAs.TabIndex = 0
		Me.SaveAs.Text = "Save As"
		Me.SaveAs.UseVisualStyleBackColor = True
		'
		'Export_File_Type
		'
		Me.Export_File_Type.FormattingEnabled = True
		Me.Export_File_Type.Items.AddRange(New Object() {"Part", "IGES", "STEP", "eDrawings", "DXF", "DWG", "STL", "JPEG", "PDF"})
		Me.Export_File_Type.Location = New System.Drawing.Point(110, 41)
		Me.Export_File_Type.Name = "Export_File_Type"
		Me.Export_File_Type.Size = New System.Drawing.Size(157, 21)
		Me.Export_File_Type.TabIndex = 1
		Me.Export_File_Type.Text = "Export File Type..."
		'
		'SaveAsPartWarning
		'
		Me.SaveAsPartWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SaveAsPartWarning.Location = New System.Drawing.Point(29, 79)
		Me.SaveAsPartWarning.Name = "SaveAsPartWarning"
		Me.SaveAsPartWarning.Size = New System.Drawing.Size(238, 25)
		Me.SaveAsPartWarning.TabIndex = 2
		Me.SaveAsPartWarning.Text = "If you are saving as part files this may take time"
		Me.SaveAsPartWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(309, 136)
		Me.Controls.Add(Me.SaveAsPartWarning)
		Me.Controls.Add(Me.Export_File_Type)
		Me.Controls.Add(Me.SaveAs)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Configuration Extractor"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents SaveAs As Button
    Friend WithEvents Export_File_Type As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents SaveAsPartWarning As Label
End Class
