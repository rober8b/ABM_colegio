<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.Condicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlumnosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me._tablas_colegioDataSet4 = New forms_para_colegio._tablas_colegioDataSet4()
        Me.AlumnosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me._tablas_colegioDataSet3 = New forms_para_colegio._tablas_colegioDataSet3()
        Me._tablas_colegioDataSet2 = New forms_para_colegio._tablas_colegioDataSet2()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New forms_para_colegio._tablas_colegioDataSet2TableAdapters.AlumnosTableAdapter()
        Me.AlumnosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter1 = New forms_para_colegio._tablas_colegioDataSet3TableAdapters.AlumnosTableAdapter()
        Me.btnactu = New System.Windows.Forms.Button()
        Me.AlumnosTableAdapter2 = New forms_para_colegio._tablas_colegioDataSet4TableAdapters.AlumnosTableAdapter()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._tablas_colegioDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._tablas_colegioDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._tablas_colegioDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NlegajoDataGridViewTextBoxColumn, Me.DivisionDataGridViewTextBoxColumn, Me.MateriaDataGridViewTextBoxColumn, Me.PcuatrimestreDataGridViewTextBoxColumn, Me.ScuatrimestreDataGridViewTextBoxColumn, Me.TcuatrimestreDataGridViewTextBoxColumn, Me.PromedioDataGridViewTextBoxColumn, Me.Condicion})
        Me.DataGridView1.DataSource = Me.AlumnosBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(13, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(742, 303)
        Me.DataGridView1.TabIndex = 34
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
        'Condicion
        '
        Me.Condicion.DataPropertyName = "Condicion"
        Me.Condicion.HeaderText = "Condicion"
        Me.Condicion.Name = "Condicion"
        Me.Condicion.ReadOnly = True
        '
        'AlumnosBindingSource3
        '
        Me.AlumnosBindingSource3.DataMember = "Alumnos"
        Me.AlumnosBindingSource3.DataSource = Me._tablas_colegioDataSet4
        '
        '_tablas_colegioDataSet4
        '
        Me._tablas_colegioDataSet4.DataSetName = "_tablas_colegioDataSet4"
        Me._tablas_colegioDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosBindingSource2
        '
        Me.AlumnosBindingSource2.DataMember = "Alumnos"
        Me.AlumnosBindingSource2.DataSource = Me._tablas_colegioDataSet3
        '
        '_tablas_colegioDataSet3
        '
        Me._tablas_colegioDataSet3.DataSetName = "_tablas_colegioDataSet3"
        Me._tablas_colegioDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_tablas_colegioDataSet2
        '
        Me._tablas_colegioDataSet2.DataSetName = "_tablas_colegioDataSet2"
        Me._tablas_colegioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me._tablas_colegioDataSet2
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'AlumnosBindingSource1
        '
        Me.AlumnosBindingSource1.DataMember = "Alumnos"
        Me.AlumnosBindingSource1.DataSource = Me._tablas_colegioDataSet2
        '
        'AlumnosTableAdapter1
        '
        Me.AlumnosTableAdapter1.ClearBeforeFill = True
        '
        'btnactu
        '
        Me.btnactu.BackColor = System.Drawing.SystemColors.Info
        Me.btnactu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnactu.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnactu.Location = New System.Drawing.Point(271, 404)
        Me.btnactu.Name = "btnactu"
        Me.btnactu.Size = New System.Drawing.Size(205, 34)
        Me.btnactu.TabIndex = 38
        Me.btnactu.Text = "Actualizar data grid"
        Me.btnactu.UseVisualStyleBackColor = False
        '
        'AlumnosTableAdapter2
        '
        Me.AlumnosTableAdapter2.ClearBeforeFill = True
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.SystemColors.Info
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnVolver.Location = New System.Drawing.Point(12, 404)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(100, 34)
        Me.BtnVolver.TabIndex = 46
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Futura-Bold", 26.25!, System.Drawing.FontStyle.Underline)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(201, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 35)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "PROMEDIOS TOTALES"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(767, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.btnactu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form5"
        Me.Text = "PROMEDIOS TOTALES"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._tablas_colegioDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._tablas_colegioDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._tablas_colegioDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _tablas_colegioDataSet2 As _tablas_colegioDataSet2
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As _tablas_colegioDataSet2TableAdapters.AlumnosTableAdapter
    Friend WithEvents AlumnosBindingSource1 As BindingSource
    Friend WithEvents _tablas_colegioDataSet3 As _tablas_colegioDataSet3
    Friend WithEvents AlumnosBindingSource2 As BindingSource
    Friend WithEvents AlumnosTableAdapter1 As _tablas_colegioDataSet3TableAdapters.AlumnosTableAdapter
    Friend WithEvents btnactu As Button
    Friend WithEvents _tablas_colegioDataSet4 As _tablas_colegioDataSet4
    Friend WithEvents AlumnosBindingSource3 As BindingSource
    Friend WithEvents AlumnosTableAdapter2 As _tablas_colegioDataSet4TableAdapters.AlumnosTableAdapter
    Friend WithEvents NlegajoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DivisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MateriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcuatrimestreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScuatrimestreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TcuatrimestreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Condicion As DataGridViewTextBoxColumn
    Friend WithEvents BtnVolver As Button
    Friend WithEvents Label1 As Label
End Class
