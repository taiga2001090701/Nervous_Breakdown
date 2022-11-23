<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Font = New System.Drawing.Font("MS UI Gothic", 30.0!)
        Me.B1.Location = New System.Drawing.Point(19, 19)
        Me.B1.Margin = New System.Windows.Forms.Padding(10)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(250, 80)
        Me.B1.TabIndex = 0
        Me.B1.Text = "1 Player"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Font = New System.Drawing.Font("MS UI Gothic", 30.0!)
        Me.B2.Location = New System.Drawing.Point(289, 19)
        Me.B2.Margin = New System.Windows.Forms.Padding(10)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(250, 80)
        Me.B2.TabIndex = 1
        Me.B2.Text = "2 Players"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Font = New System.Drawing.Font("MS UI Gothic", 30.0!)
        Me.B3.Location = New System.Drawing.Point(19, 119)
        Me.B3.Margin = New System.Windows.Forms.Padding(10)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(250, 80)
        Me.B3.TabIndex = 2
        Me.B3.Text = "3 Players"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Font = New System.Drawing.Font("MS UI Gothic", 30.0!)
        Me.B4.Location = New System.Drawing.Point(289, 119)
        Me.B4.Margin = New System.Windows.Forms.Padding(10)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(250, 80)
        Me.B4.TabIndex = 3
        Me.B4.Text = "4 Players"
        Me.B4.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.Font = New System.Drawing.Font("MS UI Gothic", 30.0!)
        Me.B5.Location = New System.Drawing.Point(19, 219)
        Me.B5.Margin = New System.Windows.Forms.Padding(10)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(250, 80)
        Me.B5.TabIndex = 4
        Me.B5.Text = "5 Players"
        Me.B5.UseVisualStyleBackColor = True
        '
        'B6
        '
        Me.B6.Font = New System.Drawing.Font("MS UI Gothic", 30.0!)
        Me.B6.Location = New System.Drawing.Point(289, 219)
        Me.B6.Margin = New System.Windows.Forms.Padding(10)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(250, 80)
        Me.B6.TabIndex = 5
        Me.B6.Text = "6 Players"
        Me.B6.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(567, 323)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents B1 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B6 As Button
End Class
