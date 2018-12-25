Namespace FactoryMethod
    Public Class BmwCar
        Implements Car
        Public Function Run() As Object Implements Car.Run
            MessageBox.Show("宝马汽车启动")
        End Function
    End Class
End Namespace
