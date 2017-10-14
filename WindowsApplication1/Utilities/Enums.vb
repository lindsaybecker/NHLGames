﻿Namespace Utilities

    Public Enum GameStateEnum
        Scheduled = 1
        Pregame = 2
        InProgress = 3
        Ending = 4
        Final = 5
    End Enum

    Public Enum GameTypeEnum
        Preseason = 1
        Season = 2
        Series = 3
    End Enum

    Public Enum StreamType
        Away = 1
        Home
        National
        French
        MultiCam1
        MultiCam2
        RefCam
        EndzoneCam1
        EndzoneCam2
    End Enum

    Public Enum CdnType
        Akc = 0
        L3C
    End Enum

    Public Enum StreamQuality
#Disable Warning InconsistentNaming
        best = 0
        _720p = 1
        _540p = 2
        _504p = 3
        _360p = 4
        _288p = 5
        _224p = 6
        worst = 7
#Enable Warning InconsistentNaming
    End Enum

    Public Enum PlayerTypeEnum
        None = 0
        Vlc = 1
        Mpc = 2
        Mpv = 3
    End Enum

    Public Enum SettingsEnum
        Version = 1
        DefaultWatchArgs = 2
        VlcPath = 3
        MpcPath = 4
        MpvPath = 5
        StreamerPath = 6
        ServerList = 7
        ShowScores = 8
        SelectedServer = 9
        SelectedLanguage = 10
        ShowLiveScores = 11
        ShowSeriesRecord = 12
        LanguageList = 13
        AdDetection = 14
    End Enum

    Public Enum OutputType
        Normal = 0
        Status = 1
        [Error] = 2
        Warning = 3
        Cli = 4
    End Enum

    Public Enum AdModulesEnum
        Spotify = 1
        Obs
    End Enum
End Namespace
