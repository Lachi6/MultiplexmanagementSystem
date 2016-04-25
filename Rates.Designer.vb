<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rates
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
        Me.txtShowId = New System.Windows.Forms.TextBox()
        Me.Platinum = New System.Windows.Forms.TextBox()
        Me.Gold = New System.Windows.Forms.TextBox()
        Me.Silver = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtShowId
        '
        Me.txtShowId.Location = New System.Drawing.Point(142, 64)
        Me.txtShowId.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtShowId.Name = "txtShowId"
        Me.txtShowId.Size = New System.Drawing.Size(148, 23)
        Me.txtShowId.TabIndex = 0
        '
        'Platinum
        '
        Me.Platinum.Location = New System.Drawing.Point(142, 140)
        Me.Platinum.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Platinum.Name = "Platinum"
        Me.Platinum.Size = New System.Drawing.Size(148, 23)
        Me.Platinum.TabIndex = 2
        '
        'Gold
        '
        Me.Gold.Location = New System.Drawing.Point(142, 175)
        Me.Gold.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Gold.Name = "Gold"
        Me.Gold.Size = New System.Drawing.Size(148, 23)
        Me.Gold.TabIndex = 3
        '
        'Silver
        '
        Me.Silver.Location = New System.Drawing.Point(142, 212)
        Me.Silver.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Silver.Name = "Silver"
        Me.Silver.Size = New System.Drawing.Size(148, 23)
        Me.Silver.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ShowId"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Platinium"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 179)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Gold"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 212)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Silver"
        '
        'cmdAdd
        '
        Me.cmdAdd.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blue_abstract_background
        Me.cmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdAdd.Location = New System.Drawing.Point(142, 253)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(113, 28)
        Me.cmdAdd.TabIndex = 10
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Rates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blue_abstract_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(347, 323)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Silver)
        Me.Controls.Add(Me.Gold)
        Me.Controls.Add(Me.Platinum)
        Me.Controls.Add(Me.txtShowId)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Rates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtShowId As System.Windows.Forms.TextBox
    Friend WithEvents Platinum As System.Windows.Forms.TextBox
    Friend WithEvents Gold As System.Windows.Forms.TextBox
    Friend WithEvents Silver As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
End Class
