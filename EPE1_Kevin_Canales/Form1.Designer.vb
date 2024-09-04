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
        cmbProductos = New ComboBox()
        btnCargar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtDescripcion = New TextBox()
        txtPrecio = New TextBox()
        txtStock = New TextBox()
        SuspendLayout()
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Items.AddRange(New Object() {"Té Dharamsala", "Cerveza tibetana Barley", "Sirope de regaliz", "Especias Cajun del chef Anton", "Mezcla Gumbo del chef Anton", "Mermelada de grosellas de la abuela", "Peras secas orgánicas del tío Bob", "Salsa de arándanos Northwoods", "Buey Mishi Kobe", "Pez espada", "Queso Cabrales", "Queso Manchego La Pastora", "Algas Konbu", "Cuajada de judías", "Salsa de soja baja en sodio", "Postre de merengue Pavlova", "Cordero Alice Springs", "Langostinos tigre Carnarvon", "Pastas de té de chocolate", "Mermelada de Sir Rodney's", "Bollos de Sir Rodney's", "Pan de centeno crujiente estilo Gustaf's", "Pan fino", "Refresco Guaraná Fantástica", "Crema de chocolate y nueces NuNuCa", "Ositos de goma Gumbär", "Chocolate Schoggi", "Col fermentada Rössle", "Salchicha Thüringer", "Arenque blanco del noroeste", "Queso gorgonzola Telino", "Queso Mascarpone Fabioli", "Queso de cabra", "Cerveza Sasquatch", "Cerveza negra Steeleye", "Escabeche de arenque", "Salmón ahumado Gravad", "Vino Côte de Blaye", "Licor verde Chartreuse", "Carne de cangrejo de Boston", "Crema de almejas estilo Nueva Inglaterra", "Tallarines de Singapur", "Café de Malasia", "Azúcar negra Malacca", "Arenque ahumado", "Arenque salado", "Galletas Zaanse", "Chocolate holandés", "Regaliz", "Chocolate blanco", "Manzanas secas Manjimup", "Cereales para Filo", "Empanada de carne", "Empanada de cerdo", "Paté chino", "Gnocchi de la abuela Alicia", "Raviolis Angelo", "Caracoles de Borgoña", "Raclet de queso Courdavault", "Camembert Pierrot", "Sirope de arce", "Tarta de azúcar", "Sandwich de vegetales", "Bollos de pan de Wimmer", "Salsa de pimiento picante de Luisiana", "Especias picantes de Luisiana", "Cerveza Laughing Lumberjack", "Barras de pan de Escocia", "Queso Gudbrandsdals", "Cerveza Outback", "Crema de queso Fløtemys", "Queso Mozzarella Giovanni", "Caviar rojo", "Queso de soja Longlife", "Cerveza Klosterbier Rhönbräu", "Licor Cloudberry", "Salsa verde original Frankfurter"})
        cmbProductos.Location = New Point(259, 127)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(216, 28)
        cmbProductos.TabIndex = 0
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(267, 42)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(177, 29)
        btnCargar.TabIndex = 1
        btnCargar.Text = "Cargar Productos"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(81, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 20)
        Label1.TabIndex = 2
        Label1.Text = "boton  de cargar c.box"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(55, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 20)
        Label2.TabIndex = 3
        Label2.Text = "seleccionar producto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(55, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 20)
        Label3.TabIndex = 4
        Label3.Text = "detalle del producto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(136, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 20)
        Label4.TabIndex = 5
        Label4.Text = "nom producto"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(341, 280)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 20)
        Label5.TabIndex = 6
        Label5.Text = "prec porducto"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(536, 280)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 20)
        Label6.TabIndex = 7
        Label6.Text = "stock producto"
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(99, 323)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.ReadOnly = True
        txtDescripcion.Size = New Size(168, 27)
        txtDescripcion.TabIndex = 8
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(303, 323)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.ReadOnly = True
        txtPrecio.Size = New Size(172, 27)
        txtPrecio.TabIndex = 9
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(508, 323)
        txtStock.Name = "txtStock"
        txtStock.ReadOnly = True
        txtStock.Size = New Size(166, 27)
        txtStock.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtStock)
        Controls.Add(txtPrecio)
        Controls.Add(txtDescripcion)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCargar)
        Controls.Add(cmbProductos)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtStock As TextBox

End Class
