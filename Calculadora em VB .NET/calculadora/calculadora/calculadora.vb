Public Class calculadora


    Dim v1 As Double
    Dim v2 As Double
    Dim total As Double
    Dim operacao As String

    'resultado.Text = (CInt(TextBox1.Text) + CInt(TextBox2.Text)).ToString

    Private Sub bot1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot1.Click

        Dim texto As String = (resultado.Text).ToString
        texto = texto + CStr(1)
        resultado.Text = texto

    End Sub

    Private Sub bot2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot2.Click

        Dim texto As String = (resultado.Text).ToString
        texto = texto + CStr(2)
        resultado.Text = texto

    End Sub

    Private Sub bot3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot3.Click

        Dim texto As String = (resultado.Text).ToString
        texto = texto + CStr(3)
        resultado.Text = texto

    End Sub

    Private Sub bot4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot4.Click

        Dim texto As String = (resultado.Text).ToString

        texto = texto + CStr(4)
        resultado.Text = texto

    End Sub

    Private Sub bot5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot5.Click

        Dim texto As String = (resultado.Text).ToString
        texto = texto + CStr(5)
        resultado.Text = texto

    End Sub

    Private Sub bot6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot6.Click

        Dim texto As String = (resultado.Text).ToString
        texto = texto + CStr(6)
        resultado.Text = texto

    End Sub

    Private Sub bot7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot7.Click

        Dim texto As String = (resultado.Text).ToString
        texto = texto + CStr(7)
        resultado.Text = texto

    End Sub

    Private Sub bot8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot8.Click

        Dim texto As String = (resultado.Text).ToString
        texto = texto + CStr(8)
        resultado.Text = texto

    End Sub

    Private Sub bot9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot9.Click

        Dim texto As String = (resultado.Text).ToString
        texto = texto + CStr(9)
        resultado.Text = texto

    End Sub

    Private Sub bot0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot0.Click

        Dim texto As String = (resultado.Text).ToString
        texto = texto + CStr(0)
        resultado.Text = texto

    End Sub
    Private Sub ponto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ponto.Click

        Dim texto As String = (resultado.Text).ToString
        ' Text = texto + CStr(.)
        resultado.Text = texto
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click

        resultado.Clear()

    End Sub

    Private Sub Btosoma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btosoma.Click

        v1 = resultado.Text
        resultado.Clear()
        operacao = "soma"

    End Sub

    Private Sub Btosubtracao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btosubtracao.Click

        v1 = resultado.Text
        resultado.Clear()
        operacao = "subtracao"

    End Sub

    Private Sub Btodivisao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btodivisao.Click

        v1 = resultado.Text
        resultado.Clear()
        operacao = "divisao"

    End Sub

    Private Sub Btomultiplicacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btomultiplicacao.Click

        v1 = resultado.Text
        resultado.Clear()
        operacao = "multiplicacao"

    End Sub

    Private Sub Btoigual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btoigual.Click

        If (operacao = "soma") Then
            v2 = resultado.Text
            total = v1 + v2
            resultado.Text = CStr(total) ' converte o valor int para string para ser exibido
        ElseIf (operacao = "subtracao") Then
            v2 = resultado.Text
            total = v1 - v2
            resultado.Text = CStr(total) ' converte o valor int para string para ser exibido
        ElseIf (operacao = "multiplicacao") Then
            v2 = resultado.Text
            total = v1 * v2
            resultado.Text = CStr(total)  ' converte o valor int para string para ser exibido
        ElseIf (operacao = "divisao") Then
            v2 = resultado.Text
            total = v1 / v2
            resultado.Text = CStr(total) ' converte o valor int para string para ser exibido
        End If

    End Sub
  
End Class
