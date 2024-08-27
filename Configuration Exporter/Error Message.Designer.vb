<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Error_Message
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Error_Message))
		Me.Okay = New System.Windows.Forms.Button()
		Me.Message_Text = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'Okay
		'
		Me.Okay.Location = New System.Drawing.Point(93, 62)
		Me.Okay.Name = "Okay"
		Me.Okay.Size = New System.Drawing.Size(75, 23)
		Me.Okay.TabIndex = 1
		Me.Okay.Text = "Okay"
		Me.Okay.UseVisualStyleBackColor = True
		'
		'Message_Text
		'
		Me.Message_Text.BackColor = System.Drawing.SystemColors.Window
		Me.Message_Text.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Message_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Message_Text.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Message_Text.Location = New System.Drawing.Point(0, 25)
		Me.Message_Text.Margin = New System.Windows.Forms.Padding(0)
		Me.Message_Text.Multiline = True
		Me.Message_Text.Name = "Message_Text"
		Me.Message_Text.ReadOnly = True
		Me.Message_Text.Size = New System.Drawing.Size(281, 34)
		Me.Message_Text.TabIndex = 2
		Me.Message_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Error_Message
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.ClientSize = New System.Drawing.Size(284, 112)
		Me.Controls.Add(Me.Message_Text)
		Me.Controls.Add(Me.Okay)
		Me.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Error_Message"
		Me.Text = "Error Message"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Okay As Button
    Friend WithEvents Message_Text As TextBox
End Class
