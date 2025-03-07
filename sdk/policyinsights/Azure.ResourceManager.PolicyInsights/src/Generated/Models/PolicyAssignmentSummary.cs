// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Policy assignment summary. </summary>
    public partial class PolicyAssignmentSummary
    {
        /// <summary> Initializes a new instance of PolicyAssignmentSummary. </summary>
        internal PolicyAssignmentSummary()
        {
            PolicyDefinitions = new ChangeTrackingList<PolicyDefinitionSummary>();
            PolicyGroups = new ChangeTrackingList<PolicyGroupSummary>();
        }

        /// <summary> Initializes a new instance of PolicyAssignmentSummary. </summary>
        /// <param name="policyAssignmentId"> Policy assignment ID. </param>
        /// <param name="policySetDefinitionId"> Policy set definition ID, if the policy assignment is for a policy set. </param>
        /// <param name="results"> Compliance summary for the policy assignment. </param>
        /// <param name="policyDefinitions"> Policy definitions summary. </param>
        /// <param name="policyGroups"> Policy definition group summary. </param>
        internal PolicyAssignmentSummary(ResourceIdentifier policyAssignmentId, ResourceIdentifier policySetDefinitionId, PolicySummaryResults results, IReadOnlyList<PolicyDefinitionSummary> policyDefinitions, IReadOnlyList<PolicyGroupSummary> policyGroups)
        {
            PolicyAssignmentId = policyAssignmentId;
            PolicySetDefinitionId = policySetDefinitionId;
            Results = results;
            PolicyDefinitions = policyDefinitions;
            PolicyGroups = policyGroups;
        }

        /// <summary> Policy assignment ID. </summary>
        public ResourceIdentifier PolicyAssignmentId { get; }
        /// <summary> Policy set definition ID, if the policy assignment is for a policy set. </summary>
        public ResourceIdentifier PolicySetDefinitionId { get; }
        /// <summary> Compliance summary for the policy assignment. </summary>
        public PolicySummaryResults Results { get; }
        /// <summary> Policy definitions summary. </summary>
        public IReadOnlyList<PolicyDefinitionSummary> PolicyDefinitions { get; }
        /// <summary> Policy definition group summary. </summary>
        public IReadOnlyList<PolicyGroupSummary> PolicyGroups { get; }
    }
}
