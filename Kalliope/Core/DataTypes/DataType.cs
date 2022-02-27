﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DataType.cs" company="RHEA System S.A.">
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
    /// The base type for all data types
    /// </summary>
    [Description("")]
    [Domain(isAbstract: true, general: "ORMModelElement")]
    [Container(typeName: "ORMModel", propertyName: "DataTypes")]
    public abstract class DataType : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataType"/> class
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="DataType"/>
        /// </param>
        protected DataType(ORMModel model)
        {
            this.Model = model;
            model.DataTypes.Add(this);
        }

        /// <summary>
        /// Gets or sets the container <see cref="ORMModel"/>
        /// </summary>
        public ORMModel Model { get; set; }
    }
}
