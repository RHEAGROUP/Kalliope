// -------------------------------------------------------------------------------------------------
// <copyright file="RheaModelTestFixture.cs" company="RHEA System S.A.">
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

namespace Kalliope.OO.Tests
{
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using Kalliope.Core;
    using Kalliope.OO.Generation;
    using Kalliope.OO.StructuralFeature;

    using NUnit.Framework;

    public class RheaModelTestFixture
    {
        private OrmRoot ormRoot;
        private ClassGenerator classGenerator;

        [SetUp]
        public void Setup()
        {
            var assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var ormFileName = Path.Combine(assemblyFolder, "Data", "RheaTest.orm");

            this.ormRoot = OrmModelLoader.Load(ormFileName);

            this.classGenerator = new ClassGenerator(this.ormRoot.Model, new GeneratorSettings());
        }

        [Test]
        public void VerifyThatAllEntityClassesAreCreated()
        {
            var classes = this.classGenerator.Generate();

            foreach (var ooClass in classes)
            {
                foreach (var property in ooClass.Properties)
                {
                    Assert.That(property.Name, Is.Not.Empty);
                    Assert.That(property.DataType, Is.Not.EqualTo("Unknown type"));
                    var isEnumerable = property.IsEnumerable;
                }
            }

            Assert.That(classes.Count, Is.EqualTo(9));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ValueTypeProperty>().Count(), Is.EqualTo(12));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ReferenceProperty<ObjectifiedType>>().Count(), Is.EqualTo(2));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ReferenceProperty<EntityType>>().Count(), Is.EqualTo(6));
            Assert.That(classes.SelectMany(x => x.SuperClasses).Count(), Is.EqualTo(5));
            Assert.That(classes.SelectMany(x => x.SubClasses).Count(), Is.EqualTo(5));
            Assert.That(classes.Where(x => x.IsAbstract == true).Count, Is.EqualTo(1));
        }
    }
}
