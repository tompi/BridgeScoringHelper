using System;
using Microsoft.AppCenter.Analytics;

namespace BridgeScoringHelper
{
    public static class Logger
    {
        public static void Info(string message)
        {
            Analytics.TrackEvent(message);
        }
    }
}
