using LogPlay.Helpers.Interface;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LogPlay.Helpers
{
    public class CallerMemberNameHelper : ICallerMemberNameHelper
    {
        public void ResolveWithoutParameter([CallerMemberName] string memberName = "")
        {
            Trace.WriteLine($"Entering CallerMemberNameHelper.ResolveWithoutParameter called from {memberName}");
            Trace.WriteLine("Exiting CallerMemberNameHelper.ResolveWithoutParameter ");
        }

        public void ResolveWithParameter(string value, [CallerMemberName] string memberName = "")
        {
            Trace.WriteLine($"Entering CallerMemberNameHelper.ResolveWithParameter called from {memberName}");
            Trace.WriteLine($"value {value}");
            Trace.WriteLine("Exiting CallerMemberNameHelper.ResolveWithoutParameter ");
        }
    }
}