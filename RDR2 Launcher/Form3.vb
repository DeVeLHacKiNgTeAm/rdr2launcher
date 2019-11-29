Public Class Form3

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ("C:\Program Files\Rockstar Games\RDR2\")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckBox1.Checked And CheckBox2.Checked = True Then
            Form4.Show()
            Form4.TextBox2.Text = ("Games Cracked Successfully + All Language And Win10 Optimizer")
        End If

        If CheckBox1.Checked = True And CheckBox2.Checked = False Then
            Form4.Show()
            Form4.TextBox2.Text = ("Games Cracked Successfully + All Language Support Added")
        End If

        If CheckBox1.Checked = False And CheckBox2.Checked = True Then
            Form4.Show()
            Form4.TextBox2.Text = ("Games Cracked Successfully + Win10 Optimizer Added")
        End If

        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            Form4.Show()
            Form4.TextBox2.Text = ("Games Cracked Successfully")
        End If

    End Sub
End Class