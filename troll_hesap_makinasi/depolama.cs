using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace troll_hesap_makinasi
{
    internal class depolama
    {
        private string _sayi1;
        private string _sayi2;
        // 1
        public string sayi1
        {
            get
            {
                return _sayi1;
            }


            set
            {


                if (value == null)
                {
                    _sayi1 = value;
                }
                else
                {
                    _sayi1 = _sayi1 + value;
                }
            }
            



        }
        //2
        public string sayi2
        {
            get
            {
                return _sayi2;
            }


            set
            {


                if (value == null)
                {
                    _sayi2 = value;
                }
                else
                {
                    _sayi2 = _sayi2 + value;
                }
            }




        }
        
    }
}
    
