Namespace Facade
    Public Class Device
        Implements Hardware

        Public Function Combine() As Object Implements Hardware.Combine
            MessageBox.Show("Successful installed hardware")
        End Function
    End Class
End Namespace
