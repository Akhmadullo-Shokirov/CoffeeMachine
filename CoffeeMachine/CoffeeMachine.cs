using System;

namespace CoffeeMachine
{
    public class CoffeeMachine
    {
        
        private int water;
        private int milk;
        private int coffeeBeans;
        private int disposableCups;
        private int money;

        public CoffeeMachine()
        {
            
        }

        public CoffeeMachine(int water, int milk, int coffeeBeans, int disposableCups, int money)
        {
            this.water = water;
            this.milk = milk;
            this.coffeeBeans = coffeeBeans;
            this.disposableCups = disposableCups;
            this.money = money;
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

        public int getDisposableCups() {
            return disposableCups;
        }

        public void setDisposableCups(int disposableCups) {
            this.disposableCups = disposableCups;
        }

        public int getMoney() {
            return money;
        }

        public void setMoney(int money) {
            this.money = money;
        }

        public static void showSupply(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("The coffee machine has:");
            Console.WriteLine(coffeeMachine.getWater() + " ml of water");
            Console.WriteLine(coffeeMachine.getMilk() + " ml of Milk");
            Console.WriteLine(coffeeMachine.getCoffeeBeans() + " gr of coffee beans");
            Console.WriteLine(coffeeMachine.getDisposableCups() + " of disposable cups");
            Console.WriteLine(coffeeMachine.getMoney() + "$ money");
        }

        public static void buy(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("What do you want to buy? 1 - espresso, 2 - latte, 3 - cappuccino, 4 - back to main menu");
            String inputValue = Console.ReadLine();

            switch (inputValue)
            {
                case "1":
                    Console.WriteLine(checkWhatIsNotEnough(coffeeMachine, new Espresso()));
                    break;
                case "2":
                    Console.WriteLine(checkWhatIsNotEnough(coffeeMachine, new Latte()));
                    break;
                case "3":
                    Console.WriteLine(checkWhatIsNotEnough(coffeeMachine, new Cappuccino()));
                    break;
                case "4": break;
            }
        }
        
        public static String checkWhatIsNotEnough(CoffeeMachine coffeeMachine, Coffee coffee){
            String choice = "";

            if(coffeeMachine.getWater() < coffee.getWater()){
                return "Sorry, not enough water!";
            }else if(coffeeMachine.getMilk() < coffee.getMilk()){
                return "Sorry, not enough milk!";
            }else if(coffeeMachine.getCoffeeBeans()<coffee.getCoffeeBeans()){
                return "Sorry, not enough coffee beans";
            }else if(coffeeMachine.getDisposableCups() < 1){
                return "Sorry, not enough disposable cups";
            }else {
                Console.WriteLine("I have enough resources. The " + coffee.getName() + " costs " + coffee.getMoney() + "$. Would you like to continue? (yes or no)");
                choice = Console.ReadLine();
                if(choice == "yes") {
                    coffeeMachine.setWater(coffeeMachine.getWater() - coffee.getWater());
                    coffeeMachine.setMilk(coffeeMachine.getMilk() - coffee.getMilk());
                    coffeeMachine.setCoffeeBeans(coffeeMachine.getCoffeeBeans() - coffee.getCoffeeBeans());
                    coffeeMachine.setDisposableCups(coffeeMachine.getDisposableCups() - 1);
                    coffeeMachine.setMoney(coffeeMachine.getMoney() + coffee.getMoney());
                    return "Thank you! Making you a coffee!";
                } else {
                    return "You may choose another coffee that you like";
                }
                
            }
        }
        
        public static void fill(CoffeeMachine coffeeMachine){
            Console.WriteLine("Write how many ml of water do you want to add: ");
            coffeeMachine.setWater(Convert.ToInt32(Console.ReadLine()) + coffeeMachine.getWater());
            Console.WriteLine("Write how many ml of milk do you want to add: ");
            coffeeMachine.setMilk(Convert.ToInt32(Console.ReadLine())+  coffeeMachine.getMilk());
            Console.WriteLine("Write how many grams of coffee do you want to add: ");
            coffeeMachine.setCoffeeBeans(Convert.ToInt32(Console.ReadLine()) + coffeeMachine.getCoffeeBeans());
           Console.WriteLine("Write how many disposable cups of coffee do you want to add: ");
            coffeeMachine.setDisposableCups(Convert.ToInt32(Console.ReadLine()) + coffeeMachine.getDisposableCups());
        }

        
        public static void take(CoffeeMachine coffeeMachine){
            Console.WriteLine("I gave you $" + coffeeMachine.getMoney());
            coffeeMachine.setMoney(0);
        }


    }
        
    
}