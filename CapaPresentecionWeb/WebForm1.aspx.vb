Imports CapaEntidad

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    ' Declaramos el objeto persona
    Dim persona1 As New Persona()
    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        persona1.Apellidos = txtApellidos.Text
        persona1.Nombres = txtNombres.Text
        persona1.Edad = txtEdad.Text
        Session("PersonaRegistrada") = persona1
        lblResultado.Text = "Persona Registrada Correctamente"
    End Sub

    Protected Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click

        ' Obtener la instancia de Persona de la variable de sesión
        Dim persona1 As Persona = TryCast(Session("PersonaRegistrada"), Persona)

        ' Verificar si la variable de sesión contiene una instancia de Persona
        If persona1 IsNot Nothing Then
            ' Si hay una instancia de Persona, mostrar sus datos
            lblResultado.Text = persona1.DevolverDatos()
        Else
            lblResultado.Text = "No se ha registrado ninguna persona."
        End If
    End Sub
End Class