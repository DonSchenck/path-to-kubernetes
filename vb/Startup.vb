Imports System
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.AspNetCore
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.AspNetCore.Builder
Class Startup
    Sub ConfigureServices(Services as IServiceCollection)
        Services.AddMvc()
    End Sub
    Sub Configure(app as IApplicationBuilder)
        app.UseStaticFiles()
        app.UseMvcWithDefaultRoute()
    End Sub
End Class