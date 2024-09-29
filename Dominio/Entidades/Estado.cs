namespace Dominio.Entidades
{
    public static class Estado
    {
        public static int abierto = 0;
        public static int cerrado = 1;
        public static int terminado = 2;

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