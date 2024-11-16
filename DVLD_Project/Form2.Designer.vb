Namespace DVLD_Project
    Partial Class Form2
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
            label1 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
            guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
            cbFilters = New Guna.UI2.WinForms.Guna2ComboBox()
            contextMenuStrip1 = New Windows.Forms.ContextMenuStrip(components)
            showInformationsToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            editePersonToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            deleteToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            addPersonToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            sendEmailToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            callToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            pictureBox1 = New Windows.Forms.PictureBox()
            CType(guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
            contextMenuStrip1.SuspendLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label1.Location = New Drawing.Point(433, 203)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(239, 36)
            label1.TabIndex = 2
            label1.Text = "Maneage People"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Font = New Drawing.Font("Modern No. 20", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label2.Location = New Drawing.Point(59, 264)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(56, 22)
            label2.TabIndex = 9
            label2.Text = "Filter"
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
            guna2DataGridView1.TabIndex = 8
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
            ' guna2TextBox1
            ' 
            guna2TextBox1.AutoRoundedCorners = True
            guna2TextBox1.BorderColor = Drawing.Color.FromArgb(255, 128, 128)
            guna2TextBox1.BorderRadius = 16
            guna2TextBox1.Cursor = Windows.Forms.Cursors.IBeam
            guna2TextBox1.DefaultText = ""
            guna2TextBox1.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            guna2TextBox1.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            guna2TextBox1.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            guna2TextBox1.DisabledState.Parent = guna2TextBox1
            guna2TextBox1.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            guna2TextBox1.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            guna2TextBox1.FocusedState.Parent = guna2TextBox1
            guna2TextBox1.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            guna2TextBox1.HoverState.Parent = guna2TextBox1
            guna2TextBox1.Location = New Drawing.Point(405, 258)
            guna2TextBox1.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            guna2TextBox1.Name = "guna2TextBox1"
            guna2TextBox1.PasswordChar = ChrW(0)
            guna2TextBox1.PlaceholderText = ""
            guna2TextBox1.SelectedText = ""
            guna2TextBox1.ShadowDecoration.Parent = guna2TextBox1
            guna2TextBox1.Size = New Drawing.Size(267, 35)
            guna2TextBox1.TabIndex = 6
            AddHandler guna2TextBox1.TextChanged, New EventHandler(AddressOf guna2TextBox1_TextChanged)
            ' 
            ' cbFilters
            ' 
            cbFilters.BackColor = Drawing.Color.Transparent
            cbFilters.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            cbFilters.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cbFilters.FocusedColor = Drawing.Color.Empty
            cbFilters.FocusedState.Parent = cbFilters
            cbFilters.Font = New Drawing.Font("Segoe UI", 10F)
            cbFilters.ForeColor = Drawing.Color.FromArgb(68, 88, 112)
            cbFilters.FormattingEnabled = True
            cbFilters.HoverState.Parent = cbFilters
            cbFilters.ItemHeight = 30
            cbFilters.ItemsAppearance.Parent = cbFilters
            cbFilters.Location = New Drawing.Point(135, 257)
            cbFilters.Name = "cbFilters"
            cbFilters.ShadowDecoration.Parent = cbFilters
            cbFilters.Size = New Drawing.Size(263, 36)
            cbFilters.TabIndex = 5
            AddHandler cbFilters.SelectedIndexChanged, New EventHandler(AddressOf cbFilters_SelectedIndexChanged)
            ' 
            ' contextMenuStrip1
            ' 
            contextMenuStrip1.ImageScalingSize = New Drawing.Size(20, 20)
            contextMenuStrip1.Items.AddRange(New Windows.Forms.ToolStripItem() {showInformationsToolStripMenuItem, editePersonToolStripMenuItem, deleteToolStripMenuItem, addPersonToolStripMenuItem, sendEmailToolStripMenuItem, callToolStripMenuItem})
            contextMenuStrip1.Name = "contextMenuStrip1"
            contextMenuStrip1.Size = New Drawing.Size(215, 188)
            ' 
            ' showInformationsToolStripMenuItem
            ' 
            showInformationsToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_info_64
            showInformationsToolStripMenuItem.Name = "showInformationsToolStripMenuItem"
            showInformationsToolStripMenuItem.Size = New Drawing.Size(214, 26)
            showInformationsToolStripMenuItem.Text = "ShowInformations"
            AddHandler showInformationsToolStripMenuItem.Click, New EventHandler(AddressOf showInformationsToolStripMenuItem_Click)
            ' 
            ' editePersonToolStripMenuItem
            ' 
            editePersonToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_edit_64
            editePersonToolStripMenuItem.Name = "editePersonToolStripMenuItem"
            editePersonToolStripMenuItem.Size = New Drawing.Size(214, 26)
            editePersonToolStripMenuItem.Text = "Edite"
            AddHandler editePersonToolStripMenuItem.Click, New EventHandler(AddressOf editePersonToolStripMenuItem_Click)
            ' 
            ' deleteToolStripMenuItem
            ' 
            deleteToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_delete_64
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem"
            deleteToolStripMenuItem.Size = New Drawing.Size(214, 26)
            deleteToolStripMenuItem.Text = "Delete"
            AddHandler deleteToolStripMenuItem.Click, New EventHandler(AddressOf deleteToolStripMenuItem_Click)
            ' 
            ' addPersonToolStripMenuItem
            ' 
            addPersonToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_add_male_user_64
            addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem"
            addPersonToolStripMenuItem.Size = New Drawing.Size(214, 26)
            addPersonToolStripMenuItem.Text = "AddPerson"
            ' 
            ' sendEmailToolStripMenuItem
            ' 
            sendEmailToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_sent_64
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem"
            sendEmailToolStripMenuItem.Size = New Drawing.Size(214, 26)
            sendEmailToolStripMenuItem.Text = "SendEmail"
            ' 
            ' callToolStripMenuItem
            ' 
            callToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_online_support_64
            callToolStripMenuItem.Name = "callToolStripMenuItem"
            callToolStripMenuItem.Size = New Drawing.Size(214, 26)
            callToolStripMenuItem.Text = "Call"
            ' 
            ' guna2Button1
            ' 
            guna2Button1.CheckedState.Parent = guna2Button1
            guna2Button1.CustomImages.Parent = guna2Button1
            guna2Button1.FillColor = Drawing.Color.Transparent
            guna2Button1.Font = New Drawing.Font("Segoe UI", 9F)
            guna2Button1.ForeColor = Drawing.SystemColors.Window
            guna2Button1.HoverState.Parent = guna2Button1
            guna2Button1.Image = Global.DVLD_Project.Properties.Resources.icons8_add_male_user_64
            guna2Button1.ImageSize = New Drawing.Size(64, 64)
            guna2Button1.Location = New Drawing.Point(993, 254)
            guna2Button1.Name = "guna2Button1"
            guna2Button1.ShadowDecoration.Parent = guna2Button1
            guna2Button1.Size = New Drawing.Size(75, 65)
            guna2Button1.TabIndex = 7
            AddHandler guna2Button1.Click, New EventHandler(AddressOf guna2Button1_Click)
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = Global.DVLD_Project.Properties.Resources.icons8_nation_100
            pictureBox1.Location = New Drawing.Point(350, 12)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(404, 172)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 0
            pictureBox1.TabStop = False
            ' 
            ' Form2
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(1105, 716)
            ContextMenuStrip = contextMenuStrip1
            Controls.Add(label2)
            Controls.Add(guna2DataGridView1)
            Controls.Add(guna2Button1)
            Controls.Add(guna2TextBox1)
            Controls.Add(cbFilters)
            Controls.Add(label1)
            Controls.Add(pictureBox1)
            Name = "Form2"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "Form2"
            AddHandler Load, New EventHandler(AddressOf Form2_Load)
            CType(guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
            contextMenuStrip1.ResumeLayout(False)
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private pictureBox1 As Windows.Forms.PictureBox
        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Private guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
        Private cbFilters As Guna.UI2.WinForms.Guna2ComboBox
        Private contextMenuStrip1 As Windows.Forms.ContextMenuStrip
        Private showInformationsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private editePersonToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private deleteToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private addPersonToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private sendEmailToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private callToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    End Class
End Namespace
