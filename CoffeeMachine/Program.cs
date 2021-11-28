using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine defaulCoffeeMachine = new CoffeeMachine(400, 540, 120, 9, 550);
            
            bool exit = false;
            String inputValue = "";
            while(!exit){
                Console.WriteLine("Write action (buy, fill, take, remaining, exit)");
                inputValue = Console.ReadLine();

                if(inputValue == "buy"){
                    CoffeeMachine.buy(defaulCoffeeMachine);
                }else if(inputValue == "fill"){
                    CoffeeMachine.fill(defaulCoffeeMachine);
                }else if(inputValue == "take"){
                    CoffeeMachine.take(defaulCoffeeMachine);
                }else if(inputValue == "remaining"){
                    CoffeeMachine.showSupply(defaulCoffeeMachine);
                }else if(inputValue == "exit"){
                    exit = true;
                }
            }
        }
    }
}