/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.5.1
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
    /// FileVersionUploadStatus
    /// </summary>
    [DataContract]
    public partial class FileVersionUploadStatus :  IEquatable<FileVersionUploadStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileVersionUploadStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileVersionUploadStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileVersionUploadStatus" /> class.
        /// </summary>
        /// <param name="uploadId">uploadId (required).</param>
        /// <param name="fileName">fileName (required).</param>
        /// <param name="nextPartNumber">nextPartNumber (required).</param>
        /// <param name="maxParts">maxParts (required).</param>
        /// <param name="parts">parts (required).</param>
        /// <param name="etags">Unknown (required).</param>
        public FileVersionUploadStatus(string uploadId = default(string), string fileName = default(string), decimal nextPartNumber = default(decimal), decimal maxParts = default(decimal), List<Object> parts = default(List<Object>), List<Object> etags = default(List<Object>))
        {
            // to ensure "uploadId" is required (not null)
            if (uploadId == null)
            {
                throw new InvalidDataException("uploadId is a required property for FileVersionUploadStatus and cannot be null");
            }
            else
            {
                this.UploadId = uploadId;
            }

            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new InvalidDataException("fileName is a required property for FileVersionUploadStatus and cannot be null");
            }
            else
            {
                this.FileName = fileName;
            }

            // to ensure "nextPartNumber" is required (not null)
            if (nextPartNumber == null)
            {
                throw new InvalidDataException("nextPartNumber is a required property for FileVersionUploadStatus and cannot be null");
            }
            else
            {
                this.NextPartNumber = nextPartNumber;
            }

            // to ensure "maxParts" is required (not null)
            if (maxParts == null)
            {
                throw new InvalidDataException("maxParts is a required property for FileVersionUploadStatus and cannot be null");
            }
            else
            {
                this.MaxParts = maxParts;
            }

            // to ensure "parts" is required (not null)
            if (parts == null)
            {
                throw new InvalidDataException("parts is a required property for FileVersionUploadStatus and cannot be null");
            }
            else
            {
                this.Parts = parts;
            }

            // to ensure "etags" is required (not null)
            if (etags == null)
            {
                throw new InvalidDataException("etags is a required property for FileVersionUploadStatus and cannot be null");
            }
            else
            {
                this.Etags = etags;
            }

        }

        /// <summary>
        /// Gets or Sets UploadId
        /// </summary>
        [DataMember(Name="uploadId", EmitDefaultValue=true)]
        public string UploadId { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="fileName", EmitDefaultValue=true)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets NextPartNumber
        /// </summary>
        [DataMember(Name="nextPartNumber", EmitDefaultValue=true)]
        public decimal NextPartNumber { get; set; }

        /// <summary>
        /// Gets or Sets MaxParts
        /// </summary>
        [DataMember(Name="maxParts", EmitDefaultValue=true)]
        public decimal MaxParts { get; set; }

        /// <summary>
        /// Gets or Sets Parts
        /// </summary>
        [DataMember(Name="parts", EmitDefaultValue=true)]
        public List<Object> Parts { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="etags", EmitDefaultValue=true)]
        public List<Object> Etags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileVersionUploadStatus {\n");
            sb.Append("  UploadId: ").Append(UploadId).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  NextPartNumber: ").Append(NextPartNumber).Append("\n");
            sb.Append("  MaxParts: ").Append(MaxParts).Append("\n");
            sb.Append("  Parts: ").Append(Parts).Append("\n");
            sb.Append("  Etags: ").Append(Etags).Append("\n");
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
            return this.Equals(input as FileVersionUploadStatus);
        }

        /// <summary>
        /// Returns true if FileVersionUploadStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of FileVersionUploadStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileVersionUploadStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UploadId == input.UploadId ||
                    (this.UploadId != null &&
                    this.UploadId.Equals(input.UploadId))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.NextPartNumber == input.NextPartNumber ||
                    (this.NextPartNumber != null &&
                    this.NextPartNumber.Equals(input.NextPartNumber))
                ) && 
                (
                    this.MaxParts == input.MaxParts ||
                    (this.MaxParts != null &&
                    this.MaxParts.Equals(input.MaxParts))
                ) && 
                (
                    this.Parts == input.Parts ||
                    this.Parts != null &&
                    input.Parts != null &&
                    this.Parts.SequenceEqual(input.Parts)
                ) && 
                (
                    this.Etags == input.Etags ||
                    this.Etags != null &&
                    input.Etags != null &&
                    this.Etags.SequenceEqual(input.Etags)
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
                if (this.UploadId != null)
                    hashCode = hashCode * 59 + this.UploadId.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.NextPartNumber != null)
                    hashCode = hashCode * 59 + this.NextPartNumber.GetHashCode();
                if (this.MaxParts != null)
                    hashCode = hashCode * 59 + this.MaxParts.GetHashCode();
                if (this.Parts != null)
                    hashCode = hashCode * 59 + this.Parts.GetHashCode();
                if (this.Etags != null)
                    hashCode = hashCode * 59 + this.Etags.GetHashCode();
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

            // UploadId (string) minLength
            if(this.UploadId != null && this.UploadId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UploadId, length must be greater than 1.", new [] { "UploadId" });
            }


            // FileName (string) minLength
            if(this.FileName != null && this.FileName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FileName, length must be greater than 1.", new [] { "FileName" });
            }



            // NextPartNumber (decimal) minimum
            if(this.NextPartNumber < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NextPartNumber, must be a value greater than or equal to 0.", new [] { "NextPartNumber" });
            }



            // MaxParts (decimal) minimum
            if(this.MaxParts < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxParts, must be a value greater than or equal to 1.", new [] { "MaxParts" });
            }





            yield break;
        }
    }

}
