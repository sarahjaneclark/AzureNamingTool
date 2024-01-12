﻿using AzureNamingTool.Models;
using AzureNamingTool.Components.Pages;
using System.Collections.Generic;

namespace AzureNamingTool.Models
{
    public class ConfigurationData
    {
        public List<ResourceComponent> ResourceComponents { get; set; } = [];
        public List<ResourceDelimiter> ResourceDelimiters { get; set; } = [];
        public List<ResourceEnvironment> ResourceEnvironments { get; set; } = [];
        public List<ResourceLocation> ResourceLocations { get; set; } = [];
        public List<ResourceOrg> ResourceOrgs { get; set; } = [];
        public List<ResourceProjAppSvc> ResourceProjAppSvcs { get; set; } = [];
        public List<ResourceType> ResourceTypes { get; set; } = [];
        public List<ResourceUnitDept> ResourceUnitDepts { get; set; } = [];
        public List<ResourceFunction> ResourceFunctions { get; set; } = [];
        public List<CustomComponent> CustomComponents { get; set; } = [];
        public List<GeneratedName> GeneratedNames { get; set; } = [];
        public List<AdminLogMessage>? AdminLogs { get; set; } = [];
        public List<AdminUser> AdminUsers { get; set; } = [];

        public string? SALTKey { get; set; }
        public string? AdminPassword { get; set; }
        public string? APIKey { get; set; }
        public string? ReadOnlyAPIKey { get; set; }
        public string? DismissedAlerts { get; set; }
        public string? DuplicateNamesAllowed { get; set; } = "False";
        public string? GenerationWebhook { get; set; }
        public string? ConnectivityCheckEnabled { get; set; } = "True";
        public string? IdentityHeaderName { get; set; }
        public string? ResourceTypeEditingAllowed { get; set; } = "False";
        public string? AutoIncrementResourceInstance { get; set; } = "False";
        public string? InstructionsEnabled { get; set; } = "True";
        public string? GeneratedNamesLogEnabled { get; set; } = "True";
        public string? LatestNewsEnabled { get; set; } = "False";
    }
}
