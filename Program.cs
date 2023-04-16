using System.Reflection;

namespace Reflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClosestNumber.FindNumber();
            Console.WriteLine("----------Fetch all Class Methods using Reflection.-----------");
            Type type = typeof(ClosestNumber);
            MemberInfo[] members = type.GetMembers();

            foreach (MemberInfo member in members)
            {
                Console.WriteLine(member);
            }
        }
    }
}