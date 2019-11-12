/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using za.co.grindrodbank.a3s.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using za.co.grindrodbank.a3s.A3SApiResources;
using za.co.grindrodbank.a3s.AbstractApiControllers;
using za.co.grindrodbank.a3s.Helpers;
using System.Security.Claims;

namespace za.co.grindrodbank.a3s.Controllers
{
    public class UserController : UserApiController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [Authorize(Policy = "permission:a3s.users.create")]
        public async override Task<IActionResult> CreateUserAsync([FromBody] UserSubmit userSubmit)
        {
            var loggedOnUser = ClaimsHelper.GetScalarClaimValue<Guid>(User, ClaimTypes.NameIdentifier, Guid.Empty);
            return Ok(await userService.CreateAsync(userSubmit, loggedOnUser));
        }

        [Authorize(Policy = "permission:a3s.users.read")]
        public async override Task<IActionResult> GetUserAsync([FromRoute, Required] Guid userId)
        {
            if (userId == Guid.Empty)
                return BadRequest();

            var user = await userService.GetByIdAsync(userId, true);

            if(user == null)
                return NotFound();

            return Ok(user);
        }

        [Authorize(Policy = "permission:a3s.users.read")]
        public async override Task<IActionResult> ListUsersAsync([FromQuery] bool teams, [FromQuery] bool roles, [FromQuery] bool functions, [FromQuery, StringLength(5, MinimumLength = 2)] string locale, [FromQuery] int page, [FromQuery, Range(1, 20)] int size, [FromQuery, StringLength(255, MinimumLength = 0)] string filterName, [FromQuery] string filterUsername, [FromQuery] List<string> orderBy)
        {
            return Ok(await userService.GetListAsync());
        }

        [Authorize(Policy = "permission:a3s.users.update")]
        public async override Task<IActionResult> UpdateUserAsync([FromRoute, Required] Guid userId, [FromBody] UserSubmit userSubmit)
        {
            if (userId == Guid.Empty || userSubmit.Uuid == Guid.Empty)
                return BadRequest();

            var loggedOnUser = ClaimsHelper.GetScalarClaimValue<Guid>(User, ClaimTypes.NameIdentifier, Guid.Empty);
            return Ok(await userService.UpdateAsync(userSubmit, loggedOnUser));
        }

        [Authorize(Policy = "permission:a3s.users.delete")]
        public async override Task<IActionResult> DeleteUserAsync([FromRoute, Required] Guid userId)
        {
            if (userId == Guid.Empty)
                return BadRequest();

            await userService.DeleteAsync(userId);
            return NoContent();
        }

        [Authorize(Policy = "permission:a3s.users.update")]
        public async override Task<IActionResult> ChangeUserPasswordAsync([FromRoute, Required] Guid userId, [FromBody] UserPasswordChangeSubmit userPasswordChangeSubmit)
        {
            if (userId == Guid.Empty || userPasswordChangeSubmit.Uuid == Guid.Empty)
                return BadRequest();

            await userService.ChangePasswordAsync(userPasswordChangeSubmit);
            return NoContent();
        }
    }
}
