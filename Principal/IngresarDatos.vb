Public Class IngresarDatos

    Dim a, b, c As Int16

    Dim cuanto As Int16, contador As Int16 = 0

    Dim prom, promgen As Decimal

    Dim promprom As Decimal() = New Decimal(9) {}


    Private Sub txtCuantos_TextChanged(sender As Object, e As EventArgs) Handles txtCuantos.TextChanged
        If txtCuantos.Text <> "" Then cuanto = Convert.ToInt16(txtCuantos.Text)
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As Libreria.Libreria = New Libreria.Libreria()
        prom = obj.calprom(a, b, c)
        promprom(contador) = prom
        LbProm.Text = "" & prom
        contador += 1
        If contador = cuanto Then
            promgen = obj.CalPromProms(promprom, cuanto)
            lblPromGen.Text = "El promedio es :" & Convert.ToString(promgen)
            lblMensaje.Text = Convert.ToString("Ya son N veces...")
            TxbA.Enabled = False
            TxbB.Enabled = False
            TxbC.Enabled = False
        Else
            TxbA.Text = ""
            TxbB.Text = ""
            TxbC.Text = ""
        End If
    End Sub

    Private Sub btnDesplegar_Click(sender As Object, e As EventArgs) Handles btnDesplegar.Click
        Dim objDesplegar As DesplegarResultados.DesplegarPromedio = New DesplegarResultados.DesplegarPromedio()
        Me.Hide()
        objDesplegar.Recibe(promprom, cuanto)
        objDesplegar.Show()
    End Sub

    Private Sub TxbA_TextChanged(sender As Object, e As EventArgs) Handles TxbA.TextChanged
        txtCuantos.Enabled = False
        If TxbA.Text <> "" Then a = Convert.ToInt16(TxbA.Text)
    End Sub

    Private Sub TxbB_TextChanged(sender As Object, e As EventArgs) Handles TxbB.TextChanged
        If TxbB.Text <> "" Then b = Convert.ToInt16(TxbB.Text)
    End Sub

    Private Sub TxbC_TextChanged(sender As Object, e As EventArgs) Handles TxbC.TextChanged
        If TxbC.Text <> "" Then c = Convert.ToInt16(TxbC.Text)
    End Sub
End Class
