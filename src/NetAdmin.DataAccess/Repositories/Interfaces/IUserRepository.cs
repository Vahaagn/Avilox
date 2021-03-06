﻿using NetAdmin.Common.Abstractions;

namespace NetAdmin.DataAccess
{
    public interface IUserRepository :
        IInsertable<User>,
        IUpdatable<User>,
        IDeletable<User>,
        IObtainable<User>
    {
        User GetByName(string name);
    }
}