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
        Me.BtnPromedios = New System.Windows.Forms.Button()
        Me.BtnAplazados = New System.Windows.Forms.Button()
        Me.BtnDesaprobados = New System.Windows.Forms.Button()
        Me.BtnAprobados = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TCtext = New System.Windows.Forms.TextBox()
        Me.SCtext = New System.Windows.Forms.TextBox()
        Me.PCtext = New System.Windows.Forms.TextBox()
        Me.Matext = New System.Windows.Forms.TextBox()
        Me.Divtext = New System.Windows.Forms.TextBox()
        Me.NLtext = New System.Windows.Forms.TextBox()
        Me._tablas_colegioDataSet1 = New forms_para_colegio._tablas_colegioDataSet1()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New forms_para_colegio._tablas_colegioDataSet1TableAdapters.AlumnosTableAdapter()
        Me.CalcProm = New System.Windows.Forms.Button()
        Me.Promtext = New System.Windows.Forms.TextBox()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.Estadotext = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me._tablas_colegioDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnPromedios
        '
        Me.BtnPromedios.BackColor = System.Drawing.Color.AliceBlue
        Me.BtnPromedios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPromedios.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPromedios.Location = New System.Drawing.Point(22, 58)
        Me.BtnPromedios.Name = "BtnPromedios"
        Me.BtnPromedios.Size = New System.Drawing.Size(129, 34)
        Me.BtnPromedios.TabIndex = 37
        Me.BtnPromedios.Text = "Ver Promedios "
        Me.BtnPromedios.UseVisualStyleBackColor = False
        '
        'BtnAplazados
        '
        Me.BtnAplazados.BackColor = System.Drawing.Color.AliceBlue
        Me.BtnAplazados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAplazados.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAplazados.Location = New System.Drawing.Point(22, 193)
        Me.BtnAplazados.Name = "BtnAplazados"
        Me.BtnAplazados.Size = New System.Drawing.Size(129, 34)
        Me.BtnAplazados.TabIndex = 36
        Me.BtnAplazados.Text = "Aplazados"
        Me.BtnAplazados.UseVisualStyleBackColor = False
        '
        'BtnDesaprobados
        '
        Me.BtnDesaprobados.BackColor = System.Drawing.Color.AliceBlue
        Me.BtnDesaprobados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDesaprobados.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDesaprobados.Location = New System.Drawing.Point(22, 150)
        Me.BtnDesaprobados.Name = "BtnDesaprobados"
        Me.BtnDesaprobados.Size = New System.Drawing.Size(129, 34)
        Me.BtnDesaprobados.TabIndex = 35
        Me.BtnDesaprobados.Text = "Desaprobados"
        Me.BtnDesaprobados.UseVisualStyleBackColor = False
        '
        'BtnAprobados
        '
        Me.BtnAprobados.BackColor = System.Drawing.Color.AliceBlue
        Me.BtnAprobados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAprobados.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAprobados.Location = New System.Drawing.Point(22, 104)
        Me.BtnAprobados.Name = "BtnAprobados"
        Me.BtnAprobados.Size = New System.Drawing.Size(129, 34)
        Me.BtnAprobados.TabIndex = 34
        Me.BtnAprobados.Text = "Aprobados"
        Me.BtnAprobados.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminar.Location = New System.Drawing.Point(336, 404)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(100, 34)
        Me.BtnEliminar.TabIndex = 32
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Location = New System.Drawing.Point(217, 404)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 34)
        Me.BtnGuardar.TabIndex = 31
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Info
        Me.Label6.Location = New System.Drawing.Point(472, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 25)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "3er trimestre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(258, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "2do trimestre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Info
        Me.Label4.Location = New System.Drawing.Point(30, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "1er trimestre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(30, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Materia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(30, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Division"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Numero de legajo"
        '
        'TCtext
        '
        Me.TCtext.BackColor = System.Drawing.Color.AliceBlue
        Me.TCtext.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TCtext.Location = New System.Drawing.Point(477, 273)
        Me.TCtext.Name = "TCtext"
        Me.TCtext.Size = New System.Drawing.Size(124, 29)
        Me.TCtext.TabIndex = 4
        '
        'SCtext
        '
        Me.SCtext.BackColor = System.Drawing.Color.AliceBlue
        Me.SCtext.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SCtext.Location = New System.Drawing.Point(263, 273)
        Me.SCtext.Name = "SCtext"
        Me.SCtext.Size = New System.Drawing.Size(124, 29)
        Me.SCtext.TabIndex = 3
        '
        'PCtext
        '
        Me.PCtext.BackColor = System.Drawing.Color.AliceBlue
        Me.PCtext.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PCtext.Location = New System.Drawing.Point(35, 273)
        Me.PCtext.Name = "PCtext"
        Me.PCtext.Size = New System.Drawing.Size(124, 29)
        Me.PCtext.TabIndex = 2
        '
        'Matext
        '
        Me.Matext.BackColor = System.Drawing.SystemColors.Info
        Me.Matext.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Matext.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Matext.Location = New System.Drawing.Point(35, 213)
        Me.Matext.Name = "Matext"
        Me.Matext.ReadOnly = True
        Me.Matext.Size = New System.Drawing.Size(125, 29)
        Me.Matext.TabIndex = 21
        Me.Matext.Text = "Matematica"
        '
        'Divtext
        '
        Me.Divtext.BackColor = System.Drawing.Color.AliceBlue
        Me.Divtext.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Divtext.Location = New System.Drawing.Point(35, 153)
        Me.Divtext.Name = "Divtext"
        Me.Divtext.Size = New System.Drawing.Size(125, 29)
        Me.Divtext.TabIndex = 1
        '
        'NLtext
        '
        Me.NLtext.BackColor = System.Drawing.Color.AliceBlue
        Me.NLtext.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NLtext.Location = New System.Drawing.Point(35, 93)
        Me.NLtext.Name = "NLtext"
        Me.NLtext.Size = New System.Drawing.Size(282, 29)
        Me.NLtext.TabIndex = 0
        '
        '_tablas_colegioDataSet1
        '
        Me._tablas_colegioDataSet1.DataSetName = "_tablas_colegioDataSet1"
        Me._tablas_colegioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me._tablas_colegioDataSet1
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'CalcProm
        '
        Me.CalcProm.BackColor = System.Drawing.SystemColors.Info
        Me.CalcProm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CalcProm.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CalcProm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalcProm.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcProm.ForeColor = System.Drawing.Color.Black
        Me.CalcProm.Location = New System.Drawing.Point(263, 320)
        Me.CalcProm.Name = "CalcProm"
        Me.CalcProm.Size = New System.Drawing.Size(124, 34)
        Me.CalcProm.TabIndex = 5
        Me.CalcProm.Text = "Promediar"
        Me.CalcProm.UseVisualStyleBackColor = False
        '
        'Promtext
        '
        Me.Promtext.BackColor = System.Drawing.SystemColors.Info
        Me.Promtext.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Promtext.ForeColor = System.Drawing.Color.Teal
        Me.Promtext.Location = New System.Drawing.Point(199, 360)
        Me.Promtext.MaxLength = 3
        Me.Promtext.Name = "Promtext"
        Me.Promtext.ReadOnly = True
        Me.Promtext.Size = New System.Drawing.Size(118, 29)
        Me.Promtext.TabIndex = 40
        '
        'BtnModif
        '
        Me.BtnModif.BackColor = System.Drawing.Color.LightGreen
        Me.BtnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModif.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnModif.Location = New System.Drawing.Point(455, 404)
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.Size = New System.Drawing.Size(100, 34)
        Me.BtnModif.TabIndex = 42
        Me.BtnModif.Text = "Modificar"
        Me.BtnModif.UseVisualStyleBackColor = False
        '
        'Estadotext
        '
        Me.Estadotext.BackColor = System.Drawing.Color.RoyalBlue
        Me.Estadotext.Cursor = System.Windows.Forms.Cursors.Default
        Me.Estadotext.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Estadotext.ForeColor = System.Drawing.SystemColors.Info
        Me.Estadotext.Location = New System.Drawing.Point(336, 360)
        Me.Estadotext.MaxLength = 3
        Me.Estadotext.Name = "Estadotext"
        Me.Estadotext.ReadOnly = True
        Me.Estadotext.Size = New System.Drawing.Size(118, 29)
        Me.Estadotext.TabIndex = 43
        Me.Estadotext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Estadotext.WordWrap = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightGreen
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.Location = New System.Drawing.Point(104, 404)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(100, 34)
        Me.BtnNuevo.TabIndex = 44
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IconButton1.BackColor = System.Drawing.Color.LightGreen
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Transparent
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton1.IconSize = 25
        Me.IconButton1.Location = New System.Drawing.Point(320, 93)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(0, 5, 0, 3)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.IconButton1.Size = New System.Drawing.Size(39, 29)
        Me.IconButton1.TabIndex = 46
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.GroupBox1.Controls.Add(Me.BtnPromedios)
        Me.GroupBox1.Controls.Add(Me.BtnAprobados)
        Me.GroupBox1.Controls.Add(Me.BtnDesaprobados)
        Me.GroupBox1.Controls.Add(Me.BtnAplazados)
        Me.GroupBox1.Location = New System.Drawing.Point(637, -11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 463)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Futura-Bold", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(177, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(301, 35)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Base De Alumnos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Estadotext)
        Me.Controls.Add(Me.BtnModif)
        Me.Controls.Add(Me.Promtext)
        Me.Controls.Add(Me.CalcProm)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TCtext)
        Me.Controls.Add(Me.SCtext)
        Me.Controls.Add(Me.PCtext)
        Me.Controls.Add(Me.Matext)
        Me.Controls.Add(Me.Divtext)
        Me.Controls.Add(Me.NLtext)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Alumnos"
        CType(Me._tablas_colegioDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPromedios As Button
    Friend WithEvents BtnAplazados As Button
    Friend WithEvents BtnDesaprobados As Button
    Friend WithEvents BtnAprobados As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TCtext As TextBox
    Friend WithEvents SCtext As TextBox
    Friend WithEvents PCtext As TextBox
    Friend WithEvents Matext As TextBox
    Friend WithEvents Divtext As TextBox
    Friend WithEvents NLtext As TextBox
    Friend WithEvents _tablas_colegioDataSet1 As _tablas_colegioDataSet1
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As _tablas_colegioDataSet1TableAdapters.AlumnosTableAdapter
    Friend WithEvents CalcProm As Button
    Friend WithEvents Promtext As TextBox
    Friend WithEvents BtnModif As Button
    Friend WithEvents Estadotext As TextBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
End Class
