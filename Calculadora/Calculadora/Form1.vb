Public Class Form1

    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean

    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(txtResultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            txtResultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            txtResultado.Text = ""
            SePresionaOperador = False
        ElseIf txtResultado.Text = "0" Then
            txtResultado.Text = ""
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "1"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "9"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "6"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "3"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "2"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "5"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "4"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "8"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "0"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtResultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        EvaluayHazOperacion()
        Operacion = ""
    End Sub
End Class
