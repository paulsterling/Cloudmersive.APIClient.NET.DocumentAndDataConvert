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
    /// Alternate file format possibility
    /// </summary>
    [DataContract]
    public partial class AlternateFileFormatCandidate :  IEquatable<AlternateFileFormatCandidate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlternateFileFormatCandidate" /> class.
        /// </summary>
        /// <param name="Probability">Probability that this extension is the right one; possible values are between 0.0 (lowest confidence) and 1.0 (highest confidence).</param>
        /// <param name="DetectedFileExtension">Detected file extension of the file format, with a leading period.</param>
        /// <param name="DetectedMimeType">MIME type of this file extension.</param>
        public AlternateFileFormatCandidate(double? Probability = default(double?), string DetectedFileExtension = default(string), string DetectedMimeType = default(string))
        {
            this.Probability = Probability;
            this.DetectedFileExtension = DetectedFileExtension;
            this.DetectedMimeType = DetectedMimeType;
        }
        
        /// <summary>
        /// Probability that this extension is the right one; possible values are between 0.0 (lowest confidence) and 1.0 (highest confidence)
        /// </summary>
        /// <value>Probability that this extension is the right one; possible values are between 0.0 (lowest confidence) and 1.0 (highest confidence)</value>
        [DataMember(Name="Probability", EmitDefaultValue=false)]
        public double? Probability { get; set; }

        /// <summary>
        /// Detected file extension of the file format, with a leading period
        /// </summary>
        /// <value>Detected file extension of the file format, with a leading period</value>
        [DataMember(Name="DetectedFileExtension", EmitDefaultValue=false)]
        public string DetectedFileExtension { get; set; }

        /// <summary>
        /// MIME type of this file extension
        /// </summary>
        /// <value>MIME type of this file extension</value>
        [DataMember(Name="DetectedMimeType", EmitDefaultValue=false)]
        public string DetectedMimeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlternateFileFormatCandidate {\n");
            sb.Append("  Probability: ").Append(Probability).Append("\n");
            sb.Append("  DetectedFileExtension: ").Append(DetectedFileExtension).Append("\n");
            sb.Append("  DetectedMimeType: ").Append(DetectedMimeType).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlternateFileFormatCandidate);
        }

        /// <summary>
        /// Returns true if AlternateFileFormatCandidate instances are equal
        /// </summary>
        /// <param name="input">Instance of AlternateFileFormatCandidate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlternateFileFormatCandidate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Probability == input.Probability ||
                    (this.Probability != null &&
                    this.Probability.Equals(input.Probability))
                ) && 
                (
                    this.DetectedFileExtension == input.DetectedFileExtension ||
                    (this.DetectedFileExtension != null &&
                    this.DetectedFileExtension.Equals(input.DetectedFileExtension))
                ) && 
                (
                    this.DetectedMimeType == input.DetectedMimeType ||
                    (this.DetectedMimeType != null &&
                    this.DetectedMimeType.Equals(input.DetectedMimeType))
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
                if (this.Probability != null)
                    hashCode = hashCode * 59 + this.Probability.GetHashCode();
                if (this.DetectedFileExtension != null)
                    hashCode = hashCode * 59 + this.DetectedFileExtension.GetHashCode();
                if (this.DetectedMimeType != null)
                    hashCode = hashCode * 59 + this.DetectedMimeType.GetHashCode();
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
