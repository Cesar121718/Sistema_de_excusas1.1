Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Dim usuario As String
    Dim contra As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        usuario = TextBox1.Text
        contra = TextBox2.Text

        If usuario = "UnionExcusas" And contra = "UN10N" Then
            Menuvb.show
            Me.Hide()
        Else
            MsgBox("El Usuario o Contraseña es incorrecto", vbCritical,)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ver.Click
        ver.Visible = False
        ocultar.Visible = True
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub ocultar_Click(sender As Object, e As EventArgs) Handles ocultar.Click
        ver.Visible = True
        ocultar.Visible = False
        TextBox2.UseSystemPasswordChar = False

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
