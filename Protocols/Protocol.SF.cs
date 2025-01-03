﻿using Protocols.Interfaces;

namespace Protocols
{
    public class ConvertTicksToDateTimeResponse : IAPIResponse
    {
        public string DateTime { get; set; }
        public bool Ok { get; set; }
    }
    public class ConvertDateTimeToTicksResponse : IAPIResponse
    {
        public long Ticks { get; set; }
        public bool Ok { get; set; }
    }

    public class GetMacroLatestVersionResponse : IAPIResponse
    {
        public VersionNote VersionNote { get; set; }
        public bool Ok { get; set; }
    }
}
