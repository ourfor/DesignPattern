Namespace ChainOfResp
    Public Class Manager
        Inherits Leader

        Public Sub New(ByVal name As String)
            MyBase.New(name)
        End Sub

        Public Overrides Function Deal(req As Require)
            If req.day < 10 Then
                MessageBox.Show("同意" + req.name + "的请假" + ",批假人:" + Me.name + "主任")
            Else
                NextLeader.Deal(req)
            End If
        End Function

    End Class
End Namespace