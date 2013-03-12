using SoccerRankingLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lib;

namespace FrenchLeagueTest
{
    
    
    /// <summary>
    ///Classe de test pour FrenchLeague1PointSystem_PointTotalTest, destinée à contenir tous
    ///les tests unitaires FrenchLeague1PointSystem_PointTotalTest
    ///</summary>
    [TestClass()]
    public class FrenchLeague1PointSystem_PointTotalTest
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
        ///Test pour Constructeur PointTotal
        ///</summary>
        [TestMethod()]
        public void FrenchLeague1PointSystem_PointTotalConstructorTest()
        {
            Club france = new Club("france");
            Match m = new Match(france,"home"); // TODO: initialisez à une valeur appropriée
            bool home = true;
            FrenchLeague1PointSystem.PointTotal target = new FrenchLeague1PointSystem.PointTotal(m, home);
            Assert.ReferenceEquals(target, "france");
            Assert.ReferenceEquals(target, home);
        }

        /// <summary>
        ///Test pour CompareTo
        ///</summary>
        [TestMethod()]
        public void CompareToTest()
        {
            int value = 4;
            FrenchLeague1PointSystem.PointTotal target = new FrenchLeague1PointSystem.PointTotal(new Match(value, "home"), true); // TODO: initialisez à une valeur appropriée
            //object obj = null; // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.CompareTo(value);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Increment
        ///</summary>
        [TestMethod()]
        public void IncrementTest()
        {
            int value = 4;
            int add_value = 4;
            FrenchLeague1PointSystem.PointTotal target = new FrenchLeague1PointSystem.PointTotal(new Match(value, "home"), true); // TODO: initialisez à une valeur appropriée
            FrenchLeague1PointSystem.PointTotal with = new FrenchLeague1PointSystem.PointTotal(new Match(add_value, "home"), true); // TODO: initialisez à une valeur appropriée
            target.Increment(with);
            Assert.AreEqual(target.CompareTo(0), value + add_value);
            //Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }
    }
}
