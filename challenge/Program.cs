using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valeurSaisie;
            int nbLongeur;
            string [] lesLieux;
            int[] lesQteDeProduits;
            string [] lesProduits;
            int ind;
            //int cpt1 = 1;
            //int cpt2 = 0;
            int total =0;
            bool n;
            int indice=0;

            do
            {
                Console.WriteLine(" saisissez le nombre d'usines que vous voulez entrer ");
                valeurSaisie = Console.ReadLine().Trim().ToUpper();
                n = int.TryParse(valeurSaisie, out nbLongeur); 
            } while (n==false);

            lesLieux = new string[nbLongeur];
            lesQteDeProduits = new int[nbLongeur]; 

            for (ind= 0; ind < nbLongeur; ind++)
            {
                Console.WriteLine("saisissez la ville " + (ind + 1) + " :");
                valeurSaisie=Console.ReadLine().Trim().ToUpper();
                lesLieux[ind] = valeurSaisie;
            }

            for (ind= 0;ind < nbLongeur; ind++) 
            {
                Console.WriteLine("saisissez le nombre de produit fabrique dans " + lesLieux[ind] + " :");
                valeurSaisie = Console.ReadLine().Trim().ToUpper();
                int.TryParse (valeurSaisie, out lesQteDeProduits[ind]);
                total += lesQteDeProduits[ind];

            }

            lesProduits = new string[total];

            //on boucle sur la longeure des lieux 
           
                for (ind = 0; ind < lesLieux.Length; ind++)
                {
                    if (lesQteDeProduits[ind]==0)
                    {
                        lesProduits[indice] = "0";                    
                        if (indice != lesLieux.Length)
                        {

                            indice += 1;

                        }
                        
                    }
                    else
                    {
                    //on boucle sur la valeure a l indice ind de notre premiere boucles
                        for (int i = 0; i < lesQteDeProduits[ind]; i++)
                        {
                            Console.WriteLine(" saisir l'element de la ville " + lesLieux[ind] + " dont le nombre de produit est de " + lesQteDeProduits[ind]);
                            valeurSaisie = Console.ReadLine().Trim().ToUpper();
                            lesProduits[indice] = valeurSaisie;
                            if (indice != lesLieux.Length)
                            {
                                indice += 1;

                            }

                        }
                    }
                  

                    /*for (int i = 0; i < lesQteDeProduits[ind]; i++)
                    { 

                        Console.WriteLine("saisir le produit pour numero "+ (cpt+=1) + lesLieux[ind]);
                        valeurSaisie=Console.ReadLine();
                        lesProduits[cpt] = valeurSaisie;
                        lesQteDeProduits[ind] -= 1;
                        cpt++;

                    }

                    Console.WriteLine(" saisir le produit " + cpt);
                    valeurSaisie= Console.ReadLine().Trim().ToUpper();
                    lesProduits[ind] = valeurSaisie;
                    cpt++;*/

                }
            
            
            for (ind = 0;ind < nbLongeur; ind++) 
            {
                Console.Write( "[ " + lesLieux[ind]+ " ]");

            }
            Console.WriteLine("\n");
            for (ind = 0; ind < nbLongeur; ind++)
            {
                Console.Write("[ " + lesQteDeProduits[ind] + " ]");

            }
            Console.WriteLine("\n");
            for (ind = 0; ind < total; ind++)
            {
                Console.Write("[ " + lesProduits[ind] + " ]");
            }
            Console.ReadLine();

        }
    }
}
