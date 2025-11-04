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
        // Отримує "логер" для поточного класу (де використовується)
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        // Логування інформаційних повідомлень (Info)
        public void Info(string message) => logger.Info(message);

        // Логування попереджень (Warn)
        public void Warn(string message) => logger.Warn(message);

        // Логування помилок (Error) з передачею Exception
        public void Error(Exception ex, string message) => logger.Error(ex, message);

        // Логування критичних помилок (Fatal)
        public void Fatal(string message) => logger.Fatal(message);
    }
}
