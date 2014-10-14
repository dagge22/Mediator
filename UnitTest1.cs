using System;
using MediatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            ComputerSystem computerSystem = new ComputerSystem();
            Computer computer = new Computer(computerSystem);
            Keyboard keyboard = new Keyboard(computerSystem);
            Screen screen = new Screen(computerSystem);

            //Act
            computer.SwitchOn();
            keyboard.KeyPressed();
            screen.DisplayCharacter();
            //Assert

        }
    }
}
