Namespace ChainOfResp
    Public Class Require
        Public reason As String
        Public day As Integer
        Public name As String

        Public Sub New(ByVal name As String, ByVal day As Integer, ByVal reason As String)
            Me.name = name
            Me.day = day
            Me.reason = reason
        End Sub
    End Class
End Namespace
