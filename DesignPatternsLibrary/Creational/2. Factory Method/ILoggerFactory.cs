using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Creational._2._Factory_Method
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
        IFileWriter CreateFileWriter();
    }
}
