﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DataTypeRef.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;

    /// <summary>
    /// A use of a data type, including facet information
    /// </summary>
    [Description("A use of a data type, including facet information")]
    [Domain(isAbstract: false, general: "ORMModelElement")]
    [Container(typeName:"ObjectType", propertyName: "ConceptualDataType")]
    public class DataTypeRef : ORMModelElement
    {
        /// <summary>
        /// Gets or sets the value of the Scale facet
        /// </summary>
        [Description("The value of the Scale facet")]
        [Property(name: "Scale", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "")]
        public int Scale { get; set; }

        /// <summary>
        /// Gets or sets the value of the Length facet. Holds the Precision fact for Decimal and Money data types
        /// </summary>
        [Description("The value of the Length facet. Holds the Precision fact for Decimal and Money data types")]
        [Property(name: "Length", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "")]
        public int Length { get; set; }

        /// <summary>
        /// The value of the referenced element's unique id
        /// </summary>
        /// <remarks>
        /// The unique identifier of the referenced <see cref="DataType"/>
        /// </remarks>
        [Description("The value of the referenced element's unique id")]
        [Property(name: "Reference", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string Reference { get; set; }
    }
}
