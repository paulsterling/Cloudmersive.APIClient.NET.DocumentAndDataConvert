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
    /// Word DOCX template application request
    /// </summary>
    [DataContract]
    public partial class DocxTemplateApplicationRequest :  IEquatable<DocxTemplateApplicationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocxTemplateApplicationRequest" /> class.
        /// </summary>
        /// <param name="operations">Operations to apply to this template.</param>
        public DocxTemplateApplicationRequest(List<DocxTemplateOperation> operations = default(List<DocxTemplateOperation>))
        {
            this.Operations = operations;
        }
        
        /// <summary>
        /// Operations to apply to this template
        /// </summary>
        /// <value>Operations to apply to this template</value>
        [DataMember(Name="Operations", EmitDefaultValue=false)]
        public List<DocxTemplateOperation> Operations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocxTemplateApplicationRequest {\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
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
            return this.Equals(input as DocxTemplateApplicationRequest);
        }

        /// <summary>
        /// Returns true if DocxTemplateApplicationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DocxTemplateApplicationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocxTemplateApplicationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operations == input.Operations ||
                    this.Operations != null &&
                    this.Operations.SequenceEqual(input.Operations)
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
                if (this.Operations != null)
                    hashCode = hashCode * 59 + this.Operations.GetHashCode();
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
