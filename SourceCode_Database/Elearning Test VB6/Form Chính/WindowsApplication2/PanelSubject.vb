Imports System.Runtime.InteropServices
Imports System.Globalization

Public Class PanelSubject
    Private _subject As New SubjectItem
    Private iClickSubject As IClickSubject
    Dim x As Integer = 0
    Public Property IClick() As IClickSubject
        Get
            Return iClickSubject
        End Get
        Set(value As IClickSubject)
            iClickSubject = value
        End Set
    End Property
    Public Property Subject() As SubjectItem
        Get
            Return _subject
        End Get
        Set(value As SubjectItem)
            _subject = value
        End Set
    End Property
    Private Sub PanelSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' btnSubject.Size = New Size(Width / 5, Height / 5)
        btnSubject.Text = _subject.name
        If (IsNothing(_subject.dayTest) = False AndAlso _subject.dayTest.Equals("") = False) Then
            Dim date_test As Date = Date.Parse(_subject.dayTest)
            Dim diff As Long = DateDiff(DateInterval.Hour, Date.Now, date_test)
            ' diff = Math.Round(diff / 24)
            If diff > 0 AndAlso diff < 24 Then
                lbDay.Text = 1       
            ElseIf diff > 24 Then
                Dim dayInt As Integer = diff / 24
                Dim hour As Double = diff Mod 24
                If hour > 0 Then
                    dayInt = dayInt + 1

                End If
                lbDay.Text = dayInt
            ElseIf diff = 0 Then
               
            ElseIf diff <= 0 AndAlso diff > -24 Then

                lbDay.Visible = False
                pic.Visible = True
            Else
                lbDay.Visible = False
            End If
        Else
            lbDay.Visible = False
           
        End If


    End Sub


    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        iClickSubject.ClickSubject(_subject)
    End Sub


End Class
