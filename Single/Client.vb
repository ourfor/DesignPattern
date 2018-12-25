Namespace SingleClass
    Public Class Client
        Sub Main()
            Dim s As SingleHunger = SingleHunger.getInstance()
            s.Info()
            s.age = 20
            Dim t As SingleHunger = SingleHunger.getInstance()
            t.Info()
        End Sub
    End Class
End Namespace
