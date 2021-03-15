using System;

namespace All_My_Classes
{
    public class BasicCoffeeMaker : ICoffeeMaker
    {
        private string name;
        private int size;
        private string[] ingredients = new string[2];

        public BasicCoffeeMaker(string name, string ingredient1, string ingredient2, int sizeInOzs) 
        {
            this.name = name;
            size = sizeInOzs;
            ingredients[0] = ingredient1;
            ingredients[1] =  ingredient2; 
        }
        public string Brew() 
        {
            return "Brewing Ingredients"; 
        }

        public string PourDrink() 
        {
            return $"{size}oz. drink Completed In 2 Minutes";
        }
    }



    public class AdvancedCoffeeMaker: ICoffeeMaker 
    {
        private string name; 
        private int size;
        private string[] ingredients = new string[3]; 

        public AdvancedCoffeeMaker(string name, string ingredient1, string ingredient2, string ingredient3, int sizeInOzs)
        {
            this.size = sizeInOzs;
            this.name = name;
            ingredients[0] = ingredient1;
            ingredients[1] = ingredient2;
            ingredients[2] = ingredient3; 
        }

        public string Brew() 
        {
            return "Brewing"; 
        }

        public string Brew(string brewSpeed) 
        {
            if (brewSpeed == "fast") return "Brewing Quickly";

            return $"Brewing It {brewSpeed}ly"; 
        }

        public string Brew(string brewSpeed, int quantity) 
        {
            this.size = quantity; 
            return $"{brewSpeed}ly brewing your {size}oz. cup of carefully crafted coffee"; 
        }

        public string PourDrink() 
        {
            return "Pouring Your Daringly Designed Cup!";
        }

        public string Update() 
        {
            return $"Your {this.name} machine is churning out your drink as soon as possible. Slow and steady wins the race.";
        }
    }

}
