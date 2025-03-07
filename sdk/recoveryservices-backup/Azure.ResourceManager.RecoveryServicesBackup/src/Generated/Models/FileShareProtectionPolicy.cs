// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> AzureStorage backup policy. </summary>
    public partial class FileShareProtectionPolicy : BackupGenericProtectionPolicy
    {
        /// <summary> Initializes a new instance of FileShareProtectionPolicy. </summary>
        public FileShareProtectionPolicy()
        {
            BackupManagementType = "AzureStorage";
        }

        /// <summary> Initializes a new instance of FileShareProtectionPolicy. </summary>
        /// <param name="protectedItemsCount"> Number of items associated with this policy. </param>
        /// <param name="backupManagementType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuard Operation Requests. </param>
        /// <param name="workLoadType"> Type of workload for the backup management. </param>
        /// <param name="schedulePolicy">
        /// Backup schedule specified as part of backup policy.
        /// Please note <see cref="BackupSchedulePolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LogSchedulePolicy"/>, <see cref="LongTermSchedulePolicy"/>, <see cref="SimpleSchedulePolicy"/> and <see cref="SimpleSchedulePolicyV2"/>.
        /// </param>
        /// <param name="retentionPolicy">
        /// Retention policy with the details on backup copy retention ranges.
        /// Please note <see cref="BackupRetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LongTermRetentionPolicy"/> and <see cref="SimpleRetentionPolicy"/>.
        /// </param>
        /// <param name="timeZone"> TimeZone optional input as string. For example: TimeZone = &quot;Pacific Standard Time&quot;. </param>
        internal FileShareProtectionPolicy(int? protectedItemsCount, string backupManagementType, IList<string> resourceGuardOperationRequests, BackupWorkloadType? workLoadType, BackupSchedulePolicy schedulePolicy, BackupRetentionPolicy retentionPolicy, string timeZone) : base(protectedItemsCount, backupManagementType, resourceGuardOperationRequests)
        {
            WorkLoadType = workLoadType;
            SchedulePolicy = schedulePolicy;
            RetentionPolicy = retentionPolicy;
            TimeZone = timeZone;
            BackupManagementType = backupManagementType ?? "AzureStorage";
        }

        /// <summary> Type of workload for the backup management. </summary>
        public BackupWorkloadType? WorkLoadType { get; set; }
        /// <summary>
        /// Backup schedule specified as part of backup policy.
        /// Please note <see cref="BackupSchedulePolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LogSchedulePolicy"/>, <see cref="LongTermSchedulePolicy"/>, <see cref="SimpleSchedulePolicy"/> and <see cref="SimpleSchedulePolicyV2"/>.
        /// </summary>
        public BackupSchedulePolicy SchedulePolicy { get; set; }
        /// <summary>
        /// Retention policy with the details on backup copy retention ranges.
        /// Please note <see cref="BackupRetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LongTermRetentionPolicy"/> and <see cref="SimpleRetentionPolicy"/>.
        /// </summary>
        public BackupRetentionPolicy RetentionPolicy { get; set; }
        /// <summary> TimeZone optional input as string. For example: TimeZone = &quot;Pacific Standard Time&quot;. </summary>
        public string TimeZone { get; set; }
    }
}
