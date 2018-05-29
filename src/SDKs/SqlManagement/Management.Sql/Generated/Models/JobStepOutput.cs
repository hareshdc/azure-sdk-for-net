// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The output configuration of a job step.
    /// </summary>
    public partial class JobStepOutput
    {
        /// <summary>
        /// Initializes a new instance of the JobStepOutput class.
        /// </summary>
        public JobStepOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobStepOutput class.
        /// </summary>
        /// <param name="serverName">The output destination server
        /// name.</param>
        /// <param name="databaseName">The output destination database.</param>
        /// <param name="tableName">The output destination table.</param>
        /// <param name="credential">The resource ID of the credential to use
        /// to connect to the output destination.</param>
        /// <param name="type">The output destination type. Possible values
        /// include: 'SqlDatabase'</param>
        /// <param name="subscriptionId">The output destination subscription
        /// id.</param>
        /// <param name="resourceGroupName">The output destination resource
        /// group.</param>
        /// <param name="schemaName">The output destination schema.</param>
        public JobStepOutput(string serverName, string databaseName, string tableName, string credential, string type = default(string), System.Guid? subscriptionId = default(System.Guid?), string resourceGroupName = default(string), string schemaName = default(string))
        {
            Type = type;
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            ServerName = serverName;
            DatabaseName = databaseName;
            SchemaName = schemaName;
            TableName = tableName;
            Credential = credential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the output destination type. Possible values include:
        /// 'SqlDatabase'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the output destination subscription id.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public System.Guid? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the output destination resource group.
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroupName")]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the output destination server name.
        /// </summary>
        [JsonProperty(PropertyName = "serverName")]
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or sets the output destination database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the output destination schema.
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets the output destination table.
        /// </summary>
        [JsonProperty(PropertyName = "tableName")]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the credential to use to connect to
        /// the output destination.
        /// </summary>
        [JsonProperty(PropertyName = "credential")]
        public string Credential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ServerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServerName");
            }
            if (DatabaseName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DatabaseName");
            }
            if (TableName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TableName");
            }
            if (Credential == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Credential");
            }
        }
    }
}
