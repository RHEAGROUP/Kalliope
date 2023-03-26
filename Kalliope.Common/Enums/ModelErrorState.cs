﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ModelErrorState.cs" company="RHEA System S.A.">
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

namespace Kalliope.Common
{
    [Description("")]
    public enum ModelErrorState
    {
        /// <summary>
        /// Error is fully enabled
        /// </summary>
        [Description("Error is fully enabled")]
        Error = 0,

        /// <summary>
        /// Error state is tracked, but ignored
        /// </summary>
        [Description("Error state is tracked, but ignored")]
        Ignored = 1
    }
}
