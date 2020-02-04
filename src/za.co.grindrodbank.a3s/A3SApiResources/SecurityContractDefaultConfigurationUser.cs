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
    /// Models a default user definition within a default configuration. 
    /// </summary>
    [DataContract]
    public partial class SecurityContractDefaultConfigurationUser : IEquatable<SecurityContractDefaultConfigurationUser>
    { 
        /// <summary>
        /// The unique Id of the user.
        /// </summary>
        /// <value>The unique Id of the user.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid Uuid { get; set; }

        /// <summary>
        /// The username of the user.
        /// </summary>
        /// <value>The username of the user.</value>
        [Required]
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The surname of the user.
        /// </summary>
        /// <value>The surname of the user.</value>
        [Required]
        [DataMember(Name="surname", EmitDefaultValue=false)]
        public string Surname { get; set; }

        /// <summary>
        /// The user&#39;s email.
        /// </summary>
        /// <value>The user&#39;s email.</value>
        [Required]
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The user&#39;s phone number.
        /// </summary>
        /// <value>The user&#39;s phone number.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The user&#39;s plain text password.
        /// </summary>
        /// <value>The user&#39;s plain text password.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// An optional field containing the user&#39;s salted and hashed password. If used, the password field will be ignored.
        /// </summary>
        /// <value>An optional field containing the user&#39;s salted and hashed password. If used, the password field will be ignored.</value>
        [DataMember(Name="hashedPassword", EmitDefaultValue=false)]
        public string HashedPassword { get; set; }

        /// <summary>
        /// True if this user is considered deleted.
        /// </summary>
        /// <value>True if this user is considered deleted.</value>
        [DataMember(Name="isDeleted", EmitDefaultValue=true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Populated with user delete date and time.
        /// </summary>
        /// <value>Populated with user delete date and time.</value>
        [DataMember(Name="deletedTime", EmitDefaultValue=true)]
        public DateTime? DeletedTime { get; set; }

        /// <summary>
        /// The user&#39;s avatar image in base64 format
        /// </summary>
        /// <value>The user&#39;s avatar image in base64 format</value>
        [DataMember(Name="avatar", EmitDefaultValue=true)]
        public string Avatar { get; set; }

        /// <summary>
        /// The user&#39;s linked LDAP Authentication Mode name, if applicable
        /// </summary>
        /// <value>The user&#39;s linked LDAP Authentication Mode name, if applicable</value>
        [DataMember(Name="ldapAuthenticationMode", EmitDefaultValue=true)]
        public string LdapAuthenticationMode { get; set; }

        /// <summary>
        /// An array of all the role names that are to be added to the user. The user must already exist or be defined in other sections of the security contract.
        /// </summary>
        /// <value>An array of all the role names that are to be added to the user. The user must already exist or be defined in other sections of the security contract.</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityContractDefaultConfigurationUser {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  HashedPassword: ").Append(HashedPassword).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  DeletedTime: ").Append(DeletedTime).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  LdapAuthenticationMode: ").Append(LdapAuthenticationMode).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SecurityContractDefaultConfigurationUser)obj);
        }

        /// <summary>
        /// Returns true if SecurityContractDefaultConfigurationUser instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityContractDefaultConfigurationUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityContractDefaultConfigurationUser other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Uuid == other.Uuid ||
                    Uuid != null &&
                    Uuid.Equals(other.Uuid)
                ) && 
                (
                    Username == other.Username ||
                    Username != null &&
                    Username.Equals(other.Username)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Surname == other.Surname ||
                    Surname != null &&
                    Surname.Equals(other.Surname)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    PhoneNumber == other.PhoneNumber ||
                    PhoneNumber != null &&
                    PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    Password == other.Password ||
                    Password != null &&
                    Password.Equals(other.Password)
                ) && 
                (
                    HashedPassword == other.HashedPassword ||
                    HashedPassword != null &&
                    HashedPassword.Equals(other.HashedPassword)
                ) && 
                (
                    IsDeleted == other.IsDeleted ||
                    
                    IsDeleted.Equals(other.IsDeleted)
                ) && 
                (
                    DeletedTime == other.DeletedTime ||
                    DeletedTime != null &&
                    DeletedTime.Equals(other.DeletedTime)
                ) && 
                (
                    Avatar == other.Avatar ||
                    Avatar != null &&
                    Avatar.Equals(other.Avatar)
                ) && 
                (
                    LdapAuthenticationMode == other.LdapAuthenticationMode ||
                    LdapAuthenticationMode != null &&
                    LdapAuthenticationMode.Equals(other.LdapAuthenticationMode)
                ) && 
                (
                    Roles == other.Roles ||
                    Roles != null &&
                    other.Roles != null &&
                    Roles.SequenceEqual(other.Roles)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Uuid != null)
                    hashCode = hashCode * 59 + Uuid.GetHashCode();
                    if (Username != null)
                    hashCode = hashCode * 59 + Username.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Surname != null)
                    hashCode = hashCode * 59 + Surname.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (PhoneNumber != null)
                    hashCode = hashCode * 59 + PhoneNumber.GetHashCode();
                    if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                    if (HashedPassword != null)
                    hashCode = hashCode * 59 + HashedPassword.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsDeleted.GetHashCode();
                    if (DeletedTime != null)
                    hashCode = hashCode * 59 + DeletedTime.GetHashCode();
                    if (Avatar != null)
                    hashCode = hashCode * 59 + Avatar.GetHashCode();
                    if (LdapAuthenticationMode != null)
                    hashCode = hashCode * 59 + LdapAuthenticationMode.GetHashCode();
                    if (Roles != null)
                    hashCode = hashCode * 59 + Roles.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SecurityContractDefaultConfigurationUser left, SecurityContractDefaultConfigurationUser right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SecurityContractDefaultConfigurationUser left, SecurityContractDefaultConfigurationUser right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
