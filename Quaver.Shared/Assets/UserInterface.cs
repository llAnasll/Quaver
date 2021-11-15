/*
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 * Copyright (c) Swan & The Quaver Team <support@quavergame.com>.
*/

using Microsoft.Xna.Framework.Graphics;
using Wobble.Managers;

namespace Quaver.Shared.Assets
{
    public static class UserInterface
    {
        public static Texture2D BlankBox => TextureManager.Load($"Quaver.Resources/Textures/UI/blank-box.png");
        public static Texture2D UnknownAvatar => TextureManager.Load($"Quaver.Resources/Textures/UI/unknown-avatar.png");
        public static Texture2D YouAvatar => TextureManager.Load($"Quaver.Resources/Textures/UI/you-avatar.png");
        public static Texture2D MenuBackground => TextureManager.Load($"Quaver.Resources/Textures/UI/Menu/menu-background.jpg");
        public static Texture2D NotificationError => TextureManager.Load("Quaver.Resources/Textures/UI/Notifications/notif-error.png");
        public static Texture2D NotificationWarning => TextureManager.Load("Quaver.Resources/Textures/UI/Notifications/notif-warning.png");
        public static Texture2D NotificationInfo => TextureManager.Load("Quaver.Resources/Textures/UI/Notifications/notif-info.png");
        public static Texture2D NotificationSuccess => TextureManager.Load("Quaver.Resources/Textures/UI/Notifications/notif-success.png");
        public static Texture2D SelectSearchBackground => TextureManager.Load("Quaver.Resources/Textures/UI/select-search-background.png");
        public static Texture2D ThumbnailSinglePlayer => TextureManager.Load("Quaver.Resources/Textures/UI/MainMenu/thumbnail-single-player.jpg");
        public static Texture2D ThumbnailCompetitive => TextureManager.Load("Quaver.Resources/Textures/UI/MainMenu/thumbnail-competitive.jpg");
        public static Texture2D ThumbnailCustomGames => TextureManager.Load("Quaver.Resources/Textures/UI/MainMenu/thumbnail-custom-games.jpg");
        public static Texture2D ThumbnailEditor => TextureManager.Load("Quaver.Resources/Textures/UI/MainMenu/thumbnail-editor.jpg");
        public static Texture2D LoadingWheel => TextureManager.Load("Quaver.Resources/Textures/UI/loading-wheel.png");
        public static Texture2D StatusRanked => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-ranked.png");
        public static Texture2D StatusUnranked => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-unranked.png");
        public static Texture2D StatusNotSubmitted => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-not-submitted.png");
        public static Texture2D StatusDanCourse => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-dancourse.png");
        public static Texture2D StatusOtherGameOsu => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-other-game-osu.png");
        public static Texture2D StatusOtherGameEtterna => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-other-game-etterna.png");
        public static Texture2D StatusVarious => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-various.png");
        public static Texture2D StatusNone => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-none.png");
        public static Texture2D SelectButtonBackground => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/select-button-background.png");
        public static Texture2D HorizontalSelectorLeft => TextureManager.Load("Quaver.Resources/Textures/UI/Elements/horizontal-selector-left.png");
        public static Texture2D HorizontalSelectorRight => TextureManager.Load("Quaver.Resources/Textures/UI/Elements/horizontal-selector-right.png");
        public static Texture2D QuaverLogoFull => TextureManager.Load("Quaver.Resources/Textures/UI/quaver-logo-full.png");
        public static Texture2D MenuBackgroundBlurred => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/menu-background-blurred.jpg");
        public static Texture2D QuaverLogoStylish => TextureManager.Load("Quaver.Resources/Textures/UI/quaver-logo-stylish.png");
        public static Texture2D EditorToolSelect => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/select.png");
        public static Texture2D EditorLayerPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/layer-panel.png");
        public static Texture2D EditorEditLayerPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/edit-layer-panel.png");
        public static Texture2D EditorMetadataPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/metadata-panel.png");
        public static Texture2D EditorHitsoundsPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/hitsounds-panel.png");
        public static Texture2D EditorCompositionToolsPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/composition-tools-panel.png");
        public static Texture2D EditorDetailsPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/details-panel.png");
        public static Texture2D MenuBackgroundRaw => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/menu-background-raw.jpg");
        public static Texture2D MenuBackgroundClear => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/menu-background-clear.jpg");
        public static Texture2D LobbyCreateGame => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/create-game.png");
        public static Texture2D TeamBannerRed => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/team-banner-red.png");
        public static Texture2D TeamBannerBlue => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/team-banner-blue.png");
        public static Texture2D BattleRoyaleGradient => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/battle-royale-gradient.png");
        public static Texture2D BattleRoyalePanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/battle-royale-panel.png");
        public static Texture2D WaitingPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/waiting-panel.png");
        public static Texture2D WinsPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/wins-panel.png");
        public static Texture2D ScoreboardBlueMirrored => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/scoreboard-blue-mirrored.png");
        public static Texture2D UserPanelFFA => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/user-panel-ffa.png");
        public static Texture2D UserPanelRed => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/user-panel-red.png");
        public static Texture2D UserPanelBlue => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/user-panel-blue.png");
        public static Texture2D UserPanelReferee => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/user-panel-referee.png");
        public static Texture2D MapPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/map-panel.png");
        public static Texture2D FeedPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/feed-panel.png");
        public static Texture2D MultiplayerSettingaPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/settings-panel.png");
        public static Texture2D PlayerOptionsPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/player-options-panel.png");
        public static Texture2D ResultHeaderPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-header-panel.png");
        public static Texture2D ResultScorePanel => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-score-panel.png");
        public static Texture2D ResultMultiplayerPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-multiplayer-panel.png");
        public static Texture2D ResultMultiplayerTeamPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-multiplayer-team-panel.png");
        public static Texture2D ResultRedTeam => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-red-team.png");
        public static Texture2D ResultBlueTeam => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-blue-team.png");
        public static Texture2D ResultNoTeam => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-no-team.png");
        public static Texture2D JukeboxPanel => TextureManager.Load("Quaver.Resources/Textures/UI/MainMenu/jukebox-panel.png");
        public static Texture2D PlayercardBackground => TextureManager.Load("Quaver.Resources/Textures/UI/Playercard/playercard-background.png");
        public static Texture2D MenuBackgroundNormal => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/menu-background-normal.jpg");
        public static Texture2D PlayercardCoverDefault => TextureManager.Load("Quaver.Resources/Textures/UI/Playercard/playercard-cover-default.png");
        public static Texture2D DownloadSearchPanel => TextureManager.Load("Quaver.Resources/Textures/UI/download-search.png");
        public static Texture2D DownloadItem => TextureManager.Load("Quaver.Resources/Textures/UI/download-item.png");
        public static Texture2D DownloadMapsetInfo => TextureManager.Load("Quaver.Resources/Textures/UI/mapset-info.png");
        public static Texture2D SelectedMapset => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/selected-mapset.png");
        public static Texture2D DeselectedMapset => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/deselected-mapset.png");
        public static Texture2D SelectSearchPanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/search-panel.png");
        public static Texture2D LeaderboardScore => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/leaderboard-score.png");
        public static Texture2D LeaderboardPanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/leaderboard-panel.png");
        public static Texture2D Logo => TextureManager.Load("Quaver.Resources/Textures/UI/logo.png");
        public static Texture2D SessionTimeBackground => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/session-time-background.png");
        public static Texture2D MenuBorderBackground => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/menu-border-background.png");
        public static Texture2D FilterPanelGradient => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/filter-panel-gradient.png");
        public static Texture2D DropdownClosed => TextureManager.Load("Quaver.Resources/Textures/UI/Elements/dropdown-closed.png");
        public static Texture2D DropdownOpen => TextureManager.Load("Quaver.Resources/Textures/UI/Elements/dropdown-open.png");
        public static Texture2D DropdownBottom => TextureManager.Load("Quaver.Resources/Textures/UI/Elements/dropdown-bottom.png");
        public static Texture2D SearchBox => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/search-box.png");
        public static Texture2D Keys4Panel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/keys4.png");
        public static Texture2D Keys7Panel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/keys7.png");
        public static Texture2D KeysNonePanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/keys-none.png");
        public static Texture2D BothModesPanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/both-modes-panel.png");
        public static Texture2D ModePanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/mode-panel.png");
        public static Texture2D EditPlayButton => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/edit-play-button.png");
        public static Texture2D StatusPanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/status-panel.png");
        public static Texture2D DefaultBanner => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/default-banner.png");
        public static Texture2D DifficultyBarBackground => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/difficultybar-bg.png");
        public static Texture2D DifficultyBarColor => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/difficultybar-colour.png");
        public static Texture2D LeaderboardScoresPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/leaderboard-scores-panel.png");
        public static Texture2D PersonalBestScorePanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/personal-best-score-panel.png");
        public static Texture2D WarningRed => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/warning-red.png");
        public static Texture2D Clock => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/clock.png");
        public static Texture2D Triangles => TextureManager.Load(@"Quaver.Resources/Textures/UI/triangles.png");
        public static Texture2D ModifierSelectorBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/modifier-selector-bg.png");
        public static Texture2D Off => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/off.png");
        public static Texture2D On => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/on.png");
        public static Texture2D ResetMods => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/reset-mods.png");
        public static Texture2D ClosePanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/close-panel.png");
        public static Texture2D CreateButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/create-button.png");
        public static Texture2D SureButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/sure-button.png");
        public static Texture2D AcceptButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/accept-button.png");
        public static Texture2D DeclineButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/decline-button.png");
        public static Texture2D LegalPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/legal-panel.png");
        public static Texture2D CancelButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/cancel-button.png");
        public static Texture2D UpdateButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/update-button.png");
        public static Texture2D YesNoPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/yes-no-panel.png");
        public static Texture2D CustomizeButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/customize-button.png");
        public static Texture2D JudgementWindowPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/judgement-window-panel.png");
        public static Texture2D JudgementWindowHeaderBanner => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/header-banner.png");
        public static Texture2D JudgementWindowCloseButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/close-button.png");
        public static Texture2D JudgementWindowCreateButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/create-button.png");
        public static Texture2D JudgementWindowDeleteButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/delete-button.png");
        public static Texture2D JudgementWindowEditNameButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/edit-name-button.png");
        public static Texture2D JudgementWindowResetButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/reset-button.png");
        public static Texture2D SliderProgressBall => TextureManager.Load(@"Quaver.Resources/Textures/UI/slider-progress-ball.png");
        public static Texture2D JukeboxPlayButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-play-button.png");
        public static Texture2D JukeboxPauseButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-pause-button.png");
        public static Texture2D JukeboxHamburgerIcon => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-hamburger-icon.png");
        public static Texture2D JukeboxBackwardButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-backward-button.png");
        public static Texture2D JukeboxInfoBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-info-bg.png");
        public static Texture2D JukeboxInfoButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-info-button.png");
        public static Texture2D JukeboxFade => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-fade.png");
        public static Texture2D HostCrown => TextureManager.Load(@"Quaver.Resources/Textures/UI/host-crown.png");
        public static Texture2D LoginButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/login-button.png");
        public static Texture2D HubTriangles => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/hub-triangles.png");
        public static Texture2D HubDownloads => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/hub-downloads.png");
        public static Texture2D HubNotifications => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/hub-notifications.png");
        public static Texture2D HubOnlineUsers => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/hub-online-users.png");
        public static Texture2D HubSongRequests => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/hub-song-requests.png");
        public static Texture2D HubHeaderBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/hub-header-background.png");
        public static Texture2D HubIconBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/hub-icon-background.png");
        public static Texture2D HubOnlineIcon => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/hub-online-icon.png");
        public static Texture2D HubNotificationIcon => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/notification.png");
        public static Texture2D HubNotificationIconUnread => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/notification-red.png");
        public static Texture2D HubDownloadContainer => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/download-container.png");
        public static Texture2D TwitchIcon => TextureManager.Load(@"Quaver.Resources/Textures/UI/twitch-icon.png");
        public static Texture2D ConnectTwitch => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/connect-twitch.png");
        public static Texture2D UnlinkTwitch => TextureManager.Load(@"Quaver.Resources/Textures/UI/Hub/unlink-twitch.png");
        public static Texture2D Emoji => TextureManager.Load(@"Quaver.Resources/Textures/UI/Chat/emoji.png");
        public static Texture2D BadgeAdmin => TextureManager.Load(@"Quaver.Resources/Textures/UI/Chat/badge-admin.png");
        public static Texture2D BadgeBot => TextureManager.Load(@"Quaver.Resources/Textures/UI/Chat/badge-bot.png");
        public static Texture2D BadgeContributor => TextureManager.Load(@"Quaver.Resources/Textures/UI/Chat/badge-contributor.png");
        public static Texture2D BadgeDeveloper => TextureManager.Load(@"Quaver.Resources/Textures/UI/Chat/badge-developer.png");
        public static Texture2D BadgeModerator => TextureManager.Load(@"Quaver.Resources/Textures/UI/Chat/badge-moderator.png");
        public static Texture2D BadgeSupervisor => TextureManager.Load(@"Quaver.Resources/Textures/UI/Chat/badge-supervisor.png");
        public static Texture2D TopicHeader => TextureManager.Load(@"Quaver.Resources/Textures/UI/Chat/topic-header.png");
        public static Texture2D CloseChannelButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Chat/close-channel.png");
        public static Texture2D RoundedPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/rounded-panel.png");
        public static Texture2D Mode4KSmall => TextureManager.Load(@"Quaver.Resources/Textures/UI/Lobby/mode-4k-small.png");
        public static Texture2D Mode7KSmall => TextureManager.Load(@"Quaver.Resources/Textures/UI/Lobby/mode-7k-small.png");
        public static Texture2D Mode4K7KSmall => TextureManager.Load(@"Quaver.Resources/Textures/UI/Lobby/mode-4k-7k-small.png");
        public static Texture2D RulesetFFA => TextureManager.Load(@"Quaver.Resources/Textures/UI/Lobby/ruleset-ffa.png");
        public static Texture2D RulesetBR => TextureManager.Load(@"Quaver.Resources/Textures/UI/Lobby/ruleset-br.png");
        public static Texture2D RulesetTeam => TextureManager.Load(@"Quaver.Resources/Textures/UI/Lobby/ruleset-team.png");
        public static Texture2D MultiplayerChatBox => TextureManager.Load(@"Quaver.Resources/Textures/UI/Multi/multiplayer-chat-box.png");
        public static Texture2D NotReadyIcon => TextureManager.Load(@"Quaver.Resources/Textures/UI/Multi/not-ready.png");
        public static Texture2D ReadyIcon => TextureManager.Load(@"Quaver.Resources/Textures/UI/Multi/ready.png");
        public static Texture2D MultiplayerUploadMapset => TextureManager.Load(@"Quaver.Resources/Textures/UI/Multi/multiplayer-upload-mapset.png");
        public static Texture2D MultiplayerChangeName => TextureManager.Load(@"Quaver.Resources/Textures/UI/Multi/multiplayer-change-name.png");
        public static Texture2D MultiplayerEditPassword => TextureManager.Load(@"Quaver.Resources/Textures/UI/Multi/multiplayer-edit-password.png");
        public static Texture2D MultiplayerSelectMap => TextureManager.Load(@"Quaver.Resources/Textures/UI/Multi/multiplayer-select-map.png");
        public static Texture2D OfflineAvatar => TextureManager.Load(@"Quaver.Resources/Textures/UI/Playercard/offline-avatar.png");
        public static Texture2D OfflinePlayercardPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/Playercard/offline-playercard-panel.png");
        public static Texture2D LoginButtonPlayercard => TextureManager.Load(@"Quaver.Resources/Textures/UI/Playercard/login-button.png");
        public static Texture2D LogoutButtonPlayercard => TextureManager.Load(@"Quaver.Resources/Textures/UI/Playercard/logout-button.png");
        public static Texture2D ViewProfileButtonPlayercard => TextureManager.Load(@"Quaver.Resources/Textures/UI/Playercard/view-profile-button.png");
        public static Texture2D UserPlayercardPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/Playercard/user-playercard-panel.png");
        public static Texture2D Mode4KOn => TextureManager.Load(@"Quaver.Resources/Textures/UI/Playercard/mode-4k-on.png");
        public static Texture2D Mode7KOn => TextureManager.Load(@"Quaver.Resources/Textures/UI/Playercard/mode-7k-on.png");
        public static Texture2D RequiredAccAlert => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/required-acc-alert.png");
        public static Texture2D VolumeControllerPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/Volume/volume-controller-panel.png");
        public static Texture2D EffectVolumeIcon => TextureManager.Load(@"Quaver.Resources/Textures/UI/Volume/effect-volume-icon.png");
        public static Texture2D MusicVolumeIcon => TextureManager.Load(@"Quaver.Resources/Textures/UI/Volume/music-volume-icon.png");
        public static Texture2D MasterVolumeIcon => TextureManager.Load(@"Quaver.Resources/Textures/UI/Volume/master-volume-icon.png");
        public static Texture2D VolumeSliderProgressBall => TextureManager.Load(@"Quaver.Resources/Textures/UI/Volume/slider-progress-ball.png");
        public static Texture2D VolumeSliderActive => TextureManager.Load(@"Quaver.Resources/Textures/UI/Volume/slider-active-color.png");
        public static Texture2D VolumeSliderInactive => TextureManager.Load(@"Quaver.Resources/Textures/UI/Volume/slider-inactive-color.png");
        public static Texture2D ReplayControllerActiveBar => TextureManager.Load(@"Quaver.Resources/Textures/UI/Replay/replay-controller-active-bar.png");
        public static Texture2D ReplayControllerInactiveBar => TextureManager.Load(@"Quaver.Resources/Textures/UI/Replay/replay-controller-inactive-bar.png");
        public static Texture2D ReplayControllerPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/Replay/replay-controller-panel.png");
        public static Texture2D ReplayControllerSpeedPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/Replay/replay-controller-speed-panel.png");
        public static Texture2D OptionsCalibrateOffsetButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/calibrate-offset-button.png");
        public static Texture2D OptionsUpdateButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-update-button.png");
        public static Texture2D OptionsExportSkinButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/export-skin-button.png");
        public static Texture2D OptionsOpenSkinFolderButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/open-skin-folder-button.png");
        public static Texture2D OptionsContentBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-content-bg.png");
        public static Texture2D OptionsHeader => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-header.png");
        public static Texture2D OptionsItemBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-item-bg.png");
        public static Texture2D OptionsSidebar => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-sidebar.png");
        public static Texture2D OptionsSidebarButtonBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/sidebar-button-bg.png");
        public static Texture2D OptionsUploadSkinButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/upload-skin-button.png");
        public static Texture2D OptionsVideo => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-video.png");
        public static Texture2D OptionsAudio => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-audio.png");
        public static Texture2D OptionsGameplay => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-gameplay.png");
        public static Texture2D OptionsEditor => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-editor.png");
        public static Texture2D OptionsSkin => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-skin.png");
        public static Texture2D OptionsInput => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-input.png");
        public static Texture2D OptionsMisc => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/options-misc.png");
        public static Texture2D DetectOtherGamesButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Options/detect-other-games-button.png");
        public static Texture2D GrayedMapset => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/grayed-mapset.png");
        public static Texture2D DeleteButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/delete-button.png");
        public static Texture2D ViewScoresButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/view-scores-button.png");
        public static Texture2D EditorZoomIn => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/editor-zoom-in.png");
        public static Texture2D EditorZoomOut => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/editor-zoom-out.png");
        public static Texture2D EditorPanelBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/editor-panel-bg.png");
        public static Texture2D EditorIconSelect => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/icon-select.png");
        public static Texture2D EditorIconNote => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/icon-note.png");
        public static Texture2D EditorIconLongNote => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/icon-long-note.png");
        public static Texture2D EditorIconWhistle => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/icon-whistle.png");
        public static Texture2D EditorIconFinish => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/icon-finish.png");
        public static Texture2D EditorIconClap => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/icon-clap.png");
        public static Texture2D EditorCreateLayer => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/editor-create-layer.png");
        public static Texture2D EditorDeleteLayer => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/editor-delete-layer.png");
        public static Texture2D NoYellowButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/no-yellow-button.png");
        public static Texture2D MetadataPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/editor-metadata-panel.png");
        public static Texture2D ResultsAvatarBorder => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/results-avatar-border.png");
        public static Texture2D ResultsAvatarMask => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/results-avatar-mask.png");
        public static Texture2D ResultsBackgroundFilter => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/results-background-filter.png");
        public static Texture2D ResultsTabSelectorBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/results-tab-selector-background.png");
        public static Texture2D ResultsLabelAccuracy => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/label-accuracy.png");
        public static Texture2D ResultsLabelMaxCombo => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/label-max-combo.png");
        public static Texture2D ResultsLabelPerformanceRating => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/label-performance-rating.png");
        public static Texture2D ResultsLabelRankedAccuracy => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/label-ranked-accuracy.png");
        public static Texture2D ResultsLabelTotalScore => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/label-total-score.png");
        public static Texture2D ResultsLabelScore => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/results-label-score.png");
        public static Texture2D ResultsLabelBlueTeam => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/results-label-blue-team.png");
        public static Texture2D ResultsLabelRedTeam => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/results-label-red-team.png");
        public static Texture2D ResultsMultiplayerTeamPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/multiplayer-team-panel.png");
        public static Texture2D ResultsScoreContainerPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/overview-score-container-panel.png");
        public static Texture2D ResultsGraphContainerPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/results-overview-graph-container.png");
        public static Texture2D ResultsMultiplayerFFAPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/Results/multiplayer-table-ffa.png");
        public static Texture2D NotificationButtonPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/MainMenu/notification-button-panel.png");
        public static Texture2D TrianglesWallpaper => TextureManager.Load(@"Quaver.Resources/Textures/UI/MainMenu/triangles.png");
        public static Texture2D MenuLogoBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/MainMenu/menu-logo-background.png");
        public static Texture2D MenuLogo => TextureManager.Load(@"Quaver.Resources/Textures/UI/MainMenu/logo.png");
        public static Texture2D NavigationButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/MainMenu/navigation-button.png");
        public static Texture2D NavigationButtonSelected => TextureManager.Load(@"Quaver.Resources/Textures/UI/MainMenu/navigation-button-selected.png");
        public static Texture2D NavigationButtonHovered => TextureManager.Load(@"Quaver.Resources/Textures/UI/MainMenu/navigation-button-hovered.png");
        public static Texture2D NewsPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/MainMenu/news-panel.png");
        public static Texture2D MenuTipPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/MainMenu/menu-tip-panel.png");
        public static Texture2D NoteVisualizer => TextureManager.Load(@"Quaver.Resources/Textures/UI/MainMenu/notes.png");
        public static Texture2D NoPreviewImage => TextureManager.Load(@"Quaver.Resources/Textures/UI/MainMenu/no-preview-image.png");
        public static Texture2D AutoModPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/AutoMod/automod-panel.png");
        public static Texture2D AutoModPanelHeader => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/AutoMod/automod-panel-header.png");
        public static Texture2D AutoModHeaderGear => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/AutoMod/automod-header-gear.png");
        public static Texture2D AutoModRefreshButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/AutoMod/refresh-button.png");
        public static Texture2D AutoModIconCritical => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/AutoMod/icon-critical.png");
        public static Texture2D AutoModIconWarning => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/AutoMod/icon-warning.png");
        public static Texture2D EditorBannerButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/banner-button.png");
        public static Texture2D EditorBackgroundButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Editor/background-button.png");
    }
}
