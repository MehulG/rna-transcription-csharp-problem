using System;
using System.Linq;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {

            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('G', 'C');
            dict.Add('C', 'G');
            dict.Add('T', 'A');
            dict.Add('A', 'U');

            char[] nuc_array = nucleotide.ToCharArray();
            List<char> rna_list= new List<char>();
            string rna = "";
            foreach(char ch in nuc_array){
                //Console.WriteLine(dict[ch]);
                //rna_list.Add(dict[ch]);
                rna += dict[ch];
            }
            //rna_list.Add('A');
            //foreach(var x in rna_list){
            //Console.WriteLine(x);
//}
            //string rna = rna_list.ToString();
            //Console.WriteLine(rna);
            return rna;        
}
        public static void Main(string[] args){
            ToRna("ACGTGGTCTTAA");
}

    }
}
