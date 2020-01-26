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
    /// A single element of a Text document
    /// </summary>
    [DataContract]
    public partial class TextDocumentElement :  IEquatable<TextDocumentElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextDocumentElement" /> class.
        /// </summary>
        /// <param name="elementNumber">The 1-based line index of the element.</param>
        /// <param name="elementContents">The text contents of a single element of a text file.</param>
        public TextDocumentElement(int? elementNumber = default(int?), string elementContents = default(string))
        {
            this.ElementNumber = elementNumber;
            this.ElementContents = elementContents;
        }
        
        /// <summary>
        /// The 1-based line index of the element
        /// </summary>
        /// <value>The 1-based line index of the element</value>
        [DataMember(Name="ElementNumber", EmitDefaultValue=false)]
        public int? ElementNumber { get; set; }

        /// <summary>
        /// The text contents of a single element of a text file
        /// </summary>
        /// <value>The text contents of a single element of a text file</value>
        [DataMember(Name="ElementContents", EmitDefaultValue=false)]
        public string ElementContents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextDocumentElement {\n");
            sb.Append("  ElementNumber: ").Append(ElementNumber).Append("\n");
            sb.Append("  ElementContents: ").Append(ElementContents).Append("\n");
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
            return this.Equals(input as TextDocumentElement);
        }

        /// <summary>
        /// Returns true if TextDocumentElement instances are equal
        /// </summary>
        /// <param name="input">Instance of TextDocumentElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextDocumentElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ElementNumber == input.ElementNumber ||
                    (this.ElementNumber != null &&
                    this.ElementNumber.Equals(input.ElementNumber))
                ) && 
                (
                    this.ElementContents == input.ElementContents ||
                    (this.ElementContents != null &&
                    this.ElementContents.Equals(input.ElementContents))
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
                if (this.ElementNumber != null)
                    hashCode = hashCode * 59 + this.ElementNumber.GetHashCode();
                if (this.ElementContents != null)
                    hashCode = hashCode * 59 + this.ElementContents.GetHashCode();
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
