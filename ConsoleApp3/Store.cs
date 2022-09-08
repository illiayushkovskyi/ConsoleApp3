using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Store : Article
    {
        string enter;
        string socks = "Носки";
        string underpants = "Трусы";
        string tshirt = "Майка";
        string tSHirt = "Футболка";
        string sweate = "Кофта";
        string pants = "Штаны";
        string rrrr = "rrrr";
        public void Show()
        {
            Console.WriteLine("ВЕСЬ АССОРТИМЕНТ");
            Console.WriteLine();
            Console.WriteLine(socks);
            Console.WriteLine(underpants);
            Console.WriteLine(tshirt);
            Console.WriteLine(tSHirt);
            Console.WriteLine(sweate);
            Console.WriteLine(pants);
            Console.WriteLine(rrrr);
        }
        public void Enter()
        {
            metka1:
            Console.WriteLine();
            string enter = Console.ReadLine();

            if (enter == socks)
            {
                ArtyklePrise = 20;
                Console.WriteLine("Носки - цвет белый, высокие, пахнут деньгами. Коттон 100%. Цена - " + ArtyklePrise + " $ "); }
            else if (enter == underpants)
            {
                ArtyklePrise = 30;
                Console.WriteLine("Трусы - семейные, цвет серый в полоску. Материал сатин. Цена - " + ArtyklePrise + " $ "); }
            else if (enter == tshirt)
            {
                ArtyklePrise = 35;
                Console.WriteLine("Майка - цвет белый, модель та же что носил дед. Цена - " + ArtyklePrise + " $ "); }
            else if (enter == tSHirt)
            {
                ArtyklePrise = 40;
                Console.WriteLine("Футболка поло, цвет бежевый с зеленым воротником. Котон. Цена - " + ArtyklePrise + " $ "); }
            else if (enter == sweate)
            {
                ArtyklePrise = 50;
                Console.WriteLine("Кофта с V вырезом, специально чтоб носить под низом футболку. Шерсть. Цена - " + ArtyklePrise + " $ "); }
            else if (enter == pants)
            {
                ArtyklePrise = 55;
                Console.WriteLine("Штаны - цвет черный с малиновыми лампасами. Легкий клёш. Лён. Цена - " + ArtyklePrise + " $ "); }
            else if (enter == rrrr)
            {
                ArtyklePrise = 100;
                Console.WriteLine("rrrr. Цена - " + ArtyklePrise + " $ "); }
            else
            { Console.WriteLine("Такого товара нет :(");
                goto metka1;
            }
            
            
            
        }

        string[] articles;
        public Store(string articlename, string storyname)
        {
            ArticleName = articlename;
            StoryName = storyname;
            articles = new string[]
            {
                "Носки - цвет белый, высокие, пахнут деньгами. Коттон 100%",
                "Трусы - семейные, цвет серый в полоску. Материал сатин",
                "Майка - цвет белый, модель та же что носил дед",
                "Футболка поло, цвет бежевый с зеленым воротником. Котон",
                "Кофта с V вырезом, специально чтоб носить под низом футболку. Шерсть",
                "Штаны - цвет черный с малиновыми лампасами. Легкий клёш. Лён",
                "rrrr",
            };
        }
            public string this[int produkt]
            {
            get
            {
                if(produkt >= 0 && produkt < articles.Length)
                {
                    return articles[produkt];
                }
                return "Такого товара нет :(";
            }
        
             
        

            }
    }
}
