Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionForm
    Private currentSubmissionIndex As Integer = 0
    Private submissions As List(Of SubmissionRecord)

    ' Assuming you have a SubmissionRecord class and submissions are loaded from the backend
    Private Sub ViewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadSubmissions()
        DisplaySubmission()
    End Sub

    Private Sub LoadSubmissions()
        ' Load submissions from backend
        submissions = GetSubmissionsFromBackend()
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(currentSubmissionIndex)
            txtName.Text = submission.Name
            TxtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGitHub.Text = submission.GithubLink
            TxtStopwatchTime.Text = submission.StopwatchTime

            ' Set TextBoxes to be read-only
            txtName.ReadOnly = True
            TxtEmail.ReadOnly = True
            txtPhone.ReadOnly = True
            txtGitHub.ReadOnly = True
            TxtStopwatchTime.ReadOnly = True
        End If
    End Sub

    ' Implementing the Previous and Next button functionality
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If currentSubmissionIndex > 0 Then
            currentSubmissionIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If currentSubmissionIndex < submissions.Count - 1 Then
            currentSubmissionIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Function GetSubmissionsFromBackend() As List(Of SubmissionRecord)
        Using client As New HttpClient()
            Dim response = client.GetAsync("http://localhost:8080/read?index=" & currentSubmissionIndex).Result
            If response.IsSuccessStatusCode Then
                Dim data = response.Content.ReadAsStringAsync().Result
                ' Deserialize the single submission object
                Dim submission As SubmissionRecord = JsonConvert.DeserializeObject(Of SubmissionRecord)(data)
                Return New List(Of SubmissionRecord) From {submission}
            Else
                ' Handle error
                Return New List(Of SubmissionRecord)()
            End If
        End Using
    End Function

    Private Sub ViewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            BtnPrevious.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            BtnNext.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub TxtStopwatchTime_TextChanged(sender As Object, e As EventArgs) Handles TxtStopwatchTime.TextChanged

    End Sub
End Class

Public Class SubmissionRecord
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class
