﻿' Developer Express Code Central Example:
' How to convert an XtraGrid to an XtraReport at runtime
' 
' This example demonstrates how to dynamically create a report based upon the
' GridControl at runtime. This means that all filtering and sorting conditions
' selected in the grid are also applied in a report. To accomplish this task, it
' is necessary to create a report with all the necessary bands, bind it to a data
' source and adjust all the necessary options.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E108

Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace dxKB17175
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace