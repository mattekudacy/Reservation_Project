Public Class Form1
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox3.Text = DateTimePicker1.Text
        TextBox4.Text = DateTimePicker2.Text
        


    End Sub

    Private Sub ProptableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProptableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProptableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PropDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PropDataSet.Proptable' table. You can move, or remove it, as needed.
        Me.ProptableTableAdapter.Fill(Me.PropDataSet.Proptable)
        Me.ProptableBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ProptableBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ProptableBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ProptableBindingSource.AddNew()
        Me.ProptableBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        Me.ProptableBindingSource.EndEdit()
        Me.ProptableTableAdapter.Update(Me.PropDataSet.Proptable)
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ProptableBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.ProptableBindingSource.Filter = "[Item Borrowed] LIKE '%" & TextBox6.Text & "%'"
    End Sub
End Class
