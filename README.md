# CSharp-Console-RPG

Simple overview of use/purpose.

## Description
Plain C# used to create a console application of a text-based Role-Playing-Game (RPG) with various Character Classes:
* Mage
* Ranger
* Rouge
* Warrior

Each character class has primary base attributes:
* Strenght - determines the physical strength of the character.
  * Each point of strength increases a **Warriors** damage by 1%.
* Dexterity - determines the characters ability to attack with speed and nimbleness.
  * Each point of dexterity increases a **Rangers** and **Rouges** damage by 1%.
* Intelligence - determines the characters affinity with magic.
  * Each point of inetlligense increases a **Mages** damage by 1%.

These attributes increases at different rates as the character gains levels. 

Each character can also equip varios items such as armor and weapons to the characters equpment slots:
* Head
* Body
* Legs
* Weapon

The equipped items will alter the power of the character, causing it to deal more damage. Weapons have a **base damage**, and how many **attacks per second** can be performed with the weapon. The weapons **damage per second (DPS)** is calculated by multiplying these together.

Certain characters can only equip certain item types: 
* Mage: 
  * Armor: Cloth
  * Weapons: Staff, Wand
* Ranger:
  * Armor: Leather, Mail
  * Weapons: Bow 
* Rouge: 
  * Armor:  Leather, Mail
  * Weapons: Dagger, Sword
* Warrior: 
  * Armor: Mai, Plate 
  * Weapons: Axe, Hammer, Sword

If a character tries to equip an item that is of too high level or the wrong item type, custom exceptions are thrown:
* InvalidArmorException()
* InvalidWeaponException()

Tests using xUnit testing are used to test the functionality of all the things stated above. 

## Getting Started

### Tools installed 

* Visual Studio 2019 with .NET 5.
* Unit testing project added to project solution

## Author and Developer

Jasotharan Cyril 
