﻿using Newtonsoft.Json;

namespace AdfToArm.Core.Models.LinkedServices.LinkedServiceTypeProperties
{
    [JsonObject]
    public class AzureSqlDatabaseTypeProperties : ILinkedServiceProperties
    {
        [ArmParameter]
        [JsonProperty("connectionString", Required = Required.Always)]
        public string ConnectionString { get; set; }
    }
}
