<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCreateSubmission = New Button()
        btnViewSubmissions = New Button()
        SuspendLayout()
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.Location = New Point(412, 260)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(221, 34)
        btnCreateSubmission.TabIndex = 0
        btnCreateSubmission.Text = "Create new Submission"
        btnCreateSubmission.UseVisualStyleBackColor = True
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.Location = New Point(209, 260)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(168, 34)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "View Submission" & vbCrLf
        btnViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' Mainform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnViewSubmissions)
        Controls.Add(btnCreateSubmission)
        Name = "Mainform"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnViewSubmissions As Button

End Class
