/* 
 * convertapi
 *
 * Convert API lets you effortlessly convert file formats and types.
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model
{
    /// <summary>
    /// Result of performing a change line ending operation
    /// </summary>
    [DataContract]
    public partial class ChangeLineEndingResponse :  IEquatable<ChangeLineEndingResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeLineEndingResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="textContentResult">Text content result.</param>
        public ChangeLineEndingResponse(bool? successful = default(bool?), string textContentResult = default(string))
        {
            this.Successful = successful;
            this.TextContentResult = textContentResult;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Text content result
        /// </summary>
        /// <value>Text content result</value>
        [DataMember(Name="TextContentResult", EmitDefaultValue=false)]
        public string TextContentResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeLineEndingResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  TextContentResult: ").Append(TextContentResult).Append("\n");
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
            return this.Equals(input as ChangeLineEndingResponse);
        }

        /// <summary>
        /// Returns true if ChangeLineEndingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeLineEndingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeLineEndingResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.TextContentResult == input.TextContentResult ||
                    (this.TextContentResult != null &&
                    this.TextContentResult.Equals(input.TextContentResult))
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.TextContentResult != null)
                    hashCode = hashCode * 59 + this.TextContentResult.GetHashCode();
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
