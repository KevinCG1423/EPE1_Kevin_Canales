Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Public Class Form1
    Private productosTable As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el formulario para que no se pueda cambiar de tamaño
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        ' Inicializar el ComboBox vacío
        cmbProductos.DataSource = Nothing
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim filePath As String = "C:\Users\kevin\Downloads\Lista.xls"

            If Not IO.File.Exists(filePath) Then
                MessageBox.Show("El archivo Lista.xls no se encuentra en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Inicializar Excel Interop
            Dim excelApp As Application = New Application()
            Dim workbooks As Workbooks = excelApp.Workbooks
            Dim workbook As Workbook = workbooks.Open(filePath)
            Dim worksheet As Worksheet = workbook.Sheets(1)
            Dim range As Range = worksheet.UsedRange

            ' Inicializar productosTable
            productosTable = New DataTable()

            ' Crear columnas
            productosTable.Columns.Add("Nombre")
            productosTable.Columns.Add("Descripcion")
            productosTable.Columns.Add("Precio")
            productosTable.Columns.Add("Stock")

            ' Leer filas
            Dim rowCount As Integer = range.Rows.Count

            If rowCount < 2 Then
                MessageBox.Show("El archivo Excel no contiene suficientes datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Cleanup(excelApp, workbook)
                Return
            End If

            For row As Integer = 2 To rowCount
                Dim nombre As String = CType(range.Cells(row, 1).Value, String)
                Dim descripcion As String = CType(range.Cells(row, 2).Value, String)
                Dim precio As String = CType(range.Cells(row, 3).Value, String)
                Dim stock As String = CType(range.Cells(row, 4).Value, String)

                ' Verificar si los datos son válidos antes de agregar
                If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(descripcion) OrElse String.IsNullOrEmpty(precio) OrElse String.IsNullOrEmpty(stock) Then
                    Continue For ' Saltar filas incompletas
                End If

                productosTable.Rows.Add(nombre, descripcion, precio, stock)
            Next

            ' Cerrar el libro de trabajo y liberar recursos
            Cleanup(excelApp, workbook)

            ' Verificar si productosTable tiene datos
            If productosTable.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron datos en el archivo Excel.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ' Llenar ComboBox
            cmbProductos.DataSource = productosTable
            cmbProductos.DisplayMember = "Nombre"
            cmbProductos.ValueMember = "Nombre"

            ' Deshabilitar el botón después de cargar
            btnCargar.Enabled = False

            ' Mensaje de éxito
            MessageBox.Show($"Datos cargados exitosamente. Total de productos: {productosTable.Rows.Count}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        If productosTable Is Nothing OrElse productosTable.Rows.Count = 0 Then
            MessageBox.Show("Los datos del producto no están cargados correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cmbProductos.SelectedIndex >= 0 AndAlso cmbProductos.SelectedIndex < productosTable.Rows.Count Then
            ' Obtener la fila seleccionada usando el índice del ComboBox
            Dim selectedRow As DataRow = productosTable.Rows(cmbProductos.SelectedIndex)
            txtDescripcion.Text = selectedRow("Descripcion").ToString()
            txtPrecio.Text = selectedRow("Precio").ToString()
            txtStock.Text = selectedRow("Stock").ToString()
        Else
            ' Limpiar los campos si no hay selección válida
            txtDescripcion.Clear()
            txtPrecio.Clear()
            txtStock.Clear()
        End If
    End Sub

    Private Sub Cleanup(excelApp As Application, workbook As Workbook)
        ' Cerrar el libro y liberar recursos
        workbook.Close(False)
        Marshal.ReleaseComObject(workbook)
        excelApp.Quit()
        Marshal.ReleaseComObject(excelApp)
    End Sub
End Class
