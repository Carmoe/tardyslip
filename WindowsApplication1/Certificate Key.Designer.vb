<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Certificate_Key
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
        Me.keyText = New System.Windows.Forms.TextBox()
        Me.KeySave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.urlLabel1 = New System.Windows.Forms.Label()
        Me.urlText = New System.Windows.Forms.TextBox()
        Me.urlCompleter = New System.Windows.Forms.Label()
        Me.httpsLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'keyText
        '
        Me.keyText.Location = New System.Drawing.Point(13, 140)
        Me.keyText.Name = "keyText"
        Me.keyText.Size = New System.Drawing.Size(259, 20)
        Me.keyText.TabIndex = 1
        '
        'KeySave
        '
        Me.KeySave.Location = New System.Drawing.Point(22, 174)
        Me.KeySave.Name = "KeySave"
        Me.KeySave.Size = New System.Drawing.Size(75, 23)
        Me.KeySave.TabIndex = 2
        Me.KeySave.Text = "Save"
        Me.KeySave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please enter your Aeries Certificate Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "The key is available from  you Aeries Administrator"
        '
        'urlLabel1
        '
        Me.urlLabel1.AutoSize = True
        Me.urlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.urlLabel1.Location = New System.Drawing.Point(13, 13)
        Me.urlLabel1.Name = "urlLabel1"
        Me.urlLabel1.Size = New System.Drawing.Size(218, 13)
        Me.urlLabel1.TabIndex = 5
        Me.urlLabel1.Text = "Please Enter the URL to the web API"
        '
        'urlText
        '
        Me.urlText.Location = New System.Drawing.Point(50, 55)
        Me.urlText.Name = "urlText"
        Me.urlText.Size = New System.Drawing.Size(161, 20)
        Me.urlText.TabIndex = 6
        '
        'urlCompleter
        '
        Me.urlCompleter.AutoSize = True
        Me.urlCompleter.Location = New System.Drawing.Point(213, 59)
        Me.urlCompleter.Name = "urlCompleter"
        Me.urlCompleter.Size = New System.Drawing.Size(143, 13)
        Me.urlCompleter.TabIndex = 7
        Me.urlCompleter.Text = "/api/V3/schools/"
        '
        'httpsLabel
        '
        Me.httpsLabel.AutoSize = True
        Me.httpsLabel.Location = New System.Drawing.Point(3, 59)
        Me.httpsLabel.Name = "httpsLabel"
        Me.httpsLabel.Size = New System.Drawing.Size(43, 13)
        Me.httpsLabel.TabIndex = 8
        Me.httpsLabel.Text = "https://"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ex:   portal.SchoolName.org"
        '
        'Certificate_Key
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 216)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.httpsLabel)
        Me.Controls.Add(Me.urlCompleter)
        Me.Controls.Add(Me.urlText)
        Me.Controls.Add(Me.urlLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KeySave)
        Me.Controls.Add(Me.keyText)
        Me.Name = "Certificate_Key"
        Me.Text = "Certificate_Key"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents keyText As TextBox
    Friend WithEvents KeySave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents urlLabel1 As Label
    Friend WithEvents urlText As TextBox
    Friend WithEvents urlCompleter As Label
    Friend WithEvents httpsLabel As Label
    Friend WithEvents Label3 As Label
End Class
