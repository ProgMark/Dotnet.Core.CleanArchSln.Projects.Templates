using System;

namespace $projectname$.Application.Interfaces.Databases
{
    public class DataBaseException : Exception
    {
        public DataBaseException(string message) : base(message)
        { }

        public DataBaseException(Exception innerException, string message) : base(message, innerException)
        { }
    }
}