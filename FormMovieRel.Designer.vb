<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMovieRel
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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.txtMno = New System.Windows.Forms.TextBox()
        Me.RBOther = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboCertificate = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBEng = New System.Windows.Forms.RadioButton()
        Me.RBMarathi = New System.Windows.Forms.RadioButton()
        Me.RBHindi = New System.Windows.Forms.RadioButton()
        Me.CboGenre = New System.Windows.Forms.ComboBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cencor = New System.Windows.Forms.Label()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnAdd.Location = New System.Drawing.Point(351, 189)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 46)
        Me.BtnAdd.TabIndex = 20
        Me.BtnAdd.Text = "Save"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'txtMno
        '
        Me.txtMno.Location = New System.Drawing.Point(179, 103)
        Me.txtMno.Name = "txtMno"
        Me.txtMno.Size = New System.Drawing.Size(100, 20)
        Me.txtMno.TabIndex = 19
        '
        'RBOther
        '
        Me.RBOther.AutoSize = True
        Me.RBOther.Location = New System.Drawing.Point(104, 77)
        Me.RBOther.Name = "RBOther"
        Me.RBOther.Size = New System.Drawing.Size(51, 17)
        Me.RBOther.TabIndex = 3
        Me.RBOther.TabStop = True
        Me.RBOther.Text = "Other"
        Me.RBOther.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Movie No"
        '
        'CboCertificate
        '
        Me.CboCertificate.FormattingEnabled = True
        Me.CboCertificate.Location = New System.Drawing.Point(197, 391)
        Me.CboCertificate.Name = "CboCertificate"
        Me.CboCertificate.Size = New System.Drawing.Size(121, 21)
        Me.CboCertificate.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBOther)
        Me.GroupBox1.Controls.Add(Me.RBEng)
        Me.GroupBox1.Controls.Add(Me.RBMarathi)
        Me.GroupBox1.Controls.Add(Me.RBHindi)
        Me.GroupBox1.Location = New System.Drawing.Point(93, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RBEng
        '
        Me.RBEng.AutoSize = True
        Me.RBEng.Location = New System.Drawing.Point(11, 77)
        Me.RBEng.Name = "RBEng"
        Me.RBEng.Size = New System.Drawing.Size(59, 17)
        Me.RBEng.TabIndex = 2
        Me.RBEng.TabStop = True
        Me.RBEng.Text = "English"
        Me.RBEng.UseVisualStyleBackColor = True
        '
        'RBMarathi
        '
        Me.RBMarathi.AutoSize = True
        Me.RBMarathi.Location = New System.Drawing.Point(104, 28)
        Me.RBMarathi.Name = "RBMarathi"
        Me.RBMarathi.Size = New System.Drawing.Size(60, 17)
        Me.RBMarathi.TabIndex = 1
        Me.RBMarathi.TabStop = True
        Me.RBMarathi.Text = "Marathi"
        Me.RBMarathi.UseVisualStyleBackColor = True
        '
        'RBHindi
        '
        Me.RBHindi.AutoSize = True
        Me.RBHindi.Location = New System.Drawing.Point(11, 28)
        Me.RBHindi.Name = "RBHindi"
        Me.RBHindi.Size = New System.Drawing.Size(49, 17)
        Me.RBHindi.TabIndex = 0
        Me.RBHindi.TabStop = True
        Me.RBHindi.Text = "Hindi"
        Me.RBHindi.UseVisualStyleBackColor = True
        '
        'CboGenre
        '
        Me.CboGenre.FormattingEnabled = True
        Me.CboGenre.Location = New System.Drawing.Point(179, 203)
        Me.CboGenre.Name = "CboGenre"
        Me.CboGenre.Size = New System.Drawing.Size(100, 21)
        Me.CboGenre.TabIndex = 15
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(179, 157)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(100, 20)
        Me.txtMname.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Movie Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Genre"
        '
        'Cencor
        '
        Me.Cencor.AutoSize = True
        Me.Cencor.Location = New System.Drawing.Point(90, 399)
        Me.Cencor.Name = "Cencor"
        Me.Cencor.Size = New System.Drawing.Size(90, 13)
        Me.Cencor.TabIndex = 14
        Me.Cencor.Text = "Censor Certificate"
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnNew.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.Blue
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNew.Location = New System.Drawing.Point(351, 118)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 40)
        Me.BtnNew.TabIndex = 22
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(358, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 48)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormMovieRel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blue_abstract_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(515, 453)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.txtMno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CboCertificate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CboGenre)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cencor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormMovieRel"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents txtMno As System.Windows.Forms.TextBox
    Friend WithEvents RBOther As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboCertificate As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBEng As System.Windows.Forms.RadioButton
    Friend WithEvents RBMarathi As System.Windows.Forms.RadioButton
    Friend WithEvents RBHindi As System.Windows.Forms.RadioButton
    Friend WithEvents CboGenre As System.Windows.Forms.ComboBox
    Friend WithEvents txtMname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cencor As System.Windows.Forms.Label
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
