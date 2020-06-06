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
    /// Result of running a Get-Specific-Row command
    /// </summary>
    [DataContract]
    public partial class GetXlsxSpecificRowResponse :  IEquatable<GetXlsxSpecificRowResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetXlsxSpecificRowResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="row">Spreadsheet Row from the Excel XLSX document.</param>
        public GetXlsxSpecificRowResponse(bool? successful = default(bool?), XlsxSpreadsheetRow row = default(XlsxSpreadsheetRow))
        {
            this.Successful = successful;
            this.Row = row;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Spreadsheet Row from the Excel XLSX document
        /// </summary>
        /// <value>Spreadsheet Row from the Excel XLSX document</value>
        [DataMember(Name="Row", EmitDefaultValue=false)]
        public XlsxSpreadsheetRow Row { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetXlsxSpecificRowResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Row: ").Append(Row).Append("\n");
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
            return this.Equals(input as GetXlsxSpecificRowResponse);
        }

        /// <summary>
        /// Returns true if GetXlsxSpecificRowResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetXlsxSpecificRowResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetXlsxSpecificRowResponse input)
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
                    this.Row == input.Row ||
                    (this.Row != null &&
                    this.Row.Equals(input.Row))
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
                if (this.Row != null)
                    hashCode = hashCode * 59 + this.Row.GetHashCode();
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