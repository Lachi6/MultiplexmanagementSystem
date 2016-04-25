<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdReg = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.cmdCan = New System.Windows.Forms.Button()
        Me.cboSecurity = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.cmdNw = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date Of Birth :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contact :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Security Question :"
        '
        'cmdReg
        '
        Me.cmdReg.Location = New System.Drawing.Point(232, 405)
        Me.cmdReg.Name = "cmdReg"
        Me.cmdReg.Size = New System.Drawing.Size(137, 32)
        Me.cmdReg.TabIndex = 6
        Me.cmdReg.Text = "Register"
        Me.cmdReg.UseVisualStyleBackColor = True
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(143, 80)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(66, 20)
        Me.txtUserID.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(143, 122)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(134, 20)
        Me.txtName.TabIndex = 8
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(143, 163)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(196, 20)
        Me.txtAdd.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(143, 213)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(175, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(143, 255)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(122, 20)
        Me.txtContact.TabIndex = 11
        '
        'cmdCan
        '
        Me.cmdCan.Location = New System.Drawing.Point(386, 405)
        Me.cmdCan.Name = "cmdCan"
        Me.cmdCan.Size = New System.Drawing.Size(129, 32)
        Me.cmdCan.TabIndex = 12
        Me.cmdCan.Text = "Cancel"
        Me.cmdCan.UseVisualStyleBackColor = True
        '
        'cboSecurity
        '
        Me.cboSecurity.FormattingEnabled = True
        Me.cboSecurity.Location = New System.Drawing.Point(143, 292)
        Me.cboSecurity.Name = "cboSecurity"
        Me.cboSecurity.Size = New System.Drawing.Size(161, 21)
        Me.cboSecurity.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Answer :"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(143, 333)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(161, 20)
        Me.txtAnswer.TabIndex = 15
        '
        'cmdNw
        '
        Me.cmdNw.Location = New System.Drawing.Point(102, 405)
        Me.cmdNw.Name = "cmdNw"
        Me.cmdNw.Size = New System.Drawing.Size(107, 32)
        Me.cmdNw.TabIndex = 16
        Me.cmdNw.Text = "New"
        Me.cmdNw.UseVisualStyleBackColor = True
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 529)
        Me.Controls.Add(Me.cmdNw)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboSecurity)
        Me.Controls.Add(Me.cmdCan)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.cmdReg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "User"
        Me.Text = "User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents cmdCan As System.Windows.Forms.Button
    Friend WithEvents cboSecurity As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents cmdNw As System.Windows.Forms.Button
    Public WithEvents cmdReg As System.Windows.Forms.Button
End Class
