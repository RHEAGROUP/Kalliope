// -------------------------------------------------------------------------------------------------
// <copyright file="CalculatedPathValueInput.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a CalculatedPathValueInput
    /// </summary>
    /// <remarks>
    /// An input value or bag passed to a function parameter calculate a value
    /// </remarks>
    public partial class CalculatedPathValueInput : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatedPathValueInput"/> class.
        /// </summary>
        public  CalculatedPathValueInput()
        {
        }
 
        /// <summary>
        /// Gets or sets a DistinctValues
        /// </summary>
        public bool DistinctValues { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="FunctionParameter"/>
        /// </summary>
        public Guid Parameter { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="CalculatedPathValue"/>
        /// </summary>
        public Guid SourceCalculatedValue { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="PathConstant"/>
        /// </summary>
        public Guid SourceConstant { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------