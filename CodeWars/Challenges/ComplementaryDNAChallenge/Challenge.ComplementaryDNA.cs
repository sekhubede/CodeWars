using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges
{
    public static partial class Challenge
    {
        public static string MakeComplement(string dna)
        {
            var sb = new StringBuilder();

            foreach(var nucleotide in dna)
            {
                switch(nucleotide)
                {
                    case 'A':
                        sb.Append('T');
                        break;
                    case 'T':
                        sb.Append('A');
                        break;
                    case 'C':
                        sb.Append('G');
                        break;
                    case 'G':
                        sb.Append('C');
                        break;
                    default:
                        throw new ArgumentException("Invalid DNA");
                }
            }

            return sb.ToString();
        }

        public static string MakeComplement_Linq(string dna)=> new string(dna.Select(c => c switch
            {
                'A' => 'T',
                'T' => 'A',
                'C' => 'G',
                'G' => 'C',
                _ => throw new ArgumentException("Invalid DNA")
            }).ToArray());
    }
}
