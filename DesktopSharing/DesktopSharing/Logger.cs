using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopSharing
{
    public enum LogLevel
    {
        DEBUG, INFO, ERROR, FATAL
    }

    public interface Logger
    {
        public String Name
        {
            get;
        }

        public LogLevel Level
        {
            get;
            set;
        }

        public String Format
        {
            get;
            set;
        }

        public void Debug(string messge);

        public void Info(string message);

        public void Error(string message);

        public void Fatal(string message);
    }

    public class NullLogger : Logger
    {
        private string name;
        private LogLevel level = LogLevel.DEBUG;
        private string format = "";

        public NullLogger(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public LogLevel Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }

        public string Format
        {
            get
            {
                return this.format;
            }
            set
            {
                this.format = value;
            }
        }

        public void Log(string message, LogLevel level)
        {
            // TODO Do nothing
        }

        public void Debug(string message)
        {
            if (level <= LogLevel.DEBUG)
            {
                Log(message, LogLevel.DEBUG);
            }
        }

        public void Info(string message)
        {
            if (level <= LogLevel.INFO)
            {
                Log(message, LogLevel.INFO);
            }
        }

        public void Error(string message)
        {
            if (level <= LogLevel.ERROR)
            {
                Log(message, LogLevel.ERROR);
            }
        }

        public void Fatal(string message)
        {
            if (level <= LogLevel.FATAL)
            {
                Log(message, LogLevel.FATAL);
            }
        }
    }

    public interface LoggerFactory
    {
        public Logger getLogger(string name);
    }
}
