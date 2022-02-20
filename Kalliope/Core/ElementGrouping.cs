﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ElementGrouping.cs" company="RHEA System S.A.">
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

    using Kalliope.Attributes;

    /// <summary>
    /// User-defined and rule-based element groupings
    /// </summary>
    /// <remarks>
    /// A group of elements. A GroupType is associated with the Group to control the group contents
    /// </remarks>
    [Description("A group of elements. A GroupType is associated with the Group to control the group contents")]
    [Domain(isAbstract: false, general: "ORMNamedElement")]
    [Container("ElementGroupingSet", "Groupings")]
    public class ElementGrouping : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementGrouping"/> class
        /// </summary>
        public ElementGrouping()
        {
            this.TypeCompliance = GroupingMembershipTypeCompliance.NotExcluded;
            this.Priority = 0;
            this.MembershipContradictionErrors = new List<ElementGroupingMembershipContradictionError>();
            this.GroupingTypes = new List<ElementGroupingType>();
            this.IncludedElements = new List<ORMModelElement>();
            this.ExcludedElements = new List<ORMModelElement>();
            this.ChildGroupings = new List<ElementGrouping>();
            this.IncludedChildGroupings = new List<ElementGrouping>();
            this.ExcludedChildGroupings = new List<ElementGrouping>();
        }

        /// <summary>
        /// Gets or sets the owned <see cref="Definition"/>
        /// </summary>
        [Description("")]
        [Property(name: "Definition", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Definition")]
        public Definition Definition { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note")]
        public Note Note { get; set; }

        /// <summary>
        /// Specify the level of GroupType compliance for elements in this group
        /// Not Excluded: Allow elements not explicitly excluded by a selected GroupType
        /// Approved by Some Type: Allow elements explicitly approved by at least one GroupType.
        /// Approved by All Types: Allow elements explicitly approved by all selected GroupTypes
        /// </summary>
        [Description("Specify the level of GroupType compliance for elements in this group. Not Excluded: Allow elements not explicitly excluded by a selected GroupType. by Some Type: Allow elements explicitly approved by at least one GroupType. Approved by All Types: Allow elements explicitly approved by all selected GroupTypes")]
        [Property(name: "TypeCompliance", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotExcluded")]
        public GroupingMembershipTypeCompliance TypeCompliance { get; set; }

        /// <summary>
        /// Specify a priority relative to other Groups.
        /// If an element is included in two groups of the same type, the settings for the Group with the highest GroupPriority are given precedence
        /// </summary>
        [Description("Specify a priority relative to other Groups. If an element is included in two groups of the same type, the settings for the Group with the highest GroupPriority are given precedence")]
        [Property(name: "Priority", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "0")]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ElementGroupingMembershipContradictionError"/>s
        /// </summary>
        [Description("")]
        [Property(name: "MembershipContradictionErrors", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGroupingMembershipContradictionError")]
        public List<ElementGroupingMembershipContradictionError> MembershipContradictionErrors { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ElementGroupingType"/>s
        /// </summary>
        [Description("")]
        [Property(name: "GroupingTypes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGroupingType")]
        public List<ElementGroupingType> GroupingTypes { get; set; }

        [Description("")]
        [Property(name: "IncludedElements", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ORMModelElement")]
        public List<ORMModelElement> IncludedElements { get; set; }

        [Description("")]
        [Property(name: "ExcludedElements", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ORMModelElement")]
        public List<ORMModelElement> ExcludedElements { get; set; }

        [Description("")]
        [Property(name: "ChildGroupings", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGrouping")]
        public List<ElementGrouping> ChildGroupings { get; set; }

        [Description("")]
        [Property(name: "IncludedChildGroupings", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGrouping")]
        public List<ElementGrouping> IncludedChildGroupings { get; set; }

        [Description("")]
        [Property(name: "ExcludedChildGroupings", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGrouping")]
        public List<ElementGrouping> ExcludedChildGroupings { get; set; }

        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGroupingDuplicateNameError")]
        public ElementGroupingDuplicateNameError DuplicateNameError { get; set; }
    }
}
