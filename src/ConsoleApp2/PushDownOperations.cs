using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PushDownOperations
    {
        public Dictionary<String, List<String>> records = new Dictionary<string, List<string>>();
        public string startPoint;
        public string stream;
        public string[] finalValues;
        public string[] alphabet;
        public Stack<String> stepStack = new Stack<string>();

   

        public bool verifierString(String temporal, String actualState, String streamOriginal, int antiquity)
        {
            if (antiquity > streamOriginal.ToCharArray().Length)
            {
                return false;
            }


            antiquity++;
            
            
                if(temporal.Length == streamOriginal.Length)
                {
                    if (temporal.Equals(streamOriginal))
                    {
                        return true;
                    }
                    else
                    {
                        if(containsNonFinals(temporal, finalValues))
                        {

                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            


        }

        public bool containsNonFinals(String temporal, String[] states)
        {
            for(int i  = 0; i < states.Length; i++)
            {
                if (temporal.Contains(states[i]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

    }
}
