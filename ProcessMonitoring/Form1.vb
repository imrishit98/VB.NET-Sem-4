Imports System.IO

Public Class Form1
    Dim theFolderP As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Use browse button to choose folder" & Environment.NewLine &
                        "The list box will show exe files" & Environment.NewLine &
                        "Double click on any list box item to open the exe file", "Instructions")
    End Sub

    Private Sub browseBtn_Click(sender As Object, e As EventArgs) Handles browseBtn.Click

        'file browsing
        Using fbd As New FolderBrowserDialog()
            'clearing textbox for path and listbox
            filePathTB.Clear()
            theExeList.Items.Clear()
            'choosing folder
            If fbd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                theFolderP = fbd.SelectedPath
                filePathTB.Text = theFolderP
                Dim exeFiles() As String
                exeFiles = Directory.GetFiles(theFolderP, "*.exe")
                'if there is no exe files then inform user
                If exeFiles.Length = 0 Then
                    MessageBox.Show("There are no exe files in " & theFolderP)
                End If
                'checking if program is running or not
                For Each fileN As String In exeFiles
                    fileN = Replace(fileN, theFolderP + "\", "")
                    Dim thePro() As Process = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(fileN))
                    If thePro.Length > 0 Then
                        theExeList.Items.Add(fileN & " - running")
                    Else
                        theExeList.Items.Add(fileN & " - not running")
                    End If
                Next
            End If
        End Using

    End Sub

    Private Sub theExeList_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles theExeList.MouseDoubleClick
        Dim openEXE As String = theExeList.SelectedItem
        openEXE = openEXE.Remove(openEXE.LastIndexOf("-") - 1)
        Process.Start(theFolderP & "\" & openEXE)
    End Sub
End Class
