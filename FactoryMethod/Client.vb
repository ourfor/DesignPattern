Namespace FActoryMethod
    Public Class Client
        Sub Main()
            Dim bmw As New BmwFactory()
            Dim aod As New AodFactory()
            bmw.Produce().Run()
            aod.Produce().Run()
        End Sub

    End Class
End Namespace
