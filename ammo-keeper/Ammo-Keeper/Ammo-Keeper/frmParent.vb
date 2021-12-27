'SPDX-License-Identifier: MIT [https://opensource.org/licenses/MIT]
'project: ammo keeper
'dev: leapingfox
'dev github: https://github.com/leapingfox
'git: https://github.com/leapingfox/ammo-keeper-vbnet.git

'dev note: this was designed to be extremely light weight and able to run on older slower machines, fancy things need not apply.


Public Class frmParent

    Private Sub ApplicationSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationSettingsToolStripMenuItem.Click
        frmSettings.MdiParent = Me
        frmSettings.Show()
    End Sub

    Private Sub ReloadingActiveReloaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadingActiveReloaderToolStripMenuItem.Click
        frmActiveReloader.MdiParent = Me
        frmActiveReloader.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ExitApplication() 'see mod_settings.vb
    End Sub
End Class
