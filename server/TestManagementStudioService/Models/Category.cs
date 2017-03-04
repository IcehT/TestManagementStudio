/*
 * TestManagement Studio Backend API
 *
 * <<Some text >>   Would respond with: ```js callbackFunction({     ... }); ``` 
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TestManagementStudioService.Models
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Category : SecuredEntity, IEquatable<Category>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Permissions">Permissions.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Parent">Parent.</param>
        /// <param name="Childrens">Childrens.</param>
        /// <param name="Questions">Questions.</param>
        /// <param name="Tests">Tests.</param>
        public Category(int? Id = default(int?), List<Permission> Permissions = default(List<Permission>), string Name = default(string), Category Parent = default(Category), List<Category> Childrens = default(List<Category>), List<Question> Questions = default(List<Question>), List<Test> Tests = default(List<Test>))
        {
            this.Id = Id;
            this.Permissions = Permissions;
            this.Name = Name;
            this.Parent = Parent;
            this.Childrens = Childrens;
            this.Questions = Questions;
            this.Tests = Tests;
            
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions")]
        public List<Permission> Permissions { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent")]
        public Category Parent { get; set; }
        /// <summary>
        /// Gets or Sets Childrens
        /// </summary>
        [DataMember(Name="childrens")]
        public List<Category> Childrens { get; set; }
        /// <summary>
        /// Gets or Sets Questions
        /// </summary>
        [DataMember(Name="questions")]
        public List<Question> Questions { get; set; }
        /// <summary>
        /// Gets or Sets Tests
        /// </summary>
        [DataMember(Name="tests")]
        public List<Test> Tests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Category {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Childrens: ").Append(Childrens).Append("\n");
            sb.Append("  Questions: ").Append(Questions).Append("\n");
            sb.Append("  Tests: ").Append(Tests).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Category)obj);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="other">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this.Childrens == other.Childrens ||
                    this.Childrens != null &&
                    this.Childrens.SequenceEqual(other.Childrens)
                ) && 
                (
                    this.Questions == other.Questions ||
                    this.Questions != null &&
                    this.Questions.SequenceEqual(other.Questions)
                ) && 
                (
                    this.Tests == other.Tests ||
                    this.Tests != null &&
                    this.Tests.SequenceEqual(other.Tests)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                    if (this.Childrens != null)
                    hash = hash * 59 + this.Childrens.GetHashCode();
                    if (this.Questions != null)
                    hash = hash * 59 + this.Questions.GetHashCode();
                    if (this.Tests != null)
                    hash = hash * 59 + this.Tests.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Category left, Category right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Category left, Category right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}