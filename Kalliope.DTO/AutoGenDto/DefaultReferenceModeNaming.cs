// -------------------------------------------------------------------------------------------------
// <copyright file="DefaultReferenceModeNaming.cs" company="RHEA System S.A.">
//
//   Copyright 2022 RHEA System S.A.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
// </copyright>
 
// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a DefaultReferenceModeNaming
    /// </summary>
    public abstract partial class DefaultReferenceModeNaming : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultReferenceModeNaming"/> class.
        /// </summary>
        protected DefaultReferenceModeNaming()
        {
            this.NamingChoice = EffectiveReferenceModeNamingChoice.ValueTypeName;
            this.PrimaryIdentifierNamingChoice = EffectiveReferenceModeNamingChoice.ValueTypeName;
            this.ReferenceModeTargetKind = ReferenceModeType.Popular;
        }
 

        /// <summary>
        /// Gets or sets a CustomFormat
        /// </summary>
        [Description("The default custom naming format used for references to EntityTypes with custom naming formats.")]
        [Property(name: "CustomFormat", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string CustomFormat { get; set; }
 
        /// <summary>
        /// Gets or sets a NamingChoice
        /// </summary>
        [Description("")]
        [Property(name: "NamingChoice", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "ValueTypeName", typeName: "EffectiveReferenceModeNamingChoice")]
        public EffectiveReferenceModeNamingChoice NamingChoice { get; set; }
 
        /// <summary>
        /// Gets or sets a PrimaryIdentifierCustomFormat
        /// </summary>
        [Description("The default custom naming format used for simple primary identification of EntityTypes with custom naming formats")]
        [Property(name: "PrimaryIdentifierCustomFormat", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string PrimaryIdentifierCustomFormat { get; set; }
 
        /// <summary>
        /// Gets or sets a PrimaryIdentifierNamingChoice
        /// </summary>
        [Description("The default naming pattern used for simple primary identification of EntityTypes with this kind of reference mode")]
        [Property(name: "PrimaryIdentifierNamingChoice", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "ValueTypeName", typeName: "EffectiveReferenceModeNamingChoice")]
        public EffectiveReferenceModeNamingChoice PrimaryIdentifierNamingChoice { get; set; }
 
        /// <summary>
        /// Gets or sets a ReferenceModeTargetKind
        /// </summary>
        [Description("")]
        [Property(name: "ReferenceModeTargetKind", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Popular", typeName: "ReferenceModeType")]
        public ReferenceModeType ReferenceModeTargetKind { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
