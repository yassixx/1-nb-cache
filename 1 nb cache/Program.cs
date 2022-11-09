/**
 * Jeu du nombre caché
 * Fakiri Yassine
 * 07/11/22
 */
namespace NombreCache
{
    class program
    {
        static void Main(string[] args)
        {
            int nbAChercher, val, i = 0;
            bool correct = false;
            while(correct != true)
            {
                try
                {
                    Console.WriteLine("Entrez le nombre à chercher : ");
                    nbAChercher = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
            correct = false;
            Console.Clear();
            do
            {
                while (correct != true)
                {
                    try
                    {
                        Console.Write("Entrez un essai : ");
                        val = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch {
                        Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                    }
                }
                if (val > nbAChercher)
                {
                    Console.WriteLine("--> trop grand !");
                }
                else
                {
                    Console.WriteLine("--> trop petit !");
                }
                i++;
            } while (val != nbAChercher);
            Console.WriteLine("bravo vous avez trouve en " + i + " fois");
        }
    }
}
