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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DeveloperType
        /// </summary>
        [DataMember(Name="developerType", EmitDefaultValue=true)]
        public DeveloperType DeveloperType { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public UserState State { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public UserStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="allowAvatarCopying">allowAvatarCopying (required).</param>
        /// <param name="bio">bio (required).</param>
        /// <param name="bioLinks">bioLinks (required).</param>
        /// <param name="currentAvatarImageUrl">currentAvatarImageUrl (required).</param>
        /// <param name="currentAvatarThumbnailImageUrl">currentAvatarThumbnailImageUrl (required).</param>
        /// <param name="developerType">developerType (required).</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="friendKey">friendKey (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="isFriend">isFriend (required).</param>
        /// <param name="lastLogin">lastLogin (required).</param>
        /// <param name="lastPlatform">This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. (required).</param>
        /// <param name="location">location.</param>
        /// <param name="profilePicOverride">profilePicOverride (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="statusDescription">statusDescription (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="userIcon">userIcon (required).</param>
        /// <param name="username">username (required).</param>
        /// <param name="worldId">worldId.</param>
        public User(bool allowAvatarCopying = default(bool), string bio = default(string), List<string> bioLinks = default(List<string>), string currentAvatarImageUrl = default(string), string currentAvatarThumbnailImageUrl = default(string), DeveloperType developerType = default(DeveloperType), string displayName = default(string), string friendKey = default(string), string id = default(string), string instanceId = default(string), bool isFriend = default(bool), string lastLogin = default(string), string lastPlatform = default(string), string location = default(string), string profilePicOverride = default(string), UserState state = default(UserState), UserStatus status = default(UserStatus), string statusDescription = default(string), List<string> tags = default(List<string>), string userIcon = default(string), string username = default(string), string worldId = default(string))
        {
            // to ensure "allowAvatarCopying" is required (not null)
            if (allowAvatarCopying == null)
            {
                throw new InvalidDataException("allowAvatarCopying is a required property for User and cannot be null");
            }
            else
            {
                this.AllowAvatarCopying = allowAvatarCopying;
            }

            // to ensure "bio" is required (not null)
            if (bio == null)
            {
                throw new InvalidDataException("bio is a required property for User and cannot be null");
            }
            else
            {
                this.Bio = bio;
            }

            // to ensure "bioLinks" is required (not null)
            if (bioLinks == null)
            {
                throw new InvalidDataException("bioLinks is a required property for User and cannot be null");
            }
            else
            {
                this.BioLinks = bioLinks;
            }

            // to ensure "currentAvatarImageUrl" is required (not null)
            if (currentAvatarImageUrl == null)
            {
                throw new InvalidDataException("currentAvatarImageUrl is a required property for User and cannot be null");
            }
            else
            {
                this.CurrentAvatarImageUrl = currentAvatarImageUrl;
            }

            // to ensure "currentAvatarThumbnailImageUrl" is required (not null)
            if (currentAvatarThumbnailImageUrl == null)
            {
                throw new InvalidDataException("currentAvatarThumbnailImageUrl is a required property for User and cannot be null");
            }
            else
            {
                this.CurrentAvatarThumbnailImageUrl = currentAvatarThumbnailImageUrl;
            }

            // to ensure "developerType" is required (not null)
            if (developerType == null)
            {
                throw new InvalidDataException("developerType is a required property for User and cannot be null");
            }
            else
            {
                this.DeveloperType = developerType;
            }

            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for User and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }

            // to ensure "friendKey" is required (not null)
            if (friendKey == null)
            {
                throw new InvalidDataException("friendKey is a required property for User and cannot be null");
            }
            else
            {
                this.FriendKey = friendKey;
            }

            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for User and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "isFriend" is required (not null)
            if (isFriend == null)
            {
                throw new InvalidDataException("isFriend is a required property for User and cannot be null");
            }
            else
            {
                this.IsFriend = isFriend;
            }

            // to ensure "lastLogin" is required (not null)
            if (lastLogin == null)
            {
                throw new InvalidDataException("lastLogin is a required property for User and cannot be null");
            }
            else
            {
                this.LastLogin = lastLogin;
            }

            // to ensure "lastPlatform" is required (not null)
            if (lastPlatform == null)
            {
                throw new InvalidDataException("lastPlatform is a required property for User and cannot be null");
            }
            else
            {
                this.LastPlatform = lastPlatform;
            }

            // to ensure "profilePicOverride" is required (not null)
            if (profilePicOverride == null)
            {
                throw new InvalidDataException("profilePicOverride is a required property for User and cannot be null");
            }
            else
            {
                this.ProfilePicOverride = profilePicOverride;
            }

            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for User and cannot be null");
            }
            else
            {
                this.State = state;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for User and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            // to ensure "statusDescription" is required (not null)
            if (statusDescription == null)
            {
                throw new InvalidDataException("statusDescription is a required property for User and cannot be null");
            }
            else
            {
                this.StatusDescription = statusDescription;
            }

            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for User and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }

            // to ensure "userIcon" is required (not null)
            if (userIcon == null)
            {
                throw new InvalidDataException("userIcon is a required property for User and cannot be null");
            }
            else
            {
                this.UserIcon = userIcon;
            }

            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for User and cannot be null");
            }
            else
            {
                this.Username = username;
            }

            this.InstanceId = instanceId;
            this.Location = location;
            this.WorldId = worldId;
        }

        /// <summary>
        /// Gets or Sets AllowAvatarCopying
        /// </summary>
        [DataMember(Name="allowAvatarCopying", EmitDefaultValue=true)]
        public bool AllowAvatarCopying { get; set; }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name="bio", EmitDefaultValue=true)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets BioLinks
        /// </summary>
        [DataMember(Name="bioLinks", EmitDefaultValue=true)]
        public List<string> BioLinks { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarImageUrl
        /// </summary>
        [DataMember(Name="currentAvatarImageUrl", EmitDefaultValue=true)]
        public string CurrentAvatarImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarThumbnailImageUrl
        /// </summary>
        [DataMember(Name="currentAvatarThumbnailImageUrl", EmitDefaultValue=true)]
        public string CurrentAvatarThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets DateJoined
        /// </summary>
        [DataMember(Name="date_joined", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DateJoined { get; private set; }


        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets FriendKey
        /// </summary>
        [DataMember(Name="friendKey", EmitDefaultValue=true)]
        public string FriendKey { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name="instanceId", EmitDefaultValue=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets IsFriend
        /// </summary>
        [DataMember(Name="isFriend", EmitDefaultValue=true)]
        public bool IsFriend { get; set; }

        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name="last_login", EmitDefaultValue=true)]
        public string LastLogin { get; set; }

        /// <summary>
        /// This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.
        /// </summary>
        /// <value>This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.</value>
        [DataMember(Name="last_platform", EmitDefaultValue=true)]
        public string LastPlatform { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets ProfilePicOverride
        /// </summary>
        [DataMember(Name="profilePicOverride", EmitDefaultValue=true)]
        public string ProfilePicOverride { get; set; }



        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name="statusDescription", EmitDefaultValue=true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets UserIcon
        /// </summary>
        [DataMember(Name="userIcon", EmitDefaultValue=true)]
        public string UserIcon { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets WorldId
        /// </summary>
        [DataMember(Name="worldId", EmitDefaultValue=false)]
        public string WorldId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  AllowAvatarCopying: ").Append(AllowAvatarCopying).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  BioLinks: ").Append(BioLinks).Append("\n");
            sb.Append("  CurrentAvatarImageUrl: ").Append(CurrentAvatarImageUrl).Append("\n");
            sb.Append("  CurrentAvatarThumbnailImageUrl: ").Append(CurrentAvatarThumbnailImageUrl).Append("\n");
            sb.Append("  DateJoined: ").Append(DateJoined).Append("\n");
            sb.Append("  DeveloperType: ").Append(DeveloperType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FriendKey: ").Append(FriendKey).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  IsFriend: ").Append(IsFriend).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  LastPlatform: ").Append(LastPlatform).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ProfilePicOverride: ").Append(ProfilePicOverride).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  UserIcon: ").Append(UserIcon).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  WorldId: ").Append(WorldId).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowAvatarCopying == input.AllowAvatarCopying ||
                    (this.AllowAvatarCopying != null &&
                    this.AllowAvatarCopying.Equals(input.AllowAvatarCopying))
                ) && 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.BioLinks == input.BioLinks ||
                    this.BioLinks != null &&
                    input.BioLinks != null &&
                    this.BioLinks.SequenceEqual(input.BioLinks)
                ) && 
                (
                    this.CurrentAvatarImageUrl == input.CurrentAvatarImageUrl ||
                    (this.CurrentAvatarImageUrl != null &&
                    this.CurrentAvatarImageUrl.Equals(input.CurrentAvatarImageUrl))
                ) && 
                (
                    this.CurrentAvatarThumbnailImageUrl == input.CurrentAvatarThumbnailImageUrl ||
                    (this.CurrentAvatarThumbnailImageUrl != null &&
                    this.CurrentAvatarThumbnailImageUrl.Equals(input.CurrentAvatarThumbnailImageUrl))
                ) && 
                (
                    this.DateJoined == input.DateJoined ||
                    (this.DateJoined != null &&
                    this.DateJoined.Equals(input.DateJoined))
                ) && 
                (
                    this.DeveloperType == input.DeveloperType ||
                    (this.DeveloperType != null &&
                    this.DeveloperType.Equals(input.DeveloperType))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FriendKey == input.FriendKey ||
                    (this.FriendKey != null &&
                    this.FriendKey.Equals(input.FriendKey))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.IsFriend == input.IsFriend ||
                    (this.IsFriend != null &&
                    this.IsFriend.Equals(input.IsFriend))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.LastPlatform == input.LastPlatform ||
                    (this.LastPlatform != null &&
                    this.LastPlatform.Equals(input.LastPlatform))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.ProfilePicOverride == input.ProfilePicOverride ||
                    (this.ProfilePicOverride != null &&
                    this.ProfilePicOverride.Equals(input.ProfilePicOverride))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.UserIcon == input.UserIcon ||
                    (this.UserIcon != null &&
                    this.UserIcon.Equals(input.UserIcon))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.WorldId == input.WorldId ||
                    (this.WorldId != null &&
                    this.WorldId.Equals(input.WorldId))
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
                if (this.AllowAvatarCopying != null)
                    hashCode = hashCode * 59 + this.AllowAvatarCopying.GetHashCode();
                if (this.Bio != null)
                    hashCode = hashCode * 59 + this.Bio.GetHashCode();
                if (this.BioLinks != null)
                    hashCode = hashCode * 59 + this.BioLinks.GetHashCode();
                if (this.CurrentAvatarImageUrl != null)
                    hashCode = hashCode * 59 + this.CurrentAvatarImageUrl.GetHashCode();
                if (this.CurrentAvatarThumbnailImageUrl != null)
                    hashCode = hashCode * 59 + this.CurrentAvatarThumbnailImageUrl.GetHashCode();
                if (this.DateJoined != null)
                    hashCode = hashCode * 59 + this.DateJoined.GetHashCode();
                if (this.DeveloperType != null)
                    hashCode = hashCode * 59 + this.DeveloperType.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FriendKey != null)
                    hashCode = hashCode * 59 + this.FriendKey.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.IsFriend != null)
                    hashCode = hashCode * 59 + this.IsFriend.GetHashCode();
                if (this.LastLogin != null)
                    hashCode = hashCode * 59 + this.LastLogin.GetHashCode();
                if (this.LastPlatform != null)
                    hashCode = hashCode * 59 + this.LastPlatform.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.ProfilePicOverride != null)
                    hashCode = hashCode * 59 + this.ProfilePicOverride.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.UserIcon != null)
                    hashCode = hashCode * 59 + this.UserIcon.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.WorldId != null)
                    hashCode = hashCode * 59 + this.WorldId.GetHashCode();
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


            // WorldId (string) pattern
            Regex regexWorldId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexWorldId.Match(this.WorldId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WorldId, must match a pattern of " + regexWorldId, new [] { "WorldId" });
            }

            yield break;
        }
    }

}
