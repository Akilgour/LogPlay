using LogPlay.Logging.Interface;

namespace LogPlay.Helpers
{
    public class InstanceLogHelper
    {
        private IXeretecLogging logging;

        public InstanceLogHelper(IXeretecLogging _logging)
        {
            logging = _logging;
        }

        public string Resolve(string orderId)
        {
            logging.Entering();

            logging.Fatal("Highest level: important stuff down");
            logging.Error("For example application crashes / exceptions.");
            logging.Warn("Incorrect behavior but the application can continue");
            logging.Info("Normal behavior like mail sent, user updated profile etc.");
            logging.Debug("Executed queries, user authenticated, session expired");
            logging.Trace("Begin method X, end method X etc");

            return "InstanceLogHelper Resolve";
        }
    }
}