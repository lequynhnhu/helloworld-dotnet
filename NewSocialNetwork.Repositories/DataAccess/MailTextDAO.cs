﻿using NewSocialNetwork.Entities;
using NewSocialNetwork.Repositories;

namespace NewSocialNetwork.DataAccess
{
    public class MailTextDAO : DAO<MailText>, IMailTextRepository
    {
        public MailTextDAO() { }
    }
}