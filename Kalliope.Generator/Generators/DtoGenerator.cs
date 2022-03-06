﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DtoGenerator.cs" company="RHEA System S.A.">
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

namespace Kalliope.Generator.Generators
{
    using System;
    using System.IO;
    using System.Linq;

    using DotLiquid;

    using Kalliope.Common;
    using Kalliope.Generator.Drops;

    /// <summary>
    /// The purpose of the <see cref="DtoGenerator"/> is to generate Kalliope DTO
    /// </summary>
    public class DtoGenerator : Generator
    {
        /// <summary>
        /// name of the DTO Template
        /// </summary>
        private const string Dtotemplate = "dto-class-template";

        /// <summary>
        /// Loads the liquid templates used for the generator
        /// </summary>
        public override void LoadTemplates()
        {
            this.LiquidTemplates.Add(Dtotemplate, this.LoadTemplate(Dtotemplate));
        }

        /// <summary>
        /// Generate the DTO class files
        /// </summary>
        /// <param name="outputDirectory">
        /// The output Directory where the DTO's will be generated.
        /// </param>
        public override void Generate(DirectoryInfo outputDirectory)
        {
            base.Generate(outputDirectory);

            var ormRootType = typeof(OrmRoot);

            var types = ormRootType.Assembly.GetTypes().ToList();

            foreach (var type in types)
            {
                var domainAttribute = (DomainAttribute) Attribute.GetCustomAttribute(type, typeof(DomainAttribute));
                var descriptionAttribute = (DescriptionAttribute) Attribute.GetCustomAttribute(type, typeof(DescriptionAttribute));
                var containerAttributes = (ContainerAttribute[]) Attribute.GetCustomAttributes(type, typeof(ContainerAttribute));
                if (domainAttribute != null)
                {
                    var typeDrop = new TypeDrop(type, domainAttribute, descriptionAttribute, containerAttributes);
                    var generatedType = this.GenerateType(typeDrop);

                    var fileName = $"{typeDrop.Name}.cs";
                    var filePath = Path.Combine(outputDirectory.FullName, fileName);

                    File.WriteAllText(filePath, generatedType);
                }
            }
        }

        /// <summary>
        /// Generate the code for a <see cref="TypeDrop"/>
        /// </summary>
        /// <param name="drop">
        /// The subject <see cref="TypeDrop"/>
        /// </param>
        /// <returns>
        /// returns the generated code
        /// </returns>
        internal string GenerateType(TypeDrop drop)
        {
            string dtoTemplate;
            if (!this.LiquidTemplates.TryGetValue(Dtotemplate, out dtoTemplate))
            {
                throw new Exception("Could not load the DTO Template");
            }

            var template = Template.Parse(dtoTemplate);

            var code = template.Render(Hash.FromAnonymousObject(new { TypeDrop = drop }));

            return this.RemoveRedundantLines(code);
        }
    }
}
