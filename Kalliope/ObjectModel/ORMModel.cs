﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ORMModel.cs" company="RHEA System S.A.">
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
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Definition of elements used in the primary definition of an ORM model
    /// </summary>
    public class ORMModel
    {
        /// <summary>
        /// A unique identifier for this element
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The name of the model
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The value of the referenced element's unique id
        /// </summary>
        public string Reference { get; set; }
    }
}
