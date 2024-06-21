<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        BtnViewSubmissions = New Button()
        BtnCreateNewSubmission = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' BtnViewSubmissions
        ' 
        BtnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        BtnViewSubmissions.FlatAppearance.BorderColor = Color.White
        BtnViewSubmissions.FlatAppearance.BorderSize = 3
        BtnViewSubmissions.FlatStyle = FlatStyle.Flat
        BtnViewSubmissions.Location = New Point(229, 144)
        BtnViewSubmissions.Name = "BtnViewSubmissions"
        BtnViewSubmissions.Size = New Size(383, 34)
        BtnViewSubmissions.TabIndex = 0
        BtnViewSubmissions.Text = "VIEW SUBMISSION(CTRL+V)"
        BtnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' BtnCreateNewSubmission
        ' 
        BtnCreateNewSubmission.BackColor = SystemColors.ActiveCaption
        BtnCreateNewSubmission.FlatAppearance.BorderColor = Color.White
        BtnCreateNewSubmission.FlatAppearance.BorderSize = 3
        BtnCreateNewSubmission.FlatStyle = FlatStyle.Flat
        BtnCreateNewSubmission.Location = New Point(229, 209)
        BtnCreateNewSubmission.Name = "BtnCreateNewSubmission"
        BtnCreateNewSubmission.Size = New Size(383, 34)
        BtnCreateNewSubmission.TabIndex = 1
        BtnCreateNewSubmission.Text = "CREATE NEW SUBMISSION(CTRL+N)"
        BtnCreateNewSubmission.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(229, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(326, 25)
        Label1.TabIndex = 2
        Label1.Text = "Manya Sharma, Slidely Task2-Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(BtnCreateNewSubmission)
        Controls.Add(BtnViewSubmissions)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnViewSubmissions As Button
    Friend WithEvents BtnCreateNewSubmission As Button
    Friend WithEvents Label1 As Label

End Class
