using System;
using System.Linq;
using System.Text;
using System.Reflection;

public class Spy
{
    public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
    {
        Type classType = Type.GetType(investigatedClass);

        FieldInfo[] classFields = classType
            .GetFields(
                        BindingFlags.Instance |
                        BindingFlags.Static |
                        BindingFlags.NonPublic |
                        BindingFlags.Public
                      );

        StringBuilder stringBuilder = new StringBuilder();

        Object classInstance = Activator.CreateInstance(classType, new object[] { });

        stringBuilder.AppendLine($"Class under investigation: {investigatedClass}");

        foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
        {
            stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return stringBuilder.ToString().Trim();
    }
}
