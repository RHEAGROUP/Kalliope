// -------------------------------------------------------------------------------------------------
// <copyright file="DynamicColor.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a DynamicColor
    /// </summary>
    /// <remarks>
    /// Dynamic color information used by extension models with shape representations
    /// </remarks>
    public abstract partial class DynamicColor : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicColor"/> class.
        /// </summary>
        protected DynamicColor()
        {
        }
 

        /// <summary>
        /// Gets or sets a ColorRole
        /// </summary>
        [Description("")]
        [Property(name: "ColorRole", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string ColorRole { get; set; }
 
        /// <summary>
        /// Gets or sets a ColorValue
        /// </summary>
        [Description("")]
        [Property(name: "ColorValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string ColorValue { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
