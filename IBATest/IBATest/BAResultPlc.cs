using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBATest;

namespace IBATest
{

    public class dd
    {

        static ref int ReturnByReference()
        {
            int[] arr = { 1 };
            ref int x = ref arr[0];
            return ref x;
        }
        //static unsafe void MIncrement(ref int x)
        //{
        //    x = x + 1;
        //}
        //ref int GetArrayReference(int[] items, int index) => ref items[index];
    }

    public class BAResultPlc : IBAResultPlc
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name12 { get; set; }
        public string Name3 { get; set; }
        public string Name23 { get; set; }
        public string Name { get; set; }




    }


}
