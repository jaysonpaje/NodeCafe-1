
Public Class frmBG

    Dim top_ As Integer = 7
    Dim left_ As Integer = 10

    Private Sub frmBG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer
        With clientPanel
            .Height = Me.Height
            .Width = Me.Width
            .Top = Me.Top + MDIMain.StatStrip.Height + 30
            .Left = Me.Left + 9
        End With
        For x = 1 To 20
            btn(x) = New System.Windows.Forms.Button()
            btn(x).Height = 85
            btn(x).Width = 78
            btn(x).TextAlign = ContentAlignment.BottomCenter
            btn(x).TextImageRelation = TextImageRelation.ImageAboveText
            btn(x).UseVisualStyleBackColor = True
            btn(x).Left = left_
            btn(x).Top = top_
            btn(x).Text = "PC " & x.ToString
            btn(x).ImageList = ImageList1
            btn(x).ImageIndex = 0

            clientPanel.Controls.Add(btn(x))
            btn_store.Add(New Store(btn(x).Text, x))
            AddHandler btn(x).Click, AddressOf ClickHandler
            'left = btn(x).Left
            If x > 0 Then
                If btn(x).Right >= Me.Width - (btn(x).Width + 10) Then
                    top_ = btn(x).Height + 12
                    left_ = 10
                Else
                    left_ += 80
                End If
            End If
        Next
        server_tcp_listen()

    End Sub
    Private Sub ClickHandler(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Click
        pc_name = sender.text
        MDIMain.txtelapse.Text = _elapseTime(btn_store.Find(AddressOf search_2).Index)
        'sqlSTR = "SELECT * " & _
        ' "FROM tbl_IN_clients " & _
        ' "LEFT JOIN tbl_OUT_clients ON tbl_IN_clients.in_id = tbl_OUT_clients.in_id " & _
        ' "WHERE pc_no =" & btn_store.Find(AddressOf search_2).Index & _
        ' " ORDER BY time_in DESC "
        'ExecuteSQLQuery(sqlSTR)
        'If sqlDr.Read Then
        '    If sqlDr("tbl_OUT_clients.in_id").ToString <> "" Then
        '        'btn(btn_store.Find(AddressOf search_2).Index).ImageIndex = 1
        '        MsgBox("here")
        '    Else

        '    End If
        'End If
        'MsgBox((38520 \ 60) \ 60)
        'MsgBox((38520 \ 60) Mod 60)

        'Dim minutes As Integer = 5100
        'Dim ts As New TimeSpan(2, 1, 60)
        'Dim s As String = String.Format("{0}:{0}", ts.TotalHours, ts.TotalMinutes)
    End Sub

    Private Sub lvClients_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        'Dim myItem As ListViewItem
        Dim myItems() As ListViewItem = e.Data.GetData("System.Windows.Forms.ListViewItem()")
        Dim i As Integer = 0
        ' lvClients.Items.Remove(lvClients.SelectedItems.Item(0))
        sender.items.add(myItems(0).Text, 0)
        'For Each myItem In myItems
        '    ' Add the item to the target list.
        '    sender.Items.Add(myItems(i).Text, 0)
        '    ' Remove the item from the source list.
        '    If sender Is lvClients Then
        '        lvClients.Items.Remove(lvClients.SelectedItems.Item(0))
        '    Else
        '        lvClients.Items.Remove(lvClients.SelectedItems.Item(0))
        '    End If
        '    i = i + 1
        'Next

    End Sub

    Private Sub lvClients_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        ' Check for the custom DataFormat ListViewItem array.
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub lvClients_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs)
        Dim myItem As ListViewItem
        Dim myItems(sender.SelectedItems.Count - 1) As ListViewItem
        Dim i As Integer = 0

        ' Loop though the SelectedItems collection for the source.
        For Each myItem In sender.SelectedItems
            ' Add the ListViewItem to the array of ListViewItems.
            myItems(i) = myItem
            i = i + 1
        Next
        ' Create a DataObject containg the array of ListViewItems.
        sender.DoDragDrop(New  _
        DataObject("System.Windows.Forms.ListViewItem()", myItems), _
        DragDropEffects.Move)
    End Sub
    Public Sub ReceiveDcClient(ByVal ThreadIndex As Integer, ByVal Counter As Integer)
        MsgBox(ThreadIndex & " " & Counter)
    End Sub
End Class