Imports System.Data.SqlClient

Public Class Ver_excusas
    Dim a, b As Graphics
    Dim bmp As Bitmap
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Menuvb.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = False
        Label2.Visible = False
        Label4.Visible = False
        Button2.Visible = False
        Button1.Visible = False
        btnImprimir.Visible = False
        a = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, a)
        b = Graphics.FromImage(bmp)
        b.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        PrintpreviewDialog1.ShowDialog()
        Label1.Visible = True
        Label2.Visible = True
        Label4.Visible = True
        Button2.Visible = True
        Button1.Visible = True
        btnImprimir.Visible = True
    End Sub

    Private Sub ExcusasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ExcusasBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.BDExcusasDataSet)

    End Sub

    Private Sub Ver_excusas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'BDExcusasDataSet.Excusas' Puede moverla o quitarla según sea necesario.



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dt As New DataTable
        Dim con As New SqlConnection("server=DESKTOP-RJC2LNS\SQLEXPRESS; database=BDExcusas;integrated security=true")
        Dim consulta As String = "SELECT * FROM Excusas WHERE Alumno = '" & AlumnoTextBox.Text & "' "
        Dim comando As New SqlCommand(consulta, con)

        Dim drd As SqlDataReader
        con.Open()
        drd = comando.ExecuteReader
        If drd.Read Then
            Me.CursoTextBox.Text = drd.Item("curso").ToString
            Me.SeccionTextBox.Text = drd.Item("Seccion").ToString
            Me.IdentidadTextBox.Text = drd.Item("Identidad").ToString
            Me.EncargadoTextBox.Text = drd.Item("Encargado").ToString
            Me.MotivoTextBox.Text = drd.Item("Motivo").ToString

        Else
            MsgBox("No se ha encontrado el Alumno")
        End If
        drd.Close()
        drd.Close()
    End Sub

    Private Sub PrintPreviewDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub
End Class