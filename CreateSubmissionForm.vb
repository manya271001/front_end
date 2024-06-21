Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Inherits Form

    Private stopwatch As New Stopwatch()

    ' Existing controls should be declared in the Designer.vb file, not here
    ' Remove duplicate declarations of the controls here
    ' Friend WithEvents BtnStartStopwatch As Button
    ' Friend WithEvents BtnSubmit As Button
    ' Friend WithEvents TxtPhone As TextBox
    ' Friend WithEvents TxtName As TextBox
    ' Friend WithEvents TxtEmail As TextBox
    ' Friend WithEvents TxtGitHub As TextBox
    ' Friend WithEvents LblStopwatch As Label

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        ' Initialize controls
        InitializeControls()

        ' Set TextBoxes to be editable
        TxtName.ReadOnly = False
        TxtEmail.ReadOnly = False
        TxtGitHub.ReadOnly = False
    End Sub

    Private Sub InitializeControls()
        ' Initialize the controls (assuming you have set their properties in designer)
        ' If they are already added in the designer, you don't need to add them again here
        ' Just set their properties if needed

        ' Add event handlers
        AddHandler BtnStartStopwatch.Click, AddressOf BtnStartStopwatch_Click
        AddHandler BtnSubmit.Click, AddressOf BtnSubmit_Click
        AddHandler Me.KeyDown, AddressOf CreateSubmissionForm_KeyDown
    End Sub

    Private Sub BtnStartStopwatch_Click(sender As Object, e As EventArgs)
        ToggleStopwatch()
    End Sub

    ' Handle keyboard shortcuts
    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.S ' Ctrl + S for Submit
                    SubmitForm()
                    e.SuppressKeyPress = True ' Prevents the default action
                Case Keys.T ' Ctrl + T for Start/Stop Stopwatch
                    ToggleStopwatch()
                    e.SuppressKeyPress = True ' Prevents the default action
            End Select
        End If
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        LblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub SubmitForm()
        Dim submission As New Submission() With {
            .UserName = TxtName.Text,
            .UserEmail = TxtEmail.Text,
            .UserPhone = TxtPhone.Text,
            .UserGithubLink = TxtGitHub.Text,
            .UserStopwatchTime = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        }

        Try
            Using client As New HttpClient()
                Dim content = New StringContent(JsonConvert.SerializeObject(submission), Encoding.UTF8, "application/json")
                Dim response = Await client.PostAsync("http://localhost:8080/submit", content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Form submission saved successfully")
                Else
                    MessageBox.Show("Failed to submit form")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error submitting form: {ex.Message}")
        End Try
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs)
        SubmitForm()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        ' Handle label click event
    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged

    End Sub

    Private Sub TxtGitHub_TextChanged(sender As Object, e As EventArgs) Handles TxtGitHub.TextChanged

    End Sub

    Private Sub TxtPhone_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone.TextChanged

    End Sub

    Private Sub BtnSubmit_Click_1(sender As Object, e As EventArgs) Handles BtnSubmit.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class

Public Class Submission
    Public Property UserName As String
    Public Property UserEmail As String
    Public Property UserPhone As String
    Public Property UserGithubLink As String
    Public Property UserStopwatchTime As String
End Class
