<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TimerDiaHora = New System.Windows.Forms.Timer(Me.components)
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblPesoSacas = New System.Windows.Forms.Label()
        Me.tbPesoSacas = New System.Windows.Forms.TrackBar()
        Me.lbCamiones = New System.Windows.Forms.ListBox()
        Me.ilCamiones = New System.Windows.Forms.ImageList(Me.components)
        Me.pbImagenesCamiones = New System.Windows.Forms.PictureBox()
        Me.lblPesoCamion = New System.Windows.Forms.Label()
        Me.btnCargarSaca = New System.Windows.Forms.Button()
        Me.pbSacas = New System.Windows.Forms.PictureBox()
        Me.ilSacas = New System.Windows.Forms.ImageList(Me.components)
        Me.pbSaca = New System.Windows.Forms.ProgressBar()
        Me.TimerSaca = New System.Windows.Forms.Timer(Me.components)
        Me.lblAtencion = New System.Windows.Forms.Label()
        Me.lblNumeroCamion = New System.Windows.Forms.Label()
        Me.lblNumeroSaca = New System.Windows.Forms.Label()
        Me.btnCargarCamion = New System.Windows.Forms.Button()
        Me.lblPesoCamionActual = New System.Windows.Forms.Label()
        Me.gbInformacionCamion = New System.Windows.Forms.GroupBox()
        Me.gbInformacionSaca = New System.Windows.Forms.GroupBox()
        Me.gbInformacion = New System.Windows.Forms.GroupBox()
        CType(Me.tbPesoSacas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagenesCamiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInformacionCamion.SuspendLayout()
        Me.gbInformacionSaca.SuspendLayout()
        Me.gbInformacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerDiaHora
        '
        Me.TimerDiaHora.Enabled = True
        Me.TimerDiaHora.Interval = 1000
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(4, 16)
        Me.lblTiempo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(76, 15)
        Me.lblTiempo.TabIndex = 0
        Me.lblTiempo.Text = "                       "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(4, 31)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(132, 15)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Página web empresarial"
        '
        'lblPesoSacas
        '
        Me.lblPesoSacas.AutoSize = True
        Me.lblPesoSacas.Location = New System.Drawing.Point(258, 16)
        Me.lblPesoSacas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPesoSacas.Name = "lblPesoSacas"
        Me.lblPesoSacas.Size = New System.Drawing.Size(109, 15)
        Me.lblPesoSacas.TabIndex = 3
        Me.lblPesoSacas.Text = "Peso de sacas: 6000"
        '
        'tbPesoSacas
        '
        Me.tbPesoSacas.Location = New System.Drawing.Point(258, 33)
        Me.tbPesoSacas.Margin = New System.Windows.Forms.Padding(2)
        Me.tbPesoSacas.Maximum = 9000
        Me.tbPesoSacas.Minimum = 3000
        Me.tbPesoSacas.Name = "tbPesoSacas"
        Me.tbPesoSacas.Size = New System.Drawing.Size(109, 45)
        Me.tbPesoSacas.TabIndex = 4
        Me.tbPesoSacas.Value = 6000
        '
        'lbCamiones
        '
        Me.lbCamiones.FormattingEnabled = True
        Me.lbCamiones.ItemHeight = 15
        Me.lbCamiones.Items.AddRange(New Object() {"Camión pequeño", "Camión mediano", "Camión grande"})
        Me.lbCamiones.Location = New System.Drawing.Point(4, 18)
        Me.lbCamiones.Margin = New System.Windows.Forms.Padding(2)
        Me.lbCamiones.Name = "lbCamiones"
        Me.lbCamiones.Size = New System.Drawing.Size(204, 49)
        Me.lbCamiones.TabIndex = 5
        '
        'ilCamiones
        '
        Me.ilCamiones.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilCamiones.ImageStream = CType(resources.GetObject("ilCamiones.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilCamiones.TransparentColor = System.Drawing.Color.Transparent
        Me.ilCamiones.Images.SetKeyName(0, "camionpequeno.jpg")
        Me.ilCamiones.Images.SetKeyName(1, "camionmediano.jpg")
        Me.ilCamiones.Images.SetKeyName(2, "camiongrande.jpg")
        '
        'pbImagenesCamiones
        '
        Me.pbImagenesCamiones.Location = New System.Drawing.Point(372, 357)
        Me.pbImagenesCamiones.Margin = New System.Windows.Forms.Padding(2)
        Me.pbImagenesCamiones.Name = "pbImagenesCamiones"
        Me.pbImagenesCamiones.Size = New System.Drawing.Size(250, 250)
        Me.pbImagenesCamiones.TabIndex = 6
        Me.pbImagenesCamiones.TabStop = False
        '
        'lblPesoCamion
        '
        Me.lblPesoCamion.AutoSize = True
        Me.lblPesoCamion.Location = New System.Drawing.Point(4, 67)
        Me.lblPesoCamion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPesoCamion.Name = "lblPesoCamion"
        Me.lblPesoCamion.Size = New System.Drawing.Size(174, 15)
        Me.lblPesoCamion.TabIndex = 7
        Me.lblPesoCamion.Text = "Peso máximo del camión: 0       "
        Me.lblPesoCamion.Visible = False
        '
        'btnCargarSaca
        '
        Me.btnCargarSaca.Enabled = False
        Me.btnCargarSaca.Location = New System.Drawing.Point(4, 16)
        Me.btnCargarSaca.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCargarSaca.Name = "btnCargarSaca"
        Me.btnCargarSaca.Size = New System.Drawing.Size(85, 30)
        Me.btnCargarSaca.TabIndex = 8
        Me.btnCargarSaca.Text = "Cargar saca"
        Me.btnCargarSaca.UseVisualStyleBackColor = True
        '
        'pbSacas
        '
        Me.pbSacas.Location = New System.Drawing.Point(4, 50)
        Me.pbSacas.Margin = New System.Windows.Forms.Padding(2)
        Me.pbSacas.Name = "pbSacas"
        Me.pbSacas.Size = New System.Drawing.Size(250, 250)
        Me.pbSacas.TabIndex = 9
        Me.pbSacas.TabStop = False
        '
        'ilSacas
        '
        Me.ilSacas.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilSacas.ImageStream = CType(resources.GetObject("ilSacas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilSacas.TransparentColor = System.Drawing.Color.Transparent
        Me.ilSacas.Images.SetKeyName(0, "sacaLlena.jpg")
        Me.ilSacas.Images.SetKeyName(1, "pala.jpg")
        '
        'pbSaca
        '
        Me.pbSaca.Location = New System.Drawing.Point(4, 319)
        Me.pbSaca.Margin = New System.Windows.Forms.Padding(2)
        Me.pbSaca.Name = "pbSaca"
        Me.pbSaca.Size = New System.Drawing.Size(105, 20)
        Me.pbSaca.TabIndex = 10
        Me.pbSaca.Visible = False
        '
        'TimerSaca
        '
        '
        'lblAtencion
        '
        Me.lblAtencion.AutoSize = True
        Me.lblAtencion.Location = New System.Drawing.Point(4, 302)
        Me.lblAtencion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAtencion.Name = "lblAtencion"
        Me.lblAtencion.Size = New System.Drawing.Size(120, 15)
        Me.lblAtencion.TabIndex = 11
        Me.lblAtencion.Text = "Atención: cargando..."
        Me.lblAtencion.Visible = False
        '
        'lblNumeroCamion
        '
        Me.lblNumeroCamion.AutoSize = True
        Me.lblNumeroCamion.Location = New System.Drawing.Point(4, 50)
        Me.lblNumeroCamion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeroCamion.Name = "lblNumeroCamion"
        Me.lblNumeroCamion.Size = New System.Drawing.Size(76, 15)
        Me.lblNumeroCamion.TabIndex = 12
        Me.lblNumeroCamion.Text = "Camion nº 0 "
        '
        'lblNumeroSaca
        '
        Me.lblNumeroSaca.AutoSize = True
        Me.lblNumeroSaca.Location = New System.Drawing.Point(4, 67)
        Me.lblNumeroSaca.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeroSaca.Name = "lblNumeroSaca"
        Me.lblNumeroSaca.Size = New System.Drawing.Size(55, 15)
        Me.lblNumeroSaca.TabIndex = 13
        Me.lblNumeroSaca.Text = "Saca nº 0"
        '
        'btnCargarCamion
        '
        Me.btnCargarCamion.Enabled = False
        Me.btnCargarCamion.Location = New System.Drawing.Point(4, 84)
        Me.btnCargarCamion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCargarCamion.Name = "btnCargarCamion"
        Me.btnCargarCamion.Size = New System.Drawing.Size(96, 26)
        Me.btnCargarCamion.TabIndex = 14
        Me.btnCargarCamion.Text = "Cargar camion"
        Me.btnCargarCamion.UseVisualStyleBackColor = True
        '
        'lblPesoCamionActual
        '
        Me.lblPesoCamionActual.AutoSize = True
        Me.lblPesoCamionActual.Location = New System.Drawing.Point(4, 112)
        Me.lblPesoCamionActual.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPesoCamionActual.Name = "lblPesoCamionActual"
        Me.lblPesoCamionActual.Size = New System.Drawing.Size(141, 15)
        Me.lblPesoCamionActual.TabIndex = 15
        Me.lblPesoCamionActual.Text = "Peso actual del camion: 0"
        '
        'gbInformacionCamion
        '
        Me.gbInformacionCamion.Controls.Add(Me.lbCamiones)
        Me.gbInformacionCamion.Controls.Add(Me.lblPesoCamionActual)
        Me.gbInformacionCamion.Controls.Add(Me.lblPesoCamion)
        Me.gbInformacionCamion.Controls.Add(Me.btnCargarCamion)
        Me.gbInformacionCamion.Location = New System.Drawing.Point(151, 7)
        Me.gbInformacionCamion.Margin = New System.Windows.Forms.Padding(2)
        Me.gbInformacionCamion.Name = "gbInformacionCamion"
        Me.gbInformacionCamion.Padding = New System.Windows.Forms.Padding(2)
        Me.gbInformacionCamion.Size = New System.Drawing.Size(216, 145)
        Me.gbInformacionCamion.TabIndex = 16
        Me.gbInformacionCamion.TabStop = False
        Me.gbInformacionCamion.Text = "Información del camión"
        '
        'gbInformacionSaca
        '
        Me.gbInformacionSaca.Controls.Add(Me.lblPesoSacas)
        Me.gbInformacionSaca.Controls.Add(Me.btnCargarSaca)
        Me.gbInformacionSaca.Controls.Add(Me.pbSacas)
        Me.gbInformacionSaca.Controls.Add(Me.tbPesoSacas)
        Me.gbInformacionSaca.Controls.Add(Me.pbSaca)
        Me.gbInformacionSaca.Controls.Add(Me.lblAtencion)
        Me.gbInformacionSaca.Location = New System.Drawing.Point(372, 7)
        Me.gbInformacionSaca.Margin = New System.Windows.Forms.Padding(2)
        Me.gbInformacionSaca.Name = "gbInformacionSaca"
        Me.gbInformacionSaca.Padding = New System.Windows.Forms.Padding(2)
        Me.gbInformacionSaca.Size = New System.Drawing.Size(377, 346)
        Me.gbInformacionSaca.TabIndex = 17
        Me.gbInformacionSaca.TabStop = False
        Me.gbInformacionSaca.Text = "Información de la saca"
        Me.gbInformacionSaca.Visible = False
        '
        'gbInformacion
        '
        Me.gbInformacion.Controls.Add(Me.lblTiempo)
        Me.gbInformacion.Controls.Add(Me.LinkLabel1)
        Me.gbInformacion.Controls.Add(Me.lblNumeroCamion)
        Me.gbInformacion.Controls.Add(Me.lblNumeroSaca)
        Me.gbInformacion.Location = New System.Drawing.Point(8, 7)
        Me.gbInformacion.Margin = New System.Windows.Forms.Padding(2)
        Me.gbInformacion.Name = "gbInformacion"
        Me.gbInformacion.Padding = New System.Windows.Forms.Padding(2)
        Me.gbInformacion.Size = New System.Drawing.Size(143, 90)
        Me.gbInformacion.TabIndex = 18
        Me.gbInformacion.TabStop = False
        Me.gbInformacion.Text = "Información general"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 708)
        Me.Controls.Add(Me.gbInformacion)
        Me.Controls.Add(Me.gbInformacionSaca)
        Me.Controls.Add(Me.gbInformacionCamion)
        Me.Controls.Add(Me.pbImagenesCamiones)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Distribuidora de arroz"
        CType(Me.tbPesoSacas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagenesCamiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInformacionCamion.ResumeLayout(False)
        Me.gbInformacionCamion.PerformLayout()
        Me.gbInformacionSaca.ResumeLayout(False)
        Me.gbInformacionSaca.PerformLayout()
        Me.gbInformacion.ResumeLayout(False)
        Me.gbInformacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TimerDiaHora As Timer
    Friend WithEvents lblTiempo As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblPesoSacas As Label
    Friend WithEvents tbPesoSacas As TrackBar
    Friend WithEvents lbCamiones As ListBox
    Friend WithEvents ilCamiones As ImageList
    Friend WithEvents pbImagenesCamiones As PictureBox
    Friend WithEvents lblPesoCamion As Label
    Friend WithEvents btnCargarSaca As Button
    Friend WithEvents pbSacas As PictureBox
    Friend WithEvents ilSacas As ImageList
    Friend WithEvents pbSaca As ProgressBar
    Friend WithEvents TimerSaca As Timer
    Friend WithEvents lblAtencion As Label
    Friend WithEvents lblNumeroCamion As Label
    Friend WithEvents lblNumeroSaca As Label
    Friend WithEvents btnCargarCamion As Button
    Friend WithEvents lblPesoCamionActual As Label
    Friend WithEvents gbInformacionCamion As GroupBox
    Friend WithEvents gbInformacionSaca As GroupBox
    Friend WithEvents gbInformacion As GroupBox
End Class
