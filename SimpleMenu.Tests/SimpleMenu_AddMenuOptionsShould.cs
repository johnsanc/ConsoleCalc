using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCLI;

namespace ConsoleCLI.Tests
{
    [TestClass]
    public class SimpleMenu_AddMenuOptionsShould
    {
        private string option1 = "Menu option one";
        private string option2 = "Menu option two";
        private SimpleMenu testMenu;

        [TestMethod]
        public void ConstructorShouldCreateList_Input2()
        {
            
            
            testMenu = new SimpleMenu(
                option1,
                option2
            );

            Assert.AreEqual(option1, testMenu.menuOptions[0]);
            Assert.AreEqual(option2, testMenu.menuOptions[1]);     
        }

        [TestMethod]
        public void ConstructorShouldCreateList_Input1()
        {
            string option1 = "Menu option one";
            
            testMenu = new SimpleMenu(
                option1
            );

            Assert.AreEqual(option1, testMenu.menuOptions[0]);
        }
    }
}
