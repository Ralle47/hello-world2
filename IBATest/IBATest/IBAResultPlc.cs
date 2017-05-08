using System.Security.Cryptography.X509Certificates;

namespace IBATest
{
    public interface IBAResultPlc : 
        //IBAResultPlc1, 
        //IBAResultPlc2,
        IBAResultPlc12,
        IBAResultPlc23
    {
        string Name { get; set; }

    }
    public interface IBAResultPlc1
    {
       
        string Name1 { get; set; }

    }
    public interface IBAResultPlc2
    {
        string Name2 { get; set; }

    }
    public interface IBAResultPlc3
    {
        string Name3 { get; set; }

    }

    public interface IBAResultPlc12 : IBAResultPlc1, IBAResultPlc2
    {
        string Name12 { get; set; }

    }

    public interface IBAResultPlc23: IBAResultPlc2, IBAResultPlc3
    {
        string Name23 { get; set; }

    }
}