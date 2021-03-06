﻿using NetAdmin.Common.Abstractions;

namespace NetAdmin.Application
{
    public interface IConnectionService : IService
    {
        void AddConnection(ConnectionAddRequest request);
    }
}