Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Listado_alumnos
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cheque As Char
        Dim valor As Char
        If A.Checked = True Then
            cheque = Label10.Text
        ElseIf CheckBox2.Checked = True Then
            cheque = Label11.Text
        Else
            cheque = Label12.Text

        End If

        If CheckBox1.Checked = True Then
            valor = Label13.Text
        Else
            valor = Label14.Text

        End If

        conexion.Open()
        Dim consulta As String = " insert into [BDExcusas].[dbo].[Alumnos] (Identidad, Alumno, Grado, Seccion,Sexo) values('" & TextBox3.Text & "','" & TextBox2.Text & "',' " & TextBox1.Text & " ',' " & cheque & " ',' " & valor & " ')"
        comando = New SqlCommand(consulta, conexion)
        'comando.Parameters.AddWithValue("@Seccion", CheckBox1.text)
        comando.ExecuteNonQuery()
        MessageBox.Show("los datos han ingresado correctamente")
        conexion.Close()
    End Sub

    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDExcusasDataSet1)

    End Sub

    Private Sub Listado_alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        conexion = New SqlConnection("server=DESKTOP-RJC2LNS\SQLEXPRESS; database=BDExcusas;integrated security=true")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conuslta As String = " delete from [BDExcusas].[dbo].[Alumnos] where Alumno= '" & TextBox2.Text & "'"

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



        If cant = 1 Then

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            A.Text = ""
            CheckBox1.Text = ""
            CheckBox2.Text = ""
            CheckBox3.Text = ""
            CheckBox4.Text = ""


            MessageBox.Show("EL registro se elimino de manera correcta")

        Else
            MessageBox.Show("No se encontro ningun registro")
        End If
        conexion.Close()



    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Menuvb.Show()
        Me.Hide()

    End Sub

    Private Sub AlumnosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDExcusasDataSet1)

    End Sub
End Class