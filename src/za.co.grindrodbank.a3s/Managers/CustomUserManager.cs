/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using za.co.grindrodbank.a3s.Models;
using za.co.grindrodbank.a3s.Stores;

namespace za.co.grindrodbank.a3s.Managers
{
    public class CustomUserManager : UserManager<UserModel>
    {
        private readonly CustomUserStore store;
        
        public CustomUserManager(IUserStore<UserModel> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<UserModel> passwordHasher,
            IEnumerable<IUserValidator<UserModel>> userValidators, IEnumerable<IPasswordValidator<UserModel>> passwordValidators, ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors, IServiceProvider services,ILogger<UserManager<UserModel>> logger)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            this.store = (CustomUserStore)store;
        }

        public async Task SetAuthenticatorTokenVerifiedAsync(UserModel user)
        {
            ThrowIfDisposed();
            await store.SetAuthenticatorTokenVerifiedAsync(user);
        }

        public virtual bool IsAuthenticatorTokenVerified(UserModel user)
        {
            ThrowIfDisposed();
            return store.IsAuthenticatorTokenVerified(user);
        }
    }
}
