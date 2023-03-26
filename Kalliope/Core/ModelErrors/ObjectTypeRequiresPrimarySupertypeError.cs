﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeRequiresPrimarySupertypeError.cs" company="RHEA System S.A.">
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
    using System;

    using Kalliope.Common;

    /// <summary>
    /// Deprecated along with SubtypeFact.IsPrimary property
    /// </summary>
    [Obsolete("Deprecated along with SubtypeFact.IsPrimary property")]
    [Description("Deprecated along with SubtypeFact.IsPrimary property")]
    [Domain(isAbstract: false, general: "ModelError")]
    public class ObjectTypeRequiresPrimarySupertypeError : ModelError
    {
    }
}
