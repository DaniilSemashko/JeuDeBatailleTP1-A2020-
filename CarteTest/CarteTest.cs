using JeuDeBatailleTP1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CarteTest
{
    [TestClass]
    public class CarteTest
    {
        /**
         * Test basique des Get Set dans la classe Carte pour la propriete AfficherNomCarte
         */
        [TestMethod]
        public void AffichageNomCarteEnJeuTest()
        {
            // Arrange
            var carte = new Carte();
            // Act
            carte.AffichageNomCarteEnJeu = "As de pique";
            // Assert
            Assert.Equals(carte.AffichageNomCarteEnJeu, "JeuDeBatailleTP1");
        }

        /**
         * Test basique des Get Set dans la classe Carte pour la propriete Figure
         */
        [TestMethod]
        public void FigureTest() 
        {
            // Arrange
            var carte = new Carte();
            // Act
            carte.Figure = Figure.Coeurs;
            // Assert
            Assert.Equals(carte.Figure, Figure.Coeurs);
        }
        /**
         * Test basique des Get Set dans la classe Carte pour la propriete Pointe 
         */
        [TestMethod]
        public void PointTest()
        {
            // Arrange
            var carte;
            //Act

            //Assert

        }


    }
}
