Public Class Form1
    Dim ctr As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LineShape3.Visible = True
        If Not (IsNumeric(TextBox1.Text)) Then
            Label9.Text = "INVALID INPUT!"
            TextBox1.Text = ""
            LineShape3.Visible = True
        Else
            Label9.Text = ""
            If ctr = 5 Then

                Label9.Text = "FULL!"
                Button1.Enabled = False
            Else
                ctr = ctr + 1
                L(5 - ctr).Text = TextBox1.Text
                L(5 - ctr).Visible = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Label9.Text = ""
            If ctr = 0 Then
                Label9.Text = "EMPTY!"
            LineShape3.Visible = True
        Else
            LineShape3.Visible = False
            For I = 6 To ctr - 2
                L(I).Text = L(I + 1).Text
            Next I
            L(5 - ctr).Text = ""
            L(5 - ctr).Visible = False
            ctr = ctr - 1
            Button1.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        TextBox1.Text = ""
        Label9.Text = ""
        ctr = 0
        Button1.Enabled = True

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If (IsNumeric(TextBox1.Text)) Then
            LineShape3.Visible = False
        Else
            LineShape3.Visible = True
        End If



        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        LineShape3.Visible = True
        If Label5.Text = "" Then
            Label9.Text = "NONE!"
        Else
            Label9.Text = "Peek : " + (Label5.Text)
        End If
    End Sub
End Class
