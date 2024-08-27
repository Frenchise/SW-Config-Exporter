Public Class Error_Message
    Private _passedText As String
    Private _passedValue As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _passedText = Nothing Then
            Message_Text.Text = "No Model is Loaded"
        Else
            If PassedValue = 0 Then
                Message_Text.Text = PassedText
            Else
                Message_Text.Text = PassedValue & PassedText
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Okay.Click
        Me.Close()
    End Sub

    Public Property [PassedText]() As String
        Get
            Return _passedText
        End Get
        Set(ByVal Value As String)
            _passedText = Value
        End Set
    End Property

    Public Property [PassedValue]() As String
        Get
            Return _passedValue
        End Get
        Set(ByVal Value As String)
            _passedValue = Value
        End Set
    End Property

    Private Sub Message_Text_TextChanged(sender As Object, e As EventArgs) Handles Message_Text.TextChanged

    End Sub
End Class