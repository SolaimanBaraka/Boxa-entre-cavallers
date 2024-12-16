namespace boxa;

class program
{
    static void Main(string[] args)
    {
        var combate = new Combate();
        Console.WriteLine("Bienvenidos al torneo!");
        Console.WriteLine("Pulsa Enter para comenzar con el registro del combate!");
        Console.ReadLine();
        combate.AgregarBoxeadores();
        combate.CombateEnCurso();
        Console.WriteLine(combate.ResultadoDelCombate());
    }
}


