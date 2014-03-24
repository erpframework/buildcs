﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildCs.FileSystem;

namespace BuildCs.NUnit
{
    public static class Extensions
    {
        public static NUnitHelper NUnitHelper(this Build build)
        {
            return build.GetService<NUnitHelper>();
        }

        public static void NUnit(this Build build, BuildItem assembly, Action<NUnitArgs> config = null)
        {
            NUnit(build, new[] { assembly }, config);
        }

        public static void NUnit(this Build build, IEnumerable<BuildItem> assemblies, Action<NUnitArgs> config = null)
        {
            NUnitHelper(build).Test(assemblies, config);
        }
    }
}