using System;
using System.Linq;
namespace _9
{
    class Program
    {
        struct ivent
        {
            public string name;
            public string level;
            public int code;
            public DateTime Maxim;
            public DateTime data;
            public DateTime vremya;
        }
        static void Main(string[] args)
        {
            ivent[] ivents = new ivent[3];
            for (int i = 0; i < ivents.Length; i++)
            {
                Console.Write("Введите название: ");
                ivents[i].name = (Console.ReadLine());
                Console.Write("Введите уровень события: ");
                ivents[i].level = Console.ReadLine();
                if (ivents[i].level == "ошибка")
                {
                    ivents[i].level = "Ошибка";
                }
                Console.Write("Введите код события: ");
                ivents[i].code = int.Parse(Console.ReadLine());
                Console.Write("Введите дату события: ");
                ivents[i].data = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Введите время события: ");
                ivents[i].vremya = Convert.ToDateTime(Console.ReadLine());
                DateTime Nikita = DateTime.Now;
                ivents[i].Maxim = new DateTime(Nikita.Subtract(ivents[i].data).Ticks);
            }
            foreach (ivent item in ivents)
            {
                if (item.level == "Ошибка")
                {
                    Console.WriteLine(item.name+", "+ item.level + ", " + item.code + ", " + item.Maxim + ", " + item.data + ", " + item.vremya);
                }
            }
        }
    }
}
