﻿using NewSocialNetwork.Entities;
using NewSocialNetwork.Repositories;

namespace NewSocialNetwork.DataAccess
{
    public class CustomRelationDAO : DAO<CustomRelation>, ICustomRelationRepository
    {
        public CustomRelationDAO() { }
    }
}