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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LabelPoolAddress = New System.Windows.Forms.Label()
        Me.LabelMyrAddress = New System.Windows.Forms.Label()
        Me.LabelThreads = New System.Windows.Forms.Label()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.TextBoxPoolAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxMyrAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxThreads = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LabelOutput = New System.Windows.Forms.Label()
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.LabelHashRate = New System.Windows.Forms.Label()
        Me.TextBoxHashRate = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxShares = New System.Windows.Forms.TextBox()
        Me.LabelShares = New System.Windows.Forms.Label()
        Me.TextBoxBadShares = New System.Windows.Forms.TextBox()
        Me.LabelBadShares = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelPoolAddress
        '
        Me.LabelPoolAddress.AutoSize = True
        Me.LabelPoolAddress.Location = New System.Drawing.Point(104, 143)
        Me.LabelPoolAddress.Name = "LabelPoolAddress"
        Me.LabelPoolAddress.Size = New System.Drawing.Size(90, 13)
        Me.LabelPoolAddress.TabIndex = 0
        Me.LabelPoolAddress.Text = "Ministara adreso: "
        '
        'LabelMyrAddress
        '
        Me.LabelMyrAddress.AutoSize = True
        Me.LabelMyrAddress.Location = New System.Drawing.Point(109, 172)
        Me.LabelMyrAddress.Name = "LabelMyrAddress"
        Me.LabelMyrAddress.Size = New System.Drawing.Size(85, 13)
        Me.LabelMyrAddress.TabIndex = 1
        Me.LabelMyrAddress.Text = "Myriada adreso: "
        '
        'LabelThreads
        '
        Me.LabelThreads.AutoSize = True
        Me.LabelThreads.Location = New System.Drawing.Point(121, 200)
        Me.LabelThreads.Name = "LabelThreads"
        Me.LabelThreads.Size = New System.Drawing.Size(73, 13)
        Me.LabelThreads.TabIndex = 2
        Me.LabelThreads.Text = "# da fadenoj: "
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(94, 318)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(164, 23)
        Me.ButtonStart.TabIndex = 3
        Me.ButtonStart.Text = "Komenci minadon"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonStop
        '
        Me.ButtonStop.Location = New System.Drawing.Point(323, 318)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(164, 23)
        Me.ButtonStop.TabIndex = 4
        Me.ButtonStop.Text = "Ĉesigi minadon"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'TextBoxPoolAddress
        '
        Me.TextBoxPoolAddress.Location = New System.Drawing.Point(201, 140)
        Me.TextBoxPoolAddress.Name = "TextBoxPoolAddress"
        Me.TextBoxPoolAddress.Size = New System.Drawing.Size(291, 20)
        Me.TextBoxPoolAddress.TabIndex = 5
        Me.TextBoxPoolAddress.Text = "stratum+tcp://stratum.eu.miners-pool.eu:8428"
        '
        'TextBoxMyrAddress
        '
        Me.TextBoxMyrAddress.Location = New System.Drawing.Point(201, 169)
        Me.TextBoxMyrAddress.Name = "TextBoxMyrAddress"
        Me.TextBoxMyrAddress.Size = New System.Drawing.Size(291, 20)
        Me.TextBoxMyrAddress.TabIndex = 6
        Me.TextBoxMyrAddress.Text = "MTXdQYbPaPMn2dLHgwEtVAN7mrexZPq7ar"
        '
        'TextBoxThreads
        '
        Me.TextBoxThreads.Location = New System.Drawing.Point(201, 197)
        Me.TextBoxThreads.Name = "TextBoxThreads"
        Me.TextBoxThreads.Size = New System.Drawing.Size(62, 20)
        Me.TextBoxThreads.TabIndex = 7
        Me.TextBoxThreads.Text = "1"
        '
        'BackgroundWorker1
        '
        '
        'LabelOutput
        '
        Me.LabelOutput.AutoSize = True
        Me.LabelOutput.Location = New System.Drawing.Point(21, 267)
        Me.LabelOutput.Name = "LabelOutput"
        Me.LabelOutput.Size = New System.Drawing.Size(65, 13)
        Me.LabelOutput.TabIndex = 8
        Me.LabelOutput.Text = "Minila eligo: "
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOutput.Location = New System.Drawing.Point(12, 283)
        Me.TextBoxOutput.Multiline = True
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.Size = New System.Drawing.Size(560, 29)
        Me.TextBoxOutput.TabIndex = 9
        '
        'LabelHashRate
        '
        Me.LabelHashRate.AutoSize = True
        Me.LabelHashRate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHashRate.Location = New System.Drawing.Point(-2, 233)
        Me.LabelHashRate.Name = "LabelHashRate"
        Me.LabelHashRate.Size = New System.Drawing.Size(103, 16)
        Me.LabelHashRate.TabIndex = 10
        Me.LabelHashRate.Text = "Haketpotenco: "
        '
        'TextBoxHashRate
        '
        Me.TextBoxHashRate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHashRate.Location = New System.Drawing.Point(94, 230)
        Me.TextBoxHashRate.Name = "TextBoxHashRate"
        Me.TextBoxHashRate.Size = New System.Drawing.Size(87, 22)
        Me.TextBoxHashRate.TabIndex = 11
        Me.TextBoxHashRate.Text = "..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(94, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(393, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'TextBoxShares
        '
        Me.TextBoxShares.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxShares.Location = New System.Drawing.Point(309, 230)
        Me.TextBoxShares.Name = "TextBoxShares"
        Me.TextBoxShares.Size = New System.Drawing.Size(76, 22)
        Me.TextBoxShares.TabIndex = 14
        Me.TextBoxShares.Text = "..."
        '
        'LabelShares
        '
        Me.LabelShares.AutoSize = True
        Me.LabelShares.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelShares.Location = New System.Drawing.Point(187, 233)
        Me.LabelShares.Name = "LabelShares"
        Me.LabelShares.Size = New System.Drawing.Size(131, 16)
        Me.LabelShares.TabIndex = 13
        Me.LabelShares.Text = "Profitpartoj entute: "
        '
        'TextBoxBadShares
        '
        Me.TextBoxBadShares.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBadShares.Location = New System.Drawing.Point(532, 230)
        Me.TextBoxBadShares.Name = "TextBoxBadShares"
        Me.TextBoxBadShares.Size = New System.Drawing.Size(49, 22)
        Me.TextBoxBadShares.TabIndex = 16
        Me.TextBoxBadShares.Text = "..."
        '
        'LabelBadShares
        '
        Me.LabelBadShares.AutoSize = True
        Me.LabelBadShares.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBadShares.Location = New System.Drawing.Point(391, 233)
        Me.LabelBadShares.Name = "LabelBadShares"
        Me.LabelBadShares.Size = New System.Drawing.Size(149, 16)
        Me.LabelBadShares.TabIndex = 15
        Me.LabelBadShares.Text = "Malbonaj profitpartoj: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(584, 353)
        Me.Controls.Add(Me.TextBoxBadShares)
        Me.Controls.Add(Me.LabelBadShares)
        Me.Controls.Add(Me.TextBoxShares)
        Me.Controls.Add(Me.LabelShares)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBoxHashRate)
        Me.Controls.Add(Me.LabelHashRate)
        Me.Controls.Add(Me.TextBoxOutput)
        Me.Controls.Add(Me.LabelOutput)
        Me.Controls.Add(Me.TextBoxThreads)
        Me.Controls.Add(Me.TextBoxMyrAddress)
        Me.Controls.Add(Me.TextBoxPoolAddress)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.LabelThreads)
        Me.Controls.Add(Me.LabelMyrAddress)
        Me.Controls.Add(Me.LabelPoolAddress)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "MyrMinilo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPoolAddress As Label
    Friend WithEvents LabelMyrAddress As Label
    Friend WithEvents LabelThreads As Label
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonStop As Button
    Friend WithEvents TextBoxPoolAddress As TextBox
    Friend WithEvents TextBoxMyrAddress As TextBox
    Friend WithEvents TextBoxThreads As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelOutput As Label
    Friend WithEvents TextBoxOutput As TextBox
    Friend WithEvents LabelHashRate As Label
    Friend WithEvents TextBoxHashRate As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxShares As TextBox
    Friend WithEvents LabelShares As Label
    Friend WithEvents TextBoxBadShares As TextBox
    Friend WithEvents LabelBadShares As Label
End Class
