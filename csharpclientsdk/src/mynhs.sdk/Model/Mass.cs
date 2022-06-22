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
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = mynhs.sdk.Client.SwaggerDateConverter;

namespace mynhs.sdk.Model
{
    /// <summary>
    /// Mass
    /// </summary>
    [DataContract]
        public partial class Mass :  IEquatable<Mass>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mass" /> class.
        /// </summary>
        /// <param name="grams">grams.</param>
        public Mass(long? grams = default(long?))
        {
            this.Grams = grams;
        }
        
        /// <summary>
        /// Gets or Sets Grams
        /// </summary>
        [DataMember(Name="Grams", EmitDefaultValue=false)]
        public long? Grams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mass {\n");
            sb.Append("  Grams: ").Append(Grams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Mass);
        }

        /// <summary>
        /// Returns true if Mass instances are equal
        /// </summary>
        /// <param name="input">Instance of Mass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mass input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Grams == input.Grams ||
                    (this.Grams != null &&
                    this.Grams.Equals(input.Grams))
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
                int hashCode = 41;
                if (this.Grams != null)
                    hashCode = hashCode * 59 + this.Grams.GetHashCode();
                return hashCode;
            }
        }
    }
}
