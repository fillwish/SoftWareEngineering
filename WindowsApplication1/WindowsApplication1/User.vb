Imports Excel = Microsoft.Office.Interop.Excel
Public Class User
    Dim userName, password, address, birthDate, email, phoneNumber, userNumber As String
    Dim isMember As Boolean = False
    Protected APP As New Excel.Application
    Protected worksheetUsers As Excel.Worksheet
    Protected workbookUsers As Excel.Workbook
    Protected path As String = My.Application.Info.DirectoryPath
    Protected usersPath As String = IO.Path.Combine(path, "users.xlsx")

    Sub New()
        workbookUsers = APP.Workbooks.Open(usersPath)
        worksheetUsers = workbookUsers.Worksheets("sheet1")
    End Sub

    Overridable Sub SearchUserNames(ByVal name As String, ByVal passWord As String)
        For row As Integer = 2 To 6
            If name = worksheetUsers.Cells(row, 1).Value Then
                If passWord = worksheetUsers.Cells(row, 3).Value Then
                    isMember = True
                    Exit For
                End If
            End If
        Next
        UserApproved()
    End Sub

    Sub UserApproved()
        If isMember = True Then
            'Out put member info and book rentals and overdue fees
            'figure out way around opening book excel sheet?
            'add function in media to scan lent to column and add function here to compare the two
            MsgBox("Working")

        Else : MsgBox("Username or Password is incorrect")
        End If
        isMember = False
    End Sub

    Sub CloseUserDatabase()
        workbookUsers.Save()
        workbookUsers.Close()
        APP.Quit()
    End Sub

End Class
