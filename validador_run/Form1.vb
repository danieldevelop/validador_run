Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRun.MaxLength = 8
        txtDV.MaxLength = 1
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim run As String = txtRun.Text
        Dim digito As String = txtDV.Text.ToUpper()

        '' Para que funcione estas variables, deben estar dentro de la funcion
        Dim contarDeUno As Integer
        Dim contador As Integer = 2
        Dim acumulador As Integer
        Dim division As Integer
        Dim dig As Integer
        Dim dig2 As String

        If (run <> "" And digito <> "") Then
            Do While (run <> 0)
                contarDeUno = (run Mod 10) * contador
                acumulador += contarDeUno
                run \= 10
                contador += 1

                If (contador = 8) Then
                    contador = 2
                End If
            Loop

            division = acumulador Mod 11
            If (division = 0) Then
                division = 11
            End If
            dig = 11 - division
            dig2 = CStr(dig)

            If (dig2 = 10) Then
                dig2 = "K"
            End If

            If (dig2 = digito) Then
                MessageBox.Show("El RUN/DNI ingresado es correcto", "Validador RUN - Visual Studio 2019", MessageBoxButtons.OK)
            Else
                MessageBox.Show("E: El RUN/DNI ingresado no es valido", "Validador RUN - Visual Studio 2019", MessageBoxButtons.OK)
            End If


        Else
            MessageBox.Show("E: Los campos no pueden estar vacio", "Validador RUN - Visual Studio 2019", MessageBoxButtons.OK)
        End If
    End Sub
End Class
