<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtGitHub = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnSubmit = New Button()
        btnStartStop = New Button()
        lblStopwatch = New Label()
        timerStopwatch = New Timer(components)
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(332, 74)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 0
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(332, 148)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(332, 111)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 2
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(332, 185)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(150, 31)
        txtGitHub.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(212, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 4
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(217, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 5
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(142, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 25)
        Label3.TabIndex = 6
        Label3.Text = "Phone number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(174, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 25)
        Label4.TabIndex = 7
        Label4.Text = "Github link"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(264, 296)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(112, 34)
        btnSubmit.TabIndex = 8
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnStartStop
        ' 
        btnStartStop.Location = New Point(142, 243)
        btnStartStop.Name = "btnStartStop"
        btnStartStop.Size = New Size(156, 34)
        btnStartStop.TabIndex = 9
        btnStartStop.Text = "Start Stopwatch"
        btnStartStop.UseVisualStyleBackColor = True
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(332, 248)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(80, 25)
        lblStopwatch.TabIndex = 10
        lblStopwatch.Text = "00:00:00"
        ' 
        ' timerStopwatch
        ' 
        timerStopwatch.Interval = 1000
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStopwatch)
        Controls.Add(btnStartStop)
        Controls.Add(btnSubmit)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGitHub)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnStartStop As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents timerStopwatch As Timer
End Class
