﻿Imports System
Imports System.Windows.Forms

Namespace DVLD_Project
    Friend Module Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Private Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form5())
        End Sub
    End Module
End Namespace
