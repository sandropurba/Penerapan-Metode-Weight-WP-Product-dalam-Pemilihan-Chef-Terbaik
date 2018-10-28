<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Utama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BobotKriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlternatifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PenilaianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InputNilaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProsesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnalisaPerhitunganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HasilKeputusanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.PenilaianToolStripMenuItem, Me.ProsesToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(831, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BobotKriteriaToolStripMenuItem, Me.AlternatifToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.DataToolStripMenuItem.Text = "File"
        '
        'BobotKriteriaToolStripMenuItem
        '
        Me.BobotKriteriaToolStripMenuItem.Name = "BobotKriteriaToolStripMenuItem"
        Me.BobotKriteriaToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.BobotKriteriaToolStripMenuItem.Text = "Bobot Kriteria"
        '
        'AlternatifToolStripMenuItem
        '
        Me.AlternatifToolStripMenuItem.Name = "AlternatifToolStripMenuItem"
        Me.AlternatifToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AlternatifToolStripMenuItem.Text = "Data Chef"
        '
        'PenilaianToolStripMenuItem
        '
        Me.PenilaianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputNilaiToolStripMenuItem})
        Me.PenilaianToolStripMenuItem.Name = "PenilaianToolStripMenuItem"
        Me.PenilaianToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.PenilaianToolStripMenuItem.Text = "Penilaian"
        '
        'InputNilaiToolStripMenuItem
        '
        Me.InputNilaiToolStripMenuItem.Name = "InputNilaiToolStripMenuItem"
        Me.InputNilaiToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.InputNilaiToolStripMenuItem.Text = "Input Nilai"
        '
        'ProsesToolStripMenuItem
        '
        Me.ProsesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnalisaPerhitunganToolStripMenuItem})
        Me.ProsesToolStripMenuItem.Name = "ProsesToolStripMenuItem"
        Me.ProsesToolStripMenuItem.Size = New System.Drawing.Size(139, 20)
        Me.ProsesToolStripMenuItem.Text = "Proses Weight Product"
        '
        'AnalisaPerhitunganToolStripMenuItem
        '
        Me.AnalisaPerhitunganToolStripMenuItem.Name = "AnalisaPerhitunganToolStripMenuItem"
        Me.AnalisaPerhitunganToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AnalisaPerhitunganToolStripMenuItem.Text = "Analisa Perhitungan"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HasilKeputusanToolStripMenuItem
        '
        Me.HasilKeputusanToolStripMenuItem.Name = "HasilKeputusanToolStripMenuItem"
        Me.HasilKeputusanToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.HasilKeputusanToolStripMenuItem.Text = "Hasil Keputusan"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HasilKeputusanToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 479)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Utama"
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BobotKriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlternatifToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenilaianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputNilaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnalisaPerhitunganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HasilKeputusanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
