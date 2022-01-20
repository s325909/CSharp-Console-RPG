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
     
        // Item testAxe = new Weapon("Common axe", "Axe", "Weapon", 2, new WeaponAttribute(7, 1.1));

        // Item testBow = new Weapon("Common bow", "bow", "Weapon", 1, new WeaponAttribute(12, 0.8));

        // Item testPlateBody = new Armor("Common plate body armor", "Armor", "Body", 2);

        // Item testClothHeady = new Armor("Common cloth head armor", "Armor", "Head", 1);


        #region Equip a high level weapon
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


        [Fact]
        public void Test1()
        {
            
        }
    }
}
