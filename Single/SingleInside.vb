Namespace SingleClass
    Public Class SingleInside
        Private Sub New()
        End Sub

        Private Class Inside
            Private Shared Ins As SingleInside = New SingleInside()
        End Class

    End Class
End Namespace
