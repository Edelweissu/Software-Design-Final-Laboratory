<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientList
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
        Dim PatientID As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientList))
        Me.TbRegisteredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalsDataSet = New Finals.FinalsDataSet()
        Me.TbRegisteredTableAdapter = New Finals.FinalsDataSetTableAdapters.tbRegisteredTableAdapter()
        Me.FinalsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Listview1 = New System.Windows.Forms.ListView()
        Me.LastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MiddleName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Age = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CityOrTown = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ZipCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VaccSite = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Vaccine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HealthcareProf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Dates = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        PatientID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.TbRegisteredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PatientID
        '
        PatientID.Text = "PatientID"
        '
        'TbRegisteredBindingSource
        '
        Me.TbRegisteredBindingSource.DataMember = "tbRegistered"
        Me.TbRegisteredBindingSource.DataSource = Me.FinalsDataSet
        '
        'FinalsDataSet
        '
        Me.FinalsDataSet.DataSetName = "FinalsDataSet"
        Me.FinalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbRegisteredTableAdapter
        '
        Me.TbRegisteredTableAdapter.ClearBeforeFill = True
        '
        'FinalsDataSetBindingSource
        '
        Me.FinalsDataSetBindingSource.DataSource = Me.FinalsDataSet
        Me.FinalsDataSetBindingSource.Position = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Listview1
        '
        Me.Listview1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {PatientID, Me.LastName, Me.FirstName, Me.MiddleName, Me.Sex, Me.Age, Me.CityOrTown, Me.ZipCode, Me.VaccSite, Me.Vaccine, Me.HealthcareProf, Me.Dates})
        Me.Listview1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Listview1.FullRowSelect = True
        Me.Listview1.HideSelection = False
        Me.Listview1.Location = New System.Drawing.Point(281, 12)
        Me.Listview1.Name = "Listview1"
        Me.Listview1.Size = New System.Drawing.Size(1215, 566)
        Me.Listview1.TabIndex = 2
        Me.Listview1.UseCompatibleStateImageBehavior = False
        Me.Listview1.View = System.Windows.Forms.View.Details
        '
        'LastName
        '
        Me.LastName.Text = "LastName"
        '
        'FirstName
        '
        Me.FirstName.Text = "FirstName"
        '
        'MiddleName
        '
        Me.MiddleName.Text = "MiddleName"
        '
        'Sex
        '
        Me.Sex.Text = "Sex"
        '
        'Age
        '
        Me.Age.Text = "Age"
        '
        'CityOrTown
        '
        Me.CityOrTown.Text = "City/Town"
        '
        'ZipCode
        '
        Me.ZipCode.Text = "ZipCode"
        '
        'VaccSite
        '
        Me.VaccSite.Text = "Vaccination Site"
        '
        'Vaccine
        '
        Me.Vaccine.Text = "Vaccine Used"
        '
        'HealthcareProf
        '
        Me.HealthcareProf.Text = "Healthcare Professional"
        '
        'Dates
        '
        Me.Dates.Text = "Date"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(55, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 50)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "REGISTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(55, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 50)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(55, 420)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 50)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(33, 179)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 70)
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'PatientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Finals.My.Resources.Resources.blue
        Me.ClientSize = New System.Drawing.Size(1517, 598)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Listview1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PatientList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VACCINATED PEOPLE"
        CType(Me.TbRegisteredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FinalsDataSet As FinalsDataSet
    Friend WithEvents TbRegisteredBindingSource As BindingSource
    Friend WithEvents TbRegisteredTableAdapter As FinalsDataSetTableAdapters.tbRegisteredTableAdapter
    Friend WithEvents FinalsDataSetBindingSource As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LastName As ColumnHeader
    Friend WithEvents FirstName As ColumnHeader
    Friend WithEvents MiddleName As ColumnHeader
    Friend WithEvents Sex As ColumnHeader
    Friend WithEvents Age As ColumnHeader
    Friend WithEvents CityOrTown As ColumnHeader
    Friend WithEvents ZipCode As ColumnHeader
    Friend WithEvents VaccSite As ColumnHeader
    Friend WithEvents Vaccine As ColumnHeader
    Friend WithEvents HealthcareProf As ColumnHeader
    Friend WithEvents Dates As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Listview1 As ListView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
