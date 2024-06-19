<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGitHub = New Label()
        lblStopwatch = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        txtStopwatch = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(191, 53)
        lblName.Name = "lblName"
        lblName.Size = New Size(63, 25)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(191, 91)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(58, 25)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(113, 128)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(136, 25)
        lblPhone.TabIndex = 2
        lblPhone.Text = "Phone Number:"
        ' 
        ' lblGitHub
        ' 
        lblGitHub.AutoSize = True
        lblGitHub.Location = New Point(100, 174)
        lblGitHub.Name = "lblGitHub"
        lblGitHub.Size = New Size(154, 25)
        lblGitHub.TabIndex = 3
        lblGitHub.Text = "GitHub Repo Link:"
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(107, 215)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(142, 25)
        lblStopwatch.TabIndex = 4
        lblStopwatch.Text = "Stopwatch Time:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(313, 52)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(313, 91)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 6
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(313, 128)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 7
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(313, 168)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.ReadOnly = True
        txtGitHub.Size = New Size(150, 31)
        txtGitHub.TabIndex = 8
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(313, 209)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(150, 31)
        txtStopwatch.TabIndex = 9
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(213, 287)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(112, 34)
        btnPrevious.TabIndex = 10
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(360, 287)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(112, 34)
        btnNext.TabIndex = 11
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatch)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblStopwatch)
        Controls.Add(lblGitHub)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGitHub As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
