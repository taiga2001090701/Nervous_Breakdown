<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OK
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BC = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BC
        '
        Me.BC.Enabled = False
        Me.BC.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.BC.Location = New System.Drawing.Point(19, 19)
        Me.BC.Margin = New System.Windows.Forms.Padding(10)
        Me.BC.Name = "BC"
        Me.BC.Size = New System.Drawing.Size(135, 76)
        Me.BC.TabIndex = 0
        Me.BC.Text = "OK"
        Me.BC.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 1
        '
        'OK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(173, 114)
        Me.ControlBox = False
        Me.Controls.Add(Me.BC)
        Me.Name = "OK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OK"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BC As Button
    Friend WithEvents Timer As Timer
End Class
