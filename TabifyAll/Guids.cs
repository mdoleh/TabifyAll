// Guids.cs
// MUST match guids.h
using System;

namespace Doleh.TabifyAll
{
    static class GuidList
    {
        public const string guidTabifyAllPkgString = "fae601ee-b1c8-4c7b-8eaa-20eca0304654";
        public const string guidTabifyAllCmdSetString = "dd625ce3-f08a-4716-b18e-f77dfc2e16c7";

        public static readonly Guid guidTabifyAllCmdSet = new Guid(guidTabifyAllCmdSetString);
    };
}