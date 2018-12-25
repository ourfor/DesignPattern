Namespace FActoryMethod
    Public Class AodFactory
        Implements Factory

        Public Function Produce() As Car Implements Factory.Produce
            MessageBox.Show("生产奥迪汽车")
            Return New AodCar()
        End Function
    End Class
End Namespace
