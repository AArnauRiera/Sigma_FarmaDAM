<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXMLReader
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button6.Location = New System.Drawing.Point(28, 255)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 44)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Llegir XML preinscripcions"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button7.Location = New System.Drawing.Point(185, 251)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(166, 44)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Llegir XML DICCIONARIO_LABORATORIOS"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button8.Location = New System.Drawing.Point(383, 251)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(212, 44)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Llegir XML DICCIONARIO_PRINCIPIOS_ACTIVOS"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'frmXMLReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 307)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Name = "frmXMLReader"
        Me.Text = "Prova XMLReader"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
