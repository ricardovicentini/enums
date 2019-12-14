using System;
using System.Text;

namespace Enums
{
    public static class PatenteV1
    {
        public enum Pefil
        {
            //Posto mais baixo do Exercíto brasileiro 
            Graduado = 1,
            //É o primeiro nível dos oficiais do exercíto 
            Subalterno = 2,
            //Nível acima dos subalternos
            Itermediario = 3,
            //Sáo oficiais de nível superior em relação os demais níveis
            Superior = 4,
            //Classe mais alta do exercíto brasileiro
            General = 5
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de perfis");
          
            Console.WriteLine(ListarEnums());
        }

        private static StringBuilder ListarEnums()
        {
            var stringBuilder = new StringBuilder();
            foreach (var perfil in Enum.GetNames(typeof(PatenteV1.Pefil)))
            {
                stringBuilder.AppendLine(perfil);
            }

            return stringBuilder;
        }
    }
}
