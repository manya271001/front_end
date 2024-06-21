Imports System.CodeDom
Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Ensures the form captures key events first

        ' Check if the buttons are not null before setting their properties
        If BtnViewSubmissions IsNot Nothing Then
            SetButtonProperties(BtnViewSubmissions, "VIEW SUBMISSIONS (CTRL + V)", Color.FromArgb(255, 255, 128)) ' Light Yellow
        End If

        If BtnCreateNewSubmission IsNot Nothing Then
            SetButtonProperties(BtnCreateNewSubmission, "CREATE NEW SUBMISSION (CTRL + N)", Color.FromArgb(173, 216, 230)) ' Light Blue
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            If BtnViewSubmissions IsNot Nothing Then
                BtnViewSubmissions.PerformClick()
                e.SuppressKeyPress = True ' Prevents the default action
            End If
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            If BtnCreateNewSubmission IsNot Nothing Then
                BtnCreateNewSubmission.PerformClick()
                e.SuppressKeyPress = True ' Prevents the default action
            End If
        End If
    End Sub

    Private Sub BtnViewSubmissions_Click(sender As Object, e As EventArgs) Handles BtnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionForm()
        viewForm.Show()
    End Sub

    Private Sub BtnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles BtnCreateNewSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub SetButtonProperties(button As Button, text As String, backColor As Color)
        If button Is Nothing Then Return ' Ensure button is not null

        button.Text = text
        button.BackColor = backColor
        button.Font = New Font("Arial", 9, FontStyle.Regular)
        button.Size = New Size(450, 39) ' Adjust size to fit the text in a single line
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.TextAlign = ContentAlignment.MiddleCenter
        AddHandler button.Paint, AddressOf DrawRoundedButton ' Attach Paint event handler
    End Sub

    Private Sub DrawRoundedButton(sender As Object, e As PaintEventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim radius As Integer = 20 ' Radius for rounded corners
        Dim rect As New Rectangle(0, 0, btn.Width, btn.Height)
        Dim path As GraphicsPath = RoundedRect(rect, radius)

        Using brush As New SolidBrush(btn.BackColor)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias ' Ensure smooth borders

            ' Fill the background
            e.Graphics.FillPath(brush, path)

            ' Draw the border
            Using pen As New Pen(Color.Black, 1)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using

        ' Draw the text in the center
        Dim textRect As New Rectangle(10, 10, btn.Width - 20, btn.Height - 20) ' Add padding
        TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, textRect, btn.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPadding)
    End Sub

    Private Function RoundedRect(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim arcRect As New Rectangle(rect.Location, New Size(radius * 2, radius * 2))

        ' Top-left arc
        path.AddArc(arcRect, 180, 90)

        ' Top-right arc
        arcRect.X = rect.Right - radius * 2
        path.AddArc(arcRect, 270, 90)

        ' Bottom-right arc
        arcRect.Y = rect.Bottom - radius * 2
        path.AddArc(arcRect, 0, 90)

        ' Bottom-left arc
        arcRect.X = rect.Left
        path.AddArc(arcRect, 90, 90)

        path.CloseFigure()
        Return path
    End Function
End Class
