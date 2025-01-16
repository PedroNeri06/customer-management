namespace costumerManagement.Interface;

internal interface IconstumerBr
{
    int id { get; }
    string fullName { get; set; }
    string cpf { get; }

    public void SetiD() { }
    public void SetCpf(int[] cpf) { }
}