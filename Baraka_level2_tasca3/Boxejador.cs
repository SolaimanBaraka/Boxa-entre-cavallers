namespace boxa
{
    public class Boxeador
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }

        public Boxeador(string nombre, int golpesQueAguanta)
        {
            Nombre = nombre;
            Vida = golpesQueAguanta;
        }
    }
}


