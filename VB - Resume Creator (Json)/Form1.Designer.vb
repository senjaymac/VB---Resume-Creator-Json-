<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMenu))
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblGenerate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Linen
        resources.ApplyResources(Me.btnGenerate, "btnGenerate")
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'lblHeader
        '
        resources.ApplyResources(Me.lblHeader, "lblHeader")
        Me.lblHeader.Name = "lblHeader"
        '
        'lblGenerate
        '
        resources.ApplyResources(Me.lblGenerate, "lblGenerate")
        Me.lblGenerate.Name = "lblGenerate"
        '
        'formMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.Controls.Add(Me.lblGenerate)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnGenerate)
        Me.MaximizeBox = False
        Me.Name = "formMenu"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblGenerate As Label
End Class
