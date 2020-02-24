<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.cmdMemClear = New System.Windows.Forms.Button()
        Me.cmdMemRecall = New System.Windows.Forms.Button()
        Me.cmdMemSave = New System.Windows.Forms.Button()
        Me.cmdMemPlus = New System.Windows.Forms.Button()
        Me.cmdMemMinus = New System.Windows.Forms.Button()
        Me.cmdBS = New System.Windows.Forms.Button()
        Me.cmdClearAll = New System.Windows.Forms.Button()
        Me.cmdClearEntry = New System.Windows.Forms.Button()
        Me.cmdChangeSign = New System.Windows.Forms.Button()
        Me.cmdSqrRoot = New System.Windows.Forms.Button()
        Me.cmd07 = New System.Windows.Forms.Button()
        Me.cmd09 = New System.Windows.Forms.Button()
        Me.cmd08 = New System.Windows.Forms.Button()
        Me.cmdDiv = New System.Windows.Forms.Button()
        Me.cmdPercent = New System.Windows.Forms.Button()
        Me.cmd04 = New System.Windows.Forms.Button()
        Me.cmd06 = New System.Windows.Forms.Button()
        Me.cmd05 = New System.Windows.Forms.Button()
        Me.cmdMul = New System.Windows.Forms.Button()
        Me.cmdInv = New System.Windows.Forms.Button()
        Me.cmd01 = New System.Windows.Forms.Button()
        Me.cmd03 = New System.Windows.Forms.Button()
        Me.cmd02 = New System.Windows.Forms.Button()
        Me.cmdMin = New System.Windows.Forms.Button()
        Me.cmd00 = New System.Windows.Forms.Button()
        Me.cmdDecimal = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdEquals = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblSuperScript = New System.Windows.Forms.Label()
        Me.lblMemStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdMemClear
        '
        Me.cmdMemClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdMemClear.FlatAppearance.BorderSize = 0
        Me.cmdMemClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMemClear.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMemClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdMemClear.Location = New System.Drawing.Point(29, 203)
        Me.cmdMemClear.Name = "cmdMemClear"
        Me.cmdMemClear.Size = New System.Drawing.Size(75, 75)
        Me.cmdMemClear.TabIndex = 24
        Me.cmdMemClear.Text = "MC"
        Me.cmdMemClear.UseVisualStyleBackColor = False
        '
        'cmdMemRecall
        '
        Me.cmdMemRecall.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdMemRecall.FlatAppearance.BorderSize = 0
        Me.cmdMemRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMemRecall.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMemRecall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdMemRecall.Location = New System.Drawing.Point(110, 203)
        Me.cmdMemRecall.Name = "cmdMemRecall"
        Me.cmdMemRecall.Size = New System.Drawing.Size(75, 75)
        Me.cmdMemRecall.TabIndex = 25
        Me.cmdMemRecall.Text = "MR"
        Me.cmdMemRecall.UseVisualStyleBackColor = False
        '
        'cmdMemSave
        '
        Me.cmdMemSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdMemSave.FlatAppearance.BorderSize = 0
        Me.cmdMemSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMemSave.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMemSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdMemSave.Location = New System.Drawing.Point(191, 203)
        Me.cmdMemSave.Name = "cmdMemSave"
        Me.cmdMemSave.Size = New System.Drawing.Size(75, 75)
        Me.cmdMemSave.TabIndex = 23
        Me.cmdMemSave.Text = "MS"
        Me.cmdMemSave.UseVisualStyleBackColor = False
        '
        'cmdMemPlus
        '
        Me.cmdMemPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdMemPlus.FlatAppearance.BorderSize = 0
        Me.cmdMemPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMemPlus.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMemPlus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdMemPlus.Location = New System.Drawing.Point(272, 203)
        Me.cmdMemPlus.Name = "cmdMemPlus"
        Me.cmdMemPlus.Size = New System.Drawing.Size(75, 75)
        Me.cmdMemPlus.TabIndex = 26
        Me.cmdMemPlus.Text = "M+"
        Me.cmdMemPlus.UseVisualStyleBackColor = False
        '
        'cmdMemMinus
        '
        Me.cmdMemMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdMemMinus.FlatAppearance.BorderSize = 0
        Me.cmdMemMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMemMinus.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMemMinus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdMemMinus.Location = New System.Drawing.Point(353, 203)
        Me.cmdMemMinus.Name = "cmdMemMinus"
        Me.cmdMemMinus.Size = New System.Drawing.Size(75, 75)
        Me.cmdMemMinus.TabIndex = 27
        Me.cmdMemMinus.Text = "M-"
        Me.cmdMemMinus.UseVisualStyleBackColor = False
        '
        'cmdBS
        '
        Me.cmdBS.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdBS.FlatAppearance.BorderSize = 0
        Me.cmdBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBS.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdBS.Location = New System.Drawing.Point(29, 284)
        Me.cmdBS.Name = "cmdBS"
        Me.cmdBS.Size = New System.Drawing.Size(75, 75)
        Me.cmdBS.TabIndex = 11
        Me.cmdBS.Text = "<--"
        Me.cmdBS.UseVisualStyleBackColor = False
        '
        'cmdClearAll
        '
        Me.cmdClearAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.cmdClearAll.FlatAppearance.BorderSize = 0
        Me.cmdClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClearAll.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.cmdClearAll.Location = New System.Drawing.Point(191, 284)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.Size = New System.Drawing.Size(75, 75)
        Me.cmdClearAll.TabIndex = 21
        Me.cmdClearAll.Text = "C"
        Me.cmdClearAll.UseVisualStyleBackColor = False
        '
        'cmdClearEntry
        '
        Me.cmdClearEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdClearEntry.FlatAppearance.BorderSize = 0
        Me.cmdClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClearEntry.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdClearEntry.Location = New System.Drawing.Point(110, 284)
        Me.cmdClearEntry.Name = "cmdClearEntry"
        Me.cmdClearEntry.Size = New System.Drawing.Size(75, 75)
        Me.cmdClearEntry.TabIndex = 22
        Me.cmdClearEntry.Text = "CE"
        Me.cmdClearEntry.UseVisualStyleBackColor = False
        '
        'cmdChangeSign
        '
        Me.cmdChangeSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdChangeSign.FlatAppearance.BorderSize = 0
        Me.cmdChangeSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdChangeSign.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChangeSign.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdChangeSign.Location = New System.Drawing.Point(272, 284)
        Me.cmdChangeSign.Name = "cmdChangeSign"
        Me.cmdChangeSign.Size = New System.Drawing.Size(75, 75)
        Me.cmdChangeSign.TabIndex = 16
        Me.cmdChangeSign.Text = "±"
        Me.cmdChangeSign.UseVisualStyleBackColor = False
        '
        'cmdSqrRoot
        '
        Me.cmdSqrRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdSqrRoot.FlatAppearance.BorderSize = 0
        Me.cmdSqrRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSqrRoot.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSqrRoot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdSqrRoot.Location = New System.Drawing.Point(353, 284)
        Me.cmdSqrRoot.Name = "cmdSqrRoot"
        Me.cmdSqrRoot.Size = New System.Drawing.Size(75, 75)
        Me.cmdSqrRoot.TabIndex = 17
        Me.cmdSqrRoot.Text = "√"
        Me.cmdSqrRoot.UseVisualStyleBackColor = False
        '
        'cmd07
        '
        Me.cmd07.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmd07.FlatAppearance.BorderSize = 0
        Me.cmd07.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd07.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd07.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmd07.Location = New System.Drawing.Point(29, 365)
        Me.cmd07.Name = "cmd07"
        Me.cmd07.Size = New System.Drawing.Size(75, 75)
        Me.cmd07.TabIndex = 7
        Me.cmd07.Text = "7"
        Me.cmd07.UseVisualStyleBackColor = False
        '
        'cmd09
        '
        Me.cmd09.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmd09.FlatAppearance.BorderSize = 0
        Me.cmd09.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd09.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd09.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmd09.Location = New System.Drawing.Point(191, 365)
        Me.cmd09.Name = "cmd09"
        Me.cmd09.Size = New System.Drawing.Size(75, 75)
        Me.cmd09.TabIndex = 9
        Me.cmd09.Text = "9"
        Me.cmd09.UseVisualStyleBackColor = False
        '
        'cmd08
        '
        Me.cmd08.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmd08.FlatAppearance.BorderSize = 0
        Me.cmd08.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd08.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd08.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmd08.Location = New System.Drawing.Point(110, 365)
        Me.cmd08.Name = "cmd08"
        Me.cmd08.Size = New System.Drawing.Size(75, 75)
        Me.cmd08.TabIndex = 8
        Me.cmd08.Text = "8"
        Me.cmd08.UseVisualStyleBackColor = False
        '
        'cmdDiv
        '
        Me.cmdDiv.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdDiv.FlatAppearance.BorderSize = 0
        Me.cmdDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDiv.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdDiv.Location = New System.Drawing.Point(272, 365)
        Me.cmdDiv.Name = "cmdDiv"
        Me.cmdDiv.Size = New System.Drawing.Size(75, 75)
        Me.cmdDiv.TabIndex = 15
        Me.cmdDiv.Text = "/"
        Me.cmdDiv.UseVisualStyleBackColor = False
        '
        'cmdPercent
        '
        Me.cmdPercent.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdPercent.FlatAppearance.BorderSize = 0
        Me.cmdPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPercent.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPercent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdPercent.Location = New System.Drawing.Point(353, 365)
        Me.cmdPercent.Name = "cmdPercent"
        Me.cmdPercent.Size = New System.Drawing.Size(75, 75)
        Me.cmdPercent.TabIndex = 19
        Me.cmdPercent.Text = "%"
        Me.cmdPercent.UseVisualStyleBackColor = False
        '
        'cmd04
        '
        Me.cmd04.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmd04.FlatAppearance.BorderSize = 0
        Me.cmd04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd04.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd04.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmd04.Location = New System.Drawing.Point(29, 446)
        Me.cmd04.Name = "cmd04"
        Me.cmd04.Size = New System.Drawing.Size(75, 75)
        Me.cmd04.TabIndex = 4
        Me.cmd04.Text = "4"
        Me.cmd04.UseVisualStyleBackColor = False
        '
        'cmd06
        '
        Me.cmd06.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmd06.FlatAppearance.BorderSize = 0
        Me.cmd06.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd06.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd06.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmd06.Location = New System.Drawing.Point(191, 446)
        Me.cmd06.Name = "cmd06"
        Me.cmd06.Size = New System.Drawing.Size(75, 75)
        Me.cmd06.TabIndex = 6
        Me.cmd06.Text = "6"
        Me.cmd06.UseVisualStyleBackColor = False
        '
        'cmd05
        '
        Me.cmd05.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmd05.FlatAppearance.BorderSize = 0
        Me.cmd05.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd05.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd05.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmd05.Location = New System.Drawing.Point(110, 446)
        Me.cmd05.Name = "cmd05"
        Me.cmd05.Size = New System.Drawing.Size(75, 75)
        Me.cmd05.TabIndex = 5
        Me.cmd05.Text = "5"
        Me.cmd05.UseVisualStyleBackColor = False
        '
        'cmdMul
        '
        Me.cmdMul.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdMul.FlatAppearance.BorderSize = 0
        Me.cmdMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMul.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdMul.Location = New System.Drawing.Point(272, 446)
        Me.cmdMul.Name = "cmdMul"
        Me.cmdMul.Size = New System.Drawing.Size(75, 75)
        Me.cmdMul.TabIndex = 14
        Me.cmdMul.Text = "*"
        Me.cmdMul.UseVisualStyleBackColor = False
        '
        'cmdInv
        '
        Me.cmdInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdInv.FlatAppearance.BorderSize = 0
        Me.cmdInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdInv.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdInv.Location = New System.Drawing.Point(353, 446)
        Me.cmdInv.Name = "cmdInv"
        Me.cmdInv.Size = New System.Drawing.Size(75, 75)
        Me.cmdInv.TabIndex = 18
        Me.cmdInv.Text = "1/x"
        Me.cmdInv.UseVisualStyleBackColor = False
        '
        'cmd01
        '
        Me.cmd01.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmd01.FlatAppearance.BorderSize = 0
        Me.cmd01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd01.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmd01.Location = New System.Drawing.Point(29, 527)
        Me.cmd01.Name = "cmd01"
        Me.cmd01.Size = New System.Drawing.Size(75, 75)
        Me.cmd01.TabIndex = 1
        Me.cmd01.Text = "1"
        Me.cmd01.UseVisualStyleBackColor = False
        '
        'cmd03
        '
        Me.cmd03.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmd03.FlatAppearance.BorderSize = 0
        Me.cmd03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd03.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd03.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmd03.Location = New System.Drawing.Point(191, 527)
        Me.cmd03.Name = "cmd03"
        Me.cmd03.Size = New System.Drawing.Size(75, 75)
        Me.cmd03.TabIndex = 3
        Me.cmd03.Text = "3"
        Me.cmd03.UseVisualStyleBackColor = False
        '
        'cmd02
        '
        Me.cmd02.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmd02.FlatAppearance.BorderSize = 0
        Me.cmd02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd02.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd02.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmd02.Location = New System.Drawing.Point(110, 527)
        Me.cmd02.Name = "cmd02"
        Me.cmd02.Size = New System.Drawing.Size(75, 75)
        Me.cmd02.TabIndex = 2
        Me.cmd02.Text = "2"
        Me.cmd02.UseVisualStyleBackColor = False
        '
        'cmdMin
        '
        Me.cmdMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdMin.FlatAppearance.BorderSize = 0
        Me.cmdMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMin.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdMin.Location = New System.Drawing.Point(272, 527)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(75, 75)
        Me.cmdMin.TabIndex = 13
        Me.cmdMin.Text = "-"
        Me.cmdMin.UseVisualStyleBackColor = False
        '
        'cmd00
        '
        Me.cmd00.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmd00.FlatAppearance.BorderSize = 0
        Me.cmd00.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd00.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd00.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmd00.Location = New System.Drawing.Point(29, 608)
        Me.cmd00.Name = "cmd00"
        Me.cmd00.Size = New System.Drawing.Size(156, 75)
        Me.cmd00.TabIndex = 0
        Me.cmd00.Text = "0"
        Me.cmd00.UseVisualStyleBackColor = False
        '
        'cmdDecimal
        '
        Me.cmdDecimal.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdDecimal.FlatAppearance.BorderSize = 0
        Me.cmdDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDecimal.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDecimal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdDecimal.Location = New System.Drawing.Point(191, 608)
        Me.cmdDecimal.Name = "cmdDecimal"
        Me.cmdDecimal.Size = New System.Drawing.Size(75, 75)
        Me.cmdDecimal.TabIndex = 10
        Me.cmdDecimal.Text = "."
        Me.cmdDecimal.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdAdd.FlatAppearance.BorderSize = 0
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cmdAdd.Location = New System.Drawing.Point(272, 608)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 75)
        Me.cmdAdd.TabIndex = 12
        Me.cmdAdd.Text = "+"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdEquals
        '
        Me.cmdEquals.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cmdEquals.FlatAppearance.BorderSize = 0
        Me.cmdEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEquals.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEquals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.cmdEquals.Location = New System.Drawing.Point(353, 527)
        Me.cmdEquals.Name = "cmdEquals"
        Me.cmdEquals.Size = New System.Drawing.Size(75, 156)
        Me.cmdEquals.TabIndex = 20
        Me.cmdEquals.Text = "="
        Me.cmdEquals.UseVisualStyleBackColor = False
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.lblDisplay.Font = New System.Drawing.Font("Montserrat Alternates SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblDisplay.Location = New System.Drawing.Point(29, 83)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(399, 102)
        Me.lblDisplay.TabIndex = 2
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblSuperScript
        '
        Me.lblSuperScript.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.lblSuperScript.Font = New System.Drawing.Font("Montserrat Alternates SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperScript.Location = New System.Drawing.Point(29, 83)
        Me.lblSuperScript.Name = "lblSuperScript"
        Me.lblSuperScript.Size = New System.Drawing.Size(97, 20)
        Me.lblSuperScript.TabIndex = 3
        Me.lblSuperScript.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMemStatus
        '
        Me.lblMemStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.lblMemStatus.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemStatus.Location = New System.Drawing.Point(30, 150)
        Me.lblMemStatus.Name = "lblMemStatus"
        Me.lblMemStatus.Size = New System.Drawing.Size(28, 35)
        Me.lblMemStatus.TabIndex = 4
        Me.lblMemStatus.Text = "M"
        Me.lblMemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 715)
        Me.Controls.Add(Me.lblMemStatus)
        Me.Controls.Add(Me.lblSuperScript)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.cmdEquals)
        Me.Controls.Add(Me.cmdInv)
        Me.Controls.Add(Me.cmdPercent)
        Me.Controls.Add(Me.cmdSqrRoot)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdMin)
        Me.Controls.Add(Me.cmdMemMinus)
        Me.Controls.Add(Me.cmdMul)
        Me.Controls.Add(Me.cmdDiv)
        Me.Controls.Add(Me.cmdChangeSign)
        Me.Controls.Add(Me.cmd02)
        Me.Controls.Add(Me.cmdMemPlus)
        Me.Controls.Add(Me.cmd05)
        Me.Controls.Add(Me.cmd08)
        Me.Controls.Add(Me.cmdClearEntry)
        Me.Controls.Add(Me.cmdDecimal)
        Me.Controls.Add(Me.cmd03)
        Me.Controls.Add(Me.cmdMemRecall)
        Me.Controls.Add(Me.cmd06)
        Me.Controls.Add(Me.cmd09)
        Me.Controls.Add(Me.cmdClearAll)
        Me.Controls.Add(Me.cmd00)
        Me.Controls.Add(Me.cmd01)
        Me.Controls.Add(Me.cmdMemSave)
        Me.Controls.Add(Me.cmd04)
        Me.Controls.Add(Me.cmd07)
        Me.Controls.Add(Me.cmdBS)
        Me.Controls.Add(Me.cmdMemClear)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MaximizeBox = False
        Me.Name = "frmCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab 1&4: Calculator (Gabutero, Mercado, Puno)"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdMemClear As Button
    Friend WithEvents cmdMemRecall As Button
    Friend WithEvents cmdMemSave As Button
    Friend WithEvents cmdMemPlus As Button
    Friend WithEvents cmdMemMinus As Button
    Friend WithEvents cmdBS As Button
    Friend WithEvents cmdClearAll As Button
    Friend WithEvents cmdClearEntry As Button
    Friend WithEvents cmdChangeSign As Button
    Friend WithEvents cmdSqrRoot As Button
    Friend WithEvents cmd07 As Button
    Friend WithEvents cmd09 As Button
    Friend WithEvents cmd08 As Button
    Friend WithEvents cmdDiv As Button
    Friend WithEvents cmdPercent As Button
    Friend WithEvents cmd04 As Button
    Friend WithEvents cmd06 As Button
    Friend WithEvents cmd05 As Button
    Friend WithEvents cmdMul As Button
    Friend WithEvents cmdInv As Button
    Friend WithEvents cmd01 As Button
    Friend WithEvents cmd03 As Button
    Friend WithEvents cmd02 As Button
    Friend WithEvents cmdMin As Button
    Friend WithEvents cmd00 As Button
    Friend WithEvents cmdDecimal As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdEquals As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents lblSuperScript As Label
    Friend WithEvents lblMemStatus As Label
End Class
