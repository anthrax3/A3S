/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
/*
 * A3S
 *
 * API Definition for A3S. This service allows authentication, authorisation and accounting.
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
    public abstract class TermsOfServiceApiController : ControllerBase
    { 
        /// <summary>
        /// Create a new terms of service entry.
        /// </summary>
        /// <remarks>Create a new terms of service entry.</remarks>
        /// <param name="termsOfServiceSubmit"></param>
        /// <response code="200">OK.</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to create terms of service entries.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPost]
        [Route("/termsOfService", Name = "CreateTermsOfService")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(TermsOfService))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> CreateTermsOfServiceAsync([FromBody]TermsOfServiceSubmit termsOfServiceSubmit);

        /// <summary>
        /// Delete a terms of service entry.
        /// </summary>
        /// <remarks>Deletes a terms of service entry from A3S.</remarks>
        /// <param name="termsOfServiceId">The UUID of the terms of service entry to delete.</param>
        /// <response code="204">No Content.</response>
        /// <response code="400">Invalid parameters.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - Not authorized to delete terms of service entry.</response>
        /// <response code="404">Terms of service entry not found.</response>
        /// <response code="422">Terms of service entry cannot be deleted.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpDelete]
        [Route("/termsOfService/{termsOfServiceId}", Name = "DeleteTermsOfService")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> DeleteTermsOfServiceAsync([FromRoute][Required]Guid termsOfServiceId);

        /// <summary>
        /// Get a terms of service entry.
        /// </summary>
        /// <remarks>Get a terms of service entry by its UUID.</remarks>
        /// <param name="termsOfServiceId">Terms of service entry</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access the terms of service entry.</response>
        /// <response code="404">Terms of service entry not found.</response>
        /// <response code="500">An unexpected error occurred</response>
        [HttpGet]
        [Route("/termsOfService/{termsOfServiceId}", Name = "GetTermsOfService")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(TermsOfService))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> GetTermsOfServiceAsync([FromRoute][Required]Guid termsOfServiceId);

        /// <summary>
        /// Search for terms of service entries.
        /// </summary>
        /// <remarks>Search for terms of service entries.</remarks>
        /// <param name="page">The page to view.</param>
        /// <param name="size">The size of a page.</param>
        /// <param name="includeRelations">Determines whether the related entities, such as teams and which users accepted the agreement, are returned.</param>
        /// <param name="filterAgreementName">A search query filter on the agreement&#39;s name.</param>
        /// <param name="orderBy">a comma separated list of fields in their sort order. Ascending order is assumed. Append &#39;_desc&#39; after a field to indicate descending order. Supported fields. &#39;agreementName&#39;.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access the list of terms of service entries.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/termsOfService", Name = "ListTermsOfServices")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<TermsOfServiceListItem>))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> ListTermsOfServicesAsync([FromQuery]int page, [FromQuery][Range(1, 20)]int size, [FromQuery]bool includeRelations, [FromQuery][StringLength(255, MinimumLength=0)]string filterAgreementName, [FromQuery]string orderBy);
    }
}
