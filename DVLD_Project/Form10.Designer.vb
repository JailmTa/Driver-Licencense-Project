Namespace DVLD_Project
    Partial Class Form10
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim dataGridViewCellStyle1 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
            label1 = New Windows.Forms.Label()
            contextMenuStrip1 = New Windows.Forms.ContextMenuStrip(components)
            upDateToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            pictureBox1 = New Windows.Forms.PictureBox()
            CType(guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
            contextMenuStrip1.SuspendLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' guna2DataGridView1
            ' 
            guna2DataGridView1.AllowUserToAddRows = False
            guna2DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle1.BackColor = Drawing.Color.White
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
            guna2DataGridView1.AutoSizeColumnsMode = Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            guna2DataGridView1.BackgroundColor = Drawing.Color.White
            guna2DataGridView1.BorderStyle = Windows.Forms.BorderStyle.None
            guna2DataGridView1.CellBorderStyle = Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            guna2DataGridView1.ColumnHeadersBorderStyle = Windows.Forms.DataGridViewHeaderBorderStyle.None
            dataGridViewCellStyle2.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle2.BackColor = Drawing.Color.FromArgb(100, 88, 255)
            dataGridViewCellStyle2.Font = New Drawing.Font("Segoe UI", 10.5F)
            dataGridViewCellStyle2.ForeColor = Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = Drawing.SystemColors.Highlight
            dataGridViewCellStyle2.SelectionForeColor = Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = Windows.Forms.DataGridViewTriState.True
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            guna2DataGridView1.ColumnHeadersHeight = 40
            dataGridViewCellStyle3.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = Drawing.Color.White
            dataGridViewCellStyle3.Font = New Drawing.Font("Segoe UI", 10.5F)
            dataGridViewCellStyle3.ForeColor = Drawing.Color.FromArgb(71, 69, 94)
            dataGridViewCellStyle3.SelectionBackColor = Drawing.Color.FromArgb(231, 229, 255)
            dataGridViewCellStyle3.SelectionForeColor = Drawing.Color.FromArgb(71, 69, 94)
            dataGridViewCellStyle3.WrapMode = Windows.Forms.DataGridViewTriState.False
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3
            guna2DataGridView1.EnableHeadersVisualStyles = False
            guna2DataGridView1.GridColor = Drawing.Color.FromArgb(231, 229, 255)
            guna2DataGridView1.Location = New Drawing.Point(37, 325)
            guna2DataGridView1.Name = "guna2DataGridView1"
            guna2DataGridView1.ReadOnly = True
            guna2DataGridView1.RowHeadersVisible = False
            guna2DataGridView1.RowHeadersWidth = 51
            guna2DataGridView1.RowTemplate.Height = 24
            guna2DataGridView1.SelectionMode = Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            guna2DataGridView1.Size = New Drawing.Size(1031, 379)
            guna2DataGridView1.TabIndex = 18
            guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Drawing.Color.White
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Drawing.Color.Empty
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Drawing.Color.Empty
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Drawing.Color.Empty
            guna2DataGridView1.ThemeStyle.BackColor = Drawing.Color.White
            guna2DataGridView1.ThemeStyle.GridColor = Drawing.Color.FromArgb(231, 229, 255)
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Drawing.Color.FromArgb(100, 88, 255)
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = Windows.Forms.DataGridViewHeaderBorderStyle.None
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Drawing.Font("Segoe UI", 10.5F)
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Drawing.Color.White
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40
            guna2DataGridView1.ThemeStyle.ReadOnly = True
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Drawing.Color.White
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Drawing.Font("Segoe UI", 10.5F)
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Drawing.Color.FromArgb(71, 69, 94)
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Drawing.Color.FromArgb(231, 229, 255)
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Drawing.Color.FromArgb(71, 69, 94)
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label1.Location = New Drawing.Point(433, 203)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(227, 36)
            label1.TabIndex = 17
            label1.Text = "Maneage Types"
            ' 
            ' contextMenuStrip1
            ' 
            contextMenuStrip1.ImageScalingSize = New Drawing.Size(20, 20)
            contextMenuStrip1.Items.AddRange(New Windows.Forms.ToolStripItem() {upDateToolStripMenuItem})
            contextMenuStrip1.Name = "contextMenuStrip1"
            contextMenuStrip1.Size = New Drawing.Size(215, 58)
            ' 
            ' upDateToolStripMenuItem
            ' 
            upDateToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_update_file_64
            upDateToolStripMenuItem.Name = "upDateToolStripMenuItem"
            upDateToolStripMenuItem.Size = New Drawing.Size(214, 26)
            upDateToolStripMenuItem.Text = "UpDate"
            AddHandler upDateToolStripMenuItem.Click, New EventHandler(AddressOf upDateToolStripMenuItem_Click)
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = Global.DVLD_Project.Properties.Resources.icons8_cloud_document_64
            pictureBox1.Location = New Drawing.Point(350, 12)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(404, 173)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 16
            pictureBox1.TabStop = False
            ' 
            ' Form10
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(1105, 716)
            ContextMenuStrip = contextMenuStrip1
            Controls.Add(guna2DataGridView1)
            Controls.Add(label1)
            Controls.Add(pictureBox1)
            Name = "Form10"
            Text = "Form10"
            AddHandler Load, New EventHandler(AddressOf Form10_Load)
            CType(guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
            contextMenuStrip1.ResumeLayout(False)
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
        Private label1 As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private contextMenuStrip1 As Windows.Forms.ContextMenuStrip
        Private upDateToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    End Class
End Namespace
