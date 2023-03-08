<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListViewWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataListView = New System.Windows.Forms.ListView()
        Me.FirstNameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MiddleNameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LastNameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AgeHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GenderHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResultHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OkButton = New System.Windows.Forms.Button()
        Me.genderCount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DataListView
        '
        Me.DataListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FirstNameHeader, Me.MiddleNameHeader, Me.LastNameHeader, Me.AgeHeader, Me.GenderHeader, Me.ResultHeader})
        Me.DataListView.FullRowSelect = True
        Me.DataListView.GridLines = True
        Me.DataListView.HideSelection = False
        Me.DataListView.Location = New System.Drawing.Point(48, 34)
        Me.DataListView.MultiSelect = False
        Me.DataListView.Name = "DataListView"
        Me.DataListView.Size = New System.Drawing.Size(690, 361)
        Me.DataListView.TabIndex = 0
        Me.DataListView.UseCompatibleStateImageBehavior = False
        Me.DataListView.View = System.Windows.Forms.View.Details
        '
        'FirstNameHeader
        '
        Me.FirstNameHeader.Text = "First Name"
        Me.FirstNameHeader.Width = 112
        '
        'MiddleNameHeader
        '
        Me.MiddleNameHeader.Text = "Middle Name"
        Me.MiddleNameHeader.Width = 112
        '
        'LastNameHeader
        '
        Me.LastNameHeader.Text = "Last Name"
        Me.LastNameHeader.Width = 112
        '
        'AgeHeader
        '
        Me.AgeHeader.Text = "Age"
        Me.AgeHeader.Width = 112
        '
        'GenderHeader
        '
        Me.GenderHeader.Text = "Gender"
        Me.GenderHeader.Width = 112
        '
        'ResultHeader
        '
        Me.ResultHeader.Text = "Result"
        Me.ResultHeader.Width = 112
        '
        'OkButton
        '
        Me.OkButton.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkButton.Location = New System.Drawing.Point(648, 405)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(90, 33)
        Me.OkButton.TabIndex = 12
        Me.OkButton.Text = "Ok"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'genderCount
        '
        Me.genderCount.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderCount.Location = New System.Drawing.Point(514, 405)
        Me.genderCount.Name = "genderCount"
        Me.genderCount.Size = New System.Drawing.Size(90, 33)
        Me.genderCount.TabIndex = 13
        Me.genderCount.Text = "Gender"
        Me.genderCount.UseVisualStyleBackColor = True
        '
        'ListViewWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 450)
        Me.Controls.Add(Me.genderCount)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.DataListView)
        Me.Name = "ListViewWindow"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of People"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataListView As Windows.Forms.ListView
    Friend WithEvents FirstNameHeader As ColumnHeader
    Friend WithEvents MiddleNameHeader As ColumnHeader
    Friend WithEvents LastNameHeader As ColumnHeader
    Friend WithEvents AgeHeader As ColumnHeader
    Friend WithEvents GenderHeader As ColumnHeader
    Friend WithEvents ResultHeader As ColumnHeader
    Friend WithEvents OkButton As Button
    Friend WithEvents genderCount As Button
End Class
