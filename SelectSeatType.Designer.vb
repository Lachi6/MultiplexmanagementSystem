<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectSeatType
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
        Me.Platinium = New System.Windows.Forms.Button()
        Me.Gold = New System.Windows.Forms.Button()
        Me.Silver = New System.Windows.Forms.Button()
        Me.txtPlatinium = New System.Windows.Forms.TextBox()
        Me.txtGold = New System.Windows.Forms.TextBox()
        Me.txtSilver = New System.Windows.Forms.TextBox()
        Me.txtShowId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Platinium
        '
        Me.Platinium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Platinium.Location = New System.Drawing.Point(126, 57)
        Me.Platinium.Name = "Platinium"
        Me.Platinium.Size = New System.Drawing.Size(75, 23)
        Me.Platinium.TabIndex = 0
        Me.Platinium.Text = "Platinum"
        Me.Platinium.UseVisualStyleBackColor = True
        '
        'Gold
        '
        Me.Gold.Location = New System.Drawing.Point(126, 95)
        Me.Gold.Name = "Gold"
        Me.Gold.Size = New System.Drawing.Size(75, 23)
        Me.Gold.TabIndex = 1
        Me.Gold.Text = "Gold"
        Me.Gold.UseVisualStyleBackColor = True
        '
        'Silver
        '
        Me.Silver.Location = New System.Drawing.Point(126, 137)
        Me.Silver.Name = "Silver"
        Me.Silver.Size = New System.Drawing.Size(75, 23)
        Me.Silver.TabIndex = 2
        Me.Silver.Text = "Silver"
        Me.Silver.UseVisualStyleBackColor = True
        '
        'txtPlatinium
        '
        Me.txtPlatinium.Location = New System.Drawing.Point(223, 60)
        Me.txtPlatinium.Name = "txtPlatinium"
        Me.txtPlatinium.Size = New System.Drawing.Size(100, 20)
        Me.txtPlatinium.TabIndex = 3
        '
        'txtGold
        '
        Me.txtGold.Location = New System.Drawing.Point(231, 95)
        Me.txtGold.Name = "txtGold"
        Me.txtGold.Size = New System.Drawing.Size(100, 20)
        Me.txtGold.TabIndex = 4
        '
        'txtSilver
        '
        Me.txtSilver.Location = New System.Drawing.Point(231, 140)
        Me.txtSilver.Name = "txtSilver"
        Me.txtSilver.Size = New System.Drawing.Size(100, 20)
        Me.txtSilver.TabIndex = 5
        '
        'txtShowId
        '
        Me.txtShowId.Location = New System.Drawing.Point(223, 22)
        Me.txtShowId.Name = "txtShowId"
        Me.txtShowId.Size = New System.Drawing.Size(100, 20)
        Me.txtShowId.TabIndex = 6
        Me.txtShowId.Visible = False
        '
        'SelectSeatType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blue_abstract_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(426, 262)
        Me.Controls.Add(Me.txtShowId)
        Me.Controls.Add(Me.txtSilver)
        Me.Controls.Add(Me.txtGold)
        Me.Controls.Add(Me.txtPlatinium)
        Me.Controls.Add(Me.Silver)
        Me.Controls.Add(Me.Gold)
        Me.Controls.Add(Me.Platinium)
        Me.Name = "SelectSeatType"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Platinium As System.Windows.Forms.Button
    Friend WithEvents Gold As System.Windows.Forms.Button
    Friend WithEvents Silver As System.Windows.Forms.Button
    Friend WithEvents txtPlatinium As System.Windows.Forms.TextBox
    Friend WithEvents txtGold As System.Windows.Forms.TextBox
    Friend WithEvents txtSilver As System.Windows.Forms.TextBox
    Friend WithEvents txtShowId As System.Windows.Forms.TextBox
End Class
