Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq


Public Class ViewSubmissionsForm
    Private submissions As JArray
    Private currentIndex As Integer

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentIndex = 0
        LoadSubmissions()
        DisplaySubmission(currentIndex)
        Me.KeyPreview = True
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Private Async Sub LoadSubmissions()
        Dim client As New HttpClient()
        Try
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/read_all")
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            submissions = JArray.Parse(responseBody)
        Catch ex As Exception
            MessageBox.Show("Error loading submissions: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso index >= 0 AndAlso index < submissions.Count Then
            Dim submission As JObject = submissions(index)
            txtName.Text = submission("name").ToString()
            txtEmail.Text = submission("email").ToString()
            txtPhone.Text = submission("phone").ToString()
            txtGitHub.Text = submission("github_link").ToString()
            txtStopwatch.Text = submission("stopwatch_time").ToString()
        End If
    End Sub

    Private Sub lblStopwatch_Click(sender As Object, e As EventArgs) Handles lblStopwatch.Click

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If submissions IsNot Nothing AndAlso currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class