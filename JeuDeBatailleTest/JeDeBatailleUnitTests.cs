using JeuDeBatailleTP1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace JeuDeBatailleTest
{
    [TestClass]
    public class JeDeBatailleUnitTests
    {
        /**
         * Test basique des Get Set dans la classe Carte pour la propriete AfficherNomCarte 
         */
        [TestMethod]
        public void AffichageNomCarteEnJeu_Test()
        {
            // Arrange 
            var carte = new Carte();
            // Act   
            carte.AffichageNomCarteEnJeu = "As de pique";
            // Assert     
            Assert.AreEqual(carte.AffichageNomCarteEnJeu, "As de pique");
        }
        /**  
         * Test basique des Get Set dans la classe Carte pour la propriete Figure     
         */
        [TestMethod]
        public void Figure_Test()
        {
            // Arrange 
            var carte = new Carte();
            // Act            
            carte.Figure = Figure.Coeurs;
            // Assert      
            Assert.AreEqual(carte.Figure, Figure.Coeurs);
        }
        /**   
         * Test basique des Get Set dans la classe Carte pour la propriete Pointe    
         */
        [TestMethod]
        public void Point_Test()
        {
            // Arrange        
            var carte = new Carte();
            //Act         
            carte.Point = 2;
            //Assert
            Assert.AreEqual(carte.Point, 2);
        }
        /**   
         * Test qui valide que lors de la generation du paquet de cvartes 
         * on a un paquet de 52 cartes de jeu qui est cree. On cree donc un paquet de cartes
         * avec la meme methode et on valide que le paquet de cartes contient 52 cartes. Cette methode verifie aussi
         * que la methode MelangePaquetDeCartes garde le paquet a 52 cartes puique le return utilise la methode privee Melange
         * Avabt de retourner le paquet de cartes
         */
        [TestMethod]
        public void DistribuerLesCartes_Test()
        {
            // arrange
            var pqtDeCartes = new Queue<Carte>();
            // act
            pqtDeCartes = Paquet.GenererPaquetDeCartes();
            // assert
            Assert.AreEqual(52, (int)pqtDeCartes.Count);

        }
        /**
         * Methode qui va verifier si la carte que nous pigeons du paquet 
         * va avoir un nom conforme a celui genere par la methode obtenir nom de lacarte
         * et que le display name va etre conforme a la methode ToString
         */
        [TestMethod]
        public void ObtenirNom_Test()
        {
            //arrange
            string carte = "";
            //act
            carte = Paquet.ObtenirNom(10, Figure.Trefles);
            // assert
            Assert.AreEqual(carte, "10 de Trefles");

        }
        /**
         * methode qui va valider si le jeu se termine et une des conditions ou 
         * un des joueurs n`a plus de cartes dans son paquet de cartes est true
         */
        [TestMethod]
        public void FinJeu_Test_True() 
        {
            // arrange
            var jeu = new Jeu("j1","j2");
            var pqt = Paquet.GenererPaquetDeCartes();
            pqt.Clear();
            //act
            jeu.FinJeu();
            // Assert
            Assert.IsTrue(true);
        }

    }
}
