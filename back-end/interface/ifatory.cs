namespace costumerManagement.Interface;
public interface IfataryCustomer<T>
{
    abstract T Create(int _id, string _fullName, int[] _cpf, Icheck _check);
};