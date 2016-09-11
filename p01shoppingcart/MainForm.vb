Public Class MainForm
    Private Total As Double = 0
    Private Total1 As Double = 0
    Private Comprarc1 As Boolean = True
    Private ComprarC2 As Boolean = True
    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub
    ''' <summary>
    ''' Ver - Camisa de Algodon
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImagen1.Click
        lblTituloProducto.Text = "Camisa de Algodon"
        lblPrecio.Text = "$120"
        pbProductos.Image = ilProductos.Images.Item(0)
    End Sub
    ''' <summary>
    ''' Ver - Blazer Mezcla de Lana
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnImagen2.Click
        lblTituloProducto.Text = "Blazer Mezcla de Algodon"
        lblPrecio.Text = "$240"
        pbProductos.Image = ilProductos.Images.Item(1)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Ver - Jersey Cuello Pico
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblTituloProducto.Text = "Jersey Cuello Pico"
        lblPrecio.Text = "$160"
        pbProductos.Image = ilProductos.Images.Item(2)
    End Sub
    ''' <summary>
    ''' Ver - Polo Cuello Redondo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblTituloProducto.Text = "Polo Cuello Redndo"
        lblPrecio.Text = "$70"
        pbProductos.Image = ilProductos.Images.Item(1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnHombres.Click
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black
        lblPro1.Text = "Camisa de Algodon"
        lblPro2.Text = "Blazer Mezcla de Lana"
        lblPro3.Text = "Jersey Cuello Pico"
        lblPro4.Text = "Polo Cuello Redondo"

        lblP1.Text = "$120"
        lblP2.Text = "$240"
        lblP3.Text = "$160"
        lblP4.Text = "$70"

    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black

        lblPro1.Text = "Polo Rayas Cuello Redondo"
        lblPro2.Text = "Chompa Lana Cuello Redondo"
        lblPro3.Text = "Casaca de Jean"
        lblPro4.Text = "Abrigo Mezcla Lana"

        lblP1.Text = "$80"
        lblP2.Text = "$150"
        lblP3.Text = "$220"
        lblP4.Text = "$270"
    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.SteelBlue
        btnAccesorios.ForeColor = Color.Black

        lblPro1.Text = "Zapatos Oxfords"
        lblPro2.Text = "Zapatos Derby"
        lblPro3.Text = "Botines"
        lblPro4.Text = "Loafers"

        lblP1.Text = "$120"
        lblP2.Text = "$140"
        lblP3.Text = "$160"
        lblP4.Text = "$80"
    End Sub

    Private Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.SteelBlue

        lblPro1.Text = "Reloj de Acero"
        lblPro2.Text = "Cinturon de Cuero"
        lblPro3.Text = "Billetera de Cuero"
        lblPro4.Text = "Gorra Clasica"

        lblP1.Text = "$380"
        lblP2.Text = "$70"
        lblP3.Text = "$190"
        lblP4.Text = "$50"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnF2.Click
        If Comprarc1 Then
            Total = Total + 120
            lbl1.Text = "0"
            Comprarc1 = False
        Else
            Total = Total + 120
            lbl1.Text = String.Format("{0:0}", Total1)
            Comprarc1 = True
        End If
        lblTotal.Text = String.Format("S/. {0:000}", Total)
    End Sub

    Private Sub btnF1_Click(sender As Object, e As EventArgs) Handles btnF1.Click
        If Comprarc1 Then
            Total = Total + 120
            lbl1.Text = "1"
            Comprarc1 = False
        Else
            Total = Total - 120
            lbl1.Text = "0"
            Comprarc1 = True
        End If
        lblTotal.Text = String.Format("S/. {0:000}", Total)
    End Sub
End Class