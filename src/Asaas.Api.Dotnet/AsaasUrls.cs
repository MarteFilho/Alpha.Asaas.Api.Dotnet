using Asaas.Util;

namespace Asaas.Api.Dotnet;
public static class AsaasUrls
{
    static private readonly UriParameterFormatProvider _provider = new();

    public static readonly Uri ApiV3Sandbox = new("https://sandbox.asaas.com/api/v3/");
    public static readonly Uri ApiV3Production = new("https://www.asaas.com/api/v3/");

    public static readonly Uri Authorize = new("https://accounts.spotify.com/authorize");

    public static readonly Uri OAuthToken = new("https://accounts.spotify.com/api/token");

    public static Uri Me() => BaseAddress($"me");

    public static Uri User(string userId) => BaseAddress($"users/{userId}");

    public static Uri Customers() => BaseAddress($"customers");
    public static Uri Payments() => BaseAddress($"payments");
    public static Uri Subscriptions() => BaseAddress($"subscriptions");
    public static Uri Subscriptions(string id) => BaseAddress($"subscriptions/{id}");
    public static Uri TokenizeCreditCard() => BaseAddress($"creditcard/tokenize");
    public static Uri PixQrCode(string id) => BaseAddress($"payments/{id}/pixQrCode");
    public static Uri BilletIdentificationField(string id) => BaseAddress($"payments/{id}/identificationField");
    public static Uri Invoices() => BaseAddress($"invoices");

    public static Uri Categories() => BaseAddress($"browse/categories");

    public static Uri Category(string categoryId) => BaseAddress($"browse/categories/{categoryId}");

    public static Uri CategoryPlaylists(string categoryId) => BaseAddress($"browse/categories/{categoryId}/playlists");

    public static Uri Recommendations() => BaseAddress($"recommendations");

    public static Uri RecommendationGenres() => BaseAddress($"recommendations/available-genre-seeds");

    public static Uri NewReleases() => BaseAddress($"browse/new-releases");

    public static Uri FeaturedPlaylists() => BaseAddress($"browse/featured-playlists");

    public static Uri Show(string showId) => BaseAddress($"shows/{showId}");

    public static Uri Shows() => BaseAddress($"shows");

    public static Uri ShowEpisodes(string showId) => BaseAddress($"shows/{showId}/episodes");

    public static Uri PlaylistTracks(string playlistId) => BaseAddress($"playlists/{playlistId}/tracks");

    public static Uri UserPlaylists(string userId) => BaseAddress($"users/{userId}/playlists");

    public static Uri PlaylistImages(string playlistId) => BaseAddress($"playlists/{playlistId}/images");

    public static Uri Playlist(string playlistId) => BaseAddress($"playlists/{playlistId}");

    public static Uri CurrentUserPlaylists() => BaseAddress($"me/playlists");

    public static Uri Search() => BaseAddress($"search");

    public static Uri CurrentUserFollowerContains() => BaseAddress($"me/following/contains");

    public static Uri PlaylistFollowersContains(string playlistId) => BaseAddress($"playlists/{playlistId}/followers/contains");

    public static Uri CurrentUserFollower() => BaseAddress($"me/following");

    public static Uri PlaylistFollowers(string playlistId) => BaseAddress($"playlists/{playlistId}/followers");

    public static Uri Tracks() => BaseAddress($"tracks");

    public static Uri Track(string trackId) => BaseAddress($"tracks/{trackId}");

    public static Uri AudioAnalysis(string trackId) => BaseAddress($"audio-analysis/{trackId}");

    public static Uri AudioFeatures(string trackId) => BaseAddress($"audio-features/{trackId}");

    public static Uri AudioFeatures() => BaseAddress($"audio-features");

    public static Uri Player() => BaseAddress($"me/player");

    public static Uri PlayerQueue() => BaseAddress($"me/player/queue");

    public static Uri PlayerDevices() => BaseAddress($"me/player/devices");

    public static Uri PlayerCurrentlyPlaying() => BaseAddress($"me/player/currently-playing");

    public static Uri PlayerRecentlyPlayed() => BaseAddress($"me/player/recently-played");

    public static Uri PlayerPause() => BaseAddress($"me/player/pause");

    public static Uri PlayerResume() => BaseAddress($"me/player/play");

    public static Uri PlayerSeek() => BaseAddress($"me/player/seek");

    public static Uri PlayerRepeat() => BaseAddress($"me/player/repeat");

    public static Uri PlayerShuffle() => BaseAddress($"me/player/shuffle");

    public static Uri PlayerVolume() => BaseAddress($"me/player/volume");

    public static Uri PlayerNext() => BaseAddress($"me/player/next");

    public static Uri PlayerPrevious() => BaseAddress($"me/player/previous");

    public static Uri Albums() => BaseAddress($"albums");

    public static Uri Album(string albumId) => BaseAddress($"albums/{albumId}");

    public static Uri AlbumTracks(string albumId) => BaseAddress($"albums/{albumId}/tracks");

    public static Uri Artists() => BaseAddress($"artists");

    public static Uri Artist(string artistId) => BaseAddress($"artists/{artistId}");

    public static Uri ArtistAlbums(string artistId) => BaseAddress($"artists/{artistId}/albums");

    public static Uri ArtistTopTracks(string artistId) => BaseAddress($"artists/{artistId}/top-tracks");

    public static Uri ArtistRelatedArtists(string artistId) => BaseAddress($"artists/{artistId}/related-artists");

    public static Uri PersonalizationTop(string type) => BaseAddress($"me/top/{type}");

    public static Uri Episode(string episodeId) => BaseAddress($"episodes/{episodeId}");

    public static Uri Episodes() => BaseAddress($"episodes");

    public static Uri LibraryAlbumsContains() => BaseAddress($"me/albums/contains");

    public static Uri LibraryAlbums() => BaseAddress($"me/albums");

    public static Uri LibraryTracksContains() => BaseAddress($"me/tracks/contains");

    public static Uri LibraryTracks() => BaseAddress($"me/tracks");

    public static Uri LibraryShowsContains() => BaseAddress($"me/shows/contains");

    public static Uri LibraryShows() => BaseAddress($"me/shows");

    public static Uri LibraryEpisodes() => BaseAddress($"me/episodes");

    public static Uri LibraryEpisodesContains() => BaseAddress($"me/episodes/contains");

    private static Uri BaseAddress(FormattableString path) => new(path.ToString(_provider), UriKind.Relative);
}
