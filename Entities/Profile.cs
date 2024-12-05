using Newtonsoft.Json;

namespace RenRen.Plurk.Entities;

public class Profile
{
    [JsonProperty("are_friends")]
    public bool AreFriends { get; set; } = false;
    [JsonProperty("is_fan")]
    public bool IsFan { get; set; } = false;
    [JsonProperty("is_following")]
    public bool IsFollowing { get; set; } = false;
    [JsonProperty("is_following_replurk")]
    public bool IsFollowingReplurk { get; set; } = false;
    [JsonProperty("friend_status")]
    public int FriendStatus { get; set; } = -1;
    [JsonProperty("blocked_by_me")]
    public bool BlockedByMe { get; set; } = false;
    [JsonProperty("alias")]
    public string Alias { get; set; } = string.Empty;
    [JsonProperty("has_read_permission")]
    public bool HasReadPermission { get; set; } = false;
    [JsonProperty("plurks")]
    public List<Plurk> Plurks { get; set; } = new();
    [JsonProperty("user_info")]
    public User UserInfo { get; set; } = new();
    [JsonProperty("friends_count")]
    public int FriendsCount { get; set; } = -1;
    [JsonProperty("fans_count")]
    public int FansCount { get; set; } = -1;
    [JsonProperty("privacy")]
    public string Privacy { get; set; } = string.Empty;
}
