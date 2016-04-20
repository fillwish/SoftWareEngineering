Imports Excel = Microsoft.Office.Interop.Excel
Public Class Media
    Dim APP As New Excel.Application
    Dim worksheetMedia As Excel.Worksheet
    Dim workbookMedia As Excel.Workbook
    Dim path As String = My.Application.Info.DirectoryPath
    Dim mediaPath As String = IO.Path.Combine(path, "media.xlsx")
    Dim currentCell As String

    Sub New()
        workbookMedia = APP.Workbooks.Open(mediaPath)
        worksheetMedia = workbookMedia.Worksheets("sheet1")
    End Sub

    Sub searchMedia(ByRef searchType As String, ByRef search As String)
        Dim column As Integer
        If searchType = "Choose Option" Then
            MsgBox("Please select search type")
            Exit Sub
        End If

        If searchType = "Name" Then column = 1
        If searchType = "Author" Then column = 2
        If searchType = "Genre" Then column = 4

        For row As Integer = 2 To 8
            currentCell = worksheetMedia.Cells(row, column).Value
            If search = currentCell Then
                MsgBox("match")
                'output info to listbox
            Else
                MsgBox("no match")
                'take out else later
            End If
        Next
    End Sub

    Sub CloseUserDatabase()
        workbookMedia.Save()
        workbookMedia.Close()
        APP.Quit()
    End Sub
End Class
