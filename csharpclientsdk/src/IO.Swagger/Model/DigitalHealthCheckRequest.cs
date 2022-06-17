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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// DigitalHealthCheckRequest
    /// </summary>
    [DataContract]
        public partial class DigitalHealthCheckRequest :  IEquatable<DigitalHealthCheckRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DigitalHealthCheckRequest" /> class.
        /// </summary>
        /// <param name="height">height.</param>
        /// <param name="weight">weight.</param>
        /// <param name="bloodPressure">bloodPressure.</param>
        /// <param name="bloodSugar">bloodSugar.</param>
        /// <param name="colesterol">colesterol.</param>
        /// <param name="ethnicity">ethnicity.</param>
        public DigitalHealthCheckRequest(long? height = default(long?), long? weight = default(long?), string bloodPressure = default(string), string bloodSugar = default(string), string colesterol = default(string), string ethnicity = default(string))
        {
            this.Height = height;
            this.Weight = weight;
            this.BloodPressure = bloodPressure;
            this.BloodSugar = bloodSugar;
            this.Colesterol = colesterol;
            this.Ethnicity = ethnicity;
        }
        
        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public long? Height { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="Weight", EmitDefaultValue=false)]
        public long? Weight { get; set; }

        /// <summary>
        /// Gets or Sets BloodPressure
        /// </summary>
        [DataMember(Name="BloodPressure", EmitDefaultValue=false)]
        public string BloodPressure { get; set; }

        /// <summary>
        /// Gets or Sets BloodSugar
        /// </summary>
        [DataMember(Name="BloodSugar", EmitDefaultValue=false)]
        public string BloodSugar { get; set; }

        /// <summary>
        /// Gets or Sets Colesterol
        /// </summary>
        [DataMember(Name="Colesterol", EmitDefaultValue=false)]
        public string Colesterol { get; set; }

        /// <summary>
        /// Gets or Sets Ethnicity
        /// </summary>
        [DataMember(Name="Ethnicity", EmitDefaultValue=false)]
        public string Ethnicity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DigitalHealthCheckRequest {\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  BloodPressure: ").Append(BloodPressure).Append("\n");
            sb.Append("  BloodSugar: ").Append(BloodSugar).Append("\n");
            sb.Append("  Colesterol: ").Append(Colesterol).Append("\n");
            sb.Append("  Ethnicity: ").Append(Ethnicity).Append("\n");
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
            return this.Equals(input as DigitalHealthCheckRequest);
        }

        /// <summary>
        /// Returns true if DigitalHealthCheckRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DigitalHealthCheckRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DigitalHealthCheckRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.BloodPressure == input.BloodPressure ||
                    (this.BloodPressure != null &&
                    this.BloodPressure.Equals(input.BloodPressure))
                ) && 
                (
                    this.BloodSugar == input.BloodSugar ||
                    (this.BloodSugar != null &&
                    this.BloodSugar.Equals(input.BloodSugar))
                ) && 
                (
                    this.Colesterol == input.Colesterol ||
                    (this.Colesterol != null &&
                    this.Colesterol.Equals(input.Colesterol))
                ) && 
                (
                    this.Ethnicity == input.Ethnicity ||
                    (this.Ethnicity != null &&
                    this.Ethnicity.Equals(input.Ethnicity))
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
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.BloodPressure != null)
                    hashCode = hashCode * 59 + this.BloodPressure.GetHashCode();
                if (this.BloodSugar != null)
                    hashCode = hashCode * 59 + this.BloodSugar.GetHashCode();
                if (this.Colesterol != null)
                    hashCode = hashCode * 59 + this.Colesterol.GetHashCode();
                if (this.Ethnicity != null)
                    hashCode = hashCode * 59 + this.Ethnicity.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
