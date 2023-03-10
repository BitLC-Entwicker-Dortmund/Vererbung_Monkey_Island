namespace Vererbung_Monkey_Island {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Vererbung - Inheritence!");

            Pirat p = new Pirat();
            p.SetName("einzigartiger Pirat");
            Console.WriteLine(  p.GetName());

            Spielfigur guybrush = new Spielfigur();
            guybrush.SetName("Guybrush");
            Console.WriteLine(guybrush.GetName());

            guybrush.Machen();
            Console.WriteLine(  guybrush);

            Console.ReadLine();
        }
    }
}