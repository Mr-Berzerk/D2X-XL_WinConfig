Public Class Setup
    Private Sub CHBCustomBackgroundTransparency_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHBCustomBackgroundTransparency.CheckedChanged
        If CHBCustomBackgroundTransparency.Checked = True Then
            NUDCustomBackgroundTransparency.Enabled = False
        Else
            NUDCustomBackgroundTransparency.Enabled = True
        End If
    End Sub

    Private Sub CHBCustomMusic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHBCustomMusic.CheckedChanged
        If CHBCustomMusic.Checked = True Then
            GRBCustomMusic.Enabled = True
        Else
            GRBCustomMusic.Enabled = False
        End If
    End Sub

    Private Sub RDBReticleDrawn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDBReticleDrawn.CheckedChanged
        If RDBReticleDrawn.Checked = True Then
            LBLReticleLineLength.Enabled = True
            NUDReticle.Enabled = True
        Else
            LBLReticleLineLength.Enabled = False
            NUDReticle.Enabled = False
        End If
    End Sub

    Private Sub BTNCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancel.Click
        End
    End Sub

    Private Sub CHBRunDemos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHBRunDemos.CheckedChanged
        If CHBRunDemos.Checked = True Then
            CHBAutoDemo.Enabled = True
        Else
            CHBAutoDemo.Enabled = False
            CHBAutoDemo.Checked = False
        End If
    End Sub

    Private Sub CHBAutoDemo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHBAutoDemo.CheckedChanged
        If CHBAutoDemo.Checked = True Then
            CMBAutoDemo.Enabled = True
        Else
            CMBAutoDemo.Enabled = False
        End If
    End Sub
End Class
