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
    /// Details of the screenshot request
    /// </summary>
    [DataContract]
    public partial class ScreenshotRequest :  IEquatable<ScreenshotRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenshotRequest" /> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="extraLoadingWait">extraLoadingWait.</param>
        /// <param name="screenshotWidth">screenshotWidth.</param>
        /// <param name="screenshotHeight">screenshotHeight.</param>
        public ScreenshotRequest(string url = default(string), int? extraLoadingWait = default(int?), int? screenshotWidth = default(int?), int? screenshotHeight = default(int?))
        {
            this.Url = url;
            this.ExtraLoadingWait = extraLoadingWait;
            this.ScreenshotWidth = screenshotWidth;
            this.ScreenshotHeight = screenshotHeight;
        }
        
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets ExtraLoadingWait
        /// </summary>
        [DataMember(Name="ExtraLoadingWait", EmitDefaultValue=false)]
        public int? ExtraLoadingWait { get; set; }

        /// <summary>
        /// Gets or Sets ScreenshotWidth
        /// </summary>
        [DataMember(Name="ScreenshotWidth", EmitDefaultValue=false)]
        public int? ScreenshotWidth { get; set; }

        /// <summary>
        /// Gets or Sets ScreenshotHeight
        /// </summary>
        [DataMember(Name="ScreenshotHeight", EmitDefaultValue=false)]
        public int? ScreenshotHeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenshotRequest {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ExtraLoadingWait: ").Append(ExtraLoadingWait).Append("\n");
            sb.Append("  ScreenshotWidth: ").Append(ScreenshotWidth).Append("\n");
            sb.Append("  ScreenshotHeight: ").Append(ScreenshotHeight).Append("\n");
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
            return this.Equals(input as ScreenshotRequest);
        }

        /// <summary>
        /// Returns true if ScreenshotRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenshotRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenshotRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ExtraLoadingWait == input.ExtraLoadingWait ||
                    (this.ExtraLoadingWait != null &&
                    this.ExtraLoadingWait.Equals(input.ExtraLoadingWait))
                ) && 
                (
                    this.ScreenshotWidth == input.ScreenshotWidth ||
                    (this.ScreenshotWidth != null &&
                    this.ScreenshotWidth.Equals(input.ScreenshotWidth))
                ) && 
                (
                    this.ScreenshotHeight == input.ScreenshotHeight ||
                    (this.ScreenshotHeight != null &&
                    this.ScreenshotHeight.Equals(input.ScreenshotHeight))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ExtraLoadingWait != null)
                    hashCode = hashCode * 59 + this.ExtraLoadingWait.GetHashCode();
                if (this.ScreenshotWidth != null)
                    hashCode = hashCode * 59 + this.ScreenshotWidth.GetHashCode();
                if (this.ScreenshotHeight != null)
                    hashCode = hashCode * 59 + this.ScreenshotHeight.GetHashCode();
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
