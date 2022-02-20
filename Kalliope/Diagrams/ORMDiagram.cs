﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ORMDiagram.cs" company="RHEA System S.A.">
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

namespace Kalliope.Diagrams
{
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.Attributes;
    using Kalliope.Core;

    /// <summary>
    /// A diagram that represents items contained by an <see cref="ORMModel"/>
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "")]
    public class ORMDiagram
    {
        private string subjectReference = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="ORMDiagram"/>
        /// </summary>
        public ORMDiagram()
        {
            this.ObjectTypeShapes = new List<ObjectTypeShape>();
            this.FactTypeShapes = new List<FactTypeShape>();
            this.ExternalConstraintShapes = new List<ExternalConstraintShape>();
            this.FrequencyConstraintShapes = new List<FrequencyConstraintShape>();
            this.RingConstraintShapes = new List<RingConstraintShape>();
            this.ValueComparisonConstraintShapes = new List<ValueComparisonConstraintShape>();
            this.ModelNoteShapes = new List<ModelNoteShape>();
        }

        /// <summary>
        /// Gets or sets the subject <see cref="ORMModel"/> that is represented by this shape
        /// </summary>
        [Description("The subject ORMModel that is represented by this Diagram")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ORMModel")]
        public ORMModel Subject { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier
        /// </summary>
        [Description("")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the human readable name
        /// </summary>
        [Description("")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the base font
        /// </summary>
        [Description("")]
        [Property(name: "BaseFontName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string BaseFontName { get; set; }

        /// <summary>
        /// Gets or sets the size of the base font
        /// </summary>
        [Description("")]
        [Property(name: "BaseFontSize", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Double, defaultValue: "", typeName: "")]
        public double BaseFontSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this a complete view or not
        /// </summary>
        [Description("")]
        [Property(name: "IsCompleteView", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsCompleteView { get; set; }

        /// <summary>
        /// Gets or sets a value whether the shapes should be automatically populated
        /// </summary>
        /// <remarks>
        /// If this is set to true, then all shapes in the model will be loaded onto this diagram when the diagram is first loaded.
        /// AutoPopulateShapes is never written, but is useful for importing models with no diagram information
        /// </remarks>
        [Description("If this is set to true, then all shapes in the model will be loaded onto this diagram when the diagram is first loaded. AutoPopulateShapes is never written, but is useful for importing models with no diagram information")]
        [Property(name: "AutoPopulateShapes", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool AutoPopulateShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ObjectTypeShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "ObjectTypeShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeShape")]
        public List<ObjectTypeShape> ObjectTypeShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="FactTypeShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "FactTypeShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeShape")]
        public List<FactTypeShape> FactTypeShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ExternalConstraintShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "ExternalConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExternalConstraintShape")]
        public List<ExternalConstraintShape> ExternalConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="FrequencyConstraintShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "FrequencyConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FrequencyConstraintShape")]
        public List<FrequencyConstraintShape> FrequencyConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="RingConstraintShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "RingConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RingConstraintShape")]
        public List<RingConstraintShape> RingConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ValueComparisonConstraintShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "ValueComparisonConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueComparisonConstraintShape")]
        public List<ValueComparisonConstraintShape> ValueComparisonConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ModelNoteShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "ModelNoteShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelNoteShape")]
        public List<ModelNoteShape> ModelNoteShapes { get; set; }

        /// <summary>
        /// Generates a <see cref="ORMModel"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal void ReadXml(XmlReader reader)
        {
            this.Id = reader.GetAttribute("id");
            this.Name = reader.GetAttribute("Name");
            this.BaseFontName = reader.GetAttribute("BaseFontName");

            var baseFontSize = reader.GetAttribute("BaseFontSize");
            if (!string.IsNullOrEmpty(baseFontSize))
            {
                this.BaseFontSize = XmlConvert.ToDouble(baseFontSize);
            }

            var isCompleteView = reader.GetAttribute("IsCompleteView");
            if (!string.IsNullOrEmpty(isCompleteView))
            {
                this.IsCompleteView = XmlConvert.ToBoolean(isCompleteView);
            }
            
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Shapes":
                            using (var objectsSubtree = reader.ReadSubtree())
                            {
                                objectsSubtree.MoveToContent();
                                this.ReadShapes(objectsSubtree);
                            }
                            break;
                        case "Subject":
                            this.subjectReference = reader.GetAttribute("ref");
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="ORMBaseShape"/>s from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadShapes(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ObjectTypeShape":
                            using (var objectTypeShapeSubtree = reader.ReadSubtree())
                            {
                                objectTypeShapeSubtree.MoveToContent();
                                var objectTypeShape = new ObjectTypeShape();
                                objectTypeShape.ReadXml(objectTypeShapeSubtree);
                                this.ObjectTypeShapes.Add(objectTypeShape);
                            }
                            break;
                        case "FactTypeShape":

                            using (var factTypeShapeSubtree = reader.ReadSubtree())
                            {
                                factTypeShapeSubtree.MoveToContent();
                                var factTypeShape = new FactTypeShape();
                                factTypeShape.ReadXml(factTypeShapeSubtree);
                                this.FactTypeShapes.Add(factTypeShape);
                            }
                            break;

                        case "ExternalConstraintShape":
                            using (var externalConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                externalConstraintShapeSubtree.MoveToContent();
                                var externalConstraintShape = new ExternalConstraintShape();
                                externalConstraintShape.ReadXml(externalConstraintShapeSubtree);
                                this.ExternalConstraintShapes.Add(externalConstraintShape);
                            }
                            break;
                        case "FrequencyConstraintShape":
                            using (var frequencyConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                frequencyConstraintShapeSubtree.MoveToContent();
                                var frequencyConstraintShape = new FrequencyConstraintShape();
                                frequencyConstraintShape.ReadXml(frequencyConstraintShapeSubtree);
                                this.FrequencyConstraintShapes.Add(frequencyConstraintShape);
                            }
                            break;
                        case "RingConstraintShape":
                            using (var ringConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                ringConstraintShapeSubtree.MoveToContent();
                                var ringConstraintShape = new RingConstraintShape();
                                ringConstraintShape.ReadXml(ringConstraintShapeSubtree);
                                this.RingConstraintShapes.Add(ringConstraintShape);
                            }
                            break;
                        case "ValueComparisonConstraintShape":
                            using (var valueComparisonConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                valueComparisonConstraintShapeSubtree.MoveToContent();
                                var valueComparisonConstraintShape = new ValueComparisonConstraintShape();
                                valueComparisonConstraintShape.ReadXml(valueComparisonConstraintShapeSubtree);
                                this.ValueComparisonConstraintShapes.Add(valueComparisonConstraintShape);
                            }
                            break;
                        case "ModelNoteShape":
                            using (var modelNoteShapeSubtree = reader.ReadSubtree())
                            {
                                modelNoteShapeSubtree.MoveToContent();
                                var modelNoteShape = new ModelNoteShape();
                                modelNoteShape.ReadXml(modelNoteShapeSubtree);
                                this.ModelNoteShapes.Add(modelNoteShape);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }
    }
}
