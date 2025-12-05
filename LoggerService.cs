using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class LoggerService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void Info(string message) => logger.Info(message);

        public void Warn(string message) => logger.Warn(message);

        public void Error(Exception ex, string message) => logger.Error(ex, message);

        public void Fatal(string message) => logger.Fatal(message);
    }
}
