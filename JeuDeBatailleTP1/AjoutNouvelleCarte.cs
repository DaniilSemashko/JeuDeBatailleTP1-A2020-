using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDeBatailleTP1
{
    
    public static class AjoutNouvelleCarte
    {
        public static void Enqueue(this Queue<Carte> cartes, Queue<Carte> nouvellesCartes)
        {
            foreach (var carte in nouvellesCartes)
            {
                cartes.Enqueue(carte);
            }
        }
    }
}
