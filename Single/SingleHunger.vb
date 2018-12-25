Namespace SingleClass
    Public Class SingleHunger
        Private Sub New()
        End Sub

        Private Shared Ins As New SingleHunger()

        Public Shared Function getInstance() As SingleHunger
            Return Ins
        End Function

        Public age = 1
        Public Function Info()
            MessageBox.Show("我是一个饿汉式的单例类的对象")
            MessageBox.Show("" + age.ToString)
        End Function


    End Class
End Namespace
