
public class Solution{    
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> counterDic=new Dictionary<int,int>();        
        List<int>[] buckets=new List<int>[nums.Length+1];
        
        for(int i=0;i<nums.Length;i++){
            currentNum=nums[i];
            if(counterDic.ContainsKey(currentNum)){
                counterDic[currentNum]+=1;
            }else{
                counterDic[currentNum]=1;
            }
        }

        for (int i = 0; i<buckets.Length; i++){
                buckets[i]=new List<int>();
        }

            
        foreach(var pair in counterDic){
            int count=pair.Value;
            buckets[count].Add(pair.Key);
        }


        List<int> result=new List<int>();
        for (int i=buckets.Length-1; i>=0 && result.Count<k;i--){
            foreach(int num in buckets[i])
                result.Add(num);
                if(result.Count==k)
                    break;
        }

        return result.ToArray();

    }
}