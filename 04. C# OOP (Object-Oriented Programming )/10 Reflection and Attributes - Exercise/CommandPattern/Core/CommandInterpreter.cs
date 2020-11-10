using System;
using System.Linq;
using System.Reflection;

using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_POSTFIX = "Command";

        public string Read(string args)
        {
            string[] commandInputArguments = args
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            string commandName = commandInputArguments[0] + COMMAND_POSTFIX;
            string[] commandArgumets = commandInputArguments.Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();

            Type type = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == commandName.ToLower());

            if (type == null)
            {
                throw new ArgumentException("Invalid command type!");
            }

            ICommand commandInstance = (ICommand)Activator.CreateInstance(type);

            string result = commandInstance.Execute(commandArgumets);

            return result;
        }
    }
}
