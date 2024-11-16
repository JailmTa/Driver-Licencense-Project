Namespace DVLD_Project
    Partial Class Form14
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
            Dim dataGridViewCellStyle4 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As Windows.Forms.DataGridViewCellStyle = New Windows.Forms.DataGridViewCellStyle()
            label2 = New Windows.Forms.Label()
            guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
            guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
            cbFilters = New Guna.UI2.WinForms.Guna2ComboBox()
            label1 = New Windows.Forms.Label()
            contextMenuStrip2 = New Windows.Forms.ContextMenuStrip(components)
            toolStripMenuItem1 = New Windows.Forms.ToolStripMenuItem()
            toolStripMenuItem2 = New Windows.Forms.ToolStripMenuItem()
            toolStripMenuItem3 = New Windows.Forms.ToolStripMenuItem()
            changePassWordToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            toolStripMenuItem7 = New Windows.Forms.ToolStripMenuItem()
            visonTestToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            writtenTestToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            drivingTestToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            toolStripMenuItem5 = New Windows.Forms.ToolStripMenuItem()
            toolStripMenuItem6 = New Windows.Forms.ToolStripMenuItem()
            showPersonLicenseHisToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            pictureBox1 = New Windows.Forms.PictureBox()
            CType(guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
            contextMenuStrip2.SuspendLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Font = New Drawing.Font("Modern No. 20", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label2.Location = New Drawing.Point(59, 264)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(56, 22)
            label2.TabIndex = 24
            label2.Text = "Filter"
            ' 
            ' guna2DataGridView1
            ' 
            guna2DataGridView1.AllowUserToAddRows = False
            guna2DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle4.BackColor = Drawing.Color.White
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4
            guna2DataGridView1.AutoSizeColumnsMode = Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            guna2DataGridView1.BackgroundColor = Drawing.Color.White
            guna2DataGridView1.BorderStyle = Windows.Forms.BorderStyle.None
            guna2DataGridView1.CellBorderStyle = Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            guna2DataGridView1.ColumnHeadersBorderStyle = Windows.Forms.DataGridViewHeaderBorderStyle.None
            dataGridViewCellStyle5.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle5.BackColor = Drawing.Color.FromArgb(100, 88, 255)
            dataGridViewCellStyle5.Font = New Drawing.Font("Segoe UI", 10.5F)
            dataGridViewCellStyle5.ForeColor = Drawing.Color.White
            dataGridViewCellStyle5.SelectionBackColor = Drawing.SystemColors.Highlight
            dataGridViewCellStyle5.SelectionForeColor = Drawing.SystemColors.HighlightText
            dataGridViewCellStyle5.WrapMode = Windows.Forms.DataGridViewTriState.True
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5
            guna2DataGridView1.ColumnHeadersHeight = 40
            dataGridViewCellStyle6.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle6.BackColor = Drawing.Color.White
            dataGridViewCellStyle6.Font = New Drawing.Font("Segoe UI", 10.5F)
            dataGridViewCellStyle6.ForeColor = Drawing.Color.FromArgb(71, 69, 94)
            dataGridViewCellStyle6.SelectionBackColor = Drawing.Color.FromArgb(231, 229, 255)
            dataGridViewCellStyle6.SelectionForeColor = Drawing.Color.FromArgb(71, 69, 94)
            dataGridViewCellStyle6.WrapMode = Windows.Forms.DataGridViewTriState.False
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6
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
            guna2DataGridView1.TabIndex = 23
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
            guna2TextBox1.TabIndex = 21
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
            cbFilters.TabIndex = 20
            AddHandler cbFilters.SelectedIndexChanged, New EventHandler(AddressOf cbFilters_SelectedIndexChanged)
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label1.Location = New Drawing.Point(345, 203)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(414, 36)
            label1.TabIndex = 19
            label1.Text = "Maneage New Local Lencinse"
            ' 
            ' contextMenuStrip2
            ' 
            contextMenuStrip2.ImageScalingSize = New Drawing.Size(20, 20)
            contextMenuStrip2.Items.AddRange(New Windows.Forms.ToolStripItem() {toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, changePassWordToolStripMenuItem, toolStripMenuItem7, toolStripMenuItem5, toolStripMenuItem6, showPersonLicenseHisToolStripMenuItem})
            contextMenuStrip2.Name = "contextMenuStrip1"
            contextMenuStrip2.Size = New Drawing.Size(269, 240)
            AddHandler contextMenuStrip2.Opening, New ComponentModel.CancelEventHandler(AddressOf contextMenuStrip2_Opening)
            ' 
            ' toolStripMenuItem1
            ' 
            toolStripMenuItem1.Image = Global.DVLD_Project.Properties.Resources.icons8_info_64
            toolStripMenuItem1.Name = "toolStripMenuItem1"
            toolStripMenuItem1.Size = New Drawing.Size(268, 26)
            toolStripMenuItem1.Text = "ShowInformations"
            AddHandler toolStripMenuItem1.Click, New EventHandler(AddressOf toolStripMenuItem1_Click)
            ' 
            ' toolStripMenuItem2
            ' 
            toolStripMenuItem2.Image = Global.DVLD_Project.Properties.Resources.icons8_edit_64
            toolStripMenuItem2.Name = "toolStripMenuItem2"
            toolStripMenuItem2.Size = New Drawing.Size(268, 26)
            toolStripMenuItem2.Text = "Edite"
            ' 
            ' toolStripMenuItem3
            ' 
            toolStripMenuItem3.Image = Global.DVLD_Project.Properties.Resources.icons8_delete_64
            toolStripMenuItem3.Name = "toolStripMenuItem3"
            toolStripMenuItem3.Size = New Drawing.Size(268, 26)
            toolStripMenuItem3.Text = "Delete"
            ' 
            ' changePassWordToolStripMenuItem
            ' 
            changePassWordToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_cancel_64
            changePassWordToolStripMenuItem.Name = "changePassWordToolStripMenuItem"
            changePassWordToolStripMenuItem.Size = New Drawing.Size(268, 26)
            changePassWordToolStripMenuItem.Text = "Cancel Application"
            AddHandler changePassWordToolStripMenuItem.Click, New EventHandler(AddressOf changePassWordToolStripMenuItem_Click)
            ' 
            ' toolStripMenuItem7
            ' 
            toolStripMenuItem7.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {visonTestToolStripMenuItem, writtenTestToolStripMenuItem, drivingTestToolStripMenuItem})
            toolStripMenuItem7.Image = Global.DVLD_Project.Properties.Resources.icons8_test_641
            toolStripMenuItem7.Name = "toolStripMenuItem7"
            toolStripMenuItem7.Size = New Drawing.Size(268, 26)
            toolStripMenuItem7.Text = "Take Exams"
            ' 
            ' visonTestToolStripMenuItem
            ' 
            visonTestToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_eye_64
            visonTestToolStripMenuItem.Name = "visonTestToolStripMenuItem"
            visonTestToolStripMenuItem.Size = New Drawing.Size(224, 26)
            visonTestToolStripMenuItem.Text = "Vison Test"
            AddHandler visonTestToolStripMenuItem.Click, New EventHandler(AddressOf visonTestToolStripMenuItem_Click)
            ' 
            ' writtenTestToolStripMenuItem
            ' 
            writtenTestToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_compose_64
            writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem"
            writtenTestToolStripMenuItem.Size = New Drawing.Size(224, 26)
            writtenTestToolStripMenuItem.Text = "Written Test"
            AddHandler writtenTestToolStripMenuItem.Click, New EventHandler(AddressOf writtenTestToolStripMenuItem_Click)
            ' 
            ' drivingTestToolStripMenuItem
            ' 
            drivingTestToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_car_64
            drivingTestToolStripMenuItem.Name = "drivingTestToolStripMenuItem"
            drivingTestToolStripMenuItem.Size = New Drawing.Size(224, 26)
            drivingTestToolStripMenuItem.Text = "Driving Test"
            AddHandler drivingTestToolStripMenuItem.Click, New EventHandler(AddressOf drivingTestToolStripMenuItem_Click)
            ' 
            ' toolStripMenuItem5
            ' 
            toolStripMenuItem5.Image = Global.DVLD_Project.Properties.Resources.icons8_preview_file_64
            toolStripMenuItem5.Name = "toolStripMenuItem5"
            toolStripMenuItem5.Size = New Drawing.Size(268, 26)
            toolStripMenuItem5.Text = "FirstTime"
            ' 
            ' toolStripMenuItem6
            ' 
            toolStripMenuItem6.Image = Global.DVLD_Project.Properties.Resources.icons8_preview_file_64
            toolStripMenuItem6.Name = "toolStripMenuItem6"
            toolStripMenuItem6.Size = New Drawing.Size(268, 26)
            toolStripMenuItem6.Text = "Show Lasence"
            ' 
            ' showPersonLicenseHisToolStripMenuItem
            ' 
            showPersonLicenseHisToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_history_64
            showPersonLicenseHisToolStripMenuItem.Name = "showPersonLicenseHisToolStripMenuItem"
            showPersonLicenseHisToolStripMenuItem.Size = New Drawing.Size(268, 26)
            showPersonLicenseHisToolStripMenuItem.Text = "Show Person License History"
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
            guna2Button1.TabIndex = 22
            AddHandler guna2Button1.Click, New EventHandler(AddressOf guna2Button1_Click)
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = Global.DVLD_Project.Properties.Resources.icons8_taxi_license_1001
            pictureBox1.Location = New Drawing.Point(444, 12)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(198, 173)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 18
            pictureBox1.TabStop = False
            ' 
            ' Form14
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(1105, 716)
            ContextMenuStrip = contextMenuStrip2
            Controls.Add(label2)
            Controls.Add(guna2DataGridView1)
            Controls.Add(guna2TextBox1)
            Controls.Add(cbFilters)
            Controls.Add(label1)
            Controls.Add(guna2Button1)
            Controls.Add(pictureBox1)
            Name = "Form14"
            Text = "Form14"
            AddHandler Load, New EventHandler(AddressOf Form14_Load)
            CType(guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
            contextMenuStrip2.ResumeLayout(False)
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label2 As Windows.Forms.Label
        Private guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
        Private guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
        Private cbFilters As Guna.UI2.WinForms.Guna2ComboBox
        Private label1 As Windows.Forms.Label
        Private contextMenuStrip2 As Windows.Forms.ContextMenuStrip
        Private toolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
        Private toolStripMenuItem2 As Windows.Forms.ToolStripMenuItem
        Private toolStripMenuItem3 As Windows.Forms.ToolStripMenuItem
        Private changePassWordToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private toolStripMenuItem5 As Windows.Forms.ToolStripMenuItem
        Private toolStripMenuItem6 As Windows.Forms.ToolStripMenuItem
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Private pictureBox1 As Windows.Forms.PictureBox
        Private showPersonLicenseHisToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private toolStripMenuItem7 As Windows.Forms.ToolStripMenuItem
        Private visonTestToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private writtenTestToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private drivingTestToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    End Class
End Namespace
