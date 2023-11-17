﻿// -------------------------------------------------------------------------------------------------
// <copyright file="JoinRule.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A sequence of constraint roles
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "ModelThing")]
    [Container(typeName: "ConstraintRoleSequenceWithJoin", propertyName: "JoinRule")]
    public class JoinRule : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinRule"/> class
        /// </summary>
        public JoinRule()
        {
        }

        /// <summary>
        /// Gets or sets the owned <see cref="JoinPathRequiredError"/>
        /// </summary>
        [Description("")]
        [Property(name: "JoinPathRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "JoinPathRequiredError")]
        public JoinPathRequiredError JoinPathRequiredError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ConstraintRoleSequenceJoinPath"/>
        /// </summary>
        [Description("")]
        [Property(name: "JoinPath", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ConstraintRoleSequenceJoinPath")]
        public ConstraintRoleSequenceJoinPath JoinPath { get; set; }
    }
}
