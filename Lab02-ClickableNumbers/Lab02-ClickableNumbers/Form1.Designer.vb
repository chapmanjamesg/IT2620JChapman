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
        Me.btnImageOne = New System.Windows.Forms.Button()
        Me.btnImageTwo = New System.Windows.Forms.Button()
        Me.btnImageThree = New System.Windows.Forms.Button()
        Me.btnImageFour = New System.Windows.Forms.Button()
        Me.btnImageFive = New System.Windows.Forms.Button()
        Me.lblClickMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnImageOne
        '
        Me.btnImageOne.Image = CType(resources.GetObject("btnImageOne.Image"), System.Drawing.Image)
        Me.btnImageOne.Location = New System.Drawing.Point(12, 182)
        Me.btnImageOne.Name = "btnImageOne"
        Me.btnImageOne.Size = New System.Drawing.Size(103, 155)
        Me.btnImageOne.TabIndex = 0
        Me.btnImageOne.UseVisualStyleBackColor = True
        '
        'btnImageTwo
        '
        Me.btnImageTwo.Image = CType(resources.GetObject("btnImageTwo.Image"), System.Drawing.Image)
        Me.btnImageTwo.Location = New System.Drawing.Point(121, 182)
        Me.btnImageTwo.Name = "btnImageTwo"
        Me.btnImageTwo.Size = New System.Drawing.Size(103, 155)
        Me.btnImageTwo.TabIndex = 1
        Me.btnImageTwo.UseVisualStyleBackColor = True
        '
        'btnImageThree
        '
        Me.btnImageThree.Image = CType(resources.GetObject("btnImageThree.Image"), System.Drawing.Image)
        Me.btnImageThree.Location = New System.Drawing.Point(230, 182)
        Me.btnImageThree.Name = "btnImageThree"
        Me.btnImageThree.Size = New System.Drawing.Size(103, 155)
        Me.btnImageThree.TabIndex = 1
        Me.btnImageThree.UseVisualStyleBackColor = True
        '
        'btnImageFour
        '
        Me.btnImageFour.Image = CType(resources.GetObject("btnImageFour.Image"), System.Drawing.Image)
        Me.btnImageFour.Location = New System.Drawing.Point(339, 182)
        Me.btnImageFour.Name = "btnImageFour"
        Me.btnImageFour.Size = New System.Drawing.Size(103, 155)
        Me.btnImageFour.TabIndex = 1
        Me.btnImageFour.UseVisualStyleBackColor = True
        '
        'btnImageFive
        '
        Me.btnImageFive.Image = CType(resources.GetObject("btnImageFive.Image"), System.Drawing.Image)
        Me.btnImageFive.Location = New System.Drawing.Point(448, 182)
        Me.btnImageFive.Name = "btnImageFive"
        Me.btnImageFive.Size = New System.Drawing.Size(103, 155)
        Me.btnImageFive.TabIndex = 1
        Me.btnImageFive.UseVisualStyleBackColor = True
        '
        'lblClickMessage
        '
        Me.lblClickMessage.AutoSize = True
        Me.lblClickMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickMessage.Location = New System.Drawing.Point(176, 89)
        Me.lblClickMessage.Name = "lblClickMessage"
        Me.lblClickMessage.Size = New System.Drawing.Size(221, 25)
        Me.lblClickMessage.TabIndex = 2
        Me.lblClickMessage.Text = "Click one of the buttons!"
        Me.lblClickMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 349)
        Me.Controls.Add(Me.lblClickMessage)
        Me.Controls.Add(Me.btnImageFive)
        Me.Controls.Add(Me.btnImageFour)
        Me.Controls.Add(Me.btnImageThree)
        Me.Controls.Add(Me.btnImageTwo)
        Me.Controls.Add(Me.btnImageOne)
        Me.Name = "Form1"
        Me.Text = "Clickable Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImageOne As Button
    Friend WithEvents btnImageTwo As Button
    Friend WithEvents btnImageThree As Button
    Friend WithEvents btnImageFour As Button
    Friend WithEvents btnImageFive As Button
    Friend WithEvents lblClickMessage As Label
End Class
