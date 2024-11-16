Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms
Imports BussnessLayerForDVLD


Namespace DVLD_Project
    Public Partial Class Form14
        Inherits Form
        Private _ClassID As Integer = 0
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form14_Load(sender As Object, e As EventArgs)
            Dim dt As DataTable = clsBussnesLayer.GetAllLocalLecinse()
            guna2DataGridView1.DataSource = dt
            cbFilters.Items.Add("None")
            guna2TextBox1.Visible = False
            cbFilters.SelectedIndex = 0
            For Each column As DataColumn In dt.Columns
                cbFilters.Items.Add(column.ColumnName)
            Next
        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            Dim form15 As Form15 = New Form15()
            form15.ShowDialog()
        End Sub

        Private Sub guna2TextBox1_TextChanged(sender As Object, e As EventArgs)
            If Equals(cbFilters.Text, "None") OrElse Equals(cbFilters.Text, "") Then

                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllLocalLecinse()
            ElseIf Equals(cbFilters.Text, "AppID_LocalDrivingLicense") OrElse Equals(cbFilters.Text, "NetionalNo") Then

                Dim Num = 0
                If Not Equals(guna2TextBox1.Text, "") Then
                    Integer.TryParse(guna2TextBox1.Text, Num)
                    If Num = 0 Then
                        guna2TextBox1.Text = ""
                    Else
                        guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFiltersL(Num, cbFilters.Text, "")
                    End If
                End If
            Else
                guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFiltersL(0, cbFilters.Text, guna2TextBox1.Text)
            End If
        End Sub

        Private Sub cbFilters_SelectedIndexChanged(sender As Object, e As EventArgs)
            If Equals(cbFilters.Text, "None") Then
                guna2TextBox1.Visible = False
                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllLocalLecinse()
            Else
                guna2TextBox1.Visible = True
            End If
        End Sub

        Private Sub changePassWordToolStripMenuItem_Click(sender As Object, e As EventArgs)
            clsBussnesLayer.CanselApp(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value))
        End Sub

        Private Sub toolStripMenuItem1_Click(sender As Object, e As EventArgs)
            Dim form17 As Form17 = New Form17(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value.ToString()), guna2DataGridView1.CurrentRow.Cells(1).Value.ToString(), Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(5).Value.ToString()), guna2DataGridView1.CurrentRow.Cells(2).Value.ToString())
            form17.ShowDialog()
        End Sub

        Private Sub toolStripMenuItem4_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub visonTestToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim ClassID = 0
            For Each c In guna2DataGridView1.CurrentRow.Cells(1).Value.ToString()
                Dim Text As String = c.ToString() & " "
                Integer.TryParse(Text, ClassID)
                If ClassID > 0 Then
                    _ClassID = ClassID
                    Exit For
                End If
            Next
            Dim form16 As Form16 = New Form16(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value.ToString()), guna2DataGridView1.CurrentRow.Cells(1).Value.ToString(), Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(5).Value.ToString()), guna2DataGridView1.CurrentRow.Cells(2).Value.ToString(), 1, Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value.ToString()), _ClassID)
            form16.ShowDialog()
        End Sub

        Private Sub contextMenuStrip2_Opening(sender As Object, e As CancelEventArgs)
            Dim TestsDone = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(5).Value)
            drivingTestToolStripMenuItem.Enabled = False
            writtenTestToolStripMenuItem.Enabled = False
            visonTestToolStripMenuItem.Enabled = False
            contextMenuStrip2.Items(5).Enabled = False
            contextMenuStrip2.Items(6).Enabled = False
            If TestsDone = 0 Then
                visonTestToolStripMenuItem.Enabled = True
            End If
            If TestsDone = 1 Then
                writtenTestToolStripMenuItem.Enabled = True
            ElseIf TestsDone = 2 Then

                drivingTestToolStripMenuItem.Enabled = True
            Else
                contextMenuStrip2.Items(5).Enabled = True
                contextMenuStrip2.Items(6).Enabled = True
            End If
        End Sub

        Private Sub writtenTestToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim ClassID = 0
            For Each c In guna2DataGridView1.CurrentRow.Cells(1).Value.ToString()
                Dim Text As String = c.ToString() & " "
                Integer.TryParse(Text, ClassID)
                If ClassID > 0 Then
                    _ClassID = ClassID
                    Exit For
                End If
            Next
            Dim form16 As Form16 = New Form16(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value.ToString()), guna2DataGridView1.CurrentRow.Cells(1).Value.ToString(), Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(5).Value.ToString()), guna2DataGridView1.CurrentRow.Cells(2).Value.ToString(), 2, Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value.ToString()), _ClassID)
            form16.ShowDialog()
        End Sub

        Private Sub drivingTestToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim ClassID = 0
            For Each c In guna2DataGridView1.CurrentRow.Cells(1).Value.ToString()
                Dim Text As String = c.ToString() & " "
                Integer.TryParse(Text, ClassID)
                If ClassID > 0 Then
                    _ClassID = ClassID
                    Exit For
                End If
            Next
            Dim form16 As Form16 = New Form16(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value.ToString()), guna2DataGridView1.CurrentRow.Cells(1).Value.ToString(), Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(5).Value.ToString()), guna2DataGridView1.CurrentRow.Cells(2).Value.ToString(), 3, Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value.ToString()), _ClassID)
            form16.ShowDialog()
        End Sub
    End Class
End Namespace
