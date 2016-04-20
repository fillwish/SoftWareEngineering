<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            'added by me to close excel sheets
            Me.mediaSearch.CloseUserDatabase()
            Me.UserLogin.CloseUserDatabase()
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
        Me.SignIn = New System.Windows.Forms.TabPage()
        Me.UseNamePassSubmit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Rentals = New System.Windows.Forms.ListBox()
        Me.UserInfo = New System.Windows.Forms.ListBox()
        Me.PassWordText = New System.Windows.Forms.TextBox()
        Me.UserNameText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchReturnListBox = New System.Windows.Forms.ListBox()
        Me.SearchMediaSubmitButton = New System.Windows.Forms.Button()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchTypeDrop = New System.Windows.Forms.ComboBox()
        Me.Search = New System.Windows.Forms.TabControl()
        Me.AdminNameText = New System.Windows.Forms.TextBox()
        Me.AdminPasswordText = New System.Windows.Forms.TextBox()
        Me.AdminCheck = New System.Windows.Forms.Button()
        Me.SignIn.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Search.SuspendLayout()
        Me.SuspendLayout()
        '
        'SignIn
        '
        Me.SignIn.BackColor = System.Drawing.Color.PaleTurquoise
        Me.SignIn.Controls.Add(Me.UseNamePassSubmit)
        Me.SignIn.Controls.Add(Me.Label7)
        Me.SignIn.Controls.Add(Me.Label6)
        Me.SignIn.Controls.Add(Me.Rentals)
        Me.SignIn.Controls.Add(Me.UserInfo)
        Me.SignIn.Controls.Add(Me.PassWordText)
        Me.SignIn.Controls.Add(Me.UserNameText)
        Me.SignIn.Controls.Add(Me.Label5)
        Me.SignIn.Controls.Add(Me.Label4)
        Me.SignIn.Location = New System.Drawing.Point(4, 22)
        Me.SignIn.Name = "SignIn"
        Me.SignIn.Padding = New System.Windows.Forms.Padding(3)
        Me.SignIn.Size = New System.Drawing.Size(1081, 666)
        Me.SignIn.TabIndex = 2
        Me.SignIn.Text = "Sign In                            "
        '
        'UseNamePassSubmit
        '
        Me.UseNamePassSubmit.Location = New System.Drawing.Point(254, 46)
        Me.UseNamePassSubmit.Name = "UseNamePassSubmit"
        Me.UseNamePassSubmit.Size = New System.Drawing.Size(75, 62)
        Me.UseNamePassSubmit.TabIndex = 8
        Me.UseNamePassSubmit.Text = "Submit"
        Me.UseNamePassSubmit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(586, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Rentals"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "User Information"
        '
        'Rentals
        '
        Me.Rentals.FormattingEnabled = True
        Me.Rentals.Location = New System.Drawing.Point(586, 183)
        Me.Rentals.Name = "Rentals"
        Me.Rentals.Size = New System.Drawing.Size(462, 407)
        Me.Rentals.TabIndex = 5
        '
        'UserInfo
        '
        Me.UserInfo.FormattingEnabled = True
        Me.UserInfo.Location = New System.Drawing.Point(27, 183)
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.Size = New System.Drawing.Size(449, 407)
        Me.UserInfo.TabIndex = 4
        '
        'PassWordText
        '
        Me.PassWordText.HideSelection = False
        Me.PassWordText.Location = New System.Drawing.Point(109, 88)
        Me.PassWordText.MaxLength = 10
        Me.PassWordText.Name = "PassWordText"
        Me.PassWordText.Size = New System.Drawing.Size(100, 20)
        Me.PassWordText.TabIndex = 3
        Me.PassWordText.UseSystemPasswordChar = True
        '
        'UserNameText
        '
        Me.UserNameText.Location = New System.Drawing.Point(109, 46)
        Me.UserNameText.Name = "UserNameText"
        Me.UserNameText.Size = New System.Drawing.Size(100, 20)
        Me.UserNameText.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "PassWord"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User Name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.AdminCheck)
        Me.TabPage2.Controls.Add(Me.AdminPasswordText)
        Me.TabPage2.Controls.Add(Me.AdminNameText)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1081, 666)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Admin                       "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.SearchReturnListBox)
        Me.TabPage1.Controls.Add(Me.SearchMediaSubmitButton)
        Me.TabPage1.Controls.Add(Me.SearchText)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.SearchTypeDrop)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1081, 666)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Search                      "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(839, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Title                                        Author                              " & _
    "     Genre                                     Category                         " & _
    "    Location"
        '
        'SearchReturnListBox
        '
        Me.SearchReturnListBox.FormattingEnabled = True
        Me.SearchReturnListBox.Location = New System.Drawing.Point(34, 167)
        Me.SearchReturnListBox.Name = "SearchReturnListBox"
        Me.SearchReturnListBox.Size = New System.Drawing.Size(1012, 472)
        Me.SearchReturnListBox.TabIndex = 6
        '
        'SearchMediaSubmitButton
        '
        Me.SearchMediaSubmitButton.Location = New System.Drawing.Point(121, 96)
        Me.SearchMediaSubmitButton.Name = "SearchMediaSubmitButton"
        Me.SearchMediaSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchMediaSubmitButton.TabIndex = 5
        Me.SearchMediaSubmitButton.Text = "Submit"
        Me.SearchMediaSubmitButton.UseVisualStyleBackColor = True
        '
        'SearchText
        '
        Me.SearchText.Location = New System.Drawing.Point(13, 60)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(331, 20)
        Me.SearchText.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search By:"
        '
        'SearchTypeDrop
        '
        Me.SearchTypeDrop.FormattingEnabled = True
        Me.SearchTypeDrop.Items.AddRange(New Object() {"Name", "Author", "Genre"})
        Me.SearchTypeDrop.Location = New System.Drawing.Point(75, 21)
        Me.SearchTypeDrop.Name = "SearchTypeDrop"
        Me.SearchTypeDrop.Size = New System.Drawing.Size(121, 21)
        Me.SearchTypeDrop.TabIndex = 0
        Me.SearchTypeDrop.Text = "Choose Option"
        '
        'Search
        '
        Me.Search.Controls.Add(Me.TabPage1)
        Me.Search.Controls.Add(Me.TabPage2)
        Me.Search.Controls.Add(Me.SignIn)
        Me.Search.Location = New System.Drawing.Point(0, 1)
        Me.Search.Name = "Search"
        Me.Search.SelectedIndex = 0
        Me.Search.Size = New System.Drawing.Size(1089, 692)
        Me.Search.TabIndex = 0
        '
        'AdminNameText
        '
        Me.AdminNameText.Location = New System.Drawing.Point(92, 67)
        Me.AdminNameText.Name = "AdminNameText"
        Me.AdminNameText.Size = New System.Drawing.Size(100, 20)
        Me.AdminNameText.TabIndex = 0
        '
        'AdminPasswordText
        '
        Me.AdminPasswordText.Location = New System.Drawing.Point(92, 125)
        Me.AdminPasswordText.Name = "AdminPasswordText"
        Me.AdminPasswordText.Size = New System.Drawing.Size(100, 20)
        Me.AdminPasswordText.TabIndex = 1
        '
        'AdminCheck
        '
        Me.AdminCheck.Location = New System.Drawing.Point(260, 99)
        Me.AdminCheck.Name = "AdminCheck"
        Me.AdminCheck.Size = New System.Drawing.Size(75, 23)
        Me.AdminCheck.TabIndex = 2
        Me.AdminCheck.Text = "Button1"
        Me.AdminCheck.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 693)
        Me.Controls.Add(Me.Search)
        Me.Name = "Form1"
        Me.Text = "Your Library"
        Me.SignIn.ResumeLayout(False)
        Me.SignIn.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Search.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SignIn As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Rentals As System.Windows.Forms.ListBox
    Friend WithEvents UserInfo As System.Windows.Forms.ListBox
    Friend WithEvents PassWordText As System.Windows.Forms.TextBox
    Friend WithEvents UserNameText As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SearchReturnListBox As System.Windows.Forms.ListBox
    Friend WithEvents SearchMediaSubmitButton As System.Windows.Forms.Button
    Friend WithEvents SearchText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchTypeDrop As System.Windows.Forms.ComboBox
    Friend WithEvents Search As System.Windows.Forms.TabControl
    Friend WithEvents UseNamePassSubmit As System.Windows.Forms.Button
    Friend WithEvents AdminPasswordText As System.Windows.Forms.TextBox
    Friend WithEvents AdminNameText As System.Windows.Forms.TextBox
    Friend WithEvents AdminCheck As System.Windows.Forms.Button

End Class
