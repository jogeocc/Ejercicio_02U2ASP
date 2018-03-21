Public Class DesplegarPromedio


    Dim Copia As Decimal() = New Decimal(9) {}

    Dim obj As Libreria.Libreria = New Libreria.Libreria()

    Dim ene As Int16

    Dim respuesta As Decimal

    Public Sub Recibe(ByRef aux As Decimal(), ByVal tamanio As Int16)
        Dim ciclo As Int16
        ene = tamanio
        For ciclo = 0 To tamanio - 1
            Copia(ciclo) = aux(ciclo)
        Next

        Return
    End Sub


    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Dim objProyDos As Principal.IngresarDatos = New Principal.IngresarDatos()
        objProyDos.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDesplegar_Click(sender As Object, e As EventArgs) Handles BtnDesplegar.Click
        respuesta = obj.CalPromProms(Copia, ene)
        TxtPromProms.Text = Convert.ToString(respuesta)
    End Sub
End Class
