using System;
using Xunit;
using ConsoleRPG.Attributes;
using ConsoleRPG.Characters;
using ConsoleRPG.Exceptions;
using ConsoleRPG.Items;

namespace ConsoleRPGTests
{
    public class ItemEquipmentTests  
    {
        Character testHero = new Warrior("CHAD");

        #region Equip a high level item 
        [Fact]
        public void TestEquip_HighLevelWeapon_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Item testAxe = new Weapon("Common axe", "Axe", "Weapon", 2, new WeaponAttribute(7, 1.1));

            // Act and Assert
            Assert.Throws<InvalidWeaponException>(() => testHero.EquipableItemCheck(testAxe));
        }

        [Fact]
        public void TestEquip_HighLevelArmor_ShouldThrowInvalidArmorException() 
        {
            // Arrange
            Item testPlateBody = new Armor("Common plate body armor", "Armor", "Body", 2);

            // Act and Assert
            Assert.Throws<InvalidArmorException>(() => testHero.EquipableItemCheck(testPlateBody));
        }

        #endregion

        #region Equip a wrong item type 
        [Fact]
        public void TestEquip_WrongWeaponType_ShouldThrowInvalidWeaponException() 
        {
            // Arrange
            Item testBow = new Weapon("Common bow", "Bow", "Weapon", 1, new WeaponAttribute(12, 0.8));

            // Act and Assert
            Assert.Throws<InvalidWeaponException>(() => testHero.EquipableItemCheck(testBow));
        }

        [Fact]
        public void TestEquip_WrongArmorType_ShouldThrowInvalidArmorException() 
        {
            // Arrange
            Item testClothHead = new Armor("Common cloth head armor", "Cloth", "Head", 1);

            // Act and Assert
            Assert.Throws<InvalidArmorException>(() => testHero.EquipableItemCheck(testClothHead));
        }

        #endregion

        #region Equip a valid item type 
        [Fact]
        public void TestEquip_ValidWeaponType_ShouldEquipItem()  
        {
            // Arrange
            Item testAxe = new Weapon("Common axe", "Axe", "Weapon", 1, new WeaponAttribute(7, 1.1));
            string expected = $"New weapon equipped!";

            // Act
            string actual = testHero.EquipableItemCheck(testAxe);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEquip_ValidArmorType_ShouldEquipArmor()  
        {
            // Arrange;
            Item testPlateBody = new Armor("Common plate body armor", "Plate", "Body", 1);
            string expected = $"New armor equipped!";

            // Act
            string actual = testHero.EquipableItemCheck(testPlateBody);

            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Calculate damage with and without valid weapon and armor equipped
        [Fact]
        public void Damage_NewWariorWithoutWeaponEquipped_ShouldDealTotalDamage()   
        {
            // Arrange
            double expected = 1 * (1 + (5 / 100)); 

            // Act
            double actual = testHero.CalculateTotalDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_NewWariorWithValidWeaponEquipped_ShouldDealTotalDamage()   
        {
            // Arrange
            Item testAxe = new Weapon("Common axe", "Axe", "Weapon", 1, new WeaponAttribute(7, 1.1));
            testHero.EquipableItemCheck(testAxe);
            double expected = (7 * 1.1) * (1 + (5 / 100));

            // Act
            double actual = testHero.CalculateTotalDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_NewWariorWithValidWeaponAndArmorEquipped_ShouldDealTotalDamage()  
        {
            // Arrange
            Item testAxe = new Weapon("Common axe", "Axe", "Weapon", 1, new WeaponAttribute(7, 1.1));
            Item testPlateBody = new Armor("Common plate body armor", "Plate", "Body", 1);
            testHero.EquipableItemCheck(testAxe);
            testHero.EquipableItemCheck(testPlateBody);
            double expected = (7 * 1.1) * (1 + ((5 + 1) / 100));

            // Act
            double actual = testHero.CalculateTotalDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion
    }
}
