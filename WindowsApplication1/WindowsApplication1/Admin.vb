Public Class Admin
    Inherits User
    Dim isAdmin As Boolean = False
    Sub SignInAdmin(ByVal name As String, ByVal passWord As String)
        For row As Integer = 2 To 6
            If name = worksheetUsers.Cells(row, 1).Value Then
                If passWord = worksheetUsers.Cells(row, 3).Value Then
                    If worksheetUsers.Cells(row, 4).Value = "True" Then
                        MsgBox("its a admin")
                    Else : MsgBox("Its not an admin")
                    End If
                    Exit For
                End If
            End If
        Next
    End Sub

End Class
