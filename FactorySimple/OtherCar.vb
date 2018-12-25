Namespace FactorySimple
    Public Class OtherCar
        Implements Car

        Public Function Run() As Object Implements Car.Run
            MessageBox.Show("没有您要的汽车")
        End Function
    End Class
End Namespace
