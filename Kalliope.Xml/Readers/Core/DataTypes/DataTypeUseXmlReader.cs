﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DataTypeUseXmlReader.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Readers
{
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="DataTypeUseXmlReader"/> is to deserialize a <see cref="DataTypeUse"/>
    /// from an .orm XML file
    /// </summary>
    public class DataTypeUseXmlReader : OrmModelElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="DataTypeRef"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="dataTypeUse">
        /// The subject <see cref="DataTypeUse"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(DataTypeUse dataTypeUse, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(dataTypeUse, reader, modelThings);

            dataTypeUse.Reference = reader.GetAttribute("ref");

            var scale = reader.GetAttribute("Scale");
            if (!string.IsNullOrEmpty(scale))
            {
                dataTypeUse.Scale = XmlConvert.ToInt32(scale);
            }

            var length = reader.GetAttribute("Length");
            if (!string.IsNullOrEmpty(length))
            {
                dataTypeUse.Length = XmlConvert.ToInt32(length);
            }

            var autoGenerated = reader.GetAttribute("AutoGenerated");
            if (!string.IsNullOrEmpty(autoGenerated))
            {
                dataTypeUse.AutoGenerated = XmlConvert.ToBoolean(autoGenerated);
            }
        }
    }
}
