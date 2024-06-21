<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionForm
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
        txtName = New TextBox()
        TxtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        TxtStopwatchTime = New TextBox()
        BtnPrevious = New Button()
        BtnNext = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ScrollBar
        txtName.Location = New Point(376, 73)
        txtName.Margin = New Padding(5, 6, 5, 6)
        txtName.Name = "txtName"
        txtName.Size = New Size(364, 31)
        txtName.TabIndex = 0
        ' 
        ' TxtEmail
        ' 
        TxtEmail.BackColor = SystemColors.ScrollBar
        TxtEmail.Location = New Point(376, 128)
        TxtEmail.Margin = New Padding(5, 6, 5, 6)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(364, 31)
        TxtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.ScrollBar
        txtPhone.Location = New Point(376, 191)
        txtPhone.Margin = New Padding(5, 6, 5, 6)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(364, 31)
        txtPhone.TabIndex = 2
        ' 
        ' txtGitHub
        ' 
        txtGitHub.BackColor = SystemColors.ScrollBar
        txtGitHub.Location = New Point(376, 249)
        txtGitHub.Margin = New Padding(5, 6, 5, 6)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(364, 31)
        txtGitHub.TabIndex = 3
        ' 
        ' TxtStopwatchTime
        ' 
        TxtStopwatchTime.BackColor = SystemColors.ScrollBar
        TxtStopwatchTime.Location = New Point(376, 309)
        TxtStopwatchTime.Margin = New Padding(5, 6, 5, 6)
        TxtStopwatchTime.Name = "TxtStopwatchTime"
        TxtStopwatchTime.Size = New Size(364, 31)
        TxtStopwatchTime.TabIndex = 4
        ' 
        ' BtnPrevious
        ' 
        BtnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        BtnPrevious.FlatAppearance.BorderColor = Color.White
        BtnPrevious.FlatAppearance.BorderSize = 3
        BtnPrevious.FlatStyle = FlatStyle.Flat
        BtnPrevious.Location = New Point(40, 367)
        BtnPrevious.Margin = New Padding(5, 6, 5, 6)
        BtnPrevious.Name = "BtnPrevious"
        BtnPrevious.Size = New Size(281, 44)
        BtnPrevious.TabIndex = 5
        BtnPrevious.Text = "PREVIOUS(CTRL+P)"
        BtnPrevious.UseVisualStyleBackColor = False
        ' 
        ' BtnNext
        ' 
        BtnNext.BackColor = SystemColors.ActiveCaption
        BtnNext.FlatAppearance.BorderColor = Color.White
        BtnNext.FlatAppearance.BorderSize = 3
        BtnNext.FlatStyle = FlatStyle.Flat
        BtnNext.Location = New Point(503, 367)
        BtnNext.Margin = New Padding(5, 6, 5, 6)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(266, 44)
        BtnNext.TabIndex = 6
        BtnNext.Text = "NEXT(CTRL+N)"
        BtnNext.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(226, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(374, 25)
        Label1.TabIndex = 7
        Label1.Text = "Manya Sharma,Slidely Task2-View Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(246, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 8
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(246, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 25)
        Label3.TabIndex = 9
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(215, 195)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 25)
        Label4.TabIndex = 10
        Label4.Text = "Phone Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(190, 325)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 25)
        Label5.TabIndex = 11
        Label5.Text = "Start Stop Watch"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(190, 255)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 25)
        Label6.TabIndex = 12
        Label6.Text = "Git Hub Task2 Link"
        ' 
        ' ViewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(824, 502)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnNext)
        Controls.Add(BtnPrevious)
        Controls.Add(TxtStopwatchTime)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(TxtEmail)
        Controls.Add(txtName)
        Margin = New Padding(5, 6, 5, 6)
        Name = "ViewSubmissionForm"
        Text = "ViewSubmissionForm"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtGitHub As System.Windows.Forms.TextBox
    Friend WithEvents TxtStopwatchTime As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
