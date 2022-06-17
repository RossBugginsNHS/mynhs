/*
 * My NHS Graph
 *
 * WIP Strawman API ideas for a Unified API myNHS API Graph endpoint, bringing together both new \"User Generated Data\" and existing sources into one endpoint and one Authorisation model, supporting delegated user access and proxy access. Modeling that the records belong to the \"tennant\" with owners having proxy access (ie full) and users being shared specifics records. Oauth scopes, with modifiers of .shared and .all. Look at Microsoft Graph for where that comes from. To support idempotency, all POST apis are just requests to start something, the put starts this. Alows for evential consistency. Long running GETs are removed, by POSTing requests for data, with a GET endpoint returned.
 *
 * OpenAPI spec version: 0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace mynhs.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class DigitalHealthCheckResult : IEquatable<DigitalHealthCheckResult>
    { 
        /// <summary>
        /// Gets or Sets HealthyPercentage
        /// </summary>

        [DataMember(Name="HealthyPercentage")]
        public long? HealthyPercentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DigitalHealthCheckResult {\n");
            sb.Append("  HealthyPercentage: ").Append(HealthyPercentage).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((DigitalHealthCheckResult)obj);
        }

        /// <summary>
        /// Returns true if DigitalHealthCheckResult instances are equal
        /// </summary>
        /// <param name="other">Instance of DigitalHealthCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DigitalHealthCheckResult other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HealthyPercentage == other.HealthyPercentage ||
                    HealthyPercentage != null &&
                    HealthyPercentage.Equals(other.HealthyPercentage)
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
                    if (HealthyPercentage != null)
                    hashCode = hashCode * 59 + HealthyPercentage.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DigitalHealthCheckResult left, DigitalHealthCheckResult right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DigitalHealthCheckResult left, DigitalHealthCheckResult right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
