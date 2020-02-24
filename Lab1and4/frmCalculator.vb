Imports MaterialSkin

Public Class frmCalculator

    Dim inputLength As Integer
    Dim charLimit As Integer = 16
    Dim opFlag As Boolean = False
    Dim eqFlag As Boolean = False
    Dim funcFlag As Boolean = False
    Dim firstTerm, secondTerm, memory As Double
    Dim activeOp As Integer = 0
    Dim lastOp As Integer = 0
    Dim startFlag As Boolean = False
    Dim opCharArray() As Char = {"", "+", "-", "*", "/"}

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.Green900, Primary.LightBlue600, Accent.Yellow100, TextShade.WHITE)

        frmNotepad.Show()





    End Sub

    Public Sub cmdButtonClick(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub numClick(index As Integer)
        If opFlag = True Then
            If index = 11 Then
                Beep()
                Exit Sub
            Else
                lblDisplay.Text = ""
                opFlag = False
            End If
        End If

        If eqFlag = True Then
            eqFlag = False
            lblDisplay.Text = ""
        End If

        If funcFlag = True Then
            funcFlag = False
            lblDisplay.Text = ""
        End If

        inputLength = Len(lblDisplay.Text)

        If index = 11 Then
            Dim strLen = Len(lblDisplay.Text)
            If strLen > 1 Then
                lblDisplay.Text = Mid(lblDisplay.Text, 1, strLen - 1)
            Else
                lblDisplay.Text = "0"
            End If
            Exit Sub
        End If

        If index = 10 Then
            If InStr(1, lblDisplay.Text, ".") = 0 Then
                lblDisplay.Text &= "."
                If Microsoft.VisualBasic.Left(lblDisplay.Text, 1) = "0" Then
                    charLimit = 18
                Else
                    charLimit = 17
                End If
            End If
            Exit Sub
        End If

        If inputLength >= charLimit Then
            Exit Sub
        ElseIf inputLength = 1 Then
            If lblDisplay.Text = "0" Then
                If index = 0 Then
                    Exit Sub
                Else
                    lblDisplay.Text = index
                End If
            Else
                lblDisplay.Text &= index
            End If
        Else
            lblDisplay.Text &= index
        End If
    End Sub

    Sub opClick(index As Integer)
        If opFlag = True Then
            lastOp = index
            lblSuperScript.Text = lblDisplay.Text & " " & opCharArray(index)
            Exit Sub
        Else
            opFlag = True
            activeOp = lastOp
            lastOp = index
            If startFlag = False Then
                firstTerm = CDbl(lblDisplay.Text)
                startFlag = True
            Else
                secondTerm = CDbl(lblDisplay.Text)
                Select Case activeOp
                    Case 1
                        firstTerm += secondTerm
                    Case 2
                        firstTerm -= secondTerm
                    Case 3
                        firstTerm *= secondTerm
                    Case 4
                        firstTerm /= secondTerm
                End Select
                lblDisplay.Text = firstTerm
            End If
            lblSuperScript.Text = lblDisplay.Text & " " & opCharArray(index)
        End If
    End Sub

    Sub funcClick(index As Integer)
        Select Case index
            Case 1
                lblDisplay.Text = -CDbl(lblDisplay.Text)
                funcFlag = True
            Case 2
                lblDisplay.Text = Math.Sqrt(CDbl(lblDisplay.Text))
                funcFlag = True
            Case 3
                lblDisplay.Text = 1 / CDbl(lblDisplay.Text)
                funcFlag = True
            Case 4
                Dim percentage As Double
                percentage = CDbl(lblDisplay.Text)
                lblDisplay.Text = firstTerm * percentage / 100
                funcFlag = True
        End Select
    End Sub

    Sub evaluate()
        Dim result As Double
        If startFlag = False Then
            Exit Sub
        Else
            activeOp = lastOp
            secondTerm = CDbl(lblDisplay.Text)
            Select Case activeOp
                Case 1
                    result = firstTerm + secondTerm
                Case 2
                    result = firstTerm - secondTerm
                Case 3
                    result = firstTerm * secondTerm
                Case 4
                    result = firstTerm / secondTerm
            End Select
            clearAll()
            lblDisplay.Text = result
            eqFlag = True
        End If
    End Sub

    Sub clearAll()
        inputLength = 0
        charLimit = 16
        opFlag = False
        firstTerm = 0
        secondTerm = 0
        activeOp = 0
        lastOp = 0
        startFlag = False
        lblDisplay.Text = "0"
        lblSuperScript.Text = ""
    End Sub

    Private Sub cmdButton_Click(sender As Object, e As EventArgs) _
  Handles cmd00.Click, cmd01.Click, cmd02.Click, cmd03.Click, cmd04.Click,
  cmd05.Click, cmd06.Click, cmd07.Click, cmd08.Click, cmd09.Click,
  cmdDecimal.Click, cmdBS.Click, cmdAdd.Click, cmdMin.Click, cmdMul.Click,
  cmdDiv.Click, cmdChangeSign.Click, cmdSqrRoot.Click, cmdInv.Click,
  cmdPercent.Click, cmdEquals.Click, cmdClearAll.Click, cmdClearEntry.Click,
  cmdMemSave.Click, cmdMemClear.Click, cmdMemRecall.Click, cmdMemPlus.Click,
  cmdMemMinus.Click

        Select Case sender.TabIndex
            Case 0 To 11
                numClick(sender.TabIndex)
            Case 12 To 15
                opClick(sender.TabIndex - 11)
            Case 16 To 19
                funcClick(sender.TabIndex - 15)
            Case 20
                evaluate()
            Case 21
                clearAll()
            Case 22
                lblDisplay.Text = "0"
            Case 23
                memory = CDbl(lblDisplay.Text)
                If memory <> 0 Then
                    lblMemStatus.Visible = True
                Else
                    lblMemStatus.Visible = False
                End If
            Case 24
                memory = 0
                lblMemStatus.Visible = False
            Case 25
                lblDisplay.Text = memory
            Case 26
                memory += CDbl(lblDisplay.Text)
                If memory = 0 Then
                    lblMemStatus.Visible = False
                Else
                    lblMemStatus.Visible = True
                End If
            Case 27
                memory -= CDbl(lblDisplay.Text)
                If memory = 0 Then
                    lblMemStatus.Visible = False
                Else
                    lblMemStatus.Visible = True
                End If
        End Select
    End Sub



End Class
