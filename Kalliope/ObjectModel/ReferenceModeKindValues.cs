﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ReferenceModeKindValues.cs" company="RHEA System S.A.">
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

namespace Kalliope.ObjectModel
{
    /// <summary>
    /// Classification of reference mode patterns
    /// </summary>
    public enum ReferenceModeKindValues
    {
        /// <summary>
        /// The reference mode patterns resolves to a value type with no special semantics
        /// </summary>
        General,

        /// <summary>
        /// The reference mode patterns resolves to a value type with a name based on the identified entity type.
        /// The value type identifies exactly one entity type
        /// </summary>
        Popular,

        /// <summary>
        /// The reference mode patterns resolves to a value type that is associated with a measurable unit
        /// </summary>
        UnitBased
    }
}
