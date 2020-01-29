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
    /// Model a default LDAP Authentication Mode 
    /// </summary>
    [DataContract]
    public partial class SecurityContractDefaultConfigurationLdapAuthMode : IEquatable<SecurityContractDefaultConfigurationLdapAuthMode>
    { 
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets HostName
        /// </summary>
        [Required]
        [DataMember(Name="hostName", EmitDefaultValue=false)]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [Required]
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int Port { get; set; }

        /// <summary>
        /// Gets or Sets IsLdaps
        /// </summary>
        [Required]
        [DataMember(Name="isLdaps", EmitDefaultValue=true)]
        public bool IsLdaps { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [Required]
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets BaseDn
        /// </summary>
        [Required]
        [DataMember(Name="baseDn", EmitDefaultValue=false)]
        public string BaseDn { get; set; }

        /// <summary>
        /// A list of LDAP attribute to user field mappings
        /// </summary>
        /// <value>A list of LDAP attribute to user field mappings</value>
        [DataMember(Name="ldapAttributes", EmitDefaultValue=false)]
        public List<SecurityContractDefaultConfigurationLdapAttributeLink> LdapAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityContractDefaultConfigurationLdapAuthMode {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  IsLdaps: ").Append(IsLdaps).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  BaseDn: ").Append(BaseDn).Append("\n");
            sb.Append("  LdapAttributes: ").Append(LdapAttributes).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SecurityContractDefaultConfigurationLdapAuthMode)obj);
        }

        /// <summary>
        /// Returns true if SecurityContractDefaultConfigurationLdapAuthMode instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityContractDefaultConfigurationLdapAuthMode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityContractDefaultConfigurationLdapAuthMode other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    HostName == other.HostName ||
                    HostName != null &&
                    HostName.Equals(other.HostName)
                ) && 
                (
                    Port == other.Port ||
                    
                    Port.Equals(other.Port)
                ) && 
                (
                    IsLdaps == other.IsLdaps ||
                    
                    IsLdaps.Equals(other.IsLdaps)
                ) && 
                (
                    Account == other.Account ||
                    Account != null &&
                    Account.Equals(other.Account)
                ) && 
                (
                    BaseDn == other.BaseDn ||
                    BaseDn != null &&
                    BaseDn.Equals(other.BaseDn)
                ) && 
                (
                    LdapAttributes == other.LdapAttributes ||
                    LdapAttributes != null &&
                    other.LdapAttributes != null &&
                    LdapAttributes.SequenceEqual(other.LdapAttributes)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (HostName != null)
                    hashCode = hashCode * 59 + HostName.GetHashCode();
                    
                    hashCode = hashCode * 59 + Port.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsLdaps.GetHashCode();
                    if (Account != null)
                    hashCode = hashCode * 59 + Account.GetHashCode();
                    if (BaseDn != null)
                    hashCode = hashCode * 59 + BaseDn.GetHashCode();
                    if (LdapAttributes != null)
                    hashCode = hashCode * 59 + LdapAttributes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SecurityContractDefaultConfigurationLdapAuthMode left, SecurityContractDefaultConfigurationLdapAuthMode right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SecurityContractDefaultConfigurationLdapAuthMode left, SecurityContractDefaultConfigurationLdapAuthMode right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
