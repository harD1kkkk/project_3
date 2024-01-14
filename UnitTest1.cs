using Myspace;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Mage
        [TestMethod]
        public void TestMageMagicalAttack()
        {
            // Arrange
            Mage mage = new Mage("TestMage", 100, 35, 10, 40, 100);
            double expectedDamage = 235;

            // Act
            double actualDamage = mage.AttackPow(Attack.Magical, mage.AttackPower);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, 140, "Mage's AttackPow method did not return the expected damage for a magical attack.");
        }

        [TestMethod]
        public void TestMagePhysicalAttack()
        {
            // Arrange
            Mage mage = new Mage("TestMage", 100, 35, 10, 40, 300);
            double expectedDamage = 45;

            // Act
            double actualDamage = mage.AttackPow(Attack.Physical, mage.AttackPower);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Mage's AttackPow method did not return the expected damage for a physical attack.");
        }

        [TestMethod]
        public void TestMageShieldActivated()
        {
            // Arrange
            Mage mage = new Mage("TestMage", 100, 35, 10, 40, 40);

            // Act
            bool shield = mage.shield();

            // Assert
            Assert.IsTrue(shield, "Mage's shield method did not return the expected damage when the shield is activated.");
        }

        [TestMethod]
        public void TestMageCriticalPhysicalAttack()
        {
            // Arrange
            Mage mage = new Mage("TestMage", 100, 35, 10, 40, 300);
            double expectedDamage = 10;

            // Act
            double actualDamage = mage.criticalChance(Attack.Physical);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Mage's criticalChance method did not return the expected damage for a critical physical attack.");
        }


        [TestMethod]
        public void TestMageCriticalMagicalAttack()
        {
            // Arrange
            Mage mage = new Mage("TestMage", 100, 35, 10, 40, 100);
            double expectedDamage = 60;

            // Act
            double actualDamage = mage.criticalChance(Attack.Magical);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Mage's criticalChance method did not return the expected damage for a critical physical attack.");
        }


        [TestMethod]
        public void TestMageSpecialAttack()
        {
            // Arrange
            Mage mage = new Mage("TestMage", 100, 35, 10, 40, 40);
            double expectedDamage = 140;

            // Act
            double actualDamage = mage.specialAttack(mage.AttackPower);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Mage's specialAttack method did not return the expected damage for a special magical attack.");
        }






        //Archer
        [TestMethod]
        public void TestArcherPhysicalAttack()
        {
            // Arrange
            Archer archer = new Archer("TestArcher", 150, 40, 15, 10, 100);
            double expectedDamage = 200;

            // Act
            double actualDamage = archer.AttackPow(Attack.Physical, archer.AttackPower);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, 120, "Archer's AttackPow method did not return the expected damage for a physical attack.");
        }

        [TestMethod]
        public void TestArcherMagicalAttack()
        {
            // Arrange
            Archer archer = new Archer("TestArcher", 150, 40, 15, 10, 200);
            double expectedDamage = 50;

            // Act
            double actualDamage = archer.AttackPow(Attack.Magical, archer.AttackPower);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Archer's AttackPow method did not return the expected damage for a magical attack.");
        }

        [TestMethod]
        public void TestArcherShieldActivated()
        {
            // Arrange
            Archer archer = new Archer("TestArcher", 150, 40, 15, 10, 50);

            // Act
            bool shield = archer.shield();

            // Assert
            Assert.IsTrue(shield, "Archer's shield method did not return the expected damage when the shield is activated.");
        }

        [TestMethod]
        public void TestArcherCriticalPhysicalAttack()
        {
            // Arrange
            Archer archer = new Archer("TestArcher", 150, 40, 15, 10, 100);
            double expectedDamage = 40; // Expected damage when critical chance is high for physical attack

            // Act
            double actualDamage = archer.criticalChance(Attack.Physical);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Archer's criticalChance method did not return the expected damage for a critical physical attack.");
        }

        [TestMethod]
        public void TestArcherCriticalMagicalAttack()
        {
            // Arrange
            Archer archer = new Archer("TestArcher", 150, 40, 15, 10, 200);
            double expectedDamage = 10; // Expected damage when critical chance is high for physical attack

            // Act
            double actualDamage = archer.criticalChance(Attack.Magical);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Archer's criticalChance method did not return the expected damage for a critical physical attack.");
        }


        [TestMethod]
        public void TestArcherSpecialAttack()
        {
            // Arrange
            Archer archer = new Archer("TestArcher", 150, 40, 15, 10, 50);
            double expectedDamage = 120;

            // Act
            double actualDamage = archer.specialAttack(archer.AttackPower);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Archer's specialAttack method did not return the expected damage for a special physical attack.");
        }






        //Warrior
        [TestMethod]
        public void TestWarriorPhysicalAttack()
        {
            // Arrange
            Warrior warrior = new Warrior("TestWarrior", 200, 45, 30, 15, 100);
            double expectedDamage = 195;

            // Act
            double actualDamage = warrior.AttackPow(Attack.Physical, warrior.AttackPower);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, 90, "Warrior's AttackPow method did not return the expected damage for a physical attack.");
        }


        [TestMethod]
        public void TestWarriorMagicalAttack()
        {
            // Arrange
            Warrior warrior = new Warrior("TestWarrior", 200, 45, 30, 15, 500);
            double expectedDamage = 75;

            // Act
            double actualDamage = warrior.AttackPow(Attack.Magical, warrior.AttackPower);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Warrior's AttackPow method did not return the expected damage for a magical attack.");
        }


        [TestMethod]
        public void TestWarriorShieldActivated()
        {
            // Arrange
            Warrior warrior = new Warrior("TestWarrior", 200, 45, 30, 15, 20);

            // Act
            bool shield = warrior.shield();

            // Assert
            Assert.IsTrue(shield, "Warrior's shield method did not return the expected damage when the shield is activated.");
        }


        [TestMethod]
        public void TestWarriorCriticalPhysicalAttack()
        {
            // Arrange
            Warrior warrior = new Warrior("TestWarrior", 200, 45, 30, 15, 100);
            double expectedDamage = 60; // Expected damage when critical chance is high for physical attack

            // Act
            double actualDamage = warrior.criticalChance(Attack.Physical);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Warrior's criticalChance method did not return the expected damage for a critical physical attack.");
        }

        [TestMethod]
        public void TestWarriorCriticalMagicalAttack()
        {
            // Arrange
            Warrior warrior = new Warrior("TestWarrior", 200, 45, 30, 15, 500);
            double expectedDamage = 30; // Expected damage for a critical magical attack

            // Act
            double actualDamage = warrior.criticalChance(Attack.Magical);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Warrior's criticalChance method did not return the expected damage for a critical magical attack.");
        }


        [TestMethod]
        public void TestWarriorSpecialAttack()
        {
            // Arrange
            Warrior warrior = new Warrior("TestWarrior", 200, 45, 30, 15, 20);
            double expectedDamage = 90; // Expected damage for a special physical attack

            // Act
            double actualDamage = warrior.specialAttack(warrior.AttackPower);

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage, "Warrior's specialAttack method did not return the expected damage for a special physical attack.");
        }
    }
}