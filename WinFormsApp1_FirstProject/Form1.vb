Public Class Form1
    Dim valor1 As Integer = 0
    Dim valor2 As Integer = 0
    Dim valor3 As Double = 0
    Dim msg As String

    'Nuestra funcion
    Private Function Validacion() As Boolean
        If IsNumeric(TextBox1.Text) Then
            valor1 = TextBox1.Text
        Else
            MsgBox("Debe ingresar un valor numerico en el campo 1", vbExclamation, "Error")
            Return False
        End If

        If IsNumeric(TextBox2.Text) Then
            valor2 = TextBox2.Text
        Else
            MsgBox("Debe ingresar un valor numerico en el campo 2")
            Return False
        End If

        Return True
    End Function

    Private Sub Resultado()
        msg = "El resultado es: "
        msg = msg & valor3 & " (" & valor1 & "+" & valor2 & ")"

        MsgBox(msg, vbExclamation, "Mensaje")
    End Sub

    Private Sub Resultado2(ByVal Operacion As String)
        TextBox3_Total.Text = valor3
        'Llamamos a Data DataGrid
        DataGrid(Operacion, valor3)
    End Sub

    Private Sub DataGrid(ByVal Operacion As String, ByVal ResultadoDG As Double)

        DGV1.Rows.Add()
        Dim celda As Integer = DGV1.RowCount - 1 'Se coloca en la posicion 0

        DGV1.Rows(celda).Cells(0).Value = Operacion
        DGV1.Rows(celda).Cells(1).Value = ResultadoDG

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Presionar.Click
        '/* Forma más simple  de hacer las operaciones, pero podemos sustituir por una funcion 

        If IsNumeric(TextBox1.Text) Then
            valor1 = TextBox1.Text
        Else
            MsgBox("Debe ingresar un valor numerico en el campo 1")
            Exit Sub
        End If

        If IsNumeric(TextBox2.Text) Then
            valor2 = TextBox2.Text
        Else
            MsgBox("Debe ingresar un valor numerico en el campo 2")
            Exit Sub
        End If
        '*/
        valor3 = valor1 * valor2

        msg = "El resultado es: "
        msg = msg & valor3 & " (" & valor1 & "*" & valor2 & ")"

        'Nuestra ventana de salida mensaje/tipo de ventana/nombre de la ventana
        MsgBox(msg, vbExclamation, "Mensaje")

    End Sub

    Private Sub suma_Click(sender As Object, e As EventArgs) Handles suma.Click

        If Validacion() = False Then Exit Sub
        valor3 = valor1 + valor2
        Resultado()
    End Sub

    Private Sub resta_Click(sender As Object, e As EventArgs) Handles resta.Click

        If Validacion() = False Then Exit Sub
        valor3 = valor1 - valor2
        Resultado()
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click

        If Validacion() = False Then Exit Sub
        valor3 = valor1 / valor2
        Resultado2("multiplicacion")
    End Sub

    Private Sub multiplicacion_Click(sender As Object, e As EventArgs) Handles multiplicacion.Click

        If Validacion() = False Then Exit Sub
        valor3 = valor1 * valor2
        Resultado2("division")
    End Sub
End Class
