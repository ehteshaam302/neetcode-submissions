public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> dict = new Dictionary<int,int>();

        foreach(var num in nums)
        {
            if(dict.ContainsKey(num))
            {
                dict[num]++;
            }

            else
            {
                dict[num] = 1;
            }
        }

       
            return dict
                   .OrderByDescending(x=>x.Value)
                   .Take(k)
                   .Select(x=>x.Key)
                   .ToArray();
        
    }
}
