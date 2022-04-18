<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculadora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calculadora))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.bot1 = New System.Windows.Forms.Button()
        Me.bot4 = New System.Windows.Forms.Button()
        Me.bot7 = New System.Windows.Forms.Button()
        Me.bot2 = New System.Windows.Forms.Button()
        Me.bot5 = New System.Windows.Forms.Button()
        Me.bot8 = New System.Windows.Forms.Button()
        Me.bot9 = New System.Windows.Forms.Button()
        Me.bot6 = New System.Windows.Forms.Button()
        Me.bot3 = New System.Windows.Forms.Button()
        Me.bot0 = New System.Windows.Forms.Button()
        Me.Btosoma = New System.Windows.Forms.Button()
        Me.Btosubtracao = New System.Windows.Forms.Button()
        Me.Btodivisao = New System.Windows.Forms.Button()
        Me.Btomultiplicacao = New System.Windows.Forms.Button()
        Me.Btoigual = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.ponto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        '
        'resultado
        '
        Me.resultado.Location = New System.Drawing.Point(47, 31)
        Me.resultado.Margin = New System.Windows.Forms.Padding(4)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(234, 22)
        Me.resultado.TabIndex = 5
        '
        'bot1
        '
        Me.bot1.BackColor = System.Drawing.SystemColors.Control
        Me.bot1.Location = New System.Drawing.Point(41, 143)
        Me.bot1.Name = "bot1"
        Me.bot1.Size = New System.Drawing.Size(75, 23)
        Me.bot1.TabIndex = 7
        Me.bot1.Text = "1"
        Me.bot1.UseVisualStyleBackColor = False
        '
        'bot4
        '
        Me.bot4.BackColor = System.Drawing.SystemColors.Control
        Me.bot4.Location = New System.Drawing.Point(41, 114)
        Me.bot4.Name = "bot4"
        Me.bot4.Size = New System.Drawing.Size(75, 23)
        Me.bot4.TabIndex = 8
        Me.bot4.Text = "4"
        Me.bot4.UseVisualStyleBackColor = False
        '
        'bot7
        '
        Me.bot7.BackColor = System.Drawing.SystemColors.Control
        Me.bot7.Location = New System.Drawing.Point(41, 85)
        Me.bot7.Name = "bot7"
        Me.bot7.Size = New System.Drawing.Size(75, 23)
        Me.bot7.TabIndex = 9
        Me.bot7.Text = "7"
        Me.bot7.UseVisualStyleBackColor = False
        '
        'bot2
        '
        Me.bot2.BackColor = System.Drawing.SystemColors.Control
        Me.bot2.Location = New System.Drawing.Point(122, 143)
        Me.bot2.Name = "bot2"
        Me.bot2.Size = New System.Drawing.Size(75, 23)
        Me.bot2.TabIndex = 10
        Me.bot2.Text = "2"
        Me.bot2.UseVisualStyleBackColor = False
        '
        'bot5
        '
        Me.bot5.BackColor = System.Drawing.SystemColors.Control
        Me.bot5.Location = New System.Drawing.Point(123, 114)
        Me.bot5.Name = "bot5"
        Me.bot5.Size = New System.Drawing.Size(75, 23)
        Me.bot5.TabIndex = 11
        Me.bot5.Text = "5"
        Me.bot5.UseVisualStyleBackColor = False
        '
        'bot8
        '
        Me.bot8.BackColor = System.Drawing.SystemColors.Control
        Me.bot8.Location = New System.Drawing.Point(122, 85)
        Me.bot8.Name = "bot8"
        Me.bot8.Size = New System.Drawing.Size(75, 23)
        Me.bot8.TabIndex = 12
        Me.bot8.Text = "8"
        Me.bot8.UseVisualStyleBackColor = False
        '
        'bot9
        '
        Me.bot9.BackColor = System.Drawing.SystemColors.Control
        Me.bot9.Location = New System.Drawing.Point(203, 85)
        Me.bot9.Name = "bot9"
        Me.bot9.Size = New System.Drawing.Size(75, 23)
        Me.bot9.TabIndex = 13
        Me.bot9.Text = "9"
        Me.bot9.UseVisualStyleBackColor = False
        '
        'bot6
        '
        Me.bot6.BackColor = System.Drawing.SystemColors.Control
        Me.bot6.Location = New System.Drawing.Point(204, 114)
        Me.bot6.Name = "bot6"
        Me.bot6.Size = New System.Drawing.Size(75, 23)
        Me.bot6.TabIndex = 14
        Me.bot6.Text = "6"
        Me.bot6.UseVisualStyleBackColor = False
        '
        'bot3
        '
        Me.bot3.BackColor = System.Drawing.SystemColors.Control
        Me.bot3.Location = New System.Drawing.Point(204, 143)
        Me.bot3.Name = "bot3"
        Me.bot3.Size = New System.Drawing.Size(75, 23)
        Me.bot3.TabIndex = 15
        Me.bot3.Text = "3"
        Me.bot3.UseVisualStyleBackColor = False
        '
        'bot0
        '
        Me.bot0.BackColor = System.Drawing.SystemColors.Control
        Me.bot0.Location = New System.Drawing.Point(122, 172)
        Me.bot0.Name = "bot0"
        Me.bot0.Size = New System.Drawing.Size(75, 23)
        Me.bot0.TabIndex = 16
        Me.bot0.Text = "0"
        Me.bot0.UseVisualStyleBackColor = False
        '
        'Btosoma
        '
        Me.Btosoma.BackColor = System.Drawing.SystemColors.Control
        Me.Btosoma.Location = New System.Drawing.Point(298, 85)
        Me.Btosoma.Name = "Btosoma"
        Me.Btosoma.Size = New System.Drawing.Size(45, 23)
        Me.Btosoma.TabIndex = 17
        Me.Btosoma.Text = "+"
        Me.Btosoma.UseVisualStyleBackColor = False
        '
        'Btosubtracao
        '
        Me.Btosubtracao.BackColor = System.Drawing.SystemColors.Control
        Me.Btosubtracao.Location = New System.Drawing.Point(298, 114)
        Me.Btosubtracao.Name = "Btosubtracao"
        Me.Btosubtracao.Size = New System.Drawing.Size(45, 23)
        Me.Btosubtracao.TabIndex = 18
        Me.Btosubtracao.Text = "-"
        Me.Btosubtracao.UseVisualStyleBackColor = False
        '
        'Btodivisao
        '
        Me.Btodivisao.BackColor = System.Drawing.SystemColors.Control
        Me.Btodivisao.Location = New System.Drawing.Point(298, 172)
        Me.Btodivisao.Name = "Btodivisao"
        Me.Btodivisao.Size = New System.Drawing.Size(45, 23)
        Me.Btodivisao.TabIndex = 19
        Me.Btodivisao.Text = "/"
        Me.Btodivisao.UseVisualStyleBackColor = False
        '
        'Btomultiplicacao
        '
        Me.Btomultiplicacao.BackColor = System.Drawing.SystemColors.Control
        Me.Btomultiplicacao.Location = New System.Drawing.Point(298, 143)
        Me.Btomultiplicacao.Name = "Btomultiplicacao"
        Me.Btomultiplicacao.Size = New System.Drawing.Size(45, 23)
        Me.Btomultiplicacao.TabIndex = 20
        Me.Btomultiplicacao.Text = "*"
        Me.Btomultiplicacao.UseVisualStyleBackColor = False
        '
        'Btoigual
        '
        Me.Btoigual.BackColor = System.Drawing.SystemColors.Control
        Me.Btoigual.Location = New System.Drawing.Point(70, 201)
        Me.Btoigual.Name = "Btoigual"
        Me.Btoigual.Size = New System.Drawing.Size(176, 23)
        Me.Btoigual.TabIndex = 21
        Me.Btoigual.Text = "="
        Me.Btoigual.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(289, 30)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(65, 23)
        Me.Button17.TabIndex = 22
        Me.Button17.Text = "Limpar"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'ponto
        '
        Me.ponto.Location = New System.Drawing.Point(204, 173)
        Me.ponto.Name = "ponto"
        Me.ponto.Size = New System.Drawing.Size(75, 23)
        Me.ponto.TabIndex = 23
        Me.ponto.Text = "."
        Me.ponto.UseVisualStyleBackColor = True
        '
        'calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(366, 246)
        Me.Controls.Add(Me.ponto)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Btoigual)
        Me.Controls.Add(Me.Btomultiplicacao)
        Me.Controls.Add(Me.Btodivisao)
        Me.Controls.Add(Me.Btosubtracao)
        Me.Controls.Add(Me.Btosoma)
        Me.Controls.Add(Me.bot0)
        Me.Controls.Add(Me.bot3)
        Me.Controls.Add(Me.bot6)
        Me.Controls.Add(Me.bot9)
        Me.Controls.Add(Me.bot8)
        Me.Controls.Add(Me.bot5)
        Me.Controls.Add(Me.bot2)
        Me.Controls.Add(Me.bot7)
        Me.Controls.Add(Me.bot4)
        Me.Controls.Add(Me.bot1)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "calculadora"
        Me.Text = "Calculadora v 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents resultado As System.Windows.Forms.TextBox
    Friend WithEvents bot1 As System.Windows.Forms.Button
    Friend WithEvents bot4 As System.Windows.Forms.Button
    Friend WithEvents bot7 As System.Windows.Forms.Button
    Friend WithEvents bot2 As System.Windows.Forms.Button
    Friend WithEvents bot5 As System.Windows.Forms.Button
    Friend WithEvents bot8 As System.Windows.Forms.Button
    Friend WithEvents bot9 As System.Windows.Forms.Button
    Friend WithEvents bot6 As System.Windows.Forms.Button
    Friend WithEvents bot3 As System.Windows.Forms.Button
    Friend WithEvents bot0 As System.Windows.Forms.Button
    Friend WithEvents Btosoma As System.Windows.Forms.Button
    Friend WithEvents Btosubtracao As System.Windows.Forms.Button
    Friend WithEvents Btodivisao As System.Windows.Forms.Button
    Friend WithEvents Btomultiplicacao As System.Windows.Forms.Button
    Friend WithEvents Btoigual As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents ponto As System.Windows.Forms.Button

End Class
