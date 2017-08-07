﻿using System;
using Octopus.Data.Model.User;

namespace Octopus.Data.Storage.User
{
    public interface IUserStore
    {
        UserCreateOrUpdateResult GetOrCreateUser(string username, string displayName, string emailAddress, string externalId, ApiKeyDescriptor apiKeyDescriptor = null);

        IUser GetById(string userId);
        IUser GetByUsername(string username);
        IUser GetByIdentificationToken(Guid identificationToken);

        UserCreateOrUpdateResult Create(string username, string displayName, string emailAddress, string externalId, ApiKeyDescriptor apiKeyDescriptor = null, string id = null, string password = null, bool isService = false, bool generateRandomPasswordOnCreate = false);

        UserCreateOrUpdateResult CreateOrUpdate(
            string username,
            string displayName,
            string emailAddress,
            string externalId,
            ApiKeyDescriptor apiKeyDescriptor,
            bool generateRandomPasswordOnCreate,
            string password,
            bool isService);

        void EnableUser(string userId);
        void DisableUser(string userId);
    }
}