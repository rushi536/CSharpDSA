using System.ComponentModel;

namespace Strings
{
    public class IsoMorphicString : IProblem
    {
        public void Run()
        {
            string s="egg";
            string t="add";
            bool result=isIsoMorphic(s,t);
        }
        private bool isIsoMorphic(string s, string t)
        {
            if(s.Length!=t.Length)
            return false;
            Dictionary<char,char> mapST=new();
            Dictionary<char,char> mapTS=new();
            for(int i = 0; i < s.Length; i++)
            {
                char c1=s[i];
                char c2=t[i];
                if (mapST.ContainsKey(c1))
                {
                    if (mapST[c1] != c2)
                    {
                        return false;
                    }
                }
                else
                {
                    mapST[c1]=c2;
                }
                if (mapTS.ContainsKey(c2))
                {
                    if (mapTS[c2] != c1)
                    {
                        return false;
                    }
                }
                else
                {
                    mapTS[c2]=c1;
                }
            }
            return true;
        }
    }
}