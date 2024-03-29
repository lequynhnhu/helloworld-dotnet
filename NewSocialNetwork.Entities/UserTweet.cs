﻿using Castle.ActiveRecord;

namespace NewSocialNetwork.Entities
{
    [ActiveRecord("[NSN.UserTweet]", "dbo", Lazy = true)]
    public class UserTweet : ActiveRecordValidationBase<UserTweet>, INSNEntity
    {
        [PrimaryKey(PrimaryKeyType.Identity, "TweetId")]
        public virtual int TweetId { get; set; }

        [BelongsTo("UserId", NotNull = true)]
        public virtual User User { get; set; }

        [BelongsTo("FriendUserId", NotNull = true)]
        public virtual User FriendUser { get; set; }

        [Property("Privacy", NotNull = true, Default = "0")]
        public virtual byte Privacy { get; set; }

        [Property("Content", ColumnType = "StringClob", SqlType = "NTEXT", NotNull = false)]
        public virtual string Content { get; set; }

        [Property("Timestamp", NotNull = true)]
        public virtual int Timestamp { get; set; }

        [Property("TotalComment", NotNull = true, Default = "0")]
        public virtual int TotalComment { get; set; }

        [Property("TotalLike", NotNull = true, Default = "0")]
        public virtual int TotalLike { get; set; }

        public UserTweet() { }
    }
}
