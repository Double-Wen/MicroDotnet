using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp85
{
    //资料类的定义省略
    

    static void Main(string[] args)
        {
            
            IList<Racer> racers = Racer.GetChampions();
            FileStream fs = File.Create("E:555.txt");
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < racers.Count; i++)
            {
                Racer r = racers[i];
                
                sw.WriteLine($"{r:A}");
                sw.Write("Cars: ");
                for (int j = 0; j < r.Cars.Length; j++)
                {
                    sw.Write(r.Cars[j] + "\t");
                }
                sw.WriteLine();
                sw.Write("Years: ");
                for (int k = 0; k < r.Years.Length; k++)
                {
                    sw.Write(r.Years[k] + "\t");
                }
                sw.WriteLine();
            }
            sw.Close();
            FileStream fw = File.OpenRead("E:555.txt");
            StreamReader sr = new StreamReader(fw);
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();

            while (true)
            {
                string s1 = sr.ReadLine();
                string s2 = sr.ReadLine();
                string s3 = sr.ReadLine();
                if (s1 == null) break;
                string name = s1.Substring(0, s1.IndexOf(","));
                //Console.WriteLine(name);
                for(int i=0;i<s3.Length;i++)
                {
                    if(s3[i]<='9'&&s3[i]>='0')
                    {
                        sd.Add(int.Parse(s3.Substring(i, 4)), name);
                        i += 3;
                    }
                }
            }
            sr.Close();
            foreach (var item in sd)

            {

                Console.WriteLine(item.Key + item.Value);

            }
        }

    }
}
