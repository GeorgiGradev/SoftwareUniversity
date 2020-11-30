using RobotService.IO.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RobotService.IO
{
    public class FileWriter : IWriter
    {
        public void Write(string message)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string message)
        {
            File.AppendAllText("../../../output.txt", message + Environment.NewLine);
        }
    }
}
