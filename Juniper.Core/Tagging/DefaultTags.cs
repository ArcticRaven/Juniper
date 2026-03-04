namespace Juniper.Core.Tagging;

public static class DefaultTags
{
    public static readonly Tag[] All =
    {
        // STATUS / LIFECYCLE
        new() { Name = "Planning", HexColor = "#94A3B8", Category = "Status" },
        new() { Name = "Research", HexColor = "#6366F1", Category = "Status" },
        new() { Name = "Active", HexColor = "#22C55E", Category = "Status" },
        new() { Name = "Paused", HexColor = "#F59E0B", Category = "Status" },
        new() { Name = "Blocked", HexColor = "#EF4444", Category = "Status" },
        new() { Name = "Maintenance", HexColor = "#0EA5E9", Category = "Status" },
        new() { Name = "Archived", HexColor = "#64748B", Category = "Status" },
        new() { Name = "Experimental", HexColor = "#A855F7", Category = "Status" },
        new() { Name = "Prototype", HexColor = "#8B5CF6", Category = "Status" },

        // PRIORITY
        new() { Name = "Critical", HexColor = "#DC2626", Category = "Priority" },
        new() { Name = "HighPriority", HexColor = "#F97316", Category = "Priority" },
        new() { Name = "MediumPriority", HexColor = "#EAB308", Category = "Priority" },
        new() { Name = "LowPriority", HexColor = "#3B82F6", Category = "Priority" },
        new() { Name = "Backlog", HexColor = "#94A3B8", Category = "Priority" },

        // WORK TYPES
        new() { Name = "Development", HexColor = "#2563EB", Category = "Work" },
        new() { Name = "Engineering", HexColor = "#1D4ED8", Category = "Work" },
        new() { Name = "Infrastructure", HexColor = "#475569", Category = "Work" },
        new() { Name = "Automation", HexColor = "#0EA5E9", Category = "Work" },
        new() { Name = "Optimization", HexColor = "#22C55E", Category = "Work" },
        new() { Name = "Refactor", HexColor = "#8B5CF6", Category = "Work" },
        new() { Name = "Bugfix", HexColor = "#EF4444", Category = "Work" },
        new() { Name = "Security", HexColor = "#DC2626", Category = "Work" },
        new() { Name = "Documentation", HexColor = "#10B981", Category = "Work" },
        new() { Name = "Testing", HexColor = "#F59E0B", Category = "Work" },
        new() { Name = "Deployment", HexColor = "#06B6D4", Category = "Work" },

        // CREATIVE
        new() { Name = "Writing", HexColor = "#F472B6", Category = "Creative" },
        new() { Name = "Story", HexColor = "#EC4899", Category = "Creative" },
        new() { Name = "Worldbuilding", HexColor = "#C084FC", Category = "Creative" },
        new() { Name = "Narrative", HexColor = "#F472B6", Category = "Creative" },
        new() { Name = "Design", HexColor = "#FB7185", Category = "Creative" },
        new() { Name = "ConceptArt", HexColor = "#F43F5E", Category = "Creative" },
        new() { Name = "Modeling", HexColor = "#F97316", Category = "Creative" },
        new() { Name = "Animation", HexColor = "#F59E0B", Category = "Creative" },
        new() { Name = "Audio", HexColor = "#EAB308", Category = "Creative" },
        new() { Name = "Music", HexColor = "#84CC16", Category = "Creative" },
        new() { Name = "UIUX", HexColor = "#38BDF8", Category = "Creative" },

        // GAME DEV
        new() { Name = "Gameplay", HexColor = "#22C55E", Category = "GameDev" },
        new() { Name = "Mechanics", HexColor = "#16A34A", Category = "GameDev" },
        new() { Name = "AI", HexColor = "#A855F7", Category = "GameDev" },
        new() { Name = "Networking", HexColor = "#0EA5E9", Category = "GameDev" },
        new() { Name = "Physics", HexColor = "#06B6D4", Category = "GameDev" },
        new() { Name = "Rendering", HexColor = "#9333EA", Category = "GameDev" },
        new() { Name = "Terrain", HexColor = "#65A30D", Category = "GameDev" },
        new() { Name = "ProceduralGeneration", HexColor = "#7C3AED", Category = "GameDev" },
        new() { Name = "Tooling", HexColor = "#64748B", Category = "GameDev" },
        new() { Name = "EditorTools", HexColor = "#475569", Category = "GameDev" },

        // SOFTWARE
        new() { Name = "Backend", HexColor = "#2563EB", Category = "Software" },
        new() { Name = "Frontend", HexColor = "#38BDF8", Category = "Software" },
        new() { Name = "API", HexColor = "#6366F1", Category = "Software" },
        new() { Name = "CLI", HexColor = "#64748B", Category = "Software" },
        new() { Name = "DesktopApp", HexColor = "#0EA5E9", Category = "Software" },
        new() { Name = "MobileApp", HexColor = "#22C55E", Category = "Software" },
        new() { Name = "WebApp", HexColor = "#38BDF8", Category = "Software" },
        new() { Name = "Library", HexColor = "#9333EA", Category = "Software" },
        new() { Name = "Framework", HexColor = "#7C3AED", Category = "Software" },
        new() { Name = "Plugin", HexColor = "#06B6D4", Category = "Software" },
        new() { Name = "UnrealEngine", HexColor = "#0E1128", Category = "Software" },
        new() { Name = "Godot", HexColor = "#478CBF", Category = "Software" },
        new() { Name = "SubstancePainter", HexColor = "#FF6F00", Category = "Software" },
        new() { Name = "SubstanceDesigner", HexColor = "#E65100", Category = "Software" },
        new() { Name = "NomadSculpt", HexColor = "#6B7280", Category = "Software" },
        new() { Name = "Affinity", HexColor = "#7C3AED", Category = "Software" },
        new() { Name = "Armature", HexColor = "#14B8A6", Category = "Software" },
        new() { Name = "Blender", HexColor = "#F97316", Category = "Software" },
        new() { Name = "Photoshop", HexColor = "#0EA5E9", Category = "Software" },
        new() { Name = "VSCode", HexColor = "#007ACC", Category = "Software" },
        new() { Name = "JetBrains", HexColor = "#FF007F", Category = "Software" },

        // INFRASTRUCTURE
        new() { Name = "Server", HexColor = "#475569", Category = "Infrastructure" },
        new() { Name = "Database", HexColor = "#0EA5E9", Category = "Infrastructure" },
        new() { Name = "Cloud", HexColor = "#38BDF8", Category = "Infrastructure" },
        new() { Name = "DevOps", HexColor = "#9333EA", Category = "Infrastructure" },
        new() { Name = "Monitoring", HexColor = "#F59E0B", Category = "Infrastructure" },
        new() { Name = "Logging", HexColor = "#EAB308", Category = "Infrastructure" },
        new() { Name = "Performance", HexColor = "#22C55E", Category = "Infrastructure" },
        new() { Name = "Scalability", HexColor = "#16A34A", Category = "Infrastructure" },
        new() { Name = "NetworkingInfra", HexColor = "#0EA5E9", Category = "Infrastructure" },

        // DATA / AI
        new() { Name = "DataPipeline", HexColor = "#6366F1", Category = "DataAI" },
        new() { Name = "DataAnalysis", HexColor = "#4F46E5", Category = "DataAI" },
        new() { Name = "MachineLearning", HexColor = "#7C3AED", Category = "DataAI" },
        new() { Name = "AIResearch", HexColor = "#9333EA", Category = "DataAI" },
        new() { Name = "AutomationAI", HexColor = "#A855F7", Category = "DataAI" },
        new() { Name = "PredictiveSystems", HexColor = "#C084FC", Category = "DataAI" },

        // COLLABORATION
        new() { Name = "Team", HexColor = "#0EA5E9", Category = "Collaboration" },
        new() { Name = "Client", HexColor = "#F97316", Category = "Collaboration" },
        new() { Name = "Internal", HexColor = "#64748B", Category = "Collaboration" },
        new() { Name = "OpenSource", HexColor = "#22C55E", Category = "Collaboration" },
        new() { Name = "Personal", HexColor = "#14B8A6", Category = "Collaboration" },
        new() { Name = "LaggyGames", HexColor = "#6366F1", Category = "Collaboration" },
        new() { Name = "External", HexColor = "#64748B", Category = "Collaboration" },
        new() { Name = "Partner", HexColor = "#0EA5E9", Category = "Collaboration" },
        new() { Name = "Contractor", HexColor = "#F97316", Category = "Collaboration" },

        // DOMAINS
        new() { Name = "Education", HexColor = "#6366F1", Category = "Domain" },
        new() { Name = "Finance", HexColor = "#16A34A", Category = "Domain" },
        new() { Name = "Health", HexColor = "#F43F5E", Category = "Domain" },
        new() { Name = "Productivity", HexColor = "#22C55E", Category = "Domain" },
        new() { Name = "KnowledgeBase", HexColor = "#0EA5E9", Category = "Domain" },
        new() { Name = "Communication", HexColor = "#38BDF8", Category = "Domain" },
        new() { Name = "Social", HexColor = "#F472B6", Category = "Domain" },

        // CREATIVE PRODUCTION
        new() { Name = "Video", HexColor = "#EF4444", Category = "Production" },
        new() { Name = "Film", HexColor = "#DC2626", Category = "Production" },
        new() { Name = "Photography", HexColor = "#F97316", Category = "Production" },
        new() { Name = "Illustration", HexColor = "#F43F5E", Category = "Production" },
        new() { Name = "Publishing", HexColor = "#9333EA", Category = "Production" },

        // HARDWARE
        new() { Name = "Hardware", HexColor = "#64748B", Category = "Hardware" },
        new() { Name = "Electronics", HexColor = "#0EA5E9", Category = "Hardware" },
        new() { Name = "Robotics", HexColor = "#A855F7", Category = "Hardware" },
        new() { Name = "Embedded", HexColor = "#6366F1", Category = "Hardware" },
        new() { Name = "IoT", HexColor = "#22C55E", Category = "Hardware" },
        
        new() { Name = "Work", HexColor = "#2563EB", Category = "Calendar" },
        new() { Name = "Personal", HexColor = "#22C55E", Category = "Calendar" },
        new() { Name = "Health", HexColor = "#EF4444", Category = "Calendar" },
        new() { Name = "Family", HexColor = "#F59E0B", Category = "Calendar" },
        new() { Name = "Home", HexColor = "#84CC16", Category = "Calendar" },
        new() { Name = "Finance", HexColor = "#16A34A", Category = "Calendar" },
        new() { Name = "Leisure", HexColor = "#14B8A6", Category = "Calendar" },
        new() { Name = "Social", HexColor = "#38BDF8", Category = "Calendar" },
        new() { Name = "Education", HexColor = "#6366F1", Category = "Calendar" },
        new() { Name = "Travel", HexColor = "#F97316", Category = "Calendar" },
        new() { Name = "Fitness", HexColor = "#DC2626", Category = "Calendar" },
        new() { Name = "Holiday", HexColor = "#EC4899", Category = "Calendar" },
        new() { Name = "Spiritual", HexColor = "#9333EA", Category = "Calendar" },
        new() { Name = "Meeting", HexColor = "#2563EB", Category = "Calendar" },
        new() { Name = "Reminder", HexColor = "#F59E0B", Category = "Calendar" },
        new() { Name = "Deadline", HexColor = "#EF4444", Category = "Calendar" },
        new() { Name = "Milestone", HexColor = "#9333EA", Category = "Calendar" },
        new() { Name = "Appointment", HexColor = "#0EA5E9", Category = "Calendar" },
        new() { Name = "TravelEvent", HexColor = "#F97316", Category = "Calendar" },

        // MISC
        new() { Name = "Hobby", HexColor = "#F472B6", Category = "Misc" },
        new() { Name = "Learning", HexColor = "#38BDF8", Category = "Misc" },
        new() { Name = "Experiment", HexColor = "#A855F7", Category = "Misc" },
        new() { Name = "Exploration", HexColor = "#C084FC", Category = "Misc" }
    };
}