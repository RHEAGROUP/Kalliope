// -------------------------------------------------------------------------------------------------
// <copyright file="LeadRolePathExtensions.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.Dal
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.Diagrams;

    /// <summary>
    /// A static class that provides extension methods for the <see cref="LeadRolePath"/> class
    /// </summary>
    public static class LeadRolePathExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="LeadRolePath"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="LeadRolePath"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="LeadRolePath"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.LeadRolePath poco, Kalliope.DTO.LeadRolePath dto)
        {
            if (poco == null)
            {
                throw new ArgumentNullException(nameof(poco), $"the {nameof(poco)} may not be null");
            }

            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var identifiersOfObjectsToDelete = new List<string>();

            var associatedModelErrorsToDelete = poco.AssociatedModelErrors.Select(x => x.Id).Except(dto.AssociatedModelErrors);
            foreach (var identifier in associatedModelErrorsToDelete)
            {
                var modelError = poco.AssociatedModelErrors.Single(x => x.Id == identifier);
                poco.AssociatedModelErrors.Remove(modelError);
            }

            var calculatedValuesToDelete = poco.CalculatedValues.Select(x => x.Id).Except(dto.CalculatedValues);
            identifiersOfObjectsToDelete.AddRange(calculatedValuesToDelete);
            foreach (var identifier in calculatedValuesToDelete)
            {
                var calculatedPathValue = poco.CalculatedValues.Single(x => x.Id == identifier);
                poco.CalculatedValues.Remove(calculatedPathValue);
            }

            var extensionModelErrorsToDelete = poco.ExtensionModelErrors.Select(x => x.Id).Except(dto.ExtensionModelErrors);
            foreach (var identifier in extensionModelErrorsToDelete)
            {
                var modelError = poco.ExtensionModelErrors.Single(x => x.Id == identifier);
                poco.ExtensionModelErrors.Remove(modelError);
            }

            if (poco.Note != null && poco.Note.Id != dto.Note)
            {
                identifiersOfObjectsToDelete.Add(poco.Note.Id);
                poco.Note = null;
            }

            var objectUnifiersToDelete = poco.ObjectUnifiers.Select(x => x.Id).Except(dto.ObjectUnifiers);
            identifiersOfObjectsToDelete.AddRange(objectUnifiersToDelete);
            foreach (var identifier in objectUnifiersToDelete)
            {
                var pathObjectUnifier = poco.ObjectUnifiers.Single(x => x.Id == identifier);
                poco.ObjectUnifiers.Remove(pathObjectUnifier);
            }

            var projectedPathComponentsToDelete = poco.ProjectedPathComponents.Select(x => x.Id).Except(dto.ProjectedPathComponents);
            foreach (var identifier in projectedPathComponentsToDelete)
            {
                var leadRolePath = poco.ProjectedPathComponents.Single(x => x.Id == identifier);
                poco.ProjectedPathComponents.Remove(leadRolePath);
            }

            var rolesToDelete = poco.Roles.Select(x => x.Id).Except(dto.Roles);
            foreach (var identifier in rolesToDelete)
            {
                var role = poco.Roles.Single(x => x.Id == identifier);
                poco.Roles.Remove(role);
            }

            if (poco.RootObjectType != null && poco.RootObjectType.Id != dto.RootObjectType)
            {
                poco.RootObjectType = null;
            }

            if (poco.RootObjectTypeRequiredError != null && poco.RootObjectTypeRequiredError.Id != dto.RootObjectTypeRequiredError)
            {
                identifiersOfObjectsToDelete.Add(poco.RootObjectTypeRequiredError.Id);
                poco.RootObjectTypeRequiredError = null;
            }

            poco.SplitCombinationOperator = dto.SplitCombinationOperator;

            poco.SplitIsNegated = dto.SplitIsNegated;

            var subPathsToDelete = poco.SubPaths.Select(x => x.Id).Except(dto.SubPaths);
            identifiersOfObjectsToDelete.AddRange(subPathsToDelete);
            foreach (var identifier in subPathsToDelete)
            {
                var roleSubPath = poco.SubPaths.Single(x => x.Id == identifier);
                poco.SubPaths.Remove(roleSubPath);
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="LeadRolePath"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="LeadRolePath"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="LeadRolePath"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.LeadRolePath poco, Kalliope.DTO.LeadRolePath dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
        {
            if (poco == null)
            {
                throw new ArgumentNullException(nameof(poco), $"the {nameof(poco)} may not be null");
            }

            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            if (cache == null)
            {
                throw new ArgumentNullException(nameof(cache), $"the {nameof(cache)} may not be null");
            }

            Lazy<Kalliope.Core.ModelThing> lazyPoco;

            var associatedModelErrorsToAdd = dto.AssociatedModelErrors.Except(poco.AssociatedModelErrors.Select(x => x.Id));
            foreach (var identifier in associatedModelErrorsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var modelError = (ModelError)lazyPoco.Value;
                    poco.AssociatedModelErrors.Add(modelError);
                }
            }

            var calculatedValuesToAdd = dto.CalculatedValues.Except(poco.CalculatedValues.Select(x => x.Id));
            foreach (var identifier in calculatedValuesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var calculatedPathValue = (CalculatedPathValue)lazyPoco.Value;
                    poco.CalculatedValues.Add(calculatedPathValue);
                }
            }

            var extensionModelErrorsToAdd = dto.ExtensionModelErrors.Except(poco.ExtensionModelErrors.Select(x => x.Id));
            foreach (var identifier in extensionModelErrorsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var modelError = (ModelError)lazyPoco.Value;
                    poco.ExtensionModelErrors.Add(modelError);
                }
            }

            if (poco.Note == null && !string.IsNullOrEmpty(dto.Note) && cache.TryGetValue(dto.Note, out lazyPoco))
            {
                poco.Note = (Note)lazyPoco.Value;
            }

            var objectUnifiersToAdd = dto.ObjectUnifiers.Except(poco.ObjectUnifiers.Select(x => x.Id));
            foreach (var identifier in objectUnifiersToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var pathObjectUnifier = (PathObjectUnifier)lazyPoco.Value;
                    poco.ObjectUnifiers.Add(pathObjectUnifier);
                }
            }

            var projectedPathComponentsToAdd = dto.ProjectedPathComponents.Except(poco.ProjectedPathComponents.Select(x => x.Id));
            foreach (var identifier in projectedPathComponentsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var leadRolePath = (LeadRolePath)lazyPoco.Value;
                    poco.ProjectedPathComponents.Add(leadRolePath);
                }
            }

            var rolesToAdd = dto.Roles.Except(poco.Roles.Select(x => x.Id));
            foreach (var identifier in rolesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var role = (Role)lazyPoco.Value;
                    poco.Roles.Add(role);
                }
            }

            if (poco.RootObjectType == null && !string.IsNullOrEmpty(dto.RootObjectType) && cache.TryGetValue(dto.RootObjectType, out lazyPoco))
            {
                poco.RootObjectType = (ObjectType)lazyPoco.Value;
            }

            if (poco.RootObjectTypeRequiredError == null && !string.IsNullOrEmpty(dto.RootObjectTypeRequiredError) && cache.TryGetValue(dto.RootObjectTypeRequiredError, out lazyPoco))
            {
                poco.RootObjectTypeRequiredError = (PathRequiresRootObjectTypeError)lazyPoco.Value;
            }

            var subPathsToAdd = dto.SubPaths.Except(poco.SubPaths.Select(x => x.Id));
            foreach (var identifier in subPathsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var roleSubPath = (RoleSubPath)lazyPoco.Value;
                    poco.SubPaths.Add(roleSubPath);
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
