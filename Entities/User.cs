using Newtonsoft.Json;

namespace RenRen.Plurk.Entities;
/// <summary>
/// Contains information of a Plurk user.
/// </summary>
public class User
{
    [JsonProperty("id")]
    public long ID { get; set; } = -1;
    [JsonProperty("nick_name")]
    public string NickName { get; set; } = string.Empty;
    [JsonProperty("display_name")]
    public string DisplayName { get; set; } = string.Empty;
    [JsonProperty("avatar")]
    public long? Avatar { get; set; } = -1;
    [JsonProperty("premium")]
    public bool Premium { get; set; } = false;
    [JsonProperty("date_of_birth")]
    public DateTime? DateOfBirth { get; set; } = null;
    [JsonProperty("status")]
    public string Status { get; set; } = string.Empty;
    // [JsonProperty("name_color")]
    // public string NameColor { get; set; } = string.Empty;
    [JsonProperty("bday_privacy")]
    public int BdayPrivacy { get; set; } = -1;
    [JsonProperty("birthday")]
    public UserBirthday Birthday { get; set; } = new();
    [JsonProperty("has_profile_image")]
    public bool HasProfileImage { get; set; } = false;
    [JsonProperty("timeline_privacy")]
    public int TimelinePrivacy { get; set; } = -1;
    [JsonProperty("gender")]
    public int Gender { get; set; } = -1;
    [JsonProperty("karma")]
    public float Karma { get; set; } = -1;
    [JsonProperty("verified_account")]
    public bool VerifiedAccount { get; set; } = false;
    [JsonProperty("dateformat")]
    public int Dateformat { get; set; } = -1;
    [JsonProperty("default_lang")]
    public string DefaultLang { get; set; } = string.Empty;
    [JsonProperty("friend_list_privacy")]
    public string FriendListPrivacy { get; set; } = string.Empty;
    [JsonProperty("show_location")]
    public bool ShowLocation { get; set; } = false;
    [JsonProperty("full_name")]
    public string FullName { get; set; } = string.Empty;
    [JsonProperty("relationship")]
    public string Relationship { get; set; } = string.Empty;
    [JsonProperty("location")]
    public string Location { get; set; } = string.Empty;
    [JsonProperty("timezone")]
    public string Timezone { get; set; } = string.Empty;
    [JsonProperty("email_confirmed")]
    public bool EmailConfirmed { get; set; } = false;
    // phone_verified
    [JsonProperty("pinned_plurk_id")]
    public long? PinnedPlurkID { get; set; } = -1;
    [JsonProperty("background_id")]
    public int BackgroundID { get; set; } = -1;
    [JsonProperty("recruited")]
    public int Recruited { get; set; } = -1;
    [JsonProperty("show_ads")]
    public bool ShowAds { get; set; } = false;
    [JsonProperty("_version")]
    public string Version { get; set; } = string.Empty;
    [JsonProperty("profile_views")]
    public int ProfileViews { get; set; } = -1;
    [JsonProperty("avatar_small")]
    public string AvatarSmall { get; set; } = string.Empty;
    [JsonProperty("avatar_medium")]
    public string AvatarMedium { get; set; } = string.Empty;
    [JsonProperty("avatar_big")]
    public string AvatarBig { get; set; } = string.Empty;
    [JsonProperty("about")]
    public string About { get; set; } = string.Empty;
    [JsonProperty("about_renderred")]
    public string AboutRenderred { get; set; } = string.Empty;
    // page_title
    [JsonProperty("friends_count")]
    public int FriendsCount { get; set; } = -1;
    [JsonProperty("fans_count")]
    public int FansCount { get; set; } = -1;
    [JsonProperty("join_date")]
    public DateTime? JoinDate { get; set; } = null;
    [JsonProperty("plurks_count")]
    public int PlurksCount { get; set; } = -1;
    [JsonProperty("responses_count")]
    public int ResponsesCount { get; set; } = -1;
    // hide_plurks_before
    [JsonProperty("accept_private_plurk_from")]
    public string AcceptPrivatePlurkFrom { get; set; } = string.Empty;
    [JsonProperty("privacy")]
    public string Privacy { get; set; } = string.Empty;
    [JsonProperty("post_anonymous_plurk")]
    public bool PostAnonymousPlurk { get; set; } = false;
    [JsonProperty("badges")]
    public string[] Badges { get; set; } = [];
    [JsonProperty("uid")]
    public long UID { get; set; } = -1;
}
public class UserBirthday
{
    [JsonProperty("year")]
    public int? Year { get; set; } = -1;
    [JsonProperty("month")]
    public int? Month { get; set; } = -1;
    [JsonProperty("day")]
    public int? Day { get; set; } = -1;
}
