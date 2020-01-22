/*
 * A3S
 *
 * API Definition for the A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 1.0.5
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using za.co.grindrodbank.a3s.Attributes;
using Microsoft.AspNetCore.Authorization;
using za.co.grindrodbank.a3s.A3SApiResources;

namespace za.co.grindrodbank.a3s.AbstractApiControllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class UserApiController : ControllerBase
    { 
        /// <summary>
        /// Change a user password.
        /// </summary>
        /// <remarks>Change a user password.</remarks>
        /// <param name="userId">The UUID of the user.</param>
        /// <param name="userPasswordChangeSubmit"></param>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized update user passwords.</response>
        /// <response code="404">User not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPut]
        [Route("/users/{userId}/changePassword", Name = "ChangeUserPassword")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> ChangeUserPasswordAsync([FromRoute][Required]Guid userId, [FromBody]UserPasswordChangeSubmit userPasswordChangeSubmit);

        /// <summary>
        /// Create a User.
        /// </summary>
        /// <remarks>Create a new User.</remarks>
        /// <param name="userSubmit"></param>
        /// <response code="200">Successful. User created.</response>
        /// <response code="400">Invalid parameters.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - Not authorized to create a user.</response>
        /// <response code="404">Related user entity (such as role or team) not found.</response>
        /// <response code="422">Non-Processible entity. The request was correctly structured, but some business rules were violated, preventing the user creation.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPost]
        [Route("/users", Name = "CreateUser")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(UserSubmit))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> CreateUserAsync([FromBody]UserSubmit userSubmit);

        /// <summary>
        /// Create a user profile.
        /// </summary>
        /// <remarks>Create a new user profile for a user. UUID not required in request body.</remarks>
        /// <param name="userId">The UUID of the user.</param>
        /// <param name="userProfileSubmit"></param>
        /// <response code="200">Successful. User profile created.</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized create user profiles.</response>
        /// <response code="404">User not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPost]
        [Route("/users/{userId}/profiles", Name = "CreateUserProfile")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(UserProfile))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> CreateUserProfileAsync([FromRoute][Required]Guid userId, [FromBody]UserProfileSubmit userProfileSubmit);

        /// <summary>
        /// Delete a user.
        /// </summary>
        /// <remarks>Mark a user as deleted.</remarks>
        /// <param name="userId">The user to delete.</param>
        /// <response code="204">No Content.</response>
        /// <response code="400">Invalid parameters.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - Not authorized to delete users.</response>
        /// <response code="404">User not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpDelete]
        [Route("/users/{userId}", Name = "DeleteUser")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> DeleteUserAsync([FromRoute][Required]Guid userId);

        /// <summary>
        /// Delete a user profile.
        /// </summary>
        /// <remarks>Deletes a user&#39;s profile.</remarks>
        /// <param name="userId">The UUID of the user.</param>
        /// <param name="profileId">The UUID of the user profile.</param>
        /// <response code="204">No Content.</response>
        /// <response code="400">Invalid parameters.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - Not authorized to delete user profiles.</response>
        /// <response code="404">User or user profile not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpDelete]
        [Route("/users/{userId}/profiles/{profileId}", Name = "DeleteUserProfile")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> DeleteUserProfileAsync([FromRoute][Required]Guid userId, [FromRoute][Required]Guid profileId);

        /// <summary>
        /// Get a user by its UUID.
        /// </summary>
        /// <remarks>Get a user.</remarks>
        /// <param name="userId">The UUID of the user</param>
        /// <response code="200">OK.</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access this user.</response>
        /// <response code="404">User not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/users/{userId}", Name = "GetUser")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(User))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> GetUserAsync([FromRoute][Required]Guid userId);

        /// <summary>
        /// Get a user&#39;s profile by its UUID.
        /// </summary>
        /// <remarks>Get a user profile.</remarks>
        /// <param name="userId">The UUID of the user.</param>
        /// <param name="profileId">The UUID of the user profile.</param>
        /// <response code="200">OK.</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access this user&#39;s profile.</response>
        /// <response code="404">User or user profile not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/users/{userId}/profiles/{profileId}", Name = "GetUserProfile")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(UserProfile))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> GetUserProfileAsync([FromRoute][Required]Guid userId, [FromRoute][Required]Guid profileId);

        /// <summary>
        /// Search a user for all their profiles.
        /// </summary>
        /// <remarks>Search for user profiles.</remarks>
        /// <param name="userId">The UUID of the user.</param>
        /// <param name="page">The page to view.</param>
        /// <param name="size">The size of a page.</param>
        /// <param name="filterName">A search query filter on the User profile&#39;s name.</param>
        /// <param name="orderBy">a comma separated list of fields in their sort order. Ascending order is assumed. Append desc after a field to indicate descending order.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access the list of user profiles for this user.</response>
        /// <response code="404">User not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/users/{userId}/profiles", Name = "ListUserProfiles")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<UserProfile>))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> ListUserProfilesAsync([FromRoute][Required]Guid userId, [FromQuery]int page, [FromQuery][Range(1, 20)]int size, [FromQuery][StringLength(255, MinimumLength=0)]string filterName, [FromQuery]List<string> orderBy);

        /// <summary>
        /// Search for users.
        /// </summary>
        /// <remarks>Search for users.</remarks>
        /// <param name="teams">Whether to fill in the teams member field</param>
        /// <param name="roles">Whether to fill in the roles member field</param>
        /// <param name="functions">Whether to fill in the functions member field</param>
        /// <param name="locale">If this field is set, translate all applicable fields to a specific locale </param>
        /// <param name="page">The page to view.</param>
        /// <param name="size">The size of a page.</param>
        /// <param name="filterName">A search query filter on the User&#39;s name.</param>
        /// <param name="filterUsername">A search query filter on the User&#39;s username</param>
        /// <param name="orderBy">a comma separated list of fields in their sort order. Ascending order is assumed. Append desc after a field to indicate descending order.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden -  You are not authorized to access the list of users.</response>
        /// <response code="404">User list not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/users", Name = "ListUsers")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<User>))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> ListUsersAsync([FromQuery]bool teams, [FromQuery]bool roles, [FromQuery]bool functions, [FromQuery][StringLength(5, MinimumLength=2)]string locale, [FromQuery]int page, [FromQuery][Range(1, 20)]int size, [FromQuery][StringLength(255, MinimumLength=0)]string filterName, [FromQuery]string filterUsername, [FromQuery]List<string> orderBy);

        /// <summary>
        /// Update a user.
        /// </summary>
        /// <remarks>Update a user and its associations to teams and roles.</remarks>
        /// <param name="userId">The user to update.</param>
        /// <param name="userSubmit"></param>
        /// <response code="200">Successful. User Updated.</response>
        /// <response code="400">Invalid parameters.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - Not authorized to update users.</response>
        /// <response code="404">User or related entity not found.</response>
        /// <response code="422">Non-Processible entity. The request was correctly structured, but some business rules were violated, preventing the user update.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPut]
        [Route("/users/{userId}", Name = "UpdateUser")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(User))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> UpdateUserAsync([FromRoute][Required]Guid userId, [FromBody]UserSubmit userSubmit);

        /// <summary>
        /// Update a user profile.
        /// </summary>
        /// <remarks>Update an existing user profile.</remarks>
        /// <param name="userId">The UUID of the user.</param>
        /// <param name="profileId">The UUID of the user profile.</param>
        /// <param name="userProfileSubmit"></param>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized update user profiles.</response>
        /// <response code="404">User or user profile not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPut]
        [Route("/users/{userId}/profiles/{profileId}", Name = "UpdateUserProfile")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> UpdateUserProfileAsync([FromRoute][Required]Guid userId, [FromRoute][Required]Guid profileId, [FromBody]UserProfileSubmit userProfileSubmit);
    }
}
