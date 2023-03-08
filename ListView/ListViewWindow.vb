Public Class ListViewWindow
    Private Sub ListViewWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' To determine the equal width for every column
        Dim listViewWidth As Integer = DataListView.Width
        Dim columnWidth As Integer = listViewWidth / DataListView.Columns.Count

        ' Assign the width
        With DataListView.Columns
            For columnIndex As Integer = 0 To DataListView.Columns.Count - 1
                .Item(columnIndex).Width = columnWidth
            Next
        End With
    End Sub

    ' Show the MainWindow
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Me.Hide()
        MainWindow.Show()
    End Sub

    Private Sub DataListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListView.SelectedIndexChanged
        Dim textBoxes() As Object = {MainWindow.FirstNameTextBox, MainWindow.MiddleNameTextBox, MainWindow.LastNameTextBox,
                MainWindow.AgeTextBox, MainWindow.GenderComboBox}
        ' Is there an item selected ?
        If DataListView.SelectedItems.Count > 0 Then
            MainWindow.RowIndex = DataListView.SelectedItems(0).Index   ' Get the index
            ' Show the data to user
            For columnIndex As Integer = 0 To DataListView.Items(DataListView.SelectedIndices(0)).SubItems.Count - 2
                textBoxes(columnIndex).Text = DataListView.Items(DataListView.SelectedIndices(0)).SubItems.Item(columnIndex).Text
            Next
        End If
        DataListView.SelectedItems.Clear()  ' Clear the selection after getting the index
        Me.Hide()
        MainWindow.Show()
    End Sub

    Private Sub genderCount_Click(sender As Object, e As EventArgs) Handles genderCount.Click
        Dim mGender As Integer = 0
        Dim fGender As Integer = 0
        For i = 0 To DataListView.Items.Count - 1
            If DataListView.Items(i).SubItems(4).Text = "Female" Then
                fGender += 1
            Else
                mGender += 1
            End If
        Next
        MsgBox("Female: " & fGender & " Male: " & mGender)
    End Sub
End Class
