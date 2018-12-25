Namespace FactoryMethod
    Public Class BmwFactory
        Implements Factory
        Public Function Produce() As Car Implements Factory.Produce
            MessageBox.Show("生产宝马汽车")
            Return New BmwCar()
        End Function
    End Class
End Namespace
