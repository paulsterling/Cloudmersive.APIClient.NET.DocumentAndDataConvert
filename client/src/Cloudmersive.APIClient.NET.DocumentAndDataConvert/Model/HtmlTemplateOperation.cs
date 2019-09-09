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
    /// HtmlTemplateOperation
    /// </summary>
    [DataContract]
    public partial class HtmlTemplateOperation :  IEquatable<HtmlTemplateOperation>, IValidatableObject
    {
        /// <summary>
        /// Operation action to take; possible values are \&quot;Replace\&quot;
        /// </summary>
        /// <value>Operation action to take; possible values are \&quot;Replace\&quot;</value>
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            
            NUMBER_1 = 1
        }

        /// <summary>
        /// Operation action to take; possible values are \&quot;Replace\&quot;
        /// </summary>
        /// <value>Operation action to take; possible values are \&quot;Replace\&quot;</value>
        [DataMember(Name="Action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTemplateOperation" /> class.
        /// </summary>
        /// <param name="action">Operation action to take; possible values are \&quot;Replace\&quot;.</param>
        /// <param name="matchAgsint">For Replace operations, the string to match against (to be replaced with ReplaceWith string).</param>
        /// <param name="replaceWith">For Replace operations, the string to Replace the original string with.</param>
        public HtmlTemplateOperation(ActionEnum? action = default(ActionEnum?), string matchAgsint = default(string), string replaceWith = default(string))
        {
            this.Action = action;
            this.MatchAgsint = matchAgsint;
            this.ReplaceWith = replaceWith;
        }
        

        /// <summary>
        /// For Replace operations, the string to match against (to be replaced with ReplaceWith string)
        /// </summary>
        /// <value>For Replace operations, the string to match against (to be replaced with ReplaceWith string)</value>
        [DataMember(Name="MatchAgsint", EmitDefaultValue=false)]
        public string MatchAgsint { get; set; }

        /// <summary>
        /// For Replace operations, the string to Replace the original string with
        /// </summary>
        /// <value>For Replace operations, the string to Replace the original string with</value>
        [DataMember(Name="ReplaceWith", EmitDefaultValue=false)]
        public string ReplaceWith { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlTemplateOperation {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  MatchAgsint: ").Append(MatchAgsint).Append("\n");
            sb.Append("  ReplaceWith: ").Append(ReplaceWith).Append("\n");
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
            return this.Equals(input as HtmlTemplateOperation);
        }

        /// <summary>
        /// Returns true if HtmlTemplateOperation instances are equal
        /// </summary>
        /// <param name="input">Instance of HtmlTemplateOperation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HtmlTemplateOperation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.MatchAgsint == input.MatchAgsint ||
                    (this.MatchAgsint != null &&
                    this.MatchAgsint.Equals(input.MatchAgsint))
                ) && 
                (
                    this.ReplaceWith == input.ReplaceWith ||
                    (this.ReplaceWith != null &&
                    this.ReplaceWith.Equals(input.ReplaceWith))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.MatchAgsint != null)
                    hashCode = hashCode * 59 + this.MatchAgsint.GetHashCode();
                if (this.ReplaceWith != null)
                    hashCode = hashCode * 59 + this.ReplaceWith.GetHashCode();
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
