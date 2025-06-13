public class Solution {

    public string Encode(IList<string> strs) {
        string str="";

        foreach (string word in strs){
            str+=word.Length + "#" + word;;
        }
        
        return str;
    }

    public List<string> Decode(string s) {
        List<string> result= new List<string>();
        int i=0;

        while(i<s.Length){
            int j=i;
            while(s[j] != '#'){
                j++;
            }

            int lengthWord=int.Parse(s.Substring(i, j - i));    
            string word=s.Substring(j+1,lengthWord);

            result.Add(word);

            i=j+1+lengthWord;
        }

        return result;

    }
}