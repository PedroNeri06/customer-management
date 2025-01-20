namespace costumerManagement.utils;
using costumerManagement.Interface;
using costumerManagement.Models;

public class FactoryCheck
{
    static public Check Create(double _debt, Iconstumer customer)
    {
        Random _identification = new Random();
        _identification.NextInt64();
        Check check = new Check();
        check.identification = _identification.NextInt64();
        check.debt = _debt;
        check.customer = customer.id;
        return check;
    }

}
