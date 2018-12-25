Namespace ChainOfResp
    Public Class GeneralManager
        Inherits Leader

        Public Sub New(ByVal name As String)
            MyBase.New(name)
        End Sub

        Public Overrides Function Deal(req As Require)
            If req.day < 30 Then
                MessageBox.Show("同意" + req.name + "的请假" + ",批假人:" + Me.name + "主任")
            Else
                MessageBox.Show("这小子是不想干了吧，请" + req.day.ToString + "天假。")
            End If
        End Function

    End Class
End Namespace
