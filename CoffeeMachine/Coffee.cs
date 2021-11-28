using System;

namespace CoffeeMachine
{
    public class Coffee
    {
        private int water;
        private int milk;
        private int coffeeBeans;
        private int money;
        private string name;

        public Coffee(int water, int milk, int coffeeBeans,  int money , string name)
        {
            this.water = water;
            this.milk = milk;
            this.coffeeBeans = coffeeBeans;
            this.money = money;
            this.name = name;
        }
        
        public int getWater() {
            return water;
        }
        public void setWater(int water) {
            this.water = water;
        }

        public int getMilk() {
            return milk;
        }

        public void setMilk(int milk) {
            this.milk = milk;
        }

        public int getCoffeeBeans() {
            return coffeeBeans;
        }

        public void setCoffeeBeans(int coffeeBeans) {
            this.coffeeBeans = coffeeBeans;
        }

        public String getName() {
            return name;
        }

        public void setName(string name) {
            this.name = name;
        }

        public int getMoney() {
            return money;
        }

        public void setMoney(int money) {
            this.money = money;
        }

    }
}