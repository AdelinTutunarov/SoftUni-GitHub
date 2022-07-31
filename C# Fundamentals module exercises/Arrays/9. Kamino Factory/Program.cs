using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), index = 0, testindex = 0, bestIndex = n, sampleCount = 1, bestSequence = 0, bestSample = 1, sequenceinSample = 0, bestSiquenceinSample = 0, count1s = 0, most1s = 0;
            string arr = Console.ReadLine();
            bool isCurrentSampleBetter = false;
            int[] theSample = new int[n];
            while (arr != "Clone them!")
            {
                int[] currSample = arr.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int i = 0; i < n; i++)
                {
                    if (currSample[i] == 1)
                    {
                        int j = i;
                        testindex = i;
                        while (j < n && currSample[j] == 1)
                        {
                            sequenceinSample++;
                            count1s++;
                            j++;
                        }
                        if (sequenceinSample > bestSiquenceinSample)
                        {
                            index = testindex;
                            bestSiquenceinSample = sequenceinSample;
                        }
                        sequenceinSample = 0;
                        i = j;
                    }
                }
                if (bestSequence < bestSiquenceinSample)
                {
                    isCurrentSampleBetter = true;
                }
                else if (bestSequence == bestSiquenceinSample)
                {
                    if (index < bestIndex)
                    {
                        isCurrentSampleBetter = true;
                    }
                    else if (index == bestIndex)
                    {
                        if (count1s > most1s)
                        {
                            isCurrentSampleBetter = true;
                        }
                    }
                }
                if (isCurrentSampleBetter)
                {
                    bestSample = sampleCount;
                    bestSequence = bestSiquenceinSample;
                    bestIndex = index;
                    most1s = count1s;
                    theSample = currSample;
                }
                isCurrentSampleBetter = false;
                count1s = 0;
                bestSiquenceinSample = 0;
                arr = Console.ReadLine();
                sampleCount++;
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {most1s}.");
            Console.WriteLine(string.Join(" ", theSample));
        }
    }
}
