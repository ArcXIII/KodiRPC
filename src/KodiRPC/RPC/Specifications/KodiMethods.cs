/********************************************************************************************************************************************
 * Copyright (C) 2016 Pieter-Uys Fourie
 * This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as
 * published by the Free Software Foundation, either version 3 of the License, or any later version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License along with this program. If not, see
 * http://www.gnu.org/licenses/.
 */

namespace KodiRPC.RPC.Specifications
{
    public static class KodiMethods
    {
        #region JSONRPC

        public const string Ping = "JSONRPC.Ping";

        #endregion JSONRPC

        #region VideoLibrary

        #region Shows

        public const string Clean = "VideoLibrary.Clean";
        public const string Scan = "VideoLibrary.Scan";
        public const string GetTvShows = "VideoLibrary.GetTVShows";
        public const string GetTvShowDetails = "VideoLibrary.GetTVShowDetails";
        public const string GetSeasons = "VideoLibrary.GetSeasons";
        public const string GetEpisodes = "VideoLibrary.GetEpisodes";
        public const string GetEpisodeDetails = "VideoLibrary.GetEpisodeDetails";
        public const string GetRecentlyAddedEpisodes = "VideoLibrary.GetRecentlyAddedEpisodes";

        #endregion Shows

        #region Movies

        public const string GetMovies = "VideoLibrary.GetMovies";
        public const string GetMovieDetails = "VideoLibrary.GetMovieDetails";
        public const string GetRecentlyAddedMovies = "VideoLibrary.GetRecentlyAddedMovies";

        #endregion Movies

        #endregion VideoLibrary

        #region Files

        public const string GetFileDetails = "Files.GetFileDetails";
        public const string GetDirectory = "Files.GetDirectory";
        public const string PrepareDownload = "Files.PrepareDownload";

        #endregion Files

        #region Playlists

        public const string GetPlaylists = "Playlist.GetPlaylists";

        #endregion Playlists

        #region Player

        public const string PlayPause = "Player.PlayPause";
        public const string PlayerGetItem = "Player.GetItem";
        public const string PlayerGetProperties = "Player.GetProperties";

        #endregion Player

        #region System

        public const string Reboot = "System.Reboot";

        #endregion System
    }
}