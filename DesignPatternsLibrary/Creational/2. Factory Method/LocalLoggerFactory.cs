using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Creational._2._Factory_Method
{
    public class LocalLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new FileLogger();  // Local file logger
        }

        public IFileWriter CreateFileWriter()
        {
            return new LocalFileWriter();  // Local file writer
        }
    }
}
