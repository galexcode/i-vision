Imports Skybound.Gecko
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Skybound.Gecko.Xpcom.Initialize()
        AddHandler GeckoWebBrowser1.Navigated, AddressOf Done

        If System.IO.File.Exists(FILE_NAME) = True Then


            Do While objReader.Peek() <> -1
                HomePage = objReader.ReadLine() & vbNewLine
                GeckoWebBrowser1.Navigate(HomePage)
            Loop
            objReader.Close()
        Else
            MsgBox("ERROR:Could not locate settings.txt. FATAL.")
            End
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GeckoWebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GeckoWebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GeckoWebBrowser1.GoForward()
    End Sub

    Private Sub Done(ByVal Sender As Object, ByVal e As GeckoNavigatedEventArgs)
        TextBox1.Text = GeckoWebBrowser1.Url.ToString
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GeckoWebBrowser1.Refresh()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub CurrentPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        objWriter.Write(TextBox1.Text)
        objWriter.Close()
        MsgBox("Successful!")
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        Do While objReader.Peek() <> -1
            HomePage = objReader.ReadLine() & vbNewLine
        Loop
        objReader.Close()
        objWriter.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        GeckoWebBrowser1.Navigate(HomePage)
    End Sub

    Private Sub AnotherPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ToWrite = InputBox("Please enter the website address you want to become your new home page", "i-vision")
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        objWriter.Write(ToWrite)
        objWriter.Close()
        MsgBox("Successful!")
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        Do While objReader.Peek() <> -1
            HomePage = objReader.ReadLine() & vbNewLine
        Loop
        objReader.Close()
        objWriter.Close()
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub UseCurrentPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseCurrentPageToolStripMenuItem.Click
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        objWriter.Write(TextBox1.Text)
        objWriter.Close()
        MsgBox("Successful!")
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        Do While objReader.Peek() <> -1
            HomePage = objReader.ReadLine() & vbNewLine
        Loop
        objReader.Close()
        objWriter.Close()
    End Sub

    Private Sub UseAnotherPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseAnotherPageToolStripMenuItem.Click
        ToWrite = InputBox("Please enter the website address you want to become your new home page", "i-vision")
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        objWriter.Write(ToWrite)
        objWriter.Close()
        MsgBox("Successful!")
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        Do While objReader.Peek() <> -1
            HomePage = objReader.ReadLine() & vbNewLine
        Loop
        objReader.Close()
        objWriter.Close()
    End Sub
End Class