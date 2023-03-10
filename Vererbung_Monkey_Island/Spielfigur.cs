using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_Monkey_Island {
    //internal class Spielfigur  extends Pirat  implements IEinInterface{   // willkommen bei Java
    internal class Spielfigur: Pirat, IMachbar {
        public void Machen() {
            Console.WriteLine(  "Machen ...");
        }
    }


}
