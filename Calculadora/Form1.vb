
Public Class Form1
    Dim contador As Integer = 0
    Dim valor1 As Double
        Dim valor2 As Double
        Dim Resu As Double
        Dim symbol As String
        Dim view As String
        Dim comaComp As Boolean = False
    Dim positComp As Boolean = False
    Dim operadorPendiente As String = Nothing
    Dim pulsoOperador As Boolean = Nothing
    Dim comparadorSigno As String

    'Aquí van todos los eventos del teclado
    Private Sub ListBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

            ' Si se pulsa un numero se inserta
            If e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.D1 Then
                Agregar("1")
            End If

            If e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D2 Then
                Agregar("2")
            End If

            If e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.D3 Then
                Agregar("3")
            End If

            If e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.D4 Then
                Agregar("4")
            End If

            If e.KeyCode = Keys.NumPad5 Or e.KeyCode = Keys.D5 Then
                Agregar("5")
            End If

            If e.KeyCode = Keys.NumPad6 Or e.KeyCode = Keys.D6 Then
                Agregar("6")
            End If

            If e.KeyCode = Keys.NumPad7 Or e.KeyCode = Keys.D7 Then
                Agregar("7")
            End If

            If e.KeyCode = Keys.NumPad8 Or e.KeyCode = Keys.D8 Then
                Agregar("8")
            End If

            If e.KeyCode = Keys.NumPad9 Or e.KeyCode = Keys.D9 Then
                Agregar("9")
            End If
            If e.KeyData = (Keys.Shift + Keys.D0) Then

                ButtonEqual.Select()
                accionEqual()

            Else
                If e.KeyCode = Keys.NumPad0 Or e.KeyCode = Keys.D0 Then
                    Agregar("0")
                End If
            End If



        'Teclas de operadores
        If e.KeyCode = Keys.Divide Then
            accion("divi", "/")
        End If

            If e.KeyCode = Keys.Multiply Then
            accion("multi", "*")
        End If

            If e.KeyCode = Keys.Subtract Then
            accion("resta", "-")
        End If

            If e.KeyCode = Keys.Add Then
            accion("suma", "+")
        End If

        If e.KeyCode = Keys.Delete Then
            accionAC()
        End If

        If e.KeyCode = Keys.Delete Then
                accionAC()
            End If

        If e.KeyCode = Keys.Decimal Then
            Buttoncoma.PerformClick()
        End If
        If e.KeyCode = Keys.Return Then
            ButtonEqual.Select()
            accionEqual()

        End If

        If e.KeyCode = Keys.Back Then
            accionRetroceso()
        End If

    End Sub



        '**************************************************************************
        ' Eventos de clic del raton
        '**************************************************************************

        Private Sub Num1_Click(sender As Object, e As EventArgs) Handles Num1.Click
            Agregar("1")
        End Sub

        Private Sub Num2_Click(sender As Object, e As EventArgs) Handles Num2.Click
            Agregar("2")
        End Sub

        Private Sub Num3_Click(sender As Object, e As EventArgs) Handles Num3.Click
            Agregar("3")
        End Sub
        Private Sub Num4_Click(sender As Object, e As EventArgs) Handles Num4.Click
            Agregar("4")
        End Sub
        Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click
            Agregar("5")
        End Sub
        Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click
            Agregar("6")
        End Sub
        Private Sub Num7_Click(sender As Object, e As EventArgs) Handles Num7.Click
            Agregar("7")
        End Sub
        Private Sub Num8_Click(sender As Object, e As EventArgs) Handles Num8.Click
            Agregar("8")
        End Sub
        Private Sub Num9_Click(sender As Object, e As EventArgs) Handles Num9.Click
            Agregar("9")
        End Sub
        Private Sub Num0_Click(sender As Object, e As EventArgs) Handles Num0.Click
            Agregar("0")
        End Sub

        Private Sub ButtonAC_Click(sender As Object, e As EventArgs) Handles ButtonAC.Click
            accionAC()
        End Sub

        Private Sub Buttonmas_Click(sender As Object, e As EventArgs) Handles Buttonmas.Click
        accion("suma", "+")
    End Sub

    Private Sub ButtonMen_Click(sender As Object, e As EventArgs) Handles ButtonMen.Click
        accion("resta", "-")
    End Sub

    Private Sub ButtonMult_Click(sender As Object, e As EventArgs) Handles ButtonMult.Click
        accion("multi", "*")
    End Sub

        Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        accion("divi", "/")
    End Sub

        Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        accionEqual()

    End Sub

    Private Sub Buttoncoma_Click(sender As Object, e As EventArgs) Handles Buttoncoma.Click
        accionComa()
    End Sub



    '*************************************************

    'Declaración de acciones

    '*************************************************

    Private Sub accionAC()
            valor1 = Nothing
            valor2 = Nothing
        inputCalc.Text() = "0"
        oper.Text() = ""
            view = ""
            operadorPendiente = ""
        contador = 0
        comaComp = False
        positComp = False
    End Sub

    Private Sub accion(v1 As String, v2 As String)
        comaComp = False
        If v1 IsNot "" And comparadorSigno IsNot v1 And oper.Text IsNot "" Then

            view = view.Remove(oper.Text.Length - 2)
            view = view & v2 & " "
            operadorPendiente = ""
            operar(v1)
            symbol = v2
            oper.Text = view
        End If

        If contador = 0 Then
            If (inputCalc.Text IsNot "") Then

                view = view & inputCalc.Text & " " & v2 & " "
                operar(v1)
                inputCalc.Text = ""
                symbol = v2
                oper.Text = view
                contador = 1
                If valor1 = Nothing Then
                    valor1 = valor2
                    inputCalc.Text = valor2
                Else
                    inputCalc.Text = valor1
                End If
            Else
                contador = 0
            End If
        End If
        comparadorSigno = v1
    End Sub


    Private Sub accionComa()
        If (comaComp = False) Then
            If (inputCalc.Text = "") Then
                inputCalc.Text() = inputCalc.Text() & "0,"
                comaComp = True
            Else
                inputCalc.Text() = inputCalc.Text() & ","
                comaComp = True
            End If
        End If
    End Sub


    Private Sub accionEqual()

        If (inputCalc.Text IsNot "") Then

            valor2 = inputCalc.Text()
            If (operadorPendiente = "suma") Then
                valor1 = valor1 + valor2
            End If
            If (operadorPendiente = "resta") Then
                valor1 = valor1 - valor2
            End If
            If (operadorPendiente = "multi") Then
                valor1 = valor1 * valor2
            End If
            If (operadorPendiente = "divi") Then
                valor1 = valor1 / valor2
            End If
            operadorPendiente = ""
            inputCalc.Text() = valor1
            view = ""
            oper.Text() = ""
            End If

    End Sub
    Private Sub accionRetroceso()
        If inputCalc.Text IsNot "" Then
            oper.Text() = oper.Text.Remove(oper.Text.Length - 1)
            inputCalc.Text = inputCalc.Text.Remove(inputCalc.Text.Length - 1)
        End If
    End Sub

    Function operar(operador As String) As Double

            valor2 = inputCalc.Text
            pulsoOperador = True
            Select Case operadorPendiente
                Case "suma"
                    valor1 = valor1 + valor2
                Case "resta"
                    valor1 = valor1 - valor2
                Case "multi"
                    valor1 = valor1 * valor2
                Case "divi"
                    valor1 = valor1 / valor2
                Case "1ª"
                    valor1 = valor2
            End Select
            operadorPendiente = operador

        End Function

    Private Sub Agregar(numero As String)
        If pulsoOperador Then
            inputCalc.Text = ""
            pulsoOperador = False
        End If
        'Si la cadena empieza por 0,
        If InStr(1, inputCalc.Text, "0,") Then
            inputCalc.Text() = inputCalc.Text() & numero

            'Si la cadena empieza por 0
        ElseIf MID(inputCalc.Text, 1, 1) = "0" Then
            inputCalc.Text = ""
            inputCalc.Text() = inputCalc.Text() & numero
        Else
            inputCalc.Text() = inputCalc.Text() & numero
        End If

        contador = 0
        ButtonEqual.Select()
    End Sub

    Private Sub negativ_Click(sender As Object, e As EventArgs) Handles negativ.Click
        If (positComp = False) Then
            inputCalc.Text() = "-" & inputCalc.Text()

            positComp = True
        Else
            inputCalc.Text() = inputCalc.Text().TrimStart("-")
            view = view
            oper.Text = oper.Text.TrimStart("-")
            positComp = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operadorPendiente = "1ª"
        inputCalc.Text = "0"
    End Sub
    End Class
