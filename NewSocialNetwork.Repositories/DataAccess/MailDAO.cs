﻿using NewSocialNetwork.Entities;
using NewSocialNetwork.Repositories;

namespace NewSocialNetwork.DataAccess
{
    public class MailDAO : DAO<Mail>, IMailRepository
    {
        public MailDAO() { }
    }
}