<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.custID = New System.Windows.Forms.TextBox()
        Me.compName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.contName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.conTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.postalCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.city = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.state = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.phoneNum = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContacttitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostalcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomeridDataGridViewTextBoxColumn, Me.CompanynameDataGridViewTextBoxColumn, Me.ContactnameDataGridViewTextBoxColumn, Me.ContacttitleDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PostalcodeDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.PhonenumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(281, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(207, 281)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer ID"
        '
        'custID
        '
        Me.custID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customer_id", True))
        Me.custID.Location = New System.Drawing.Point(91, 17)
        Me.custID.Name = "custID"
        Me.custID.Size = New System.Drawing.Size(176, 20)
        Me.custID.TabIndex = 0
        '
        'compName
        '
        Me.compName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "company_name", True))
        Me.compName.Location = New System.Drawing.Point(91, 51)
        Me.compName.Name = "compName"
        Me.compName.Size = New System.Drawing.Size(176, 20)
        Me.compName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Company Name"
        '
        'contName
        '
        Me.contName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "contact_name", True))
        Me.contName.Location = New System.Drawing.Point(91, 86)
        Me.contName.Name = "contName"
        Me.contName.Size = New System.Drawing.Size(176, 20)
        Me.contName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contact Name"
        '
        'conTitle
        '
        Me.conTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "contact_title", True))
        Me.conTitle.Location = New System.Drawing.Point(91, 119)
        Me.conTitle.Name = "conTitle"
        Me.conTitle.Size = New System.Drawing.Size(176, 20)
        Me.conTitle.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Contact Title"
        '
        'address
        '
        Me.address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "address", True))
        Me.address.Location = New System.Drawing.Point(91, 151)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(176, 45)
        Me.address.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Address"
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.DarkOrange
        Me.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.AddButton.FlatAppearance.BorderSize = 0
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.ForeColor = System.Drawing.SystemColors.Control
        Me.AddButton.Location = New System.Drawing.Point(79, 319)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(60, 25)
        Me.AddButton.TabIndex = 10
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.DarkRed
        Me.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.ForeColor = System.Drawing.SystemColors.Control
        Me.DeleteButton.Location = New System.Drawing.Point(175, 319)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(60, 25)
        Me.DeleteButton.TabIndex = 11
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Green
        Me.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.UpdateButton.FlatAppearance.BorderSize = 0
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.Control
        Me.UpdateButton.Location = New System.Drawing.Point(272, 319)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(60, 25)
        Me.UpdateButton.TabIndex = 12
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.DarkViolet
        Me.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CancelButton.FlatAppearance.BorderSize = 0
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.ForeColor = System.Drawing.SystemColors.Control
        Me.CancelButton.Location = New System.Drawing.Point(367, 319)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(60, 25)
        Me.CancelButton.TabIndex = 13
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'postalCode
        '
        Me.postalCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "postal_code", True))
        Me.postalCode.Location = New System.Drawing.Point(76, 210)
        Me.postalCode.Name = "postalCode"
        Me.postalCode.Size = New System.Drawing.Size(73, 20)
        Me.postalCode.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Postal Code"
        '
        'city
        '
        Me.city.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "city", True))
        Me.city.Location = New System.Drawing.Point(194, 210)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(73, 20)
        Me.city.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "City"
        '
        'state
        '
        Me.state.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "state", True))
        Me.state.Location = New System.Drawing.Point(76, 241)
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(73, 20)
        Me.state.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "State"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "country", True))
        Me.TextBox1.Location = New System.Drawing.Point(194, 241)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(73, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(152, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Country"
        '
        'phoneNum
        '
        Me.phoneNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "phone_number", True))
        Me.phoneNum.Location = New System.Drawing.Point(91, 272)
        Me.phoneNum.Name = "phoneNum"
        Me.phoneNum.Size = New System.Drawing.Size(176, 20)
        Me.phoneNum.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Phone Number"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(DemoVB.Customer)
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataSource = GetType(DemoVB.Customer)
        '
        'CustomerBindingSource2
        '
        Me.CustomerBindingSource2.DataSource = GetType(DemoVB.Customer)
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        '
        'CompanynameDataGridViewTextBoxColumn
        '
        Me.CompanynameDataGridViewTextBoxColumn.DataPropertyName = "company_name"
        Me.CompanynameDataGridViewTextBoxColumn.HeaderText = "company_name"
        Me.CompanynameDataGridViewTextBoxColumn.Name = "CompanynameDataGridViewTextBoxColumn"
        '
        'ContactnameDataGridViewTextBoxColumn
        '
        Me.ContactnameDataGridViewTextBoxColumn.DataPropertyName = "contact_name"
        Me.ContactnameDataGridViewTextBoxColumn.HeaderText = "contact_name"
        Me.ContactnameDataGridViewTextBoxColumn.Name = "ContactnameDataGridViewTextBoxColumn"
        '
        'ContacttitleDataGridViewTextBoxColumn
        '
        Me.ContacttitleDataGridViewTextBoxColumn.DataPropertyName = "contact_title"
        Me.ContacttitleDataGridViewTextBoxColumn.HeaderText = "contact_title"
        Me.ContacttitleDataGridViewTextBoxColumn.Name = "ContacttitleDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PostalcodeDataGridViewTextBoxColumn
        '
        Me.PostalcodeDataGridViewTextBoxColumn.DataPropertyName = "postal_code"
        Me.PostalcodeDataGridViewTextBoxColumn.HeaderText = "postal_code"
        Me.PostalcodeDataGridViewTextBoxColumn.Name = "PostalcodeDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "state"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "state"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "country"
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        '
        'PhonenumberDataGridViewTextBoxColumn
        '
        Me.PhonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.Name = "PhonenumberDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(500, 350)
        Me.Controls.Add(Me.phoneNum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.postalCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.conTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.contName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.compName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.custID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRUD Entity Framework"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents custID As TextBox
    Friend WithEvents compName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents contName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents conTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents postalCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents city As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents state As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents phoneNum As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerBindingSource1 As BindingSource
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanynameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContacttitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostalcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhonenumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerBindingSource2 As BindingSource
End Class
