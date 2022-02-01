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

namespace Kalliope.Core
{
    using System.Collections.Generic;
    using System.Xml;

    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Definition of elements used in the primary definition of an ORM model
    /// </summary>
    public class ORMModel : ORMNamedElement
    {
        /// <summary>
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </summary>
        private readonly ILoggerFactory loggerFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ORMModel"/> class
        /// </summary>
        public ORMModel()
        {
            this.Definitions = new List<Definition>();
            this.Notes = new List<Note>();
            this.ObjectTypes = new List<ObjectType>();
            this.FactTypes = new List<FactType>();
            this.DataTypes = new List<DataType>();
            this.Functions = new List<Function>();
            this.CustomReferenceModes = new List<CustomReferenceMode>();
            this.ModelNotes = new List<ModelNote>();
            this.ModelErrors = new List<ModelError>();
            this.ReferenceModeKinds = new List<ReferenceModeKind>();
            this.RecognizedPhrases = new List<RecognizedPhrase>();
            this.Extensions = new List<Extension>();
            this.SetConstraints = new List<SetConstraint>();
            this.SetComparisonConstraints = new List<SetComparisonConstraint>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORMModel"/> class.
        /// </summary>
        /// <param name="loggerFactory">
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </param>
        internal ORMModel(ILoggerFactory loggerFactory) : this()
        {
            this.loggerFactory = loggerFactory;
        }

        /// <summary>
        /// An informal description of this Model.
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Informal Description Editor' tool window
        /// </summary>
        public string DefinitionText { get; set; }

        /// <summary>
        /// A note to associate with this Model.
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Notes Editor' tool window
        /// </summary>
        public string NoteText { get; set; }

        /// <summary>
        /// The value of the referenced element's unique id
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ReferenceModeKind"/>
        /// </summary>
        public ReferenceModeKind ReferenceModeKind { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ReferenceMode"/>
        /// </summary>
        public ReferenceMode ReferenceMode { get; set; }

        /// <summary>
        /// The <see cref="Definitions"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<Definition> Definitions { get; set; }

        /// <summary>
        /// The <see cref="Note"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<Note> Notes { get; set; }

        /// <summary>
        /// The <see cref="ObjectType"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<ObjectType> ObjectTypes { get; set; }

        /// <summary>
        /// The <see cref="FactType"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<FactType> FactTypes { get; set; }

        /// <summary>
        /// The <see cref="DataType"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<DataType> DataTypes { get; set; }

        /// <summary>
        /// The <see cref="Function"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<Function> Functions { get; set; }

        /// <summary>
        /// The <see cref="CustomReferenceMode"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<CustomReferenceMode> CustomReferenceModes { get; set; }

        /// <summary>
        /// The <see cref="ModelNote"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<ModelNote> ModelNotes { get; set; }

        /// <summary>
        /// The <see cref="ModelError"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<ModelError> ModelErrors { get; set; }

        /// <summary>
        /// The <see cref="ReferenceModeKind"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<ReferenceModeKind> ReferenceModeKinds { get; set; }

        /// <summary>
        /// The <see cref="RecognizedPhrase"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<RecognizedPhrase> RecognizedPhrases { get; set; }

        /// <summary>
        /// The <see cref="Extension"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<Extension> Extensions { get; set; }

        /// <summary>
        /// The <see cref="SetConstraint"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<SetConstraint> SetConstraints { get; set; }

        /// <summary>
        /// The <see cref="SetComparisonConstraint"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<SetComparisonConstraint> SetComparisonConstraints { get; set; }

        /// <summary>
        /// Generates a <see cref="ORMModel"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);
            
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Objects":
                            using (var objectsSubtree = reader.ReadSubtree())
                            {
                                objectsSubtree.MoveToContent();
                                this.ReadObjects(objectsSubtree);
                            }
                            break;
                        case "Facts":
                            using (var factsSubtree = reader.ReadSubtree())
                            {
                                factsSubtree.MoveToContent();
                                this.ReadFacts(factsSubtree);
                            }
                            break;
                        case "Constraints":
                            using (var constraintsSubTree = reader.ReadSubtree())
                            {
                                constraintsSubTree.MoveToContent();
                                this.ReadConstraints(constraintsSubTree);
                            }
                            break;
                        case "DataTypes":
                            using (var dataTypesSubtree = reader.ReadSubtree())
                            {
                                dataTypesSubtree.MoveToContent();
                                this.ReadDataTypes(dataTypesSubtree);
                            }
                            break;
                        case "ReferenceModeKinds":
                            using (var referenceModeKindsSubtree = reader.ReadSubtree())
                            {
                                referenceModeKindsSubtree.MoveToContent();
                                this.ReadReferenceModeKinds(referenceModeKindsSubtree);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="ObjectType"/>s from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadObjects(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "EntityType":

                            using (var entityTypeSubtree = reader.ReadSubtree())
                            {
                                entityTypeSubtree.MoveToContent();
                                var entityType = new EntityType(this, this.loggerFactory);
                                entityType.ReadXml(entityTypeSubtree);
                            }
                            
                            break;

                        case "ValueType":

                            using (var valueTypeSubtree = reader.ReadSubtree())
                            {
                                valueTypeSubtree.MoveToContent();
                                var valueType = new ValueType(this, this.loggerFactory);
                                valueType.ReadXml(valueTypeSubtree);
                            }

                            break;

                        case "ObjectifiedType":

                            using (var objectifiedTypeSubtree = reader.ReadSubtree())
                            {
                                objectifiedTypeSubtree.MoveToContent();
                                var objectifiedType = new ObjectifiedType(this, this.loggerFactory);
                                objectifiedType.ReadXml(objectifiedTypeSubtree);
                            }

                            break;

                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }

                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadFacts(XmlReader reader)
        { 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadConstraints(XmlReader reader)
        { 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadDataTypes(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "AutoCounterNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new AutoCounterNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "AutoTimestampTemporalDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new AutoTimestampTemporalDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "DateAndTimeTemporalDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new DateAndTimeTemporalDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "DateTemporalDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new DateTemporalDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "DecimalNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new DecimalNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "DoublePrecisionFloatingPointNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new DoublePrecisionFloatingPointNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "FixedLengthRawDataDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new FixedLengthRawDataDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "FixedLengthTextDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new FixedLengthTextDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "FloatingPointNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new FloatingPointNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "LargeLengthRawDataDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new LargeLengthRawDataDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "LargeLengthTextDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new LargeLengthTextDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "LogicalDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new LogicalDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "MoneyNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new MoneyNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "ObjectIdOtherDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new ObjectIdOtherDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "OleObjectRawDataDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new OleObjectRawDataDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "PictureRawDataDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new PictureRawDataDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "RowIdOtherDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new RowIdOtherDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "SignedIntegerNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new SignedIntegerNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "SignedLargeIntegerNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new SignedLargeIntegerNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "SignedSmallIntegerNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new SignedSmallIntegerNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "SinglePrecisionFloatingPointNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new SinglePrecisionFloatingPointNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "TimeTemporalDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new TimeTemporalDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "TrueOrFalseLogicalDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new TrueOrFalseLogicalDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "UnsignedIntegerNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new UnsignedIntegerNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "UnsignedLargeIntegerNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new UnsignedLargeIntegerNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "UnsignedSmallIntegerNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new UnsignedSmallIntegerNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "UnsignedTinyIntegerNumericDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new UnsignedTinyIntegerNumericDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "UnspecifiedDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new UnspecifiedDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "VariableLengthRawDataDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new VariableLengthRawDataDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "VariableLengthTextDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new VariableLengthTextDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        case "YesOrNoLogicalDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dataType = new YesOrNoLogicalDataType(this);
                                dataType.ReadXml(dataTypeSubtree);
                            }

                            break;

                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }

                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadReferenceModeKinds(XmlReader reader)
        { 
        }
    }
}
