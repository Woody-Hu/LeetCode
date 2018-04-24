using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LetterCasePermutation
    {
        public IList<string> LetterCasePermutationMethod(string S)
        {
            if (string.IsNullOrWhiteSpace(S))
            {
                return new List<string>(){ string.Empty};
            }
            List<StringBuilder> retrunValue = new List<StringBuilder>();

            List<string> lstReturnValue = new List<string>();
            foreach (var oneChar in S)
            {
                if (Char.IsNumber(oneChar))
                {
                    if ( 0 == retrunValue.Count )
                    {
                        StringBuilder tempStringBuilder = new StringBuilder();
                        tempStringBuilder.Append(oneChar);
                        retrunValue.Add(tempStringBuilder);
                    }
                    else
                    {
                        foreach (var item in retrunValue)
                        {
                            item.Append(oneChar);
                        }
                    }
                }
                else
                {
                    if (0 == retrunValue.Count)
                    {
                        StringBuilder tempStringBuilder1 = new StringBuilder();
                        tempStringBuilder1.Append(Char.ToLower(oneChar));
                        StringBuilder tempStringBuilder2 = new StringBuilder();
                        tempStringBuilder2.Append(Char.ToUpper(oneChar));
                        retrunValue.Add(tempStringBuilder1);
                        retrunValue.Add(tempStringBuilder2);
                    }
                    else
                    {
                        List<StringBuilder> lstTempStribuilder = new List<StringBuilder>();
                        foreach (var item in retrunValue)
                        {
                            lstTempStribuilder.Add(new StringBuilder(item.ToString()));
                            item.Append(Char.ToLower(oneChar));
                        }

                        foreach (var oneStringBuilder in lstTempStribuilder)
                        {
                            oneStringBuilder.Append(Char.ToUpper(oneChar));
                            retrunValue.Add(oneStringBuilder);
                        }
                    }
                }


              

               
            }

            foreach (var oneSb in retrunValue)
            {
                lstReturnValue.Add(oneSb.ToString());

            }

            return lstReturnValue;

        }
    }
}
