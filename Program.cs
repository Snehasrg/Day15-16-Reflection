using System.Reflection;

namespace Reflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select your choice from:\n" +
               "1. To find Closest Even number with all even digit.\n" +
               "2. Fetch all class members (like methods, constructors,properties) using reflection.\n" +
               "3. Create empty object (default constructor) of above class using reflection.\n" +
               "4. Create parameterized object using reflection.\n" +
               "5. Invoke method using reflection.");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    ClosestNumber.FindNumber();
                    break;
                case 2:
                    Console.WriteLine("----------Fetch all Class Members using Reflection.-----------");
                    Type type = typeof(ClosestNumber);
                    MemberInfo[] members = type.GetMembers();

                    foreach (MemberInfo member in members)
                    {
                        Console.WriteLine(member);
                    }
                    break;
                case 3:
                    Console.WriteLine("--------Create empty object----------");
                    Type type1 = typeof(ClosestNumber);
                    object obj = Activator.CreateInstance(type1);
                    Console.WriteLine(obj.GetType().Name);
                    break;
                case 4:
                    Console.WriteLine("--------Create Parameterized Constructor--------");
                    Type type2 = typeof(ClosestNumber);
                    object name = "Sneha";
                    object parameterizedObj = Activator.CreateInstance(type2, name);
                    Console.WriteLine(parameterizedObj.GetType().Name);
                    break;
                case 5:
                    //Invoke method using reflection.
                    Type type3 = typeof(ClosestNumber);
                    MethodInfo[] methods = type3.GetMethods();
                    foreach (MethodInfo method in methods)
                    {
                        Console.WriteLine(method.Name);
                    }                  
                    break;
                default:
                    Console.WriteLine("Select Correct Option for operation");
                    break;


            }

        }
    }
}