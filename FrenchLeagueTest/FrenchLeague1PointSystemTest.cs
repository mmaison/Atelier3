using SoccerRankingLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lib;

namespace FrenchLeagueTest
{
    
    
    /// <summary>
    ///Classe de test pour FrenchLeague1PointSystemTest, destinée à contenir tous
    ///les tests unitaires FrenchLeague1PointSystemTest
    ///</summary>
    [TestClass()]
    public class FrenchLeague1PointSystemTest
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
        ///Test pour GetPointsFromMatch
        ///</summary>
        [TestMethod()]
        public void GetPointsFromMatchTest()
        {
            FrenchLeague1PointSystem target = (FrenchLeague1PointSystem)FrenchLeague1PointSystem.Instance; 
            bool isHome = true; // TODO: initialisez à une valeur appropriée
            int value_home = 1;
            int value_away = 0;
            Match m = new Match(new Club("France"), new Club("Espagne"), value_home, value_away);
            //PointSystem.ITotal actual;
            //PointSystem.ITotal result;
            int diff_home = target.GetPointsFromMatch(m, isHome).CompareTo(0);
            int diff_away = target.GetPointsFromMatch(m, !isHome).CompareTo(0);
            Assert.AreEqual(diff_home, value_home);
            Assert.AreEqual(diff_away, value_away);
        }

        /// <summary>
        ///Test pour InitialPoints
        ///</summary>
        [TestMethod()]
        public void InitialPointsTest()
        {
            FrenchLeague1PointSystem target = (FrenchLeague1PointSystem)FrenchLeague1PointSystem.Instance; // TODO: initialisez à une valeur appropriée
            //PointSystem.ITotal actual;
            int diff = target.InitialPoints.CompareTo(0);
            Assert.AreEqual(diff, 0);
            //Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Instance
        ///</summary>
        [TestMethod()]
        public void InstanceTest()
        {
            FrenchLeague1PointSystem target = (FrenchLeague1PointSystem)FrenchLeague1PointSystem.Instance; // TODO: initialisez à une valeur appropriée
            Assert.AreNotEqual(target, null);
            //Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
