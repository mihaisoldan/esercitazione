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
                await db.Database.EnsureCreatedAsync();

                Tavolo tavolo = new Tavolo();

                Mossa mossa1 = new Mossa();
                mossa1.Valore = "A2 A3";
                mossa1.Tavolo = tavolo;

                Mossa mossa2 = new Mossa();
                mossa2.Valore = "D5 H4";
                mossa2.Tavolo = tavolo;


                db.Add(mossa1);
                db.Add(mossa2);
                await db.SaveChangesAsync();
                Console.WriteLine("Mosse aggiunte.");
            }
            
        }
    }
}
