Namespace FactorySimple
    Public Class AodCar
        Implements Car

        Public Function Run() As Object Implements Car.Run
            MessageBox.Show("奥迪汽车启动")
        End Function

    End Class
End Namespace
