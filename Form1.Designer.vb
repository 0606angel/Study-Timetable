<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grd_timetable = New UJGrid.UJGrid()
        Me.SuspendLayout()
        '
        'grd_timetable
        '
        Me.grd_timetable.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grd_timetable.Cols = 8
        Me.grd_timetable.Cursor = System.Windows.Forms.Cursors.Cross
        Me.grd_timetable.FixedCols = 1
        Me.grd_timetable.FixedRows = 1
        Me.grd_timetable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grd_timetable.Location = New System.Drawing.Point(4, 2)
        Me.grd_timetable.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_timetable.Name = "grd_timetable"
        Me.grd_timetable.Padding = New System.Windows.Forms.Padding(4)
        Me.grd_timetable.Rows = 32
        Me.grd_timetable.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grd_timetable.Size = New System.Drawing.Size(1223, 695)
        Me.grd_timetable.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 730)
        Me.Controls.Add(Me.grd_timetable)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grd_timetable As UJGrid.UJGrid
End Class
