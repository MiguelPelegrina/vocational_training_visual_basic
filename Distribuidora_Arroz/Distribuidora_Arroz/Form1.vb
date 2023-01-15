Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    'Declaracion e inicializacion de variables
    Dim capacidadCamion As Integer = 0
    Dim numeroCamiones As Integer = 0
    Dim pesoCamion As Integer = 0
    Dim sacasTotal As Integer = 0
    Dim totales As ArrayList = New ArrayList()
    Dim subtotales As ArrayList = New ArrayList()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Asignacion del tiempo actual
        lblTiempo.Text = Now
        pbImagenesCamiones.Left = 12
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerDiaHora.Tick
        'Actualizacion del tiempo actual
        lblTiempo.Text = Now
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Marcamos el enlace como visitado
        LinkLabel1.LinkVisited = True
        'Llamamos a un navegador para que se inicia en la pagina web indicada
        Dim unused = Process.Start("C:\Program Files\Internet Explorer\iexplore.exe", "http://20minutos.com")
    End Sub

    Private Sub TbPesoSacas_Scroll(sender As Object, e As EventArgs) Handles tbPesoSacas.Scroll
        'Mostramos el valor actual del trackbar
        lblPesoSacas.Text = "Peso de saca: " + tbPesoSacas.Value.ToString
    End Sub

    Private Sub LbCamiones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCamiones.SelectedIndexChanged
        'Indicamos la capacidad del camion elegido
        lblPesoCamion.Visible = True
        'En funcion del camion elegido modificamos la imagen, la capacidad y el label que muestra la capacidad 
        If lbCamiones.SelectedIndex = 0 Then
            lblPesoCamion.Text = "Peso máximo del camión: " + 18000.ToString + "kg"
            pbImagenesCamiones.Image = ilCamiones.Images(0)
            capacidadCamion = 18000
        ElseIf lbCamiones.SelectedIndex = 1 Then
            lblPesoCamion.Text = "Peso máximo del camión: " + 23000.ToString + "kg"
            pbImagenesCamiones.Image = ilCamiones.Images(1)
            capacidadCamion = 23000
        ElseIf lbCamiones.SelectedIndex = 2 Then
            lblPesoCamion.Text = "Peso máximo del camión: " + 28000.ToString + "kg"
            pbImagenesCamiones.Image = ilCamiones.Images(2)
            capacidadCamion = 28000
        End If
        btnCargarCamion.Enabled = True
    End Sub

    Private Sub btnCargarSaca_Click(sender As Object, e As EventArgs) Handles btnCargarSaca.Click
        'Si el peso de la saca indica NO supera la capacidad del camion
        If capacidadCamion >= pesoCamion + tbPesoSacas.Value Then
            'Deshabilitamos el boton
            btnCargarSaca.Enabled = False
            'Visibilizamos e inicializamos el progeso de como se vacia la saca
            pbSaca.Visible = True
            pbSaca.Value = 0
            'Mostramos que se esta cargando
            lblAtencion.Visible = True
            lblAtencion.Text = "Atención: cargando"
            'Mostramos la imagen de la saca
            pbSacas.Image = ilSacas.Images(0)
            'Habilitamos el timer
            TimerSaca.Enabled = True
            'Actualizamos la informacion que se muestra: el numero total de sacas, el peso actual del camion
            sacasTotal += 1
            pesoCamion += tbPesoSacas.Value
            'Anadimos el peso de la saca introducida a un arraylist que guarda los subtotales
            subtotales.Add(tbPesoSacas.Value)
        Else
            'Si el peso de la saca indicada supera la capacidad del camion
            MsgBox("El peso de la saca va a superar la capacidad del camión. Se inicia la carga del siguiente camión. Vuelva a elegir un tipo de camión", vbInformation, "Cambio de camión")
            'Deshabilitamos el boton de cargar saca hasta que se haya elegido un nuevo camion
            btnCargarSaca.Enabled = False
            'Desplazamos la imagen del camion que sale
            While pbImagenesCamiones.Left > 12
                pbImagenesCamiones.Left -= 1
                Thread.Sleep(2)
            End While
            'Anadimos el peso del camion a un arraylist que guarda los totales
            totales.Add(pesoCamion)
            'Reiniciamos el peso del camion
            pesoCamion = 0
            lblPesoCamionActual.Text = "Peso actual del camion: " + pesoCamion.ToString
            'Invisibilizamos la informacion de la saca
            gbInformacionSaca.Visible = False
            pbSaca.Visible = False
            lblAtencion.Visible = False
            pbSacas.Image = ilSacas.Images(0)
            'Habilitamos el boton de cargar camion
            btnCargarCamion.Enabled = True
        End If
    End Sub

    Private Sub TimerSaca_Tick(sender As Object, e As EventArgs) Handles TimerSaca.Tick
        'Mientras que el proceso de vaciar la saca no se haya terminado
        If pbSaca.Value < pbSaca.Maximum Then
            pbSaca.Value += 1
            lblAtencion.Visible = Not lblAtencion.Visible
        End If
        'Cuando se haya terminado de vaciar la saca
        If pbSaca.Value = pbSaca.Maximum Then
            'Mostramos que se ha finalizado
            lblAtencion.Text = "Carga finalizada"
            lblAtencion.Visible = True
            pbSacas.Image = ilSacas.Images(1)
            'Desactivamos el timer
            TimerSaca.Enabled = False
            'Actualizamos la informacion mostrada
            lblNumeroSaca.Text = "Saca nº " + sacasTotal.ToString
            lblPesoCamionActual.Text = "Peso actual del camion: " + pesoCamion.ToString + " kg"
        End If
        'Habilitamos el boton de cargar saca
        btnCargarSaca.Enabled = True
    End Sub

    Private Sub btnCargarCamion_Click(sender As Object, e As EventArgs) Handles btnCargarCamion.Click
        'Deshabilitamos el boton de cargar camion
        btnCargarCamion.Enabled = False
        'Si aun no hemos cargado 20 camiones
        If numeroCamiones < 20 Then
            numeroCamiones += 1
            While pbImagenesCamiones.Left < gbInformacionSaca.Left + pbSacas.Left
                pbImagenesCamiones.Left += 1
                Thread.Sleep(2)
            End While
            lblPesoCamionActual.Text = "Peso actual del camion: " + pesoCamion.ToString
            lblNumeroCamion.Text = "Camion nº " + numeroCamiones.ToString
            btnCargarSaca.Enabled = True
        Else
            'Mostramos la informacion de haber finalizado junto a todos los totales y subtotales
            Dim salida As String = "No cargue más sacas. Se despache el camión 20. FINALIZADA LA CARGA DEL DIA. " & Chr(10) & " Totales (peso de cada camión): "
            For Each total In totales
                salida = salida.Insert(salida.Length, Chr(10) & total.ToString & " kg").ToString
            Next
            salida = salida.Insert(salida.Length, Chr(10) & "Subtotales (peso de cada saca): ")
            For Each subtotal In subtotales
                salida = salida.Insert(salida.Length, Chr(10) & subtotal.ToString & " kg" & Chr(10))
            Next
            MsgBox(salida, vbInformation, "Distribución de arroz")
        End If
        'Se muestra el groupbox que contiene los componentes relacionados con la carga de sacas
        gbInformacionSaca.Visible = True
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim salida As String = "Se finaliza la carga del día." & Chr(10) & "Totales (peso de cada camión): "
        If pesoCamion > 0 Then
            totales.Add(pesoCamion)
        End If
        'Mostramos la informacion de haber finalizado junto a todos los totales y subtotales
        For Each total In totales
            salida = salida.Insert(salida.Length, Chr(10) & total.ToString & " kg").ToString
        Next
        salida = salida.Insert(salida.Length, Chr(10) & "Subtotales (peso de cada saca): ")
        For Each subtotal In subtotales
            salida = salida.Insert(salida.Length, Chr(10) & subtotal.ToString & " kg")
        Next
        MsgBox(salida, vbInformation, "Distribución de arroz")
    End Sub
End Class
