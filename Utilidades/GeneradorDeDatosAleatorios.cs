namespace MetodologiaDeProgramacion.Utilidades
{
    static class GeneradorDeDatosAleatorios
    {
        public static int numeroAleatorio(int maximo)
        {
            Random rnd = new Random();
            return rnd.Next(1, maximo);
        }

        public static string stringAleatorio(int cant)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, cant)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}
