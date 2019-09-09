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
    /// Converted page as an image
    /// </summary>
    [DataContract]
    public partial class PageConversionResult :  IEquatable<PageConversionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageConversionResult" /> class.
        /// </summary>
        /// <param name="filename">File name of the image in the converted file format.</param>
        /// <param name="fileBytes">File bytes (contents) of the image in converted file format.</param>
        public PageConversionResult(string filename = default(string), byte[] fileBytes = default(byte[]))
        {
            this.Filename = filename;
            this.FileBytes = fileBytes;
        }
        
        /// <summary>
        /// File name of the image in the converted file format
        /// </summary>
        /// <value>File name of the image in the converted file format</value>
        [DataMember(Name="Filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// File bytes (contents) of the image in converted file format
        /// </summary>
        /// <value>File bytes (contents) of the image in converted file format</value>
        [DataMember(Name="FileBytes", EmitDefaultValue=false)]
        public byte[] FileBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageConversionResult {\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  FileBytes: ").Append(FileBytes).Append("\n");
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
            return this.Equals(input as PageConversionResult);
        }

        /// <summary>
        /// Returns true if PageConversionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PageConversionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageConversionResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.FileBytes == input.FileBytes ||
                    (this.FileBytes != null &&
                    this.FileBytes.Equals(input.FileBytes))
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
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.FileBytes != null)
                    hashCode = hashCode * 59 + this.FileBytes.GetHashCode();
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
