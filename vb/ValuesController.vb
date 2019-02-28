Imports System
Imports Microsoft.AspNetCore.Mvc

    <Route("/")>
    <ApiController>
    Public Class ValuesController
        Inherits ControllerBase

        <HttpGet>
        Public Function [Get]() As ActionResult(Of String)
            Return "Hello World!"
        End Function
    End Class
