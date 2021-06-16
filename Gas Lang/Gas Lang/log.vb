Public Class log
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim form As Form1 = New Form1()
        Timer1.Interval = 5000
        form.Show()
        Timer1.Stop()
    End Sub
End Class