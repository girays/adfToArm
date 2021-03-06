﻿using Newtonsoft.Json;
using System.Collections.Generic;
using AdfToArm.Core.Models.Common;

namespace AdfToArm.Core.Models.Pipelines.ActivityProperties
{
    [JsonObject]
    public class SqlServerStoredProcedureTypeProperties : IActivityTypeProperties
    {
        /// <summary>
        /// Specify the name of the stored procedure in the Azure SQL database or Azure SQL Data Warehouse that is represented by the linked service that the output table uses.
        /// </summary>
        [ArmParameter]
        [JsonProperty("storedProcedureName", Required = Required.Always)]
        public string StoredProcedureName { get; set; }

        /// <summary>
        /// Specify values for stored procedure parameters. 
        /// If you need to pass null for a parameter, use the syntax: "param1": null (all lower case)
        /// </summary>
        [ArmParameter("object")]
        [JsonConverter(typeof(PairConverter))]
        [JsonProperty("storedProcedureParameters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeyValuePair<string, string>[] StoredProcedureParameters { get; set; }
    }
}
