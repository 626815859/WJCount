using System;
using Abp.Dependency;

namespace Bestwise.WJCourt.Timing
{
    public class AppTimes : ISingletonDependency
    {
        /// <summary>
        /// Gets the startup time of the application.
        /// </summary>
        public DateTime StartupTime { get; set; }
    }
}
