using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    using System;
    // you can also use other imports, for example:
    // using System.Collections.Generic;

    class Solution
    {
        public void solution(int N, int[] k)
        {
            // sort the array
            int temp;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (k[i] > k[j])
                    {
                        temp = k[j];
                        k[j] = k[i];
                        k[i] = temp;
                    }
                }
            }
            int lcount = 1;
            int current_count = 1;

            for (int i = 0; i < N - 1; i++)
            {
                if (k[i] + 1 == k[i + 1])
                {
                    current_count++;
                }
                else if (k[i] == k[i + 1])
                {
                    continue;
                }
                else
                {
                    if (lcount < current_count)
                    {
                        lcount = current_count;
                    }

                    current_count = 1;
                }
            }
            if (lcount < current_count)
            {
                lcount = current_count;
            }
            Console.WriteLine(lcount);
        }
    }

    // Following is the part of the program and is provided as an assistance to read the input.
    public class cgProgram
    {
        public static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] Ks = Console.ReadLine().Split(null);
            int[] K = new int[N];
            for (int j = 0; j < N; j++)
                K[j] = Convert.ToInt32(Ks[j]);
            Solution s = new Solution();
            s.solution(N, K);
        }
    }
}
