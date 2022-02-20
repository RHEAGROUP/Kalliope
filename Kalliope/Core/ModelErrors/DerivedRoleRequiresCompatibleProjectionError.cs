﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DerivedRoleRequiresCompatibleProjectionError.cs" company="RHEA System S.A.">
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
    using Kalliope.Attributes;

    /// <summary>
    /// A role path projection onto a derived role must be of a type that is compatible with the derived role
    /// </summary>
    [Description("A role path projection onto a derived role must be of a type that is compatible with the derived role")]
    [Domain(isAbstract: false, general: "ModelError")]
    public class DerivedRoleRequiresCompatibleProjectionError : ModelError
    {
    }
}
