using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public string Renk { get; set; }

        private int _KapıSayısı;  // Private bir kapsül
        public int KapıSayısı 
        {
            get
            {
                return _KapıSayısı;
            }
            set 
            {
                if (value != 2 || value != 4) // Kapı sayısı 2 ve ya 4 girilmezse -1 atıyoruz.
                {
                   
                    _KapıSayısı = -1;
                    
                }
                else
                {
                    _KapıSayısı = value; // Eğer kapı sayısı doğru girilirse değeri döndürüyoruz.
                }
                
            } 
        }


    }
}
