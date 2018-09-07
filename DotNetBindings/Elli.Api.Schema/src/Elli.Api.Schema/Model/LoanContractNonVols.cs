/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Schema
 *
 * Represents schema operations on Loan.
 *
 * OpenAPI spec version: 1.3.0
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
using SwaggerDateConverter = Elli.Api.Schema.Client.SwaggerDateConverter;

namespace Elli.Api.Schema.Model
{
    /// <summary>
    /// LoanContractNonVols
    /// </summary>
    [DataContract]
    public partial class LoanContractNonVols :  IEquatable<LoanContractNonVols>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets NonVolIndex
        /// </summary>
        [DataMember(Name="nonVolIndex", EmitDefaultValue=false)]
        public int? NonVolIndex { get; set; }

        /// <summary>
        /// Gets or Sets NonVolId
        /// </summary>
        [DataMember(Name="nonVolId", EmitDefaultValue=false)]
        public string NonVolId { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentDescription
        /// </summary>
        [DataMember(Name="adjustmentDescription", EmitDefaultValue=false)]
        public string AdjustmentDescription { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentOtherDescription
        /// </summary>
        [DataMember(Name="adjustmentOtherDescription", EmitDefaultValue=false)]
        public string AdjustmentOtherDescription { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentType
        /// </summary>
        [DataMember(Name="adjustmentType", EmitDefaultValue=false)]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentAmount
        /// </summary>
        [DataMember(Name="adjustmentAmount", EmitDefaultValue=false)]
        public double? AdjustmentAmount { get; set; }

        /// <summary>
        /// Gets or Sets IncludedIndicator
        /// </summary>
        [DataMember(Name="includedIndicator", EmitDefaultValue=false)]
        public bool? IncludedIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractNonVols {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NonVolIndex: ").Append(NonVolIndex).Append("\n");
            sb.Append("  NonVolId: ").Append(NonVolId).Append("\n");
            sb.Append("  AdjustmentDescription: ").Append(AdjustmentDescription).Append("\n");
            sb.Append("  AdjustmentOtherDescription: ").Append(AdjustmentOtherDescription).Append("\n");
            sb.Append("  AdjustmentType: ").Append(AdjustmentType).Append("\n");
            sb.Append("  AdjustmentAmount: ").Append(AdjustmentAmount).Append("\n");
            sb.Append("  IncludedIndicator: ").Append(IncludedIndicator).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoanContractNonVols);
        }

        /// <summary>
        /// Returns true if LoanContractNonVols instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractNonVols to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractNonVols input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.NonVolIndex == input.NonVolIndex ||
                    (this.NonVolIndex != null &&
                    this.NonVolIndex.Equals(input.NonVolIndex))
                ) && 
                (
                    this.NonVolId == input.NonVolId ||
                    (this.NonVolId != null &&
                    this.NonVolId.Equals(input.NonVolId))
                ) && 
                (
                    this.AdjustmentDescription == input.AdjustmentDescription ||
                    (this.AdjustmentDescription != null &&
                    this.AdjustmentDescription.Equals(input.AdjustmentDescription))
                ) && 
                (
                    this.AdjustmentOtherDescription == input.AdjustmentOtherDescription ||
                    (this.AdjustmentOtherDescription != null &&
                    this.AdjustmentOtherDescription.Equals(input.AdjustmentOtherDescription))
                ) && 
                (
                    this.AdjustmentType == input.AdjustmentType ||
                    (this.AdjustmentType != null &&
                    this.AdjustmentType.Equals(input.AdjustmentType))
                ) && 
                (
                    this.AdjustmentAmount == input.AdjustmentAmount ||
                    (this.AdjustmentAmount != null &&
                    this.AdjustmentAmount.Equals(input.AdjustmentAmount))
                ) && 
                (
                    this.IncludedIndicator == input.IncludedIndicator ||
                    (this.IncludedIndicator != null &&
                    this.IncludedIndicator.Equals(input.IncludedIndicator))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NonVolIndex != null)
                    hashCode = hashCode * 59 + this.NonVolIndex.GetHashCode();
                if (this.NonVolId != null)
                    hashCode = hashCode * 59 + this.NonVolId.GetHashCode();
                if (this.AdjustmentDescription != null)
                    hashCode = hashCode * 59 + this.AdjustmentDescription.GetHashCode();
                if (this.AdjustmentOtherDescription != null)
                    hashCode = hashCode * 59 + this.AdjustmentOtherDescription.GetHashCode();
                if (this.AdjustmentType != null)
                    hashCode = hashCode * 59 + this.AdjustmentType.GetHashCode();
                if (this.AdjustmentAmount != null)
                    hashCode = hashCode * 59 + this.AdjustmentAmount.GetHashCode();
                if (this.IncludedIndicator != null)
                    hashCode = hashCode * 59 + this.IncludedIndicator.GetHashCode();
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