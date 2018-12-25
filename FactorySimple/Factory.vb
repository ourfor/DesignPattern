Namespace FactorySimple
    Public Class Factory
        Shared Function Produce(ByVal message As String) As Car
            Select Case message
                Case "宝马"
                    Return New BmwCar()
                Case "奥迪"
                    Return New AodCar()
                Case Else
                    Return New OtherCar()
            End Select
        End Function

    End Class
End Namespace
