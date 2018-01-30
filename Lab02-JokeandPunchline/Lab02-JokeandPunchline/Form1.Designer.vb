<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JokeandPunchline
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
        Me.Setup = New System.Windows.Forms.Button()
        Me.Punchline = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Setup
        '
        Me.Setup.Location = New System.Drawing.Point(141, 198)
        Me.Setup.Name = "Setup"
        Me.Setup.Size = New System.Drawing.Size(75, 23)
        Me.Setup.TabIndex = 0
        Me.Setup.Text = "Setup"
        Me.Setup.UseVisualStyleBackColor = True
        '
        'Punchline
        '
        Me.Punchline.Location = New System.Drawing.Point(296, 198)
        Me.Punchline.Name = "Punchline"
        Me.Punchline.Size = New System.Drawing.Size(75, 23)
        Me.Punchline.TabIndex = 0
        Me.Punchline.Text = "Punch Line"
        Me.Punchline.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(117, 93)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(310, 24)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Click on the Setup button for a Joke!"
        '
        'JokeandPunchline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 261)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Punchline)
        Me.Controls.Add(Me.Setup)
        Me.Name = "JokeandPunchline"
        Me.Text = "Joke and Punchline"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Setup As Button
    Friend WithEvents Punchline As Button
    Friend WithEvents lblMessage As Label
End Class
