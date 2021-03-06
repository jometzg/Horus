﻿using Horus.Functions.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Horus.Functions.Engines
{
    public interface IProcessingEngine : IEngine
    {
        Document Process(DocumentProcessingJob job, ILogger log, string snip);
    }
}
