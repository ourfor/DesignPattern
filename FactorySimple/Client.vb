Namespace FactorySimple
    Public Class Client
        Sub Main()
            Factory.Produce("宝马").Run()
            Factory.Produce("奥迪").Run()
        End Sub

    End Class
End Namespace
