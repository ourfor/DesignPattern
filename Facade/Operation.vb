Namespace Facade
    Public Class Operation
        Implements Software

        Public Function Install() As Object Implements Software.Install
            MessageBox.Show("Successful installed Operation System!")
        End Function

    End Class
End Namespace
