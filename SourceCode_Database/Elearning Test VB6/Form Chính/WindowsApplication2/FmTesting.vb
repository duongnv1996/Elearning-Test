Imports System.Data.SqlClient

Public Class FmTesting
    Private heightPanel As Integer = 200
    Private subject As String
    Private numberOfQuest As Integer = 20
    Private marginSize As Integer = 5
    Private con As New SqlConnection("Data Source=MAYTINH-JRUTQDS;Initial Catalog=db_question;Integrated Security=True")



    Private Function getItem(quest As ItemQuest, ans As ItemAnswer) As Panel
        Dim panelItem As New Panel
        Dim content_quest As New Label
        content_quest.Size = New Size(1000, 20)
        panelItem.Size = New Size(1000, heightPanel)
        content_quest.Location = New Point(10, 10)
        content_quest.Text = quest.contentQuest & "000"
        panelItem.Controls.Add(content_quest)

        Dim rbA As New RadioButton
        rbA.Size = New Size(1000, 20)
        rbA.Location = New Point(20, 40 + marginSize)
        rbA.Text = quest.contentQuest & "111"
        panelItem.Controls.Add(rbA)
        'content_quest1.Location = New Point(100, 60 + marginSize)
        'panelItem.Controls.Add(content_quest1)
        'content_quest1.Location = New Point(100, 80 + marginSize)
        'panelItem.Controls.Add(content_quest1)


        Dim rbB As New RadioButton
        rbB.Size = New Size(1000, 20)
        rbB.Location = New Point(20, 60 + marginSize)
        rbB.Text = quest.contentQuest & "222"
        panelItem.Controls.Add(rbB)

        Dim rbC As New RadioButton
        rbC.Size = New Size(1000, 20)
        rbC.Location = New Point(20, 80 + marginSize)
        rbC.Text = quest.contentQuest & "333"
        panelItem.Controls.Add(rbC)

        Dim rbD As New RadioButton
        rbD.Size = New Size(1000, 20)
        rbD.Location = New Point(20, 100 + marginSize)
        rbD.Text = quest.contentQuest & "444"
        panelItem.Controls.Add(rbD)
        Return panelItem


    End Function
    Private Sub FmTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Size = New Size(Width, heightPanel * numberOfQuest)
        For i As Integer = 0 To numberOfQuest
            Dim ans As New ItemAnswer
            Dim quest As New ItemQuest
            quest.contentQuest = i & "  amsoid asdsad asd asd as sad as  sadsada samsoid asdsad asd asd as sad as  sadsada samsoid asdsad asd asd as sad as  sadsada samsoid asdsad asd asd as sad as  sadsada s"
            Dim panelItem = getItem(quest, ans)
            panelItem.Location = New Point(10, i * heightPanel + marginSize * i)
            Me.Panel2.Controls.Add(panelItem)
        Next i
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)
        'Me.Panel2.Top = -Me.VScrollBar1.Value()
        'Me.VScrollBar1.Maximum = Me.Panel2.Size.Height - Me.Panel1.Size.Height
    End Sub


    Private Sub btnNopBai_Click(sender As Object, e As EventArgs) Handles btnNopBai.Click
        MsgBox(Panel2.Controls.Item(1).Text)


    End Sub
End Class