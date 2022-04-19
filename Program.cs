using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78DersEnums //Haftanin gunleri gibi belirli veya belirsiz ogeleri indexleyerek tutmaya yarar...
{
    enum Gunler {Pazartesi=1,Sali,Carsamba,Persembe,Cuma,Cumartesi,Pazar}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Gunler.Pazartesi);
            Console.ReadLine();
        }
    }
}
