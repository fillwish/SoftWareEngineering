Public Class Form1

    Dim mediaSearch As Media = New Media
    Dim UserLogin As Admin = New Admin

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SearchMediaSubmitButton.Click
        Dim searchType, search As String
        searchType = SearchTypeDrop.Text
        search = SearchText.Text
        mediaSearch.searchMedia(searchType, search)
    End Sub

    Private Sub UseNamePassSubmit_Click(sender As Object, e As EventArgs) Handles UseNamePassSubmit.Click
        Dim userName As String
        Dim password As String
        userName = UserNameText.Text
        password = PassWordText.Text
        UserLogin.SearchUserNames(userName, password)
    End Sub

    Private Sub AdminCheck_Click(sender As Object, e As EventArgs) Handles AdminCheck.Click
        UserLogin.SignInAdmin(AdminNameText.Text, AdminPasswordText.Text)
    End Sub
End Class
