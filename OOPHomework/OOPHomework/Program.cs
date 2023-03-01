﻿// See https://aka.ms/new-console-template for more information

using OOPHomework;

var knight = new Knight();
var archer = new Archer();
var mage = new Mage();

knight.Attack();
archer.Attack();
mage.Attack();

knight.UnitName = "Medieval Legacy";
archer.UnitName = "The Golden Arrow";
mage.UnitName = "Mystic Vestment";

Console.WriteLine($"{knight.UnitName} damage is {knight.UnitDamage} and the main skill is {knight.UnitSkills}");
Console.WriteLine($"{archer.UnitName} damage is {archer.UnitDamage} and the main skill is {archer.UnitSkills}");
Console.WriteLine($"{mage.UnitName} damage is {mage.UnitDamage} and the main skill is {mage.UnitSkills}");

Unit chosenClass = null;

chosenClass = knight;
chosenClass.Attack();

chosenClass = archer;
chosenClass.Attack();

chosenClass = mage;
chosenClass.Attack();


