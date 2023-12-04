// -------------------------------------------------------------------------------------------------
// <copyright file="PathedRole.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a PathedRole
    /// </summary>
    /// <remarks>
    /// A role in connected path.
    /// </remarks>
    [Container(typeName: "RolePath", propertyName: "PathedRole")]
    public partial class PathedRole : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PathedRole"/> class.
        /// </summary>
        public PathedRole()
        {
            this.Purpose = PathedRolePurpose.SameFactType;
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a IsNegated
        /// </summary>
        [Description("Is this PathedRole Negated")]
        [Property(name: "IsNegated", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsNegated { get; set; }
 
        /// <summary>
        /// Gets or sets a Purpose
        /// </summary>
        [Description("The Purpose specification for a PathedRole.")]
        [Property(name: "Purpose", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "SameFactType", typeName: "PathedRolePurpose", allowOverride: false, isOverride: false, isDerived: false)]
        public PathedRolePurpose Purpose { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="RoleBase"/>
        /// </summary>
        [Description("")]
        [Property(name: "Role", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleBase", allowOverride: false, isOverride: false, isDerived: false)]
        public string Role { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="PathConditionRoleValueRestriction"/>
        /// </summary>
        [Description("The PathConditionRoleValueRestriction")]
        [Property(name: "ValueRestriction", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathConditionRoleValueRestriction", allowOverride: false, isOverride: false, isDerived: false)]
        public string ValueRestriction { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------