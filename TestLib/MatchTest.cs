using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestLib
{
    
    
    /// <summary>
    ///Classe de test pour MatchTest, destinée à contenir tous
    ///les tests unitaires MatchTest
    ///</summary>
    [TestClass()]
    public class MatchTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur Match
        ///</summary>
        [TestMethod()]
        public void MatchConstructorTest()
        {
            Club home = new Club("France");
            Club away = new Club("Angleterre"); 
            int hgoals = 1; // TODO: initialisez à une valeur appropriée
            int goals = 2; // TODO: initialisez à une valeur appropriée
            Match target = new Match(home, away, hgoals, goals);

            Club actual = target.Home;
            Club actual1 = target.Away;
            int actual2 = target.HomeGoals;
            int actual3 = target.AwayGoals;
            Assert.AreEqual(actual, home);
            Assert.AreEqual(actual1, away);
            Assert.AreEqual(actual2, hgoals);
            Assert.AreEqual(actual3, goals);
           
        }

        /// <summary>
        ///Test pour Constructeur Match
        ///</summary>
        [TestMethod()]
        public void MatchConstructorTest1()
        {
            Club home = new Club("France"); 
            Club away = new Club("Angleterre"); 
            bool isBothForfeit = false; 
            Match target = new Match(home, away, isBothForfeit,"");
            Club actual = target.Home;
            Club actual1 = target.Away;
            bool actual2 = target.IsHomeForfeit;
            Assert.AreEqual(actual, home);
            Assert.AreEqual(actual1, away);
            Assert.AreEqual(actual2, isBothForfeit);
        }

  

        /// <summary>
        ///Test pour Away
        ///</summary>
        [TestMethod()]
        public void AwayTest()
        {
            Club away = new Club("Angleterre"); // TODO: initialisez à une valeur appropriée
            Match target = new Match(away, "away"); // TODO: initialisez à une valeur appropriée
            Club actual;
            actual = target.Away;
            Assert.AreEqual(actual, away);
        }

        /// <summary>
        ///Test pour AwayGoals
        ///</summary>
        [TestMethod()]
        public void AwayGoalsTest()
        {
            Club home = new Club("France"); // TODO: initialisez à une valeur appropriée
            Club away = new Club("Angleterre"); // TODO: initialisez à une valeur appropriée
            Match target = new Match(home, away, 1, 3);
            int actual;
            actual = target.AwayGoals;
            Assert.AreEqual(actual,3);
        }

        /// <summary>
        ///Test pour Home
        ///</summary>
        [TestMethod()]
        public void HomeTest()
        {
            Club home = new Club("France"); // TODO: initialisez à une valeur appropriée
           Match target=new Match(home, "home");
           Club actual = target.Home;
            Assert.AreEqual(actual,home );
        }

        /// <summary>
        ///Test pour HomeGoals
        ///</summary>
        [TestMethod()]
        public void HomeGoalsTest()
        {
            Club home = new Club("France"); // TODO: initialisez à une valeur appropriée
            Match target = new Match(3, "home");
            int actual;
            actual = target.HomeGoals;
            Assert.AreEqual(actual, 3);
        }

        /// <summary>
        ///Test pour IsAwayForfeit
        ///</summary>
        [TestMethod()]
        public void IsAwayForfeitTest()
        {
            Club home = new Club("France"); // TODO: initialisez à une valeur appropriée
            Club away = new Club("Angleterre"); // TODO: initialisez à une valeur appropriée
            bool isAwayForfeit = false; // TODO: initialisez à une valeur appropriée
            Match target = new Match(home, away, isAwayForfeit,"away"); // TODO: initialisez à une valeur appropriée
            bool actual;
            actual = target.IsAwayForfeit;
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        ///Test pour isDraw
        ///</summary>
        [TestMethod()]
        public void isDrawTest()
        {
            Club home = new Club("France"); // TODO: initialisez à une valeur appropriée
            Club away = new Club("Angleterre"); // TODO: initialisez à une valeur appropriée
            Match target = new Match(home, away, 3, 3);
            bool actual;
            actual = target.IsDraw;
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        ///Test pour isHomeForfait
        ///</summary>
        [TestMethod()]
        public void isHomeForfaitTest()
        {
            Club home = new Club("France"); // TODO: initialisez à une valeur appropriée
            Club away = new Club("Angleterre"); // TODO: initialisez à une valeur appropriée
            bool isHomeForfeit = true; // TODO: initialisez à une valeur appropriée
            Match target = new Match(home, away, isHomeForfeit,"home"); // TODO: initialisez à une valeur appropriée
            bool actual;
            actual = target.IsHomeForfeit;
            Assert.AreEqual(true, actual);
           
        }
    }
}
