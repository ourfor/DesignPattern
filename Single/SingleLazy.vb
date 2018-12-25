Namespace SingleClass
    Public Class SingleLazy
        Private Sub New()
        End Sub

        Private Shared Ins As SingleLazy

        Public Shared Function getInstance() As SingleLazy
            If Ins Is Nothing Then
                Ins = New SingleLazy()
            End If
            Return Ins
        End Function

        Public age = 1
        ·
        Public Shared Function Info()
            MessageBox.Show("我是一个懒汉式的单例")
            MessageBox.Show("" + age.ToString)
        End Function

    End Class
End Namespace
