using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelersChosen.Data
{
    public class DestinyUserInfo
    {
        public string LastSeenDisplayName { get; set; }
        public int LastSeenDisplayNameType { get; set; }
        public string iconPath { get; set; }
        public int crossSaveOverride { get; set; }
        public List<int> applicableMembershipTypes { get; set; }
        public bool isPublic { get; set; }
        public int membershipType { get; set; }
        public string membershipId { get; set; }
        public string displayName { get; set; }
    }

    public class BungieNetUserInfo
    {
        public string supplementalDisplayName { get; set; }
        public string iconPath { get; set; }
        public int crossSaveOverride { get; set; }
        public bool isPublic { get; set; }
        public int membershipType { get; set; }
        public string membershipId { get; set; }
        public string displayName { get; set; }
    }

    public class ClanMemeber
    {
        public int memberType { get; set; }
        public bool isOnline { get; set; }
        public string lastOnlineStatusChange { get; set; }
        public string groupId { get; set; }
        public DestinyUserInfo destinyUserInfo { get; set; }
        public BungieNetUserInfo bungieNetUserInfo { get; set; }
        public DateTime joinDate { get; set; }
    }

    public class Query
    {
        public int itemsPerPage { get; set; }
        public int currentPage { get; set; }
    }

    public class Response
    {
        public List<ClanMemeber> results { get; set; }
        public int totalResults { get; set; }
        public bool hasMore { get; set; }
        public Query query { get; set; }
        public bool useTotalResults { get; set; }
    }

    public class MessageData
    {
    }

    public class ResponseData
    {
        public Response Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public MessageData MessageData { get; set; }
    }
}
