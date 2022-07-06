<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NlegajoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DivisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MateriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcuatrimestreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScuatrimestreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TcuatrimestreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CondicionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlumnosaplazBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._tablas_colegioAPLAZADOS = New forms_para_colegio._tablas_colegioAPLAZADOS()
        Me.Btnlect = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlumnosaplazTableAdapter = New forms_para_colegio._tablas_colegioAPLAZADOSTableAdapters.alumnosaplazTableAdapter()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosaplazBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._tablas_colegioAPLAZADOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NlegajoDataGridViewTextBoxColumn, Me.DivisionDataGridViewTextBoxColumn, Me.MateriaDataGridViewTextBoxColumn, Me.PcuatrimestreDataGridViewTextBoxColumn, Me.ScuatrimestreDataGridViewTextBoxColumn, Me.TcuatrimestreDataGridViewTextBoxColumn, Me.PromedioDataGridViewTextBoxColumn, Me.CondicionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AlumnosaplazBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(539, 250)
        Me.DataGridView1.TabIndex = 55
        '
        'NlegajoDataGridViewTextBoxColumn
        '
        Me.NlegajoDataGridViewTextBoxColumn.DataPropertyName = "N_legajo"
        Me.NlegajoDataGridViewTextBoxColumn.HeaderText = "N_legajo"
        Me.NlegajoDataGridViewTextBoxColumn.Name = "NlegajoDataGridViewTextBoxColumn"
        '
        'DivisionDataGridViewTextBoxColumn
        '
        Me.DivisionDataGridViewTextBoxColumn.DataPropertyName = "Division"
        Me.DivisionDataGridViewTextBoxColumn.HeaderText = "Division"
        Me.DivisionDataGridViewTextBoxColumn.Name = "DivisionDataGridViewTextBoxColumn"
        '
        'MateriaDataGridViewTextBoxColumn
        '
        Me.MateriaDataGridViewTextBoxColumn.DataPropertyName = "Materia"
        Me.MateriaDataGridViewTextBoxColumn.HeaderText = "Materia"
        Me.MateriaDataGridViewTextBoxColumn.Name = "MateriaDataGridViewTextBoxColumn"
        '
        'PcuatrimestreDataGridViewTextBoxColumn
        '
        Me.PcuatrimestreDataGridViewTextBoxColumn.DataPropertyName = "P_cuatrimestre"
        Me.PcuatrimestreDataGridViewTextBoxColumn.HeaderText = "P_cuatrimestre"
        Me.PcuatrimestreDataGridViewTextBoxColumn.Name = "PcuatrimestreDataGridViewTextBoxColumn"
        '
        'ScuatrimestreDataGridViewTextBoxColumn
        '
        Me.ScuatrimestreDataGridViewTextBoxColumn.DataPropertyName = "S_cuatrimestre"
        Me.ScuatrimestreDataGridViewTextBoxColumn.HeaderText = "S_cuatrimestre"
        Me.ScuatrimestreDataGridViewTextBoxColumn.Name = "ScuatrimestreDataGridViewTextBoxColumn"
        '
        'TcuatrimestreDataGridViewTextBoxColumn
        '
        Me.TcuatrimestreDataGridViewTextBoxColumn.DataPropertyName = "T_cuatrimestre"
        Me.TcuatrimestreDataGridViewTextBoxColumn.HeaderText = "T_cuatrimestre"
        Me.TcuatrimestreDataGridViewTextBoxColumn.Name = "TcuatrimestreDataGridViewTextBoxColumn"
        '
        'PromedioDataGridViewTextBoxColumn
        '
        Me.PromedioDataGridViewTextBoxColumn.DataPropertyName = "Promedio"
        Me.PromedioDataGridViewTextBoxColumn.HeaderText = "Promedio"
        Me.PromedioDataGridViewTextBoxColumn.Name = "PromedioDataGridViewTextBoxColumn"
        '
        'CondicionDataGridViewTextBoxColumn
        '
        Me.CondicionDataGridViewTextBoxColumn.DataPropertyName = "Condicion"
        Me.CondicionDataGridViewTextBoxColumn.HeaderText = "Condicion"
        Me.CondicionDataGridViewTextBoxColumn.Name = "CondicionDataGridViewTextBoxColumn"
        '
        'AlumnosaplazBindingSource
        '
        Me.AlumnosaplazBindingSource.DataMember = "alumnosaplaz"
        Me.AlumnosaplazBindingSource.DataSource = Me._tablas_colegioAPLAZADOS
        '
        '_tablas_colegioAPLAZADOS
        '
        Me._tablas_colegioAPLAZADOS.DataSetName = "_tablas_colegioAPLAZADOS"
        Me._tablas_colegioAPLAZADOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Btnlect
        '
        Me.Btnlect.BackColor = System.Drawing.SystemColors.Info
        Me.Btnlect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnlect.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btnlect.Location = New System.Drawing.Point(199, 351)
        Me.Btnlect.Name = "Btnlect"
        Me.Btnlect.Size = New System.Drawing.Size(198, 34)
        Me.Btnlect.TabIndex = 54
        Me.Btnlect.Text = "Comenzar lectura"
        Me.Btnlect.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.SystemColors.Info
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnVolver.Location = New System.Drawing.Point(12, 351)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(100, 34)
        Me.BtnVolver.TabIndex = 53
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Futura-Bold", 26.25!, System.Drawing.FontStyle.Underline)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(331, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 35)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "APLAZADOS"
        '
        'AlumnosaplazTableAdapter
        '
        Me.AlumnosaplazTableAdapter.ClearBeforeFill = True
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.IconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Cornsilk
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MinusCircle
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Cornsilk
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 35
        Me.IconPictureBox1.Location = New System.Drawing.Point(282, 9)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(52, 35)
        Me.IconPictureBox1.TabIndex = 58
        Me.IconPictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(563, 450)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btnlect)
        Me.Controls.Add(Me.BtnVolver)
        Me.Name = "Form4"
        Me.Text = "APLAZADOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosaplazBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._tablas_colegioAPLAZADOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btnlect As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents _tablas_colegioAPLAZADOS As _tablas_colegioAPLAZADOS
    Friend WithEvents AlumnosaplazBindingSource As BindingSource
    Friend WithEvents AlumnosaplazTableAdapter As _tablas_colegioAPLAZADOSTableAdapters.alumnosaplazTableAdapter
    Friend WithEvents NlegajoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DivisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MateriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcuatrimestreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScuatrimestreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TcuatrimestreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CondicionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
