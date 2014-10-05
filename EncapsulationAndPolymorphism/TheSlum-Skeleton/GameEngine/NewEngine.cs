using System;
using System.Linq;
using TheSlum.Characters;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    class NewEngine : Engine
    {

        protected override void CreateCharacter(string[] inputParams)
        {
            Character character;
            Team team;
            switch (inputParams[5].ToLower())
            {
                case "red":
                    team = Team.Red;
                    break;
                case "blue":
                    team = Team.Blue;
                    break;
                default:
                    throw new ApplicationException("Wrong color team.");
            }

            switch (inputParams[1].ToLower())
            {
                case "warrior":
                    character = new Warrior(
                        id: inputParams[2], 
                        x: int.Parse(inputParams[3]), 
                        y: int.Parse(inputParams[4]), 
                        healthPoints: 100,
                        defensePoints: 30, 
                        team: team,
                        range: 10, 
                        attackPoints: 60);
                    break;
                case "healer":
                    character = new Healer(
                        id: inputParams[2], 
                        x: int.Parse(inputParams[3]), 
                        y: int.Parse(inputParams[4]), 
                        healthPoints: 100, 
                        defensePoints: 0, 
                        team: team, 
                        range: 10, 
                        healingPoints: 30);
                    break;
                case "mage":
                    character = new Mage(
                        id: inputParams[2],
                        x: int.Parse(inputParams[3]),
                        y: int.Parse(inputParams[4]),
                        healthPoints: 100,
                        defensePoints: 5,
                        team: team,
                        range: 10,
                        attackPoints: 30);
                    break;
                default:
                    throw new ApplicationException("No such kind of hero.");
            }

            this.characterList.Add(character);
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

        private new void AddItem(string[] inputParams)
        {
            Item item;
            switch (inputParams[2].ToLower())
            {
                case "axe":
                    item = new Axe(inputParams[3]);
                    break;
                case "shield":
                    item = new Shield(inputParams[3]);
                    break;
                case "injection":
                    item = new Injection(inputParams[3]);
                    break;
                case "pill":
                    item  =new Pill(inputParams[3]);
                    break;
                default:
                    throw new ApplicationException("No such kind of item.");
            }

            var character = this.characterList.First(c => c.Id == inputParams[1]);
            character.AddToInventory(item);
        }

    }
}
