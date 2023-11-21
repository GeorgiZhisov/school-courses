using System;

class Program
{
    static void Main()
    {
        List<int> nums1 = ReadList();
        List<int> nums2 = ReadList();

        List<int> resultNums = new List<int>();

        for (int i = 0; i < Math.Min(nums1.Count, nums2.Count); i++)
        {
            resultNums.Add(nums1[i]);
            resultNums.Add(nums2[i]);
        }

        if (nums1.Count > nums2.Count)
            resultNums.AddRange(GetRemainingElements(nums1, nums2));
        else if (nums2.Count > nums1.Count)
            resultNums.AddRange(GetRemainingElements(nums2, nums1));

        Console.WriteLine(string.Join(" ", resultNums));
    }

    static List<int> ReadList()
    {
        List<int> numbers = new List<int>();
        string[] input = Console.ReadLine().Split();

        foreach (string num in input)
        {
            numbers.Add(int.Parse(num));
        }

        return numbers;
    }

    static List<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
    {
        List<int> nums = new List<int>();

        for (int i = shorterList.Count; i < longerList.Count; i++)
        {
            nums.Add(longerList[i]);
        }

        return nums;
    }
}

