Public Class Form1

    Public Function ValidarCampos(Formulario As Form) As Boolean
        Dim valCampo As Boolean = True
        For Each control In Formulario.Controls
            If TypeOf control Is TextBox Then
                If String.IsNullOrWhiteSpace(control.text) Then
                    valCampo = False
                    Exit For
                End If
            End If
            If TypeOf control Is ComboBox Then
                If String.IsNullOrWhiteSpace(control.text) Then
                    valCampo = False
                    Exit For
                End If
            End If

            If TypeOf control Is CheckBox Then
                If String.IsNullOrWhiteSpace(control.text) Then
                    valCampo = False
                    Exit For
                End If
            End If

        Next
        Return valCampo
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not ValidarCampos(Me) Then

            MsgBox("No debe dejar ningun campo vacio")
        Else
            MsgBox("Su registro se realizo con exito")

        End If

        If Me.check_terminos.Checked = False Then
            MsgBox("Debe aceptar terminos y condiciones")

        End If

    End Sub
End Class
