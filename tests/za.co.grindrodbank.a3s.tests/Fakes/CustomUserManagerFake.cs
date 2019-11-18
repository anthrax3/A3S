/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using za.co.grindrodbank.a3s.Managers;
using za.co.grindrodbank.a3s.Models;

namespace za.co.grindrodbank.a3s.tests.Fakes
{
    public class CustomUserManagerFake : CustomUserManager
    {
        private bool isAuthenticatorTokenVerified;
        private bool isAuthenticatorOtpValid;

        public CustomUserManagerFake(IUserStore<UserModel> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<UserModel> passwordHasher,
            IEnumerable<IUserValidator<UserModel>> userValidators, IEnumerable<IPasswordValidator<UserModel>> passwordValidators, ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<UserModel>> logger)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }

        public override bool IsAuthenticatorTokenVerified(UserModel user)
        {
            return isAuthenticatorTokenVerified;
        }

        public override Task<bool> VerifyTwoFactorTokenAsync(UserModel user, string tokenProvider, string token)
        {
            if (user != null && !string.IsNullOrWhiteSpace(tokenProvider) && !string.IsNullOrWhiteSpace(token))
                return Task.FromResult(isAuthenticatorOtpValid);
            else
                return Task.FromResult(false);
        }

        public void SetAuthenticatorTokenVerified(bool value)
        {
            isAuthenticatorTokenVerified = value;
        }

        public void SetAuthenticatorOtpValid(bool value)
        {
            isAuthenticatorOtpValid = value;
        }
    }
}
