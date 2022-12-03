<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtTitulo = New System.Windows.Forms.Label()
        Me.lblRun = New System.Windows.Forms.Label()
        Me.txtRun = New System.Windows.Forms.TextBox()
        Me.lblGuion = New System.Windows.Forms.Label()
        Me.txtDV = New System.Windows.Forms.TextBox()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.AutoSize = True
        Me.txtTitulo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTitulo.Location = New System.Drawing.Point(12, 9)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(146, 28)
        Me.txtTitulo.TabIndex = 0
        Me.txtTitulo.Text = "Validador RUN."
        '
        'lblRun
        '
        Me.lblRun.AutoSize = True
        Me.lblRun.Location = New System.Drawing.Point(12, 68)
        Me.lblRun.Name = "lblRun"
        Me.lblRun.Size = New System.Drawing.Size(42, 20)
        Me.lblRun.TabIndex = 1
        Me.lblRun.Text = "RUN:"
        '
        'txtRun
        '
        Me.txtRun.Location = New System.Drawing.Point(60, 65)
        Me.txtRun.Name = "txtRun"
        Me.txtRun.Size = New System.Drawing.Size(180, 27)
        Me.txtRun.TabIndex = 2
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGuion.Location = New System.Drawing.Point(246, 66)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(17, 23)
        Me.lblGuion.TabIndex = 3
        Me.lblGuion.Text = "-"
        '
        'txtDV
        '
        Me.txtDV.Location = New System.Drawing.Point(269, 65)
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Size = New System.Drawing.Size(32, 27)
        Me.txtDV.TabIndex = 4
        '
        'btnValidar
        '
        Me.btnValidar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnValidar.Location = New System.Drawing.Point(251, 115)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(129, 38)
        Me.btnValidar.TabIndex = 5
        Me.btnValidar.Text = "&Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 165)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.txtDV)
        Me.Controls.Add(Me.lblGuion)
        Me.Controls.Add(Me.txtRun)
        Me.Controls.Add(Me.lblRun)
        Me.Controls.Add(Me.txtTitulo)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validar RUN - Visual Studio 2019"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitulo As Label
    Friend WithEvents lblRun As Label
    Friend WithEvents txtRun As TextBox
    Friend WithEvents lblGuion As Label
    Friend WithEvents txtDV As TextBox
    Friend WithEvents btnValidar As Button
End Class
