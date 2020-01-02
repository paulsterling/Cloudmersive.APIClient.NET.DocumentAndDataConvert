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
    /// The result of splitting a Word document into individual Word DOCX pages
    /// </summary>
    [DataContract]
    public partial class SplitDocxDocumentResult :  IEquatable<SplitDocxDocumentResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitDocxDocumentResult" /> class.
        /// </summary>
        /// <param name="resultDocuments">resultDocuments.</param>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        public SplitDocxDocumentResult(List<SplitDocumentResult> resultDocuments = default(List<SplitDocumentResult>), bool? successful = default(bool?))
        {
            this.ResultDocuments = resultDocuments;
            this.Successful = successful;
        }
        
        /// <summary>
        /// Gets or Sets ResultDocuments
        /// </summary>
        [DataMember(Name="ResultDocuments", EmitDefaultValue=false)]
        public List<SplitDocumentResult> ResultDocuments { get; set; }

        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SplitDocxDocumentResult {\n");
            sb.Append("  ResultDocuments: ").Append(ResultDocuments).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
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
            return this.Equals(input as SplitDocxDocumentResult);
        }

        /// <summary>
        /// Returns true if SplitDocxDocumentResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitDocxDocumentResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitDocxDocumentResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResultDocuments == input.ResultDocuments ||
                    this.ResultDocuments != null &&
                    this.ResultDocuments.SequenceEqual(input.ResultDocuments)
                ) && 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
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
                if (this.ResultDocuments != null)
                    hashCode = hashCode * 59 + this.ResultDocuments.GetHashCode();
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
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
