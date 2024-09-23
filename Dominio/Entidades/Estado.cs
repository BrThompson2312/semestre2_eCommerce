namespace Dominio.Entidades
{
    public static class Estado
    {
        private static int abierto = 0;
        private static int cerrado = 1;
        private static int terminado = 2;

        public static int Abierto {
            get { return abierto; }
        }
        public static int Cerrado {
            get { return cerrado; }
        }
        public static int Terminado {
            get { return terminado; }
        }

    }
}