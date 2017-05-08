namespace IBATest
{
    public class Test
    {
        public void Doit()
        {
            IBAResultPlc resultPlc = new BAResultPlc();

            var t = "";
            t = resultPlc.Name1;
            t = resultPlc.Name2;
            t = resultPlc.Name3;
            t = resultPlc.Name12;
            t = resultPlc.Name23;
            t = resultPlc.Name;

            var resultPlc1 = (IBAResultPlc1)resultPlc;
            t = resultPlc1.Name1;

            var resultPlc2 = (IBAResultPlc2)resultPlc;
            t = resultPlc2.Name2;

            var resultPlc3 = (IBAResultPlc3)resultPlc;
            t = resultPlc3.Name3;

            var resultPlc12 = (IBAResultPlc12)resultPlc;
            t = resultPlc12.Name1;
            t = resultPlc12.Name2;
            t = resultPlc12.Name12;

            var resultPlc23 = (IBAResultPlc23)resultPlc;
            t = resultPlc23.Name2;
            t = resultPlc23.Name3;
            t = resultPlc23.Name23;


        }
    }
}