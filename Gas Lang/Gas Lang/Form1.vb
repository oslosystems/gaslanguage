Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click

        TextBox1.ForeColor = Color.DarkBlue

        Timer1.Start()
        If Timer1.Interval = 450 Then
            TextBox1.ForeColor = Color.Black
        End If
        Timer1.Stop()

        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(TextBox1.Lines)
        For i = 0 To ListBox1.Items.Count - 1
            Dim TestString As String = ListBox1.Items.Item(i)
            Dim TestArray() As String = Split(TestString)

            If TestArray(0) = "print" Then

                MsgBox(TestArray(1))

            End If

            If TestArray(0) = "beep" Then

                Beep()

            End If

            If TestArray(0) = "give-h" Then

                Dim path As String = "C:/Users/pc/Desktop/index.html"

                ' Create or overwrite the file.
                Dim fs As FileStream = File.Create(path)

                ' Add text to the file.
                Dim info As Byte() = New UTF8Encoding(True).GetBytes("<!DOCTYPE html>
<html>
    <head>
        <title>Example</title>
    </head>
    <body>
        <p>This is an example of a simple HTML page with one paragraph.</p>
    </body>
</html>")
                fs.Write(info, 0, info.Length)
                fs.Close()

            End If

            If TestArray(0) = "give-ph" Then

                Dim path As String = "C:/Users/pc/Desktop/hworld.php"
                Dim fs As FileStream = File.Create(path)
                Dim info As Byte() = New UTF8Encoding(True).GetBytes("<?php
echo ""Hello World"";
?>")
                fs.Write(info, 0, info.Length)
                fs.Close()

            End If

            If TestArray(0) = "give-py" Then

                Dim path As String = "C:/Users/pc/Desktop/hello.py"

                ' Create or overwrite the file.
                Dim fs As FileStream = File.Create(path)

                ' Add text to the file.
                Dim info As Byte() = New UTF8Encoding(True).GetBytes("print(""Merhaba Dünya"")")
                fs.Write(info, 0, info.Length)
                fs.Close()

            End If

            If TestArray(0) = "exit" Then

                End

            End If

        Next

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim path As String = "C:/Users/pc/Desktop/project.gs"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(TextBox1.Text)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        TextBox1.Clear()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_MultilineChanged(sender As Object, e As EventArgs) Handles TextBox1.MultilineChanged

    End Sub

    Private Sub TextBox1_Move(sender As Object, e As EventArgs) Handles TextBox1.Move

    End Sub

    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click

    End Sub

    Private Sub TrTRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrTRToolStripMenuItem.Click
        FileToolStripMenuItem.Text = "Dosya"
        SaveToolStripMenuItem.Text = "Kaydet"
        CloseToolStripMenuItem.Text = "Kapat"
        ClearToolStripMenuItem.Text = "Temizle"
        DebugToolStripMenuItem.Text = "Başlat"
        RunToolStripMenuItem.Text = "Çalıştır"
        LanguageToolStripMenuItem.Text = "Dil"
    End Sub

    Private Sub EnENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnENToolStripMenuItem.Click
        FileToolStripMenuItem.Text = "File"
        SaveToolStripMenuItem.Text = "Kaydet"
        CloseToolStripMenuItem.Text = "Close"
        ClearToolStripMenuItem.Text = "Clear"
        DebugToolStripMenuItem.Text = "Debug"
        RunToolStripMenuItem.Text = "Run"
        LanguageToolStripMenuItem.Text = "Language"
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class

