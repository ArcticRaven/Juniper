namespace Juniper.Core.Tagging;

public static class DefaultTags
{
    public static readonly Tag[] All =
    {
        // STATUS / LIFECYCLE
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-000000000001")), Name = "Planning", HexColor = "#94A3B8", Category = "Status" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-000000000002")), Name = "Research", HexColor = "#6366F1", Category = "Status" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-000000000003")), Name = "Active", HexColor = "#22C55E", Category = "Status" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-000000000004")), Name = "Paused", HexColor = "#F59E0B", Category = "Status" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-000000000005")), Name = "Blocked", HexColor = "#EF4444", Category = "Status" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-000000000006")), Name = "Maintenance", HexColor = "#0EA5E9", Category = "Status" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-000000000007")), Name = "Archived", HexColor = "#64748B", Category = "Status" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-000000000008")), Name = "Experimental", HexColor = "#A855F7", Category = "Status" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-000000000009")), Name = "Prototype", HexColor = "#8B5CF6", Category = "Status" },

        // PRIORITY
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-100000000001")), Name = "Critical", HexColor = "#DC2626", Category = "Priority" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-100000000002")), Name = "HighPriority", HexColor = "#F97316", Category = "Priority" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-100000000003")), Name = "MediumPriority", HexColor = "#EAB308", Category = "Priority" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-100000000004")), Name = "LowPriority", HexColor = "#3B82F6", Category = "Priority" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-100000000005")), Name = "Backlog", HexColor = "#94A3B8", Category = "Priority" },

        // WORK TYPES
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-200000000001")), Name = "Development", HexColor = "#2563EB", Category = "Work" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-200000000002")), Name = "Engineering", HexColor = "#1D4ED8", Category = "Work" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-200000000003")), Name = "Infrastructure", HexColor = "#475569", Category = "Work" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-200000000004")), Name = "Automation", HexColor = "#0EA5E9", Category = "Work" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-200000000005")), Name = "Optimization", HexColor = "#22C55E", Category = "Work" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-200000000006")), Name = "Refactor", HexColor = "#8B5CF6", Category = "Work" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-200000000007")), Name = "Bugfix", HexColor = "#EF4444", Category = "Work" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-200000000008")), Name = "Security", HexColor = "#DC2626", Category = "Work" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-200000000009")), Name = "Documentation", HexColor = "#10B981", Category = "Work" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-200000000010")), Name = "Testing", HexColor = "#F59E0B", Category = "Work" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-200000000011")), Name = "Deployment", HexColor = "#06B6D4", Category = "Work" },

        // CREATIVE
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-300000000001")), Name = "Writing", HexColor = "#F472B6", Category = "Creative" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-300000000002")), Name = "Story", HexColor = "#EC4899", Category = "Creative" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-300000000003")), Name = "Worldbuilding", HexColor = "#C084FC", Category = "Creative" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-300000000004")), Name = "Narrative", HexColor = "#F472B6", Category = "Creative" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-300000000005")), Name = "Design", HexColor = "#FB7185", Category = "Creative" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-300000000006")), Name = "ConceptArt", HexColor = "#F43F5E", Category = "Creative" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-300000000007")), Name = "Modeling", HexColor = "#F97316", Category = "Creative" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-300000000008")), Name = "Animation", HexColor = "#F59E0B", Category = "Creative" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-300000000009")), Name = "Audio", HexColor = "#EAB308", Category = "Creative" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-300000000010")), Name = "Music", HexColor = "#84CC16", Category = "Creative" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-300000000011")), Name = "UIUX", HexColor = "#38BDF8", Category = "Creative" },

        // GAME DEV
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-400000000001")), Name = "Gameplay", HexColor = "#22C55E", Category = "GameDev" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-400000000002")), Name = "Mechanics", HexColor = "#16A34A", Category = "GameDev" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-400000000003")), Name = "AI", HexColor = "#A855F7", Category = "GameDev" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-400000000004")), Name = "Networking", HexColor = "#0EA5E9", Category = "GameDev" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-400000000005")), Name = "Physics", HexColor = "#06B6D4", Category = "GameDev" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-400000000006")), Name = "Rendering", HexColor = "#9333EA", Category = "GameDev" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-400000000007")), Name = "Terrain", HexColor = "#65A30D", Category = "GameDev" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-400000000008")), Name = "ProceduralGeneration", HexColor = "#7C3AED", Category = "GameDev" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-400000000009")), Name = "Tooling", HexColor = "#64748B", Category = "GameDev" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-400000000010")), Name = "EditorTools", HexColor = "#475569", Category = "GameDev" },

        // SOFTWARE
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000001")), Name = "Backend", HexColor = "#2563EB", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000002")), Name = "Frontend", HexColor = "#38BDF8", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000003")), Name = "API", HexColor = "#6366F1", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000004")), Name = "CLI", HexColor = "#64748B", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000005")), Name = "DesktopApp", HexColor = "#0EA5E9", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000006")), Name = "MobileApp", HexColor = "#22C55E", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000007")), Name = "WebApp", HexColor = "#38BDF8", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000008")), Name = "Library", HexColor = "#9333EA", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000009")), Name = "Framework", HexColor = "#7C3AED", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000010")), Name = "Plugin", HexColor = "#06B6D4", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000011")), Name = "UnrealEngine", HexColor = "#0E1128", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000012")), Name = "Godot", HexColor = "#478CBF", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000013")), Name = "SubstancePainter", HexColor = "#FF6F00", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000014")), Name = "SubstanceDesigner", HexColor = "#E65100", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000015")), Name = "NomadSculpt", HexColor = "#6B7280", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000016")), Name = "Affinity", HexColor = "#7C3AED", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000017")), Name = "Armature", HexColor = "#14B8A6", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000018")), Name = "Blender", HexColor = "#F97316", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000019")), Name = "Photoshop", HexColor = "#0EA5E9", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000020")), Name = "VSCode", HexColor = "#007ACC", Category = "Software" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-500000000021")), Name = "JetBrains", HexColor = "#FF007F", Category = "Software" },

        // INFRASTRUCTURE
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-600000000001")), Name = "Server", HexColor = "#475569", Category = "Infrastructure" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-600000000002")), Name = "Database", HexColor = "#0EA5E9", Category = "Infrastructure" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-600000000003")), Name = "Cloud", HexColor = "#38BDF8", Category = "Infrastructure" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-600000000004")), Name = "DevOps", HexColor = "#9333EA", Category = "Infrastructure" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-600000000005")), Name = "Monitoring", HexColor = "#F59E0B", Category = "Infrastructure" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-600000000006")), Name = "Logging", HexColor = "#EAB308", Category = "Infrastructure" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-600000000007")), Name = "Performance", HexColor = "#22C55E", Category = "Infrastructure" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-600000000008")), Name = "Scalability", HexColor = "#16A34A", Category = "Infrastructure" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-600000000009")), Name = "NetworkingInfra", HexColor = "#0EA5E9", Category = "Infrastructure" },

        // DATA / AI
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-700000000001")), Name = "DataPipeline", HexColor = "#6366F1", Category = "DataAI" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-700000000002")), Name = "DataAnalysis", HexColor = "#4F46E5", Category = "DataAI" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-700000000003")), Name = "MachineLearning", HexColor = "#7C3AED", Category = "DataAI" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-700000000004")), Name = "AIResearch", HexColor = "#9333EA", Category = "DataAI" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-700000000005")), Name = "AutomationAI", HexColor = "#A855F7", Category = "DataAI" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-700000000006")), Name = "PredictiveSystems", HexColor = "#C084FC", Category = "DataAI" },

        // COLLABORATION
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-800000000001")), Name = "Team", HexColor = "#0EA5E9", Category = "Collaboration" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-800000000002")), Name = "Client", HexColor = "#F97316", Category = "Collaboration" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-800000000003")), Name = "Internal", HexColor = "#64748B", Category = "Collaboration" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-800000000004")), Name = "OpenSource", HexColor = "#22C55E", Category = "Collaboration" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-800000000005")), Name = "Personal", HexColor = "#14B8A6", Category = "Collaboration" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-800000000006")), Name = "LaggyGames", HexColor = "#6366F1", Category = "Collaboration" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-800000000007")), Name = "External", HexColor = "#64748B", Category = "Collaboration" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-800000000008")), Name = "Partner", HexColor = "#0EA5E9", Category = "Collaboration" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-800000000009")), Name = "Contractor", HexColor = "#F97316", Category = "Collaboration" },

        // DOMAIN
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-900000000001")), Name = "Education", HexColor = "#6366F1", Category = "Domain" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-900000000002")), Name = "Finance", HexColor = "#16A34A", Category = "Domain" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-900000000003")), Name = "Health", HexColor = "#F43F5E", Category = "Domain" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-900000000004")), Name = "Productivity", HexColor = "#22C55E", Category = "Domain" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-900000000005")), Name = "KnowledgeBase", HexColor = "#0EA5E9", Category = "Domain" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-900000000006")), Name = "Communication", HexColor = "#38BDF8", Category = "Domain" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-900000000007")), Name = "Social", HexColor = "#F472B6", Category = "Domain" },

        // PRODUCTION
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-A00000000001")), Name = "Video", HexColor = "#EF4444", Category = "Production" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-A00000000002")), Name = "Film", HexColor = "#DC2626", Category = "Production" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-A00000000003")), Name = "Photography", HexColor = "#F97316", Category = "Production" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-A00000000004")), Name = "Illustration", HexColor = "#F43F5E", Category = "Production" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-A00000000005")), Name = "Publishing", HexColor = "#9333EA", Category = "Production" },

        // HARDWARE
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-B00000000001")), Name = "Hardware", HexColor = "#64748B", Category = "Hardware" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-B00000000002")), Name = "Electronics", HexColor = "#0EA5E9", Category = "Hardware" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-B00000000003")), Name = "Robotics", HexColor = "#A855F7", Category = "Hardware" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-B00000000004")), Name = "Embedded", HexColor = "#6366F1", Category = "Hardware" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-B00000000005")), Name = "IoT", HexColor = "#22C55E", Category = "Hardware" },

        // CALENDAR
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000001")), Name = "Work", HexColor = "#2563EB", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000002")), Name = "Personal", HexColor = "#22C55E", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000003")), Name = "Health", HexColor = "#EF4444", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000004")), Name = "Family", HexColor = "#F59E0B", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000005")), Name = "Home", HexColor = "#84CC16", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000006")), Name = "Finance", HexColor = "#16A34A", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000007")), Name = "Leisure", HexColor = "#14B8A6", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000008")), Name = "Social", HexColor = "#38BDF8", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000009")), Name = "Education", HexColor = "#6366F1", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000010")), Name = "Travel", HexColor = "#F97316", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000011")), Name = "Fitness", HexColor = "#DC2626", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000012")), Name = "Holiday", HexColor = "#EC4899", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000013")), Name = "Spiritual", HexColor = "#9333EA", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000014")), Name = "Meeting", HexColor = "#2563EB", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000015")), Name = "Reminder", HexColor = "#F59E0B", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000016")), Name = "Deadline", HexColor = "#EF4444", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000017")), Name = "Milestone", HexColor = "#9333EA", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000018")), Name = "Appointment", HexColor = "#0EA5E9", Category = "Calendar" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-C00000000019")), Name = "TravelEvent", HexColor = "#F97316", Category = "Calendar" },

        // MISC
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-D00000000001")), Name = "Hobby", HexColor = "#F472B6", Category = "Misc" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-D00000000002")), Name = "Learning", HexColor = "#38BDF8", Category = "Misc" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-D00000000003")), Name = "Experiment", HexColor = "#A855F7", Category = "Misc" },
        new() { Id = new TagId(new Guid("00000000-0000-0000-0000-D00000000004")), Name = "Exploration", HexColor = "#C084FC", Category = "Misc" }
    };
}