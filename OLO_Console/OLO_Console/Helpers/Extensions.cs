using System.Text;

namespace OLO_Console.Helpers
{
    public static class Extensions
    {
        public static string ToDelimitedString(this string[] array)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length == 1)
                {
                    result.Append(array[i]);
                }
                else
                {
                    result.Append(array[i] + ",");
                }
            }
            return result.ToString().Remove(result.Length - 1, 1);
        }
    }
}
