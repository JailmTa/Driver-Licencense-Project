Namespace DVLD_Project
    Partial Class Form17
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
            getInformations1 = New GetInformations()
            getAppInfo1 = New GetAppInfo()
            SuspendLayout()
            ' 
            ' getInformations1
            ' 
            getInformations1.Location = New Drawing.Point(13, 155)
            getInformations1.Name = "getInformations1"
            getInformations1.Size = New Drawing.Size(736, 373)
            getInformations1.TabIndex = 0
            ' 
            ' getAppInfo1
            ' 
            getAppInfo1.Location = New Drawing.Point(13, 61)
            getAppInfo1.Name = "getAppInfo1"
            getAppInfo1.Size = New Drawing.Size(736, 152)
            getAppInfo1.TabIndex = 1
            ' 
            ' Form17
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(751, 530)
            Controls.Add(getAppInfo1)
            Controls.Add(getInformations1)
            Name = "Form17"
            Text = "Form17"
            AddHandler Load, New EventHandler(AddressOf Form17_Load)
            ResumeLayout(False)

        End Sub

#End Region

        Private getInformations1 As GetInformations
        Private getAppInfo1 As GetAppInfo
    End Class
End Namespace
