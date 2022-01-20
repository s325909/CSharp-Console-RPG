using System;
using Xunit;
using ConsoleRPG.Characters;

namespace ConsoleRPGTests
{
    public class CharacterTests 
    {
        [Fact]
        public void Chracter_NewCharacter_ShouldBeLevel1() 
        {
            // Arrange
            Character testHero = new Mage("Harry Potter");
            int expected = 1;

            // Act
            int actual = testHero.Level;

            // Assert
            Assert.Equal(expected, actual);   
        }

        [Fact]
        public void Chracter_CharacterLevelUp_ShouldBeLevel2() 
        {
            // Arrange
            Character testHero = new Ranger("Katniss Everdeen");
            testHero.GainLevelAndAttributes();
            int expected = 2;

            // Act
            int actual = testHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        // Testing each character class primary attributes when created

        [Fact]
        public void Chracter_NewMagePrimeAttributes_ShouldBeMageBaseAttributes()  
        {
            // Arrange
            Character testMage = new Mage("Gandalf");
            var attr = testMage.BaseAttributes; 
            var expected = new[] { 1, 1, 8 };

            // Act
            var actual = new[] { attr.Strenght, attr.Dexterity, attr.Intelligence };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Chracter_NewRangerPrimeAttributes_ShouldBeRangerBaseAttributes() 
        {
            // Arrange
            Character testRanger = new Ranger("Kate Bishop");
            var attr = testRanger.BaseAttributes;
            var expected = new[] { 1, 7, 1 };

            // Act
            var actual = new[] { attr.Strenght, attr.Dexterity, attr.Intelligence };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Chracter_NewRougePrimeAttributes_ShouldBeRougeBaseAttributes()  
        {
            // Arrange
            Character testRouge = new Rouge("Shay Patrick Cormac");
            var attr = testRouge.BaseAttributes;
            var expected = new[] { 2, 6, 1 };

            // Act
            var actual = new[] { attr.Strenght, attr.Dexterity, attr.Intelligence };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Chracter_NewWariorPrimeAttributes_ShouldBeWarriorBaseAttributes()   
        {
            // Arrange
            Character testWarrior = new Warrior("Chad");
            var attr = testWarrior.BaseAttributes;
            var expected = new[] { 5, 2, 1 };

            // Act
            var actual = new[] { attr.Strenght, attr.Dexterity, attr.Intelligence };

            // Assert
            Assert.Equal(expected, actual);
        }

        // Testing each character class primary attributes when levelling up

        [Fact]
        public void Chracter_MagePrimeAttributeLevelGains_ShouldBeSumTotalAttributeGains()     
        {
            // Arrange
            Character testMage = new Mage("Albert Dumblydore");
            testMage.GainLevelAndAttributes();
            var attr = testMage.CalculateTotalAttributes();
            var expected = new[] { 2, 2, 13 };

            // Act
            var actual = new[] { attr.Strenght, attr.Dexterity, attr.Intelligence };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Chracter_RangerPrimeAttributeLevelGains_ShouldBeSumTotalAttributeGains()    
        {
            // Arrange
            Character testRanger = new Ranger("Hawkeye");
            testRanger.GainLevelAndAttributes();
            var attr = testRanger.CalculateTotalAttributes(); 
            var expected = new[] { 2, 12, 2 };

            // Act
            var actual = new[] { attr.Strenght, attr.Dexterity, attr.Intelligence };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Chracter_RougePrimeAttributeLevelGains_ShouldBeSumTotalAttributeGains()    
        {
            // Arrange
            Character testRouge = new Rouge("Sauron");
            testRouge.GainLevelAndAttributes();
            var attr = testRouge.CalculateTotalAttributes();
            var expected = new[] { 3, 10, 2 };

            // Act
            var actual = new[] { attr.Strenght, attr.Dexterity, attr.Intelligence };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Chracter_NewWariorPrimeAttributeLevelGains_ShouldBeSumTotalAttributeGains()    
        {
            // Arrange
            Character testWarrior = new Warrior("Chad");
            testWarrior.GainLevelAndAttributes();
            var attr = testWarrior.CalculateTotalAttributes();
            var expected = new[] { 8, 4, 2 };

            // Act
            var actual = new[] { attr.Strenght, attr.Dexterity, attr.Intelligence };

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
