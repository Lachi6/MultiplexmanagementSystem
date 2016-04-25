<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovieChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAllUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateWiseCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovieWiseCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovieToolStripMenuItem, Me.ShowTimeToolStripMenuItem, Me.BookTicketToolStripMenuItem, Me.UserManagementToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SupplierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1077, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MovieToolStripMenuItem
        '
        Me.MovieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovieChangeToolStripMenuItem})
        Me.MovieToolStripMenuItem.Name = "MovieToolStripMenuItem"
        Me.MovieToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MovieToolStripMenuItem.Text = "Movie"
        '
        'MovieChangeToolStripMenuItem
        '
        Me.MovieChangeToolStripMenuItem.Name = "MovieChangeToolStripMenuItem"
        Me.MovieChangeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MovieChangeToolStripMenuItem.Text = "Movie Change"
        '
        'ShowTimeToolStripMenuItem
        '
        Me.ShowTimeToolStripMenuItem.Name = "ShowTimeToolStripMenuItem"
        Me.ShowTimeToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ShowTimeToolStripMenuItem.Text = "Show Time"
        '
        'BookTicketToolStripMenuItem
        '
        Me.BookTicketToolStripMenuItem.Name = "BookTicketToolStripMenuItem"
        Me.BookTicketToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.BookTicketToolStripMenuItem.Text = "Book Ticket"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.ShowAllUsersToolStripMenuItem})
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.UserManagementToolStripMenuItem.Text = "User Management"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'ShowAllUsersToolStripMenuItem
        '
        Me.ShowAllUsersToolStripMenuItem.Name = "ShowAllUsersToolStripMenuItem"
        Me.ShowAllUsersToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ShowAllUsersToolStripMenuItem.Text = "Show All users"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserReportToolStripMenuItem, Me.DateWiseCollectionToolStripMenuItem, Me.MonthlyCollectionToolStripMenuItem, Me.MovieWiseCollectionToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'UserReportToolStripMenuItem
        '
        Me.UserReportToolStripMenuItem.Name = "UserReportToolStripMenuItem"
        Me.UserReportToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.UserReportToolStripMenuItem.Text = "Collection"
        '
        'DateWiseCollectionToolStripMenuItem
        '
        Me.DateWiseCollectionToolStripMenuItem.Name = "DateWiseCollectionToolStripMenuItem"
        Me.DateWiseCollectionToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.DateWiseCollectionToolStripMenuItem.Text = "Date Wise Collection"
        '
        'MonthlyCollectionToolStripMenuItem
        '
        Me.MonthlyCollectionToolStripMenuItem.Name = "MonthlyCollectionToolStripMenuItem"
        Me.MonthlyCollectionToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.MonthlyCollectionToolStripMenuItem.Text = "Monthly Collection"
        '
        'MovieWiseCollectionToolStripMenuItem
        '
        Me.MovieWiseCollectionToolStripMenuItem.Name = "MovieWiseCollectionToolStripMenuItem"
        Me.MovieWiseCollectionToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.MovieWiseCollectionToolStripMenuItem.Text = "Movie Wise Collection"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.main1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1077, 646)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 675)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MovieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovieChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookTicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowAllUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DateWiseCollectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlyCollectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovieWiseCollectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
