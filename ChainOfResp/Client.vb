Namespace ChainOfResp
    Public Class Client
        Sub Main()
            Dim a As Leader = New Director("张三")
            Dim b As Leader = New Manager("李四")
            Dim c As Leader = New GeneralManager("王五")

            '确定组织关系
            a.setNext(b)
            b.setNext(c)

            Dim name As String = InputBox("输入请假人的姓名:")
            Dim day As Integer = InputBox("请多少天假:")
            Dim reason As String = InputBox("那么请假的理由是?")



            Dim req As Require = New Require(name, day, reason)

            a.Deal(req)

            End

        End Sub

    End Class
End Namespace
