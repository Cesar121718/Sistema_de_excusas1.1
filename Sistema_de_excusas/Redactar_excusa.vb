Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Redactar_excusa
    Dim conexion1 As SqlConnection
    Dim comando As SqlCommand
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Dim conexion As String
            conexion = "Data Source=DESKTOP-RJC2LNS\SQLEXPRESS;Initial Catalog=BDExcusas;Integrated Security=True"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion

            Dim adaptador As New SqlCommand("insert into Excusas values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("SUS DATOS HAN SIDO GURDADOS", vbInformation,)

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
        Else
            MsgBox("SU EXCUSA NO SE NO SE GUARDO", vbCritical,)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dt As New DataTable
        Dim con As New SqlConnection("server=DESKTOP-RJC2LNS\SQLEXPRESS; database=BDExcusas;integrated security=true")
        Dim consulta As String = "SELECT * FROM Alumnos WHERE Alumno = '" & TextBox1.Text & "' "
        Dim comando As New SqlCommand(consulta, con)

        Dim drd As SqlDataReader
        con.Open()
        drd = comando.ExecuteReader
        If drd.Read Then
            Me.TextBox2.Text = drd.Item("Grado").ToString
            Me.TextBox3.Text = drd.Item("Seccion").ToString
            Me.TextBox4.Text = drd.Item("Identidad").ToString
        Else
            MsgBox("No se ha encontrado el Alumno")
        End If
        drd.Close()
        drd.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menuvb.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button4_Click_2(sender As Object, e As EventArgs)
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim conuslta As String = " delete from [BDExcusas].[dbo].[Excusas] where Alumno = '" & TextBox1.Text & "'"

        Dim cant As Integer
        Try
            conexion.Open()
            comando = New SqlCommand(conuslta, conexion)

            cant = comando.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conexion.Close()
        End Try

        'aqui

        If cant = 1 Then

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""




            MessageBox.Show("EL registro se elimino de manera correcta")

        Else
            MessageBox.Show("No se encontro ningun registro")
        End If
        conexion.Close()
    End Sub
End Class