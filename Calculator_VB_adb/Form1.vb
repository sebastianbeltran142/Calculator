Public Class Form1
    Private memoria1 As Double = 0.0
    Private memoria2 As Double = 0.0
    Private signo As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        pantalla.Text = pantalla.Text & "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pantalla.Text = pantalla.Text & "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pantalla.Text = pantalla.Text & "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pantalla.Text = pantalla.Text & "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pantalla.Text = pantalla.Text & "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pantalla.Text = pantalla.Text & "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        pantalla.Text = pantalla.Text & "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        pantalla.Text = pantalla.Text & "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        pantalla.Text = pantalla.Text & "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        pantalla.Text = pantalla.Text & "9"
    End Sub

    Private Sub mas_Click(sender As Object, e As EventArgs) Handles mas.Click
        Try
            If pantalla.Text <> "" Then
                memoria1 = Val(pantalla.Text)
                signo = "+"
                pantalla.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Try
            If pantalla.Text <> "" Then
                memoria1 = Val(pantalla.Text)
                signo = "-"
                pantalla.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub multiplicar_Click(sender As Object, e As EventArgs) Handles multiplicar.Click
        Try
            If pantalla.Text <> "" Then
                memoria1 = Val(pantalla.Text)
                signo = "*"
                pantalla.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        Try
            If pantalla.Text <> "" Then
                memoria1 = Val(pantalla.Text)
                signo = "/"
                pantalla.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub square_Click(sender As Object, e As EventArgs) Handles square.Click
        Try
            If pantalla.Text <> "" Then
                memoria1 = Val(pantalla.Text)
                signo = "raiz"
                pantalla.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub potencia_Click(sender As Object, e As EventArgs) Handles potencia.Click
        Try
            If pantalla.Text <> "" Then
                memoria1 = Val(pantalla.Text)
                signo = "exponente"
                pantalla.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub porcent_Click(sender As Object, e As EventArgs) Handles porcent.Click
        Try
            If pantalla.Text <> "" Then
                memoria1 = Val(pantalla.Text)
                signo = "%"
                pantalla.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CE_Click(sender As Object, e As EventArgs) Handles CE.Click
        pantalla.Clear()
        memoria1 = 0.0
        memoria2 = 0.0
        signo = String.Empty
    End Sub

    Private Sub flecha_rigth_Click(sender As Object, e As EventArgs) Handles flecha_rigth.Click
        Try
            Dim largo As Integer
            largo = pantalla.Text.Length
            pantalla.Text = Mid(pantalla.Text, 1, largo - 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mas_minus_Click(sender As Object, e As EventArgs) Handles mas_minus.Click
        Try
            If pantalla.Text <> "" Then
                pantalla.Text = pantalla.Text * (-1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub uno_equis_Click(sender As Object, e As EventArgs) Handles uno_equis.Click
        Try
            If pantalla.Text <> "" Then
                pantalla.Text = 1 / pantalla.Text
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub point_Click(sender As Object, e As EventArgs) Handles point.Click
        If pantalla.Text = "" Then
            pantalla.Text = "0."
        ElseIf punto(pantalla.Text) = False Then
            pantalla.Text = pantalla.Text & "."
        End If
    End Sub

    Private Function punto(ByVal cadena As String) As Boolean
        Dim largo As Integer
        Dim respuesta As Boolean = False
        largo = cadena.Length
        For i As Integer = 1 To largo Step 1
            If Mid(cadena, i, 1) = "." Then
                respuesta = True

            End If
        Next
        Return respuesta
    End Function

    Private Sub igual_Click(sender As Object, e As EventArgs) Handles igual.Click
        Try
            If pantalla.Text <> "" And memoria1 <> 0.0 Then
                memoria2 = pantalla.Text
                Calculator_VB_adb()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Calculator_VB_adb()
        Select Case signo
            Case "+"
                pantalla.Text = memoria1 + memoria2
            Case "-"
                pantalla.Text = memoria1 - memoria2
            Case "*"
                pantalla.Text = memoria1 * memoria2
            Case "/"
                pantalla.Text = memoria1 / memoria2
            Case "raiz"
                pantalla.Text = memoria2 ^ (1 / memoria1)
            Case "exponente"
                pantalla.Text = memoria1 ^ memoria2
            Case "%"
                pantalla.Text = memoria1 * memoria2 / 100
            Case Else
                MsgBox("Error")
                End Select
    End Sub
End Class
