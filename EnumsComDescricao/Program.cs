using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EnumsComDescricao
{
    public static class EnumExtensions
    {
        public static string Descricao(this Enum enumRecebido)
        {
            var descriptionAttribute = enumRecebido.GetType()
                .GetMember(enumRecebido.ToString())[0]
                .GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute;

            return descriptionAttribute is null ? enumRecebido.ToString() : descriptionAttribute.Description;
        }
    }


    public enum Perfil
    {

        [Description("Posto mais baixo do Exercíto brasileiro ")]
        Graduado = 1,
        [Description("É o primeiro nível dos oficiais do exercíto ")]
        Subalterno = 2,
        [Description("Nível acima dos subalternos")]
        Itermediario = 3,
        [Description("Sáo oficiais de nível superior em relação os demais níveis")]
        Superior = 4,
        [Description("Classe mais alta do exercíto brasileiro")]
        General = 5,
        Master = 6
    }


    class Program
    {

        

        static void Main(string[] args)
        {
            Console.WriteLine(ListarDescricoesPerfis());
        }

        private static string ListarDescricoesPerfis()
        {
            var stringBuilder = new StringBuilder();
            foreach (Perfil perfil in Enum.GetValues(typeof(Perfil)))
            {
                stringBuilder.AppendLine($"{perfil.ToString()} - {perfil.Descricao()}");
            }

            return stringBuilder.ToString();
        }
        private static StringBuilder ListarPerfis()
        {
            var stringBuilder = new StringBuilder();
            foreach (var perfil in Enum.GetNames(typeof(Perfil)))
            {
                stringBuilder.AppendLine(perfil);
            }

            return stringBuilder;
        }

    }
}
