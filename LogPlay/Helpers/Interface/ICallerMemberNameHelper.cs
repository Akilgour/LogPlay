using System.Runtime.CompilerServices;

namespace LogPlay.Helpers.Interface
{
    public interface ICallerMemberNameHelper
    {
        void ResolveWithParameter(string value, [CallerMemberName] string memberName = "");

        void ResolveWithoutParameter([CallerMemberName] string memberName = "");
    }
}