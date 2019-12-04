<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcWin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Display = New System.Windows.Forms.TextBox
        Me.Clear = New System.Windows.Forms.Button
        Me.Equal = New System.Windows.Forms.Button
        Me.Two = New System.Windows.Forms.Button
        Me.Three = New System.Windows.Forms.Button
        Me.Four = New System.Windows.Forms.Button
        Me.PlusMinus = New System.Windows.Forms.Button
        Me.Dot = New System.Windows.Forms.Button
        Me.Five = New System.Windows.Forms.Button
        Me.Zero = New System.Windows.Forms.Button
        Me.Six = New System.Windows.Forms.Button
        Me.One = New System.Windows.Forms.Button
        Me.Eight = New System.Windows.Forms.Button
        Me.Seven = New System.Windows.Forms.Button
        Me.Nine = New System.Windows.Forms.Button
        Me.Divide = New System.Windows.Forms.Button
        Me.Mult = New System.Windows.Forms.Button
        Me.Plus = New System.Windows.Forms.Button
        Me.Minus = New System.Windows.Forms.Button
        Me.Square = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Display
        '
        Me.Display.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Display.Cursor = System.Windows.Forms.Cursors.Default
        Me.Display.Enabled = False
        Me.Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.90698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Display.ForeColor = System.Drawing.Color.Lime
        Me.Display.Location = New System.Drawing.Point(13, 12)
        Me.Display.MaxLength = 16
        Me.Display.Name = "Display"
        Me.Display.ReadOnly = True
        Me.Display.Size = New System.Drawing.Size(216, 32)
        Me.Display.TabIndex = 0
        Me.Display.TabStop = False
        Me.Display.Text = "0."
        Me.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Display.WordWrap = False
        '
        'Clear
        '
        Me.Clear.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Clear.Location = New System.Drawing.Point(13, 55)
        Me.Clear.Margin = New System.Windows.Forms.Padding(4)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(48, 32)
        Me.Clear.TabIndex = 1
        Me.Clear.Text = "С/CE"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Equal
        '
        Me.Equal.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Equal.Location = New System.Drawing.Point(181, 215)
        Me.Equal.Margin = New System.Windows.Forms.Padding(4)
        Me.Equal.Name = "Equal"
        Me.Equal.Size = New System.Drawing.Size(48, 32)
        Me.Equal.TabIndex = 2
        Me.Equal.Text = "="
        Me.Equal.UseVisualStyleBackColor = True
        '
        'Two
        '
        Me.Two.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Two.Location = New System.Drawing.Point(69, 175)
        Me.Two.Margin = New System.Windows.Forms.Padding(4)
        Me.Two.Name = "Two"
        Me.Two.Size = New System.Drawing.Size(48, 32)
        Me.Two.TabIndex = 3
        Me.Two.Text = "2"
        Me.Two.UseVisualStyleBackColor = True
        '
        'Three
        '
        Me.Three.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Three.Location = New System.Drawing.Point(125, 175)
        Me.Three.Margin = New System.Windows.Forms.Padding(4)
        Me.Three.Name = "Three"
        Me.Three.Size = New System.Drawing.Size(48, 32)
        Me.Three.TabIndex = 4
        Me.Three.Text = "3"
        Me.Three.UseVisualStyleBackColor = True
        '
        'Four
        '
        Me.Four.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Four.Location = New System.Drawing.Point(13, 135)
        Me.Four.Margin = New System.Windows.Forms.Padding(4)
        Me.Four.Name = "Four"
        Me.Four.Size = New System.Drawing.Size(48, 32)
        Me.Four.TabIndex = 5
        Me.Four.Text = "4"
        Me.Four.UseVisualStyleBackColor = True
        '
        'PlusMinus
        '
        Me.PlusMinus.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PlusMinus.Location = New System.Drawing.Point(69, 215)
        Me.PlusMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.PlusMinus.Name = "PlusMinus"
        Me.PlusMinus.Size = New System.Drawing.Size(48, 32)
        Me.PlusMinus.TabIndex = 6
        Me.PlusMinus.Text = "+/-"
        Me.PlusMinus.UseVisualStyleBackColor = True
        '
        'Dot
        '
        Me.Dot.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Dot.Location = New System.Drawing.Point(125, 215)
        Me.Dot.Margin = New System.Windows.Forms.Padding(4)
        Me.Dot.Name = "Dot"
        Me.Dot.Size = New System.Drawing.Size(48, 32)
        Me.Dot.TabIndex = 7
        Me.Dot.Text = "."
        Me.Dot.UseVisualStyleBackColor = True
        '
        'Five
        '
        Me.Five.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Five.Location = New System.Drawing.Point(69, 135)
        Me.Five.Margin = New System.Windows.Forms.Padding(4)
        Me.Five.Name = "Five"
        Me.Five.Size = New System.Drawing.Size(48, 32)
        Me.Five.TabIndex = 8
        Me.Five.Text = "5"
        Me.Five.UseVisualStyleBackColor = True
        '
        'Zero
        '
        Me.Zero.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Zero.Location = New System.Drawing.Point(13, 215)
        Me.Zero.Margin = New System.Windows.Forms.Padding(4)
        Me.Zero.Name = "Zero"
        Me.Zero.Size = New System.Drawing.Size(48, 32)
        Me.Zero.TabIndex = 9
        Me.Zero.Text = "0"
        Me.Zero.UseVisualStyleBackColor = True
        '
        'Six
        '
        Me.Six.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Six.Location = New System.Drawing.Point(125, 135)
        Me.Six.Margin = New System.Windows.Forms.Padding(4)
        Me.Six.Name = "Six"
        Me.Six.Size = New System.Drawing.Size(48, 32)
        Me.Six.TabIndex = 10
        Me.Six.Text = "6"
        Me.Six.UseVisualStyleBackColor = True
        '
        'One
        '
        Me.One.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.One.Location = New System.Drawing.Point(13, 175)
        Me.One.Margin = New System.Windows.Forms.Padding(4)
        Me.One.Name = "One"
        Me.One.Size = New System.Drawing.Size(48, 32)
        Me.One.TabIndex = 11
        Me.One.Text = "1"
        Me.One.UseVisualStyleBackColor = True
        '
        'Eight
        '
        Me.Eight.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Eight.Location = New System.Drawing.Point(69, 95)
        Me.Eight.Margin = New System.Windows.Forms.Padding(4)
        Me.Eight.Name = "Eight"
        Me.Eight.Size = New System.Drawing.Size(48, 32)
        Me.Eight.TabIndex = 12
        Me.Eight.Text = "8"
        Me.Eight.UseVisualStyleBackColor = True
        '
        'Seven
        '
        Me.Seven.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Seven.Location = New System.Drawing.Point(13, 95)
        Me.Seven.Margin = New System.Windows.Forms.Padding(4)
        Me.Seven.Name = "Seven"
        Me.Seven.Size = New System.Drawing.Size(48, 32)
        Me.Seven.TabIndex = 13
        Me.Seven.Text = "7"
        Me.Seven.UseVisualStyleBackColor = True
        '
        'Nine
        '
        Me.Nine.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Nine.Location = New System.Drawing.Point(125, 95)
        Me.Nine.Margin = New System.Windows.Forms.Padding(4)
        Me.Nine.Name = "Nine"
        Me.Nine.Size = New System.Drawing.Size(48, 32)
        Me.Nine.TabIndex = 14
        Me.Nine.Text = "9"
        Me.Nine.UseVisualStyleBackColor = True
        '
        'Divide
        '
        Me.Divide.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Divide.Location = New System.Drawing.Point(181, 175)
        Me.Divide.Margin = New System.Windows.Forms.Padding(4)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(48, 32)
        Me.Divide.TabIndex = 15
        Me.Divide.Text = "/"
        Me.Divide.UseVisualStyleBackColor = True
        '
        'Mult
        '
        Me.Mult.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Mult.Location = New System.Drawing.Point(181, 135)
        Me.Mult.Margin = New System.Windows.Forms.Padding(4)
        Me.Mult.Name = "Mult"
        Me.Mult.Size = New System.Drawing.Size(48, 32)
        Me.Mult.TabIndex = 17
        Me.Mult.Text = "x"
        Me.Mult.UseVisualStyleBackColor = True
        '
        'Plus
        '
        Me.Plus.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Plus.Location = New System.Drawing.Point(181, 55)
        Me.Plus.Margin = New System.Windows.Forms.Padding(4)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(48, 32)
        Me.Plus.TabIndex = 18
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'Minus
        '
        Me.Minus.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Minus.Location = New System.Drawing.Point(182, 95)
        Me.Minus.Margin = New System.Windows.Forms.Padding(4)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(48, 32)
        Me.Minus.TabIndex = 19
        Me.Minus.Text = "-"
        Me.Minus.UseVisualStyleBackColor = True
        '
        'Square
        '
        Me.Square.Font = New System.Drawing.Font("Segoe UI", 10.04651!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Square.Location = New System.Drawing.Point(69, 55)
        Me.Square.Name = "Square"
        Me.Square.Size = New System.Drawing.Size(48, 32)
        Me.Square.TabIndex = 20
        Me.Square.Text = "Sqrt"
        Me.Square.UseVisualStyleBackColor = True
        '
        'CalcWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 263)
        Me.Controls.Add(Me.Square)
        Me.Controls.Add(Me.Minus)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(Me.Mult)
        Me.Controls.Add(Me.Divide)
        Me.Controls.Add(Me.Nine)
        Me.Controls.Add(Me.Seven)
        Me.Controls.Add(Me.Eight)
        Me.Controls.Add(Me.One)
        Me.Controls.Add(Me.Six)
        Me.Controls.Add(Me.Zero)
        Me.Controls.Add(Me.Five)
        Me.Controls.Add(Me.Dot)
        Me.Controls.Add(Me.PlusMinus)
        Me.Controls.Add(Me.Four)
        Me.Controls.Add(Me.Three)
        Me.Controls.Add(Me.Two)
        Me.Controls.Add(Me.Equal)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Display)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CalcWin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Калькулятор"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Display As System.Windows.Forms.TextBox
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents Equal As System.Windows.Forms.Button
    Friend WithEvents Two As System.Windows.Forms.Button
    Friend WithEvents Three As System.Windows.Forms.Button
    Friend WithEvents Four As System.Windows.Forms.Button
    Friend WithEvents PlusMinus As System.Windows.Forms.Button
    Friend WithEvents Dot As System.Windows.Forms.Button
    Friend WithEvents Five As System.Windows.Forms.Button
    Friend WithEvents Zero As System.Windows.Forms.Button
    Friend WithEvents Six As System.Windows.Forms.Button
    Friend WithEvents One As System.Windows.Forms.Button
    Friend WithEvents Eight As System.Windows.Forms.Button
    Friend WithEvents Seven As System.Windows.Forms.Button
    Friend WithEvents Nine As System.Windows.Forms.Button
    Friend WithEvents Divide As System.Windows.Forms.Button
    Friend WithEvents Mult As System.Windows.Forms.Button
    Friend WithEvents Plus As System.Windows.Forms.Button
    Friend WithEvents Minus As System.Windows.Forms.Button
    Friend WithEvents Square As System.Windows.Forms.Button

End Class
