﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildCs.Services.Targetting
{
    public enum BuildTargetStatus
    {
        NotRun,
        Skipped,
        Failed,
        Success
    }
}