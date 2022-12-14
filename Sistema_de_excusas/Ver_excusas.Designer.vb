<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ver_excusas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AlumnoLabel As System.Windows.Forms.Label
        Dim CursoLabel As System.Windows.Forms.Label
        Dim SeccionLabel As System.Windows.Forms.Label
        Dim IdentidadLabel As System.Windows.Forms.Label
        Dim EncargadoLabel As System.Windows.Forms.Label
        Dim MotivoLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ver_excusas))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblExcusas = New System.Windows.Forms.Label()
        Me.PrintpreviewDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ExcusasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDExcusasDataSet1 = New Sistema_de_excusas.BDExcusasDataSet1()
        Me.ExcusasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExcusasTableAdapter = New Sistema_de_excusas.BDExcusasDataSet1TableAdapters.ExcusasTableAdapter()
        Me.TableAdapterManager = New Sistema_de_excusas.BDExcusasDataSet1TableAdapters.TableAdapterManager()
        Me.AlumnoTextBox = New System.Windows.Forms.TextBox()
        Me.CursoTextBox = New System.Windows.Forms.TextBox()
        Me.SeccionTextBox = New System.Windows.Forms.TextBox()
        Me.IdentidadTextBox = New System.Windows.Forms.TextBox()
        Me.EncargadoTextBox = New System.Windows.Forms.TextBox()
        Me.MotivoTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        AlumnoLabel = New System.Windows.Forms.Label()
        CursoLabel = New System.Windows.Forms.Label()
        SeccionLabel = New System.Windows.Forms.Label()
        IdentidadLabel = New System.Windows.Forms.Label()
        EncargadoLabel = New System.Windows.Forms.Label()
        MotivoLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExcusasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDExcusasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExcusasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlumnoLabel
        '
        AlumnoLabel.AutoSize = True
        AlumnoLabel.BackColor = System.Drawing.Color.Transparent
        AlumnoLabel.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlumnoLabel.Location = New System.Drawing.Point(141, 110)
        AlumnoLabel.Name = "AlumnoLabel"
        AlumnoLabel.Size = New System.Drawing.Size(81, 28)
        AlumnoLabel.TabIndex = 14
        AlumnoLabel.Text = "Alumno:"
        '
        'CursoLabel
        '
        CursoLabel.AutoSize = True
        CursoLabel.BackColor = System.Drawing.Color.Transparent
        CursoLabel.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CursoLabel.Location = New System.Drawing.Point(379, 115)
        CursoLabel.Name = "CursoLabel"
        CursoLabel.Size = New System.Drawing.Size(67, 28)
        CursoLabel.TabIndex = 18
        CursoLabel.Text = "Curso:"
        '
        'SeccionLabel
        '
        SeccionLabel.AutoSize = True
        SeccionLabel.BackColor = System.Drawing.Color.Transparent
        SeccionLabel.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeccionLabel.Location = New System.Drawing.Point(587, 107)
        SeccionLabel.Name = "SeccionLabel"
        SeccionLabel.Size = New System.Drawing.Size(85, 28)
        SeccionLabel.TabIndex = 20
        SeccionLabel.Text = "Seccion:"
        '
        'IdentidadLabel
        '
        IdentidadLabel.AutoSize = True
        IdentidadLabel.BackColor = System.Drawing.Color.Transparent
        IdentidadLabel.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdentidadLabel.Location = New System.Drawing.Point(583, 202)
        IdentidadLabel.Name = "IdentidadLabel"
        IdentidadLabel.Size = New System.Drawing.Size(101, 28)
        IdentidadLabel.TabIndex = 22
        IdentidadLabel.Text = "Identidad:"
        '
        'EncargadoLabel
        '
        EncargadoLabel.AutoSize = True
        EncargadoLabel.BackColor = System.Drawing.Color.Transparent
        EncargadoLabel.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EncargadoLabel.Location = New System.Drawing.Point(121, 202)
        EncargadoLabel.Name = "EncargadoLabel"
        EncargadoLabel.Size = New System.Drawing.Size(110, 28)
        EncargadoLabel.TabIndex = 24
        EncargadoLabel.Text = "Encargado:"
        '
        'MotivoLabel
        '
        MotivoLabel.AutoSize = True
        MotivoLabel.BackColor = System.Drawing.Color.Transparent
        MotivoLabel.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MotivoLabel.Location = New System.Drawing.Point(360, 261)
        MotivoLabel.Name = "MotivoLabel"
        MotivoLabel.Size = New System.Drawing.Size(74, 28)
        MotivoLabel.TabIndex = 26
        MotivoLabel.Text = "Motivo:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Sistema_de_excusas.My.Resources.Resources._0c252cd5_09d4_4d55_bc21_1580bd35852f
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(735, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(130, 112)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnImprimir.BackgroundImage = Global.Sistema_de_excusas.My.Resources.Resources.salir
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(862, 406)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(62, 51)
        Me.btnImprimir.TabIndex = 10
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.BackgroundImage = Global.Sistema_de_excusas.My.Resources.Resources.impresora2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(688, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 51)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(676, 460)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Imprimir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(870, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Salir"
        '
        'lblExcusas
        '
        Me.lblExcusas.AllowDrop = True
        Me.lblExcusas.BackColor = System.Drawing.Color.Transparent
        Me.lblExcusas.CausesValidation = False
        Me.lblExcusas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblExcusas.Font = New System.Drawing.Font("MingLiU-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExcusas.ForeColor = System.Drawing.Color.Black
        Me.lblExcusas.Location = New System.Drawing.Point(281, 21)
        Me.lblExcusas.Name = "lblExcusas"
        Me.lblExcusas.Size = New System.Drawing.Size(247, 49)
        Me.lblExcusas.TabIndex = 14
        Me.lblExcusas.Text = "Excusas"
        Me.lblExcusas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintpreviewDialog1
        '
        Me.PrintpreviewDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'ExcusasBindingSource
        '
        Me.ExcusasBindingSource.DataMember = "Excusas"
        '
        'BDExcusasDataSet1
        '
        Me.BDExcusasDataSet1.DataSetName = "BDExcusasDataSet1"
        Me.BDExcusasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExcusasBindingSource1
        '
        Me.ExcusasBindingSource1.DataMember = "Excusas"
        Me.ExcusasBindingSource1.DataSource = Me.BDExcusasDataSet1
        '
        'ExcusasTableAdapter
        '
        Me.ExcusasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ExcusasTableAdapter = Me.ExcusasTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sistema_de_excusas.BDExcusasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AlumnoTextBox
        '
        Me.AlumnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExcusasBindingSource1, "Alumno", True))
        Me.AlumnoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlumnoTextBox.Location = New System.Drawing.Point(101, 141)
        Me.AlumnoTextBox.Name = "AlumnoTextBox"
        Me.AlumnoTextBox.Size = New System.Drawing.Size(149, 26)
        Me.AlumnoTextBox.TabIndex = 15
        '
        'CursoTextBox
        '
        Me.CursoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExcusasBindingSource1, "Curso", True))
        Me.CursoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CursoTextBox.Location = New System.Drawing.Point(346, 141)
        Me.CursoTextBox.Name = "CursoTextBox"
        Me.CursoTextBox.Size = New System.Drawing.Size(125, 26)
        Me.CursoTextBox.TabIndex = 19
        '
        'SeccionTextBox
        '
        Me.SeccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExcusasBindingSource1, "Seccion", True))
        Me.SeccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeccionTextBox.Location = New System.Drawing.Point(572, 141)
        Me.SeccionTextBox.Name = "SeccionTextBox"
        Me.SeccionTextBox.Size = New System.Drawing.Size(100, 26)
        Me.SeccionTextBox.TabIndex = 21
        '
        'IdentidadTextBox
        '
        Me.IdentidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExcusasBindingSource1, "Identidad", True))
        Me.IdentidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdentidadTextBox.Location = New System.Drawing.Point(535, 244)
        Me.IdentidadTextBox.Name = "IdentidadTextBox"
        Me.IdentidadTextBox.Size = New System.Drawing.Size(174, 26)
        Me.IdentidadTextBox.TabIndex = 23
        '
        'EncargadoTextBox
        '
        Me.EncargadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExcusasBindingSource1, "Encargado", True))
        Me.EncargadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncargadoTextBox.Location = New System.Drawing.Point(101, 244)
        Me.EncargadoTextBox.Name = "EncargadoTextBox"
        Me.EncargadoTextBox.Size = New System.Drawing.Size(137, 26)
        Me.EncargadoTextBox.TabIndex = 25
        '
        'MotivoTextBox
        '
        Me.MotivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExcusasBindingSource1, "Motivo", True))
        Me.MotivoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotivoTextBox.Location = New System.Drawing.Point(166, 301)
        Me.MotivoTextBox.Multiline = True
        Me.MotivoTextBox.Name = "MotivoTextBox"
        Me.MotivoTextBox.Size = New System.Drawing.Size(473, 139)
        Me.MotivoTextBox.TabIndex = 27
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(379, 517)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(60, 28)
        Label3.TabIndex = 28
        Label3.Text = "Firma"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExcusasBindingSource1, "Curso", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(261, 504)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(322, 10)
        Me.TextBox1.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.BackgroundImage = Global.Sistema_de_excusas.My.Resources.Resources.buscar__1_
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(781, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 51)
        Me.Button2.TabIndex = 30
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(777, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 21)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Buscar"
        '
        'Ver_excusas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_de_excusas.My.Resources.Resources.image002
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(945, 554)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(AlumnoLabel)
        Me.Controls.Add(Me.AlumnoTextBox)
        Me.Controls.Add(CursoLabel)
        Me.Controls.Add(Me.CursoTextBox)
        Me.Controls.Add(SeccionLabel)
        Me.Controls.Add(Me.SeccionTextBox)
        Me.Controls.Add(IdentidadLabel)
        Me.Controls.Add(Me.IdentidadTextBox)
        Me.Controls.Add(EncargadoLabel)
        Me.Controls.Add(Me.EncargadoTextBox)
        Me.Controls.Add(MotivoLabel)
        Me.Controls.Add(Me.MotivoTextBox)
        Me.Controls.Add(Me.lblExcusas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.PictureBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ver_excusas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver excusas"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExcusasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDExcusasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExcusasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblExcusas As Label
    Friend WithEvents PrintpreviewDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    'Friend WithEvents BDExcusasDataSet As BDExcusasDataSet
    Friend WithEvents ExcusasBindingSource As BindingSource
    Friend WithEvents BDExcusasDataSet1 As BDExcusasDataSet1
    Friend WithEvents ExcusasBindingSource1 As BindingSource
    Friend WithEvents ExcusasTableAdapter As BDExcusasDataSet1TableAdapters.ExcusasTableAdapter
    Friend WithEvents TableAdapterManager As BDExcusasDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AlumnoTextBox As TextBox
    Friend WithEvents CursoTextBox As TextBox
    Friend WithEvents SeccionTextBox As TextBox
    Friend WithEvents IdentidadTextBox As TextBox
    Friend WithEvents EncargadoTextBox As TextBox
    Friend WithEvents MotivoTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    'Friend WithEvents ExcusasTableAdapter As BDExcusasDataSetTableAdapters.ExcusasTableAdapter
    'Friend WithEvents TableAdapterManager As BDExcusasDataSetTableAdapters.TableAdapterManager
End Class
