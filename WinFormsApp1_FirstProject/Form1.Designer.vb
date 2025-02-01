<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Btn_Presionar = New Button()
        Lbl_valor1 = New Label()
        Lbl_valor2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        suma = New Button()
        resta = New Button()
        division = New Button()
        multiplicacion = New Button()
        TextBox3_Total = New TextBox()
        Label2 = New Label()
        DGV1 = New DataGridView()
        Operacion = New DataGridViewTextBoxColumn()
        Result = New DataGridViewTextBoxColumn()
        CType(DGV1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(167, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 21)
        Label1.TabIndex = 0
        Label1.Text = "¡Hola, Mundo! "
        ' 
        ' Btn_Presionar
        ' 
        Btn_Presionar.Location = New Point(167, 102)
        Btn_Presionar.Name = "Btn_Presionar"
        Btn_Presionar.Size = New Size(105, 53)
        Btn_Presionar.TabIndex = 1
        Btn_Presionar.Text = "Presioname!"
        Btn_Presionar.UseVisualStyleBackColor = True
        ' 
        ' Lbl_valor1
        ' 
        Lbl_valor1.AutoSize = True
        Lbl_valor1.Location = New Point(93, 193)
        Lbl_valor1.Name = "Lbl_valor1"
        Lbl_valor1.Size = New Size(45, 15)
        Lbl_valor1.TabIndex = 2
        Lbl_valor1.Text = "Valor 1:"
        ' 
        ' Lbl_valor2
        ' 
        Lbl_valor2.AutoSize = True
        Lbl_valor2.Location = New Point(93, 232)
        Lbl_valor2.Name = "Lbl_valor2"
        Lbl_valor2.Size = New Size(45, 15)
        Lbl_valor2.TabIndex = 3
        Lbl_valor2.Text = "Valor 2:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(154, 190)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 4
        TextBox1.Text = "2"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(154, 229)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        TextBox2.Text = "3"
        ' 
        ' suma
        ' 
        suma.Location = New Point(291, 190)
        suma.Name = "suma"
        suma.Size = New Size(40, 37)
        suma.TabIndex = 6
        suma.Text = "+"
        suma.UseVisualStyleBackColor = True
        ' 
        ' resta
        ' 
        resta.Location = New Point(291, 229)
        resta.Name = "resta"
        resta.Size = New Size(40, 37)
        resta.TabIndex = 7
        resta.Text = "-"
        resta.UseVisualStyleBackColor = True
        ' 
        ' division
        ' 
        division.Location = New Point(348, 190)
        division.Name = "division"
        division.Size = New Size(40, 37)
        division.TabIndex = 8
        division.Text = "/"
        division.UseVisualStyleBackColor = True
        ' 
        ' multiplicacion
        ' 
        multiplicacion.Location = New Point(348, 233)
        multiplicacion.Name = "multiplicacion"
        multiplicacion.Size = New Size(40, 37)
        multiplicacion.TabIndex = 9
        multiplicacion.Text = "*"
        multiplicacion.UseVisualStyleBackColor = True
        ' 
        ' TextBox3_Total
        ' 
        TextBox3_Total.Enabled = False
        TextBox3_Total.Location = New Point(154, 268)
        TextBox3_Total.Name = "TextBox3_Total"
        TextBox3_Total.ReadOnly = True
        TextBox3_Total.Size = New Size(100, 23)
        TextBox3_Total.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(93, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 15)
        Label2.TabIndex = 10
        Label2.Text = "Total"
        ' 
        ' DGV1
        ' 
        DGV1.AllowUserToAddRows = False
        DGV1.AllowUserToDeleteRows = False
        DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV1.Columns.AddRange(New DataGridViewColumn() {Operacion, Result})
        DGV1.Location = New Point(507, 167)
        DGV1.Name = "DGV1"
        DGV1.ReadOnly = True
        DGV1.Size = New Size(240, 150)
        DGV1.TabIndex = 12
        ' 
        ' Operacion
        ' 
        Operacion.HeaderText = "Operacion"
        Operacion.Name = "Operacion"
        Operacion.ReadOnly = True
        ' 
        ' Result
        ' 
        Result.HeaderText = "Resultado"
        Result.Name = "Result"
        Result.ReadOnly = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DGV1)
        Controls.Add(TextBox3_Total)
        Controls.Add(Label2)
        Controls.Add(multiplicacion)
        Controls.Add(division)
        Controls.Add(resta)
        Controls.Add(suma)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Lbl_valor2)
        Controls.Add(Lbl_valor1)
        Controls.Add(Btn_Presionar)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Formulario de Introduccion"
        CType(DGV1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Presionar As Button
    Friend WithEvents Lbl_valor1 As Label
    Friend WithEvents Lbl_valor2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents suma As Button
    Friend WithEvents resta As Button
    Friend WithEvents division As Button
    Friend WithEvents multiplicacion As Button
    Friend WithEvents TextBox3_Total As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Operacion As DataGridViewTextBoxColumn
    Friend WithEvents Result As DataGridViewTextBoxColumn

End Class
