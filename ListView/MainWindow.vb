Public Class MainWindow

    Private _rowIndex As Integer = -1

    Public Property RowIndex() As Integer
        Get
            Return _rowIndex
        End Get
        Set(value As Integer)
            _rowIndex = value
        End Set
    End Property

    Private Function checkAge(ByVal gender As String, ByVal age As Integer) As String
        If gender = My.Resources.MaleGender Then
            If age < 18 Then
                Return My.Resources.YMAResult
            ElseIf age > 17 AndAlso age < 40 Then
                Return My.Resources.YMAResult
            ElseIf age > 39 AndAlso age < 60 Then
                Return My.Resources.AMResult
            Else
                Return My.Resources.OMResult
            End If
        Else
            If age < 18 Then
                Return My.Resources.YLResult
            ElseIf age > 17 AndAlso age < 40 Then
                Return My.Resources.YLAResult
            ElseIf age > 39 AndAlso age < 60 Then
                Return My.Resources.AWResult
            Else
                Return My.Resources.OWResult
            End If
        End If
    End Function

    Private Sub ClickEvents(sender As Object, e As EventArgs) Handles SaveButton.Click, ShowListButton.Click, UpdateButton.Click, DeleteButton.Click
        Dim textBoxes() As Object = {FirstNameTextBox, MiddleNameTextBox, LastNameTextBox, AgeTextBox, GenderComboBox}
        If sender.Equals(SaveButton) Then
            Dim rowCount As Integer = ListViewWindow.DataListView.Items.Count       ' Which row should we add the next data?

            ' Is there any empty field in textboxes ?
            If textBoxes.Any(Function(x) String.IsNullOrEmpty(x.Text)) Then
                MsgBox(My.Resources.EmptyFields)    ' Show the user there's an empty field
            Else
                ' Add all the data to the list view
                For Each textBox As Object In textBoxes
                    If textBox.Equals(FirstNameTextBox) Then
                        ListViewWindow.DataListView.Items.Add(textBox.Text)
                    Else
                        ListViewWindow.DataListView.Items(rowCount).SubItems.Add(textBox.Text)
                    End If
                Next
                ListViewWindow.DataListView.Items(rowCount).SubItems.Add(checkAge(GenderComboBox.Text, AgeTextBox.Text))
                ' Empty all the textboxes
                For Each textBox As Object In textBoxes
                    textBox.Text = Nothing
                Next
                Me.Hide()
                ListViewWindow.Show()
            End If
        ElseIf sender.Equals(UpdateButton) Then
            ' Is there any selected row?
            If _rowIndex <> -1 Then
                ' Update the selected row in the list view
                Dim columnCount As Integer = ListViewWindow.DataListView.Items(_rowIndex).SubItems.Count
                For columnIndex As Integer = 0 To columnCount - 2
                    ListViewWindow.DataListView.Items(_rowIndex).SubItems(columnIndex).Text = textBoxes(columnIndex).Text
                Next
                ListViewWindow.DataListView.Items(_rowIndex).SubItems(columnCount - 1).Text = checkAge(GenderComboBox.Text, AgeTextBox.Text)
                For Each textBox As Object In textBoxes
                    textBox.Text = Nothing
                Next
                Me.Hide()
                ListViewWindow.Show()
            Else
                MsgBox(My.Resources.InvalidUpdateText, MsgBoxStyle.Critical, My.Resources.InvalidUpdateTitle)
            End If
        ElseIf sender.Equals(ShowListButton) Then
            Me.Hide()
            ListViewWindow.Show()
        Else
            ' Is there any selected row?
            If _rowIndex <> -1 Then
                ' Delete the selected row from the list view
                ListViewWindow.DataListView.Items.RemoveAt(_rowIndex)
                For Each textBox As Object In textBoxes
                    textBox.Text = Nothing
                Next
                Me.Hide()
                ListViewWindow.Show()
            Else
                MsgBox(My.Resources.InvalidDeleteText, MsgBoxStyle.Critical, My.Resources.InvalidDeleteTitle)
            End If
        End If
        _rowIndex = -1      ' There is no selected row
    End Sub

End Class