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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Response = New System.Windows.Forms.TextBox()
        Me.Go = New System.Windows.Forms.Button()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.I = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PeriodBox = New System.Windows.Forms.ComboBox()
        Me.StuPic = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodeBox = New System.Windows.Forms.TextBox()
        Me.InstructionText = New System.Windows.Forms.TextBox()
        Me.dtview = New System.Windows.Forms.DataGridView()
        Me.ChoosePrinter = New System.Windows.Forms.Button()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.SaveData = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.SchoolNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.StuPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Response
        '
        Me.Response.Location = New System.Drawing.Point(12, 192)
        Me.Response.Multiline = True
        Me.Response.Name = "Response"
        Me.Response.Size = New System.Drawing.Size(265, 121)
        Me.Response.TabIndex = 0
        '
        'Go
        '
        Me.Go.Location = New System.Drawing.Point(287, 340)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(75, 23)
        Me.Go.TabIndex = 1
        Me.Go.Text = "Go"
        Me.Go.UseVisualStyleBackColor = True
        '
        'IDBox
        '
        Me.IDBox.Location = New System.Drawing.Point(168, 343)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(100, 20)
        Me.IDBox.TabIndex = 2
        '
        'I
        '
        Me.I.AutoSize = True
        Me.I.Location = New System.Drawing.Point(165, 327)
        Me.I.Name = "I"
        Me.I.Size = New System.Drawing.Size(58, 13)
        Me.I.TabIndex = 3
        Me.I.Text = "Student ID"
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Period"
        '
        'PeriodBox
        '
        Me.PeriodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PeriodBox.FormattingEnabled = True
        Me.PeriodBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.PeriodBox.Location = New System.Drawing.Point(13, 343)
        Me.PeriodBox.Name = "PeriodBox"
        Me.PeriodBox.Size = New System.Drawing.Size(60, 21)
        Me.PeriodBox.TabIndex = 5
        '
        'StuPic
        '
        Me.StuPic.Location = New System.Drawing.Point(13, 13)
        Me.StuPic.Name = "StuPic"
        Me.StuPic.Size = New System.Drawing.Size(140, 160)
        Me.StuPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StuPic.TabIndex = 6
        Me.StuPic.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Code"
        '
        'CodeBox
        '
        Me.CodeBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodeBox.Location = New System.Drawing.Point(102, 343)
        Me.CodeBox.Name = "CodeBox"
        Me.CodeBox.Size = New System.Drawing.Size(38, 20)
        Me.CodeBox.TabIndex = 8
        '
        'InstructionText
        '
        Me.InstructionText.BackColor = System.Drawing.SystemColors.Control
        Me.InstructionText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InstructionText.Location = New System.Drawing.Point(180, 11)
        Me.InstructionText.Multiline = True
        Me.InstructionText.Name = "InstructionText"
        Me.InstructionText.ReadOnly = True
        Me.InstructionText.Size = New System.Drawing.Size(202, 162)
        Me.InstructionText.TabIndex = 9
        Me.InstructionText.Text = resources.GetString("InstructionText.Text")
        '
        'dtview
        '
        Me.dtview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtview.Location = New System.Drawing.Point(12, 395)
        Me.dtview.Name = "dtview"
        Me.dtview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtview.Size = New System.Drawing.Size(552, 233)
        Me.dtview.TabIndex = 11
        '
        'ChoosePrinter
        '
        Me.ChoosePrinter.Location = New System.Drawing.Point(316, 192)
        Me.ChoosePrinter.Name = "ChoosePrinter"
        Me.ChoosePrinter.Size = New System.Drawing.Size(159, 23)
        Me.ChoosePrinter.TabIndex = 12
        Me.ChoosePrinter.Text = "Choose a Printer"
        Me.ChoosePrinter.UseVisualStyleBackColor = True
        '
        'SaveData
        '
        Me.SaveData.Location = New System.Drawing.Point(387, 341)
        Me.SaveData.Name = "SaveData"
        Me.SaveData.Size = New System.Drawing.Size(159, 23)
        Me.SaveData.TabIndex = 13
        Me.SaveData.Text = "Save Students"
        Me.SaveData.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(316, 247)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(75, 23)
        Me.btnSettings.TabIndex = 14
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'SchoolNum
        '
        Me.SchoolNum.Location = New System.Drawing.Point(316, 292)
        Me.SchoolNum.Name = "SchoolNum"
        Me.SchoolNum.Size = New System.Drawing.Size(28, 20)
        Me.SchoolNum.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "School Number"
        '
        'Form1
        '
        Me.AcceptButton = Me.Go
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 653)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SchoolNum)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.SaveData)
        Me.Controls.Add(Me.ChoosePrinter)
        Me.Controls.Add(Me.dtview)
        Me.Controls.Add(Me.InstructionText)
        Me.Controls.Add(Me.CodeBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StuPic)
        Me.Controls.Add(Me.PeriodBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.I)
        Me.Controls.Add(Me.IDBox)
        Me.Controls.Add(Me.Go)
        Me.Controls.Add(Me.Response)
        Me.Name = "Form1"
        Me.Text = "Tardy Slip Printer"
        CType(Me.StuPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Response As TextBox
    Friend WithEvents Go As Button
    Friend WithEvents IDBox As TextBox
    Friend WithEvents I As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents PeriodBox As ComboBox
    Friend WithEvents StuPic As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CodeBox As TextBox
    Friend WithEvents InstructionText As TextBox
    ' Friend WithEvents dtview As DataGridView
    Friend WithEvents ChoosePrinter As Button
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents SaveData As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnSettings As Button
    Friend WithEvents SchoolNum As TextBox
    Friend WithEvents Label3 As Label
End Class
