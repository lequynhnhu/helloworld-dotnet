﻿using NewSocialNetwork.Entities;
using NewSocialNetwork.Repositories;

namespace NewSocialNetwork.DataAccess
{
    public class EmotionDAO : DAO<Emotion>, IEmotionRepository
    {
        public EmotionDAO() { }
    }
}