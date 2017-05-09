using System;
using Relazioni.Modello;
using Relazioni.Servizi;

namespace Relazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            EseguiPartita();
            Console.ReadKey();
        }

        private static async void EseguiPartita(){
            using (DataBase db = new DataBase()){
                Mossa mossa1 = new Mossa();
                mossa1.Valore = "A2 A3";

                Mossa mossa2 = new Mossa();
                mossa1.Valore = "D5 H4";

                db.Add(mossa1);
                await db.SaveChangesAsync();
                Console.WriteLine("Mosse aggiunte.");
            }
            
        }
    }
}
