﻿using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public class UserAccountRepository
    {
        public UserAccount? Get(string email)
        {
            BookScienceContext db = new BookScienceContext();
            return db.UserAccounts.FirstOrDefault(x => x.UserAddress == email);
        }
    }
}
