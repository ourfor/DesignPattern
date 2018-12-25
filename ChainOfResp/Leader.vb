Namespace ChainOfResp
    Public Class Leader
        Public NextLeader As Leader
        Protected name As String

        Public Sub New(ByVal name As String)
            Me.name = name
        End Sub

        Public Overridable Function Deal(req As Require)
        End Function

        Public Function setName(ByVal name As String)
            Me.name = name
        End Function

        Public Function setNext(input As Leader)
            NextLeader = input
        End Function

    End Class
End Namespace
