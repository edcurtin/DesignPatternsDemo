using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Creational._2._Factory_Method
{
    public class CloudLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new CloudLogger();  // Cloud-based logger
        }

        public IFileWriter CreateFileWriter()
        {
            return new CloudFileWriter();  // Cloud file writer
        }
    }
}
