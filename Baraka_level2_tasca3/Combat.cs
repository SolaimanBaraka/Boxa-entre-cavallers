namespace boxa
{
    public class Combate
    {
        private List<Boxeador> _boxeadoresCombate = new List<Boxeador>();

        public void AgregarBoxeadores()
        {
            for (int i = 1; i <= 2; i++)
            {
                string boxeador;
                do
                {
                    Console.WriteLine($"Ingresa el nombre del boxeador n.{i}:");
                    boxeador = Console.ReadLine();
                } while (ComprobarSiYaExiste(boxeador));
                Console.WriteLine("¿Cuántos golpes puede aguantar el boxeador?");
                int golpesQueAguanta = int.Parse(Console.ReadLine());
                _boxeadoresCombate.Add(new Boxeador(boxeador, golpesQueAguanta));
            }
        }

        private bool ComprobarSiYaExiste(string nuevoNombre)
        {
            foreach (var boxeador in _boxeadoresCombate)
            {
                if (boxeador.Nombre == nuevoNombre)
                {
                    Console.WriteLine("¡Este boxeador ya está inscrito!");
                    return true;
                }
            }
            return false;
        }

        public void CombateEnCurso()
        {
            Console.WriteLine("Boxeadores que lucharán:");
            foreach (var boxeador in _boxeadoresCombate)
            {
                Console.WriteLine($"{boxeador.Nombre}, puede aguantar {boxeador.Vida} golpes.");
            }

            Console.WriteLine("¡Preparados, listos... Ya!");
            Console.WriteLine($"Combate entre {_boxeadoresCombate[0].Nombre} y {_boxeadoresCombate[1].Nombre}:");

            string ataca = (_boxeadoresCombate[0].Nombre);
            string recibe = (_boxeadoresCombate[1].Nombre);

            while (_boxeadoresCombate[0].Vida > 0 && _boxeadoresCombate[1].Vida > 0)
            {
                Console.WriteLine($"{ataca} golpea!");
                ReducirVida(recibe);

                var temp = ataca;
                ataca = recibe;
                recibe = temp;
            }
        }

        public string ResultadoDelCombate()
        {
            var ganador = _boxeadoresCombate.Find(b => b.Vida > 0).Nombre;
            return $"GANADOR: {ganador}";
        }

        private void ReducirVida(string recibe)
        {
            var boxeador = _boxeadoresCombate.Find(b => b.Nombre == recibe);
            boxeador.Vida--;
        }
    }
}
