﻿namespace TwitterSharp.Rule
{
    public enum ExpressionType
    {
        Or, And, Keyword, Hashtag, Cashtag, Mention, Author, Recipient, Url, Retweet, Context, Entity, 
        ConversationId, Bio, BioLocation, Place, PlaceCountry, PointRadius, BoundingBox, IsRetweet, IsReply, IsQuote, 
        IsVerified, IsNotNullcast, HasHashtags, HasCashtags, HasLinks, HasMentions, HasMedia, HasImages, HasVideos,
        HasGeo, Sample, Lang, FollowersCount, TweetsCount, FollowingCount, ListedCount, UrlTitle, UrlDescription, 
        UrlContains, Source, InReplyToTweetId, RetweetsOfTweetId
    }
}
