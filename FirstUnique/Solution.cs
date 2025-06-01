
namespace FirstUnique
{
    public class Solution
    {
        public int solution(int[] input)
        {
            HashSet<int> all = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach(int number in input)
            {
                if (!all.Add(number))
                {
                    duplicates.Add(number);
                }
            }

            foreach (int number in input)
            {
                if (!duplicates.Contains(number))
                {
                    return number;
                }
            }

            return -1;

        }
    }
}
