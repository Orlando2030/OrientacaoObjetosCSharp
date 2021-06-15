using System;

public class Veiculo
{
    private string tipo;
    public string Tipo 
    { 
        get {return tipo;} 
        set {tipo = value;}
    }    

    public Veiculo (string tipoVeiculo) 
    {
        this.tipo = tipoVeiculo;
    }      

    public virtual void Mover()
    {}

    public virtual void Parar()
    {}

}

public class Automovel : Veiculo
{
    public Automovel(string tipoVeiculo) 
        : base(tipoVeiculo)
    {}
    public override void Mover()
    {
        Console.WriteLine("Acelerando Veiculo");   
    }

    public override void Parar()
    {
        Console.WriteLine("Brecando Veiculo ");
    }
}

public class Aeronave : Veiculo
{
    public Aeronave(string tipoVeiculo) 
        : base(tipoVeiculo)
    {}
    public override void Mover()
    {
        Console.WriteLine("Decolando Aeronave");   
    }

    public override void Parar()
    {
        Console.WriteLine("Estou Aterrisando a Aeronave");
    }
}