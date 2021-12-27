'this module is mainly to code a little cleaner
Module mod_settings
    Public Function ExitApplication()
        Dim ask As MsgBoxResult = MsgBox("are you sure you want to close Ammo-Keeper?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            AutoSaveSetting()
            End
        End If
    End Function

    Public Function AutoSaveSetting()
        'this function will save all settings everytime it is called, if a new setting is added you will need to update the setting here
    End Function
End Module

