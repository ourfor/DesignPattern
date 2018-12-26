Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim test1 As New Facade.Client()
        test1.Main()
    End Sub
End Class
