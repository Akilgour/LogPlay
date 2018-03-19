using LogPlay.Logging.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogPlay.Helpers
{
    public static class ExceptionHelper
    {
        internal static string HandledException(IXeretecLogging logging, int personId, string personName)
        {
            try
            {
                logging.Entering();
                throw new Exception("Boom!");
                var result = "I should never get here";
                logging.Exiting(result);
                return result;
            }
            catch (Exception ex)
            {
                logging.Error($"personId {personId} personName{personName}", ex);
                throw ex;
            }
        }
    }
}