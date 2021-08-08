/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://raw.githubusercontent.com/vrchatapi/vrchatapi.github.io/master/assets/apibanner.png)  # VRChat API Documentation This project is an [OPEN Open Source Project](https://openopensource.org)  Individuals making significant and valuable contributions are given commit-access to the project to contribute as they see fit. This project is more like an open wiki than a standard guarded open source project.  ## Disclaimer  This is the official response of the VRChat Team (from Tupper more specifically) on the usage of the VRChat API.  > **Use of the API using applications other than the approved methods (website, VRChat application) are not officially supported. You may use the API for your own application, but keep these guidelines in mind:** > * We do not provide documentation or support for the API. > * Do not make queries to the API more than once per 60 seconds. > * Abuse of the API may result in account termination. > * Access to API endpoints may break at any given time, with no warning.  As stated, this documentation was not created with the help of the official VRChat team. Therefore this documentation is not an official documentation of the VRChat API and may not be always up to date with the latest versions. If you find that a page or endpoint is not longer valid please create an issue and tell us so we can fix it.  ## Get in touch with us!  [https://discord.gg/qjZE9C9fkB#vrchat-api](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
{
    /// <summary>
    /// Download links for various development assets
    /// </summary>
    [DataContract]
    public partial class ConfigDownloadUrls :  IEquatable<ConfigDownloadUrls>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigDownloadUrls" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ConfigDownloadUrls()
        {
        }

        /// <summary>
        /// Download link for legacy SDK2
        /// </summary>
        /// <value>Download link for legacy SDK2</value>
        [DataMember(Name="sdk2", EmitDefaultValue=true)]
        public string Sdk2 { get; private set; }

        /// <summary>
        /// Download link for SDK3 for Avatars
        /// </summary>
        /// <value>Download link for SDK3 for Avatars</value>
        [DataMember(Name="sdk3-avatars", EmitDefaultValue=true)]
        public string Sdk3Avatars { get; private set; }

        /// <summary>
        /// Download link for SDK3 for Worlds
        /// </summary>
        /// <value>Download link for SDK3 for Worlds</value>
        [DataMember(Name="sdk3-worlds", EmitDefaultValue=true)]
        public string Sdk3Worlds { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigDownloadUrls {\n");
            sb.Append("  Sdk2: ").Append(Sdk2).Append("\n");
            sb.Append("  Sdk3Avatars: ").Append(Sdk3Avatars).Append("\n");
            sb.Append("  Sdk3Worlds: ").Append(Sdk3Worlds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigDownloadUrls);
        }

        /// <summary>
        /// Returns true if ConfigDownloadUrls instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigDownloadUrls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigDownloadUrls input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sdk2 == input.Sdk2 ||
                    (this.Sdk2 != null &&
                    this.Sdk2.Equals(input.Sdk2))
                ) && 
                (
                    this.Sdk3Avatars == input.Sdk3Avatars ||
                    (this.Sdk3Avatars != null &&
                    this.Sdk3Avatars.Equals(input.Sdk3Avatars))
                ) && 
                (
                    this.Sdk3Worlds == input.Sdk3Worlds ||
                    (this.Sdk3Worlds != null &&
                    this.Sdk3Worlds.Equals(input.Sdk3Worlds))
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
                if (this.Sdk2 != null)
                    hashCode = hashCode * 59 + this.Sdk2.GetHashCode();
                if (this.Sdk3Avatars != null)
                    hashCode = hashCode * 59 + this.Sdk3Avatars.GetHashCode();
                if (this.Sdk3Worlds != null)
                    hashCode = hashCode * 59 + this.Sdk3Worlds.GetHashCode();
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

            // Sdk2 (string) minLength
            if(this.Sdk2 != null && this.Sdk2.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sdk2, length must be greater than 1.", new [] { "Sdk2" });
            }
 

            // Sdk3Avatars (string) minLength
            if(this.Sdk3Avatars != null && this.Sdk3Avatars.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sdk3Avatars, length must be greater than 1.", new [] { "Sdk3Avatars" });
            }
 

            // Sdk3Worlds (string) minLength
            if(this.Sdk3Worlds != null && this.Sdk3Worlds.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sdk3Worlds, length must be greater than 1.", new [] { "Sdk3Worlds" });
            }
 
            yield break;
        }
    }

}
