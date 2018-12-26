Namespace Facade
    Public Class Computer
        Dim Cpu As Hardware = New Device()
        Dim Windows As Software = New Operation()

        Function NewWindowsComputer()
            Cpu.Combine()
            Windows.Install()
        End Function


    End Class
End Namespace
