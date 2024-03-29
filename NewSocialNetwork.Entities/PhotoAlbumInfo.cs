﻿using Castle.ActiveRecord;

namespace NewSocialNetwork.Entities
{
    [ActiveRecord("[NSN.PhotoAlbumInfo]", "dbo", Lazy = true)]
    public class PhotoAlbumInfo : ActiveRecordValidationBase<PhotoAlbumInfo>, INSNEntity
    {
        #region Properties

        [PrimaryKey(PrimaryKeyType.Foreign, "AlbumId")]
        public virtual int AlbumId { get; set; }

        [OneToOne]
        public virtual PhotoAlbum Album { get; set; }

        [Property("Description", NotNull = true)]
        public virtual string Description { get; set; }

        #endregion

        public PhotoAlbumInfo() { }
    }
}
