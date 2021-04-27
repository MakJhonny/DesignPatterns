using System;

namespace Creational
{
    class Program
    {
        static void Main(string[] args)
        {
            var fairPlay = new AdidasSportShop(1);
            fairPlay.recieveOrder("Football Boot");
            Console.WriteLine(fairPlay.deliverOrder());

            fairPlay.recieveOrder("Football Jersey");
            Console.WriteLine(fairPlay.deliverOrder());

            //Non-existing product
            fairPlay.recieveOrder("Baseball Glove");
            Console.WriteLine(fairPlay.deliverOrder());
        }
    }
}
