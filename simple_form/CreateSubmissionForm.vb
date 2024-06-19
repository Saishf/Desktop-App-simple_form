Imports System.Net.Http

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartStop.Text = "Start Stopwatch"
        Else
            stopwatch.Start()
            btnStartStop.Text = "Stop Stopwatch"
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim client As New HttpClient()

        ' Prepare data to send
        Dim data As New Dictionary(Of String, String) From {
        {"name", txtName.Text},
        {"email", txtEmail.Text},
        {"phone", txtPhone.Text},
        {"github_link", txtGitHub.Text},
        {"stopwatch_time", stopwatch.Elapsed.ToString()}
    }

        ' Convert data to FormUrlEncodedContent
        Dim content As New FormUrlEncodedContent(data)

        ' Send POST request to backend
        Try
            Dim response = client.PostAsync("http://localhost:3000/submit", content).Result
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Failed to submit form. Server returned " & response.StatusCode.ToString())
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnStartStop.PerformClick()
        End If
    End Sub
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerStopwatch.Start()
        Me.KeyPreview = True
    End Sub

    Private Sub timerStopwatch_Tick(sender As Object, e As EventArgs) Handles timerStopwatch.Tick
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub


End Class