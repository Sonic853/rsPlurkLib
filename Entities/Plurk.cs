using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Contains Plurk and Response. PlurkBase 
namespace RenRen.Plurk.Entities;
/// <summary>
/// Define common properties shared between plurks and responses.
/// </summary>
/// <remarks>Reserved for some convenience case where it's not important 
/// whether a plurk is either a standalone plurk or as a response.</remarks>
public class PlurkBase
{
    [JsonProperty("owner_id")]
    public long OwnerId { get; set; } = -1;
    [JsonProperty("user_id")]
    public long UserId { get; set; } = -1;
    [JsonProperty("posted")]
    public DateTime? Posted { get; set; }
    [JsonProperty("plurk_id")]
    public long PlurkId { get; set; } = -1;
    [JsonProperty("qualifier")]
    public string Qualifier { get; set; } = string.Empty;
    [JsonProperty("qualifier_translated")]
    public string QualifierTranslated { get; set; } = string.Empty;
    [JsonProperty("content")]
    public string Content { get; set; } = string.Empty;
    [JsonProperty("content_raw")]
    public string ContentRaw { get; set; } = string.Empty;
    [JsonProperty("lang")]
    public string Lang { get; set; } = string.Empty;
}

/// <summary>
/// Represents a plurk.
/// </summary>
public class Plurk : PlurkBase
{
    [JsonProperty("is_unread")]
    public int IsUnread { get; set; } = -1;
    [JsonProperty("plurk_type")]
    public int PlurkType { get; set; }
    [JsonProperty("no_comments")]
    public int NoComments { get; set; } = -1;
    [JsonProperty("response_count")]
    public int ResponseCount { get; set; } = -1;
    [JsonProperty("responses_seen")]
    public int ResponsesSeen { get; set; } = -1;
    [JsonProperty("limited_to")]
    public string LimitedTo { get; set; } = string.Empty;
    [JsonProperty("favorite")]
    public bool Favorite { get; set; } = false;
    [JsonProperty("favorite_count")]
    public int FavoriteCount { get; set; } = -1;
    [JsonProperty("favorers")]
    public int[] Favorers { get; set; } = [];
    [JsonProperty("replurkable")]
    public bool Replurkable { get; set; } = false;
    [JsonProperty("replurked")]
    public bool Replurked { get; set; } = false;
    [JsonProperty("replurker_id")]
    public long? ReplurkerId { get; set; } = -1;
    [JsonProperty("replurkers_count")]
    public int ReplurkersCount { get; set; } = -1;
    [JsonProperty("replurkers")]
    public int[] Replurkers { get; set; } = [];
}

/// <summary>
/// Represents a plurk response.
/// </summary>
public class Response : PlurkBase
{
    public long id { get; set; }
}
