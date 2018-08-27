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
    /// A worksheet (tab) in an Excel (XLSX) spreadsheet
    /// </summary>
    [DataContract]
    public partial class XlsxWorksheet :  IEquatable<XlsxWorksheet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XlsxWorksheet" /> class.
        /// </summary>
        /// <param name="Path">The Path of the location of this object; leave blank for new worksheets.</param>
        /// <param name="WorksheetName">User-facing name of the worksheet tab.</param>
        public XlsxWorksheet(string Path = default(string), string WorksheetName = default(string))
        {
            this.Path = Path;
            this.WorksheetName = WorksheetName;
        }
        
        /// <summary>
        /// The Path of the location of this object; leave blank for new worksheets
        /// </summary>
        /// <value>The Path of the location of this object; leave blank for new worksheets</value>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// User-facing name of the worksheet tab
        /// </summary>
        /// <value>User-facing name of the worksheet tab</value>
        [DataMember(Name="WorksheetName", EmitDefaultValue=false)]
        public string WorksheetName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XlsxWorksheet {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  WorksheetName: ").Append(WorksheetName).Append("\n");
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
            return this.Equals(input as XlsxWorksheet);
        }

        /// <summary>
        /// Returns true if XlsxWorksheet instances are equal
        /// </summary>
        /// <param name="input">Instance of XlsxWorksheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XlsxWorksheet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.WorksheetName == input.WorksheetName ||
                    (this.WorksheetName != null &&
                    this.WorksheetName.Equals(input.WorksheetName))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.WorksheetName != null)
                    hashCode = hashCode * 59 + this.WorksheetName.GetHashCode();
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
