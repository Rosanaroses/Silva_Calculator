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
        TextBox1 = New TextBox()
        btnclear = New Button()
        btnpoint = New Button()
        btndivide = New Button()
        btndel = New Button()
        btnminus = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btntimes = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btn3 = New Button()
        btn2 = New Button()
        btn1 = New Button()
        btnplus = New Button()
        btnequals = New Button()
        btn0 = New Button()
        btn00 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(106, 30)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(290, 40)
        TextBox1.TabIndex = 0
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Red
        btnclear.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnclear.Location = New Point(106, 86)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(68, 63)
        btnclear.TabIndex = 1
        btnclear.Text = "C"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnpoint
        ' 
        btnpoint.BackColor = SystemColors.ActiveBorder
        btnpoint.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnpoint.Location = New Point(180, 86)
        btnpoint.Name = "btnpoint"
        btnpoint.Size = New Size(68, 63)
        btnpoint.TabIndex = 2
        btnpoint.Text = "."
        btnpoint.UseVisualStyleBackColor = False
        ' 
        ' btndivide
        ' 
        btndivide.BackColor = SystemColors.ActiveBorder
        btndivide.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndivide.Location = New Point(254, 86)
        btndivide.Name = "btndivide"
        btndivide.Size = New Size(68, 63)
        btndivide.TabIndex = 3
        btndivide.Text = "/"
        btndivide.UseVisualStyleBackColor = False
        ' 
        ' btndel
        ' 
        btndel.BackColor = Color.Red
        btndel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndel.Location = New Point(328, 86)
        btndel.Name = "btndel"
        btndel.Size = New Size(68, 63)
        btndel.TabIndex = 4
        btndel.Text = "DEL"
        btndel.UseVisualStyleBackColor = False
        ' 
        ' btnminus
        ' 
        btnminus.BackColor = SystemColors.ActiveBorder
        btnminus.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnminus.Location = New Point(328, 155)
        btnminus.Name = "btnminus"
        btnminus.Size = New Size(68, 63)
        btnminus.TabIndex = 8
        btnminus.Text = "-"
        btnminus.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = SystemColors.ActiveBorder
        btn9.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn9.Location = New Point(254, 155)
        btn9.Name = "btn9"
        btn9.Size = New Size(68, 63)
        btn9.TabIndex = 7
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = SystemColors.ActiveBorder
        btn8.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn8.Location = New Point(180, 155)
        btn8.Name = "btn8"
        btn8.Size = New Size(68, 63)
        btn8.TabIndex = 6
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = SystemColors.ActiveBorder
        btn7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn7.Location = New Point(106, 155)
        btn7.Name = "btn7"
        btn7.Size = New Size(68, 63)
        btn7.TabIndex = 5
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btntimes
        ' 
        btntimes.BackColor = SystemColors.ActiveBorder
        btntimes.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btntimes.Location = New Point(328, 224)
        btntimes.Name = "btntimes"
        btntimes.Size = New Size(68, 63)
        btntimes.TabIndex = 12
        btntimes.Text = "*"
        btntimes.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = SystemColors.ActiveBorder
        btn6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn6.Location = New Point(254, 224)
        btn6.Name = "btn6"
        btn6.Size = New Size(68, 63)
        btn6.TabIndex = 11
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = SystemColors.ActiveBorder
        btn5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn5.Location = New Point(180, 224)
        btn5.Name = "btn5"
        btn5.Size = New Size(68, 63)
        btn5.TabIndex = 10
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = SystemColors.ActiveBorder
        btn4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn4.Location = New Point(106, 224)
        btn4.Name = "btn4"
        btn4.Size = New Size(68, 63)
        btn4.TabIndex = 9
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = SystemColors.ActiveBorder
        btn3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn3.Location = New Point(254, 293)
        btn3.Name = "btn3"
        btn3.Size = New Size(68, 63)
        btn3.TabIndex = 15
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = SystemColors.ActiveBorder
        btn2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn2.Location = New Point(180, 293)
        btn2.Name = "btn2"
        btn2.Size = New Size(68, 63)
        btn2.TabIndex = 14
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.BackColor = SystemColors.ActiveBorder
        btn1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn1.Location = New Point(106, 293)
        btn1.Name = "btn1"
        btn1.Size = New Size(68, 63)
        btn1.TabIndex = 13
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btnplus
        ' 
        btnplus.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnplus.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnplus.Location = New Point(328, 293)
        btnplus.Name = "btnplus"
        btnplus.Size = New Size(68, 132)
        btnplus.TabIndex = 20
        btnplus.Text = "+"
        btnplus.UseVisualStyleBackColor = False
        ' 
        ' btnequals
        ' 
        btnequals.BackColor = SystemColors.ActiveBorder
        btnequals.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnequals.Location = New Point(254, 362)
        btnequals.Name = "btnequals"
        btnequals.Size = New Size(68, 63)
        btnequals.TabIndex = 19
        btnequals.Text = "="
        btnequals.UseVisualStyleBackColor = False
        ' 
        ' btn0
        ' 
        btn0.BackColor = SystemColors.ActiveBorder
        btn0.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn0.Location = New Point(180, 362)
        btn0.Name = "btn0"
        btn0.Size = New Size(68, 63)
        btn0.TabIndex = 18
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = False
        ' 
        ' btn00
        ' 
        btn00.BackColor = SystemColors.ActiveBorder
        btn00.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn00.Location = New Point(106, 362)
        btn00.Name = "btn00"
        btn00.Size = New Size(68, 63)
        btn00.TabIndex = 17
        btn00.Text = "00"
        btn00.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(355, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(402, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 22
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnplus)
        Controls.Add(btnequals)
        Controls.Add(btn0)
        Controls.Add(btn00)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btntimes)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btnminus)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btndel)
        Controls.Add(btndivide)
        Controls.Add(btnpoint)
        Controls.Add(btnclear)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btnpoint As Button
    Friend WithEvents btndivide As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnminus As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btntimes As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnplus As Button
    Friend WithEvents btnequals As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn00 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
