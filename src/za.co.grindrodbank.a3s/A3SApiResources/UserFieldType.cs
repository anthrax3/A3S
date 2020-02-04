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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using za.co.grindrodbank.a3s.Converters;

namespace za.co.grindrodbank.a3s.A3SApiResources
{ 
        /// <summary>
        /// Enumeration to describe with what user field you're busy with 
        /// </summary>
        /// <value>Enumeration to describe with what user field you're busy with </value>
        [TypeConverter(typeof(CustomEnumConverter<UserFieldType>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum UserFieldType
        {
            
            /// <summary>
            /// Enum UserNameEnum for userName
            /// </summary>
            [EnumMember(Value = "userName")]
            UserNameEnum = 1,
            
            /// <summary>
            /// Enum FirstNameEnum for firstName
            /// </summary>
            [EnumMember(Value = "firstName")]
            FirstNameEnum = 2,
            
            /// <summary>
            /// Enum SurnameEnum for surname
            /// </summary>
            [EnumMember(Value = "surname")]
            SurnameEnum = 3,
            
            /// <summary>
            /// Enum EmailEnum for email
            /// </summary>
            [EnumMember(Value = "email")]
            EmailEnum = 4,
            
            /// <summary>
            /// Enum AvatarEnum for avatar
            /// </summary>
            [EnumMember(Value = "avatar")]
            AvatarEnum = 5
        }
}
