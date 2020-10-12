using System;
using System.Collections.Generic;
using System.Text;


namespace JeuDeBatailleTP1
{
    class TP1
    {
        
        static void Main(string[] args)
        {
            String nomJoueur = "";
            String CPU = "CPU";
            int nmbToursJouesPartie = 0;

            /**
             * Demande d`entrer le nom du joueur avant de debuter la partie
             */
            Console.WriteLine("Bienvenu dans le jeu de bataille ! Le jeu a ete programme " +
                "\npar Daniil Semashko dans le cadre du cours A20-420-3GP-BB Applications\n" +
                "Interactives. Le jeu programme se nomme Bataille qui est un jeu de carte\n" +
                "ou il y a deux personnes qui se confrontent jusqu`a temps que une d`ent-\n" +
                "re elles n`ai plus de cartes dans le paquet. Je vous souhaite donc une  \n" +
                "Bonne Partie !");
            Console.Write("\nVeuillez entrer votre nom: ");
            nomJoueur = Console.ReadLine();
           


            Jeu jeu = new Jeu(nomJoueur, CPU);
            while (!jeu.FinJeu())
            {
                jeu.DeroulememtTourJoue();
                nmbToursJouesPartie++;
                Console.WriteLine("\n================= Nombre de tours joues : " + nmbToursJouesPartie + " =================");
                Console.WriteLine("\n========== Appuyez sur une touche pour jouer la prochaine main ==========");
                Console.ReadKey(); // necessite que le joueur appuie sur une touche avant de jouer la prochaine main afdind d`eviter que la loop se continue non stop jusqua la fin du match
            }

            Console.WriteLine("Le nombre total de tours joue durant cette partie est de : " + nmbToursJouesPartie);
            Console.ReadKey(); // Necessite un key press a la fin du match pour sortir du jeu

            Console.Read();
                
            }


        }
    }

