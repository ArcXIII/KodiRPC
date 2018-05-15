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

using System.Collections.Generic;
using System.Configuration;
using KodiRPC.Responses.Files;
using KodiRPC.Responses.Player;
using KodiRPC.Responses.Types.Player;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.Connector;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.Files;
using KodiRPC.RPC.RequestResponse.Params.Player;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications;
using KodiRPC.RPC.Specifications.Properties;
using PlayerProperties = KodiRPC.Responses.Types.Player.PlayerProperties;

namespace KodiRPC.Services
{
    public class KodiService : IKodiService
    {
        private readonly RpcConnector _rpcConnector;
        public readonly string ApiVersion = "v6";
        public readonly string Host;
        public readonly string Port;
        public readonly string Username;
        public readonly string Password;

        public KodiService()
        {
            _rpcConnector = new RpcConnector(this);
            Host = ConfigurationManager.AppSettings["KodiHost"];
            Port = ConfigurationManager.AppSettings["KodiPort"];
            Username = ConfigurationManager.AppSettings["KodiUsername"];
            Password = ConfigurationManager.AppSettings["KodiPassword"];
        }

        public KodiService(string host, string port, string username, string password)
        {
            _rpcConnector = new RpcConnector(this);
            Host = host;
            Port = port;
            Username = username;
            Password = password;
        }

        #region JSONRPC

        public JsonRpcResponse<string> Ping()
        {
            return _rpcConnector.MakeRequest<string>(KodiMethods.Ping, new object(), timeout: 2000);
        }

        #endregion JSONRPC

        #region VideoLibrary

        #region Shows

        public JsonRpcResponse<string> Clean(CleanParams parameters, string requestId = "VideoLibrary.Clean")
        {
            return _rpcConnector.MakeRequest<string>(KodiMethods.Clean, parameters, requestId);
        }

        public JsonRpcResponse<string> Scan(ScanParams parameters, string requestId = "VideoLibrary.Scan")
        {
            return _rpcConnector.MakeRequest<string>(KodiMethods.Scan, parameters, requestId);
        }

        public JsonRpcResponse<GetTvShowsResponse> GetTvShows(GetTvShowsParams parameters, string requestId = "GetTvShowsResponse")
        {
            return _rpcConnector.MakeRequest<GetTvShowsResponse>(KodiMethods.GetTvShows, parameters, requestId);
        }

        public JsonRpcResponse<GetTvShowDetailsResponse> GetTvShowDetails(GetTvShowDetailsParams parameters, string requestId = "GetTvShowDetailsResponse")
        {
            return _rpcConnector.MakeRequest<GetTvShowDetailsResponse>(KodiMethods.GetTvShowDetails, parameters, requestId);
        }

        public JsonRpcResponse<GetSeasonsResponse> GetSeasons(GetSeasonsParams parameters = null, string requestId = "GetSeasonsResponse")
        {
            return _rpcConnector.MakeRequest<GetSeasonsResponse>(KodiMethods.GetSeasons, parameters, requestId);
        }

        public JsonRpcResponse<GetEpisodesResponse> GetEpisodes(GetEpisodesParams parameters, string requestId = "GetEpisodesResponse")
        {
            return _rpcConnector.MakeRequest<GetEpisodesResponse>(KodiMethods.GetEpisodes, parameters, requestId);
        }

        public JsonRpcResponse<GetEpisodeDetailsResponse> GetEpisodeDetails(GetEpisodeDetailsParams parameters, string requestId = "GetTvShowDetailsResponse")
        {
            return _rpcConnector.MakeRequest<GetEpisodeDetailsResponse>(KodiMethods.GetEpisodeDetails, parameters, requestId);
        }

        public JsonRpcResponse<GetRecentlyAddedEpisodesResponse> GetRecentlyAddedEpisodes(GetRecentlyAddedEpisodesParams parameters = null,
            string requestId = "GetRecentlyAddedEpisodesResponse")
        {
            return _rpcConnector.MakeRequest<GetRecentlyAddedEpisodesResponse>(KodiMethods.GetRecentlyAddedEpisodes, parameters, requestId);
        }

        #endregion Shows

        #region Movies

        public JsonRpcResponse<GetMoviesResponse> GetMovies(GetMoviesParams parameters, string requestId = "GetMoviesResponse")
        {
            return _rpcConnector.MakeRequest<GetMoviesResponse>(KodiMethods.GetMovies, parameters, requestId);
        }

        public JsonRpcResponse<GetMovieDetailsResponse> GetMovieDetails(GetMovieDetailsParams parameters, string requestId = "GetMovieDetailsResponse")
        {
            return _rpcConnector.MakeRequest<GetMovieDetailsResponse>(KodiMethods.GetMovieDetails, parameters, requestId);
        }

        public JsonRpcResponse<GetRecentlyAddedMoviesResponse> GetRecentlyAddedMovies(GetRecentlyAddedMoviesParams parameters = null,
            string requestId = "GetRecentlyAddedMoviesResponse")
        {
            return _rpcConnector.MakeRequest<GetRecentlyAddedMoviesResponse>(KodiMethods.GetRecentlyAddedMovies, parameters, requestId);
        }

        #endregion Movies

        #endregion VideoLibrary

        #region Files

        public JsonRpcResponse<GetFileDetailsResponse> GetFileDetails(GetFileDetailsParams parameters, string requestId = "GetFileDetails")
        {
            return _rpcConnector.MakeRequest<GetFileDetailsResponse>(KodiMethods.GetFileDetails, parameters, requestId);
        }

        public JsonRpcResponse<GetDirectoryResponse> GetDirectory(GetDirectoryParams parameters, string requestId = "GetDirectory")
        {
            return _rpcConnector.MakeRequest<GetDirectoryResponse>(KodiMethods.GetDirectory, parameters, requestId);
        }

        public JsonRpcResponse<PrepareDownloadResponse> PrepareDownload(PrepareDownloadParams parameters, string requestId = "PrepareDownload")
        {
            return _rpcConnector.MakeRequest<PrepareDownloadResponse>(KodiMethods.PrepareDownload, parameters, requestId);
        }

        #endregion Files

        #region Playlist

        public JsonRpcResponse<List<Playlist>> GetPlaylists(string requestId = "GetPlaylists")
        {
            return _rpcConnector.MakeRequest<List<Playlist>>(KodiMethods.GetPlaylists, new object(), requestId);
        }

        #endregion Playlist

        #region Player

        public JsonRpcResponse<PlayPauseResponse> PlayPause(int playerId = 1, string requestId = "PlayPause")
        {
            return _rpcConnector.MakeRequest<PlayPauseResponse>(KodiMethods.PlayPause,
                new PlayPauseParams { PlayerId = playerId }, requestId);
        }

        public JsonRpcResponse<GetItemResponse> PlayerGetItem(int playerId = 1, string[] props = null, string requestId = "PlayerGetItem")
        {
            return _rpcConnector.MakeRequest<GetItemResponse>(KodiMethods.PlayerGetItem, new GetItemParams { PlayerId = playerId, Properties = props ?? new string[0] }, requestId);
        }

        public JsonRpcResponse<PlayerProperties> PlayerGetProperty(int playerId = 1, string[] props = null,
            string requestId = "PlayerGetProperty")
        {
            return _rpcConnector.MakeRequest<PlayerProperties>(KodiMethods.PlayerGetProperties,
                new GetPropertyParams { PlayerId = playerId, Properties = props ?? RPC.Specifications.Properties.PlayerProperties.All() });
        }

        #endregion Player

        #region System

        public JsonRpcResponse<string> Reboot(string requestId = "Reboot")
        {
            return _rpcConnector.MakeRequest<string>(KodiMethods.Reboot, new object(), requestId);
        }

        #endregion System
    }
}