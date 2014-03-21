﻿using BuildCs.Services;

namespace BuildCs
{
    public static partial class Extensions
    {
        public static BuildCommandLine CommandLine(this Build build)
        {
            return build.GetService<BuildCommandLine>();
        }

        public static string GetParameter(this Build build, string name)
        {
            return build.CommandLine().GetParameter(name);
        }

        public static string GetParameterOrDefault(this Build build, string name, string defaultValue)
        {
            if (build.CommandLine().HasParameter(name))
                return build.GetParameter(name);

            return defaultValue;
        }

        public static bool HasParameter(this Build build, string name)
        {
            return build.CommandLine().HasParameter(name);
        }
    }
}