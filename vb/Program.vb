Imports System
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.AspNetCore
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.AspNetCore.Builder

Module Program
    Sub Main(args As String())
        WebHost.CreateDefaultBuilder(args).UseStartup(Of Startup)().Build().Run()
    End Sub
End Module
