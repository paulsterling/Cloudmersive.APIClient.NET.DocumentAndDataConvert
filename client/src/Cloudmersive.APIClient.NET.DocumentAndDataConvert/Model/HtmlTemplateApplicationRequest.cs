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
    /// HTML template application request
    /// </summary>
    [DataContract]
    public partial class HtmlTemplateApplicationRequest :  IEquatable<HtmlTemplateApplicationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTemplateApplicationRequest" /> class.
        /// </summary>
        /// <param name="htmlTemplate">HTML template input as a string.</param>
        /// <param name="htmlTemplateUrl">URL to HTML template input.</param>
        /// <param name="operations">Operations to apply to this template.</param>
        public HtmlTemplateApplicationRequest(string htmlTemplate = default(string), string htmlTemplateUrl = default(string), List<HtmlTemplateOperation> operations = default(List<HtmlTemplateOperation>))
        {
            this.HtmlTemplate = htmlTemplate;
            this.HtmlTemplateUrl = htmlTemplateUrl;
            this.Operations = operations;
        }
        
        /// <summary>
        /// HTML template input as a string
        /// </summary>
        /// <value>HTML template input as a string</value>
        [DataMember(Name="HtmlTemplate", EmitDefaultValue=false)]
        public string HtmlTemplate { get; set; }

        /// <summary>
        /// URL to HTML template input
        /// </summary>
        /// <value>URL to HTML template input</value>
        [DataMember(Name="HtmlTemplateUrl", EmitDefaultValue=false)]
        public string HtmlTemplateUrl { get; set; }

        /// <summary>
        /// Operations to apply to this template
        /// </summary>
        /// <value>Operations to apply to this template</value>
        [DataMember(Name="Operations", EmitDefaultValue=false)]
        public List<HtmlTemplateOperation> Operations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlTemplateApplicationRequest {\n");
            sb.Append("  HtmlTemplate: ").Append(HtmlTemplate).Append("\n");
            sb.Append("  HtmlTemplateUrl: ").Append(HtmlTemplateUrl).Append("\n");
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
            return this.Equals(input as HtmlTemplateApplicationRequest);
        }

        /// <summary>
        /// Returns true if HtmlTemplateApplicationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of HtmlTemplateApplicationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HtmlTemplateApplicationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HtmlTemplate == input.HtmlTemplate ||
                    (this.HtmlTemplate != null &&
                    this.HtmlTemplate.Equals(input.HtmlTemplate))
                ) && 
                (
                    this.HtmlTemplateUrl == input.HtmlTemplateUrl ||
                    (this.HtmlTemplateUrl != null &&
                    this.HtmlTemplateUrl.Equals(input.HtmlTemplateUrl))
                ) && 
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
                if (this.HtmlTemplate != null)
                    hashCode = hashCode * 59 + this.HtmlTemplate.GetHashCode();
                if (this.HtmlTemplateUrl != null)
                    hashCode = hashCode * 59 + this.HtmlTemplateUrl.GetHashCode();
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
