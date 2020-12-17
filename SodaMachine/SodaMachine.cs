﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //Member Variables (Has A)
        private List<Coin> _register;
        private List<Can> _inventory;

        //Constructor (Spawner)
        public SodaMachine()
        {
            _register = new List<Coin>();
            _inventory = new List<Can>();
            FillInventory();
            FillRegister();
        }

        //Member Methods (Can Do)

        //A method to fill the sodamachines register with coin objects.
        public void FillRegister()
        {
            // I want to add coin objects to my register
            // 20 quarters, 10 dimes, 20 nickels, 50 pennies
            // Create coin objects
            // Then add them to the register
            // A for loop would allow us to do the "create coin, then add" operation
            // multiple times and stop at a certain number

            for (int i = 0; i <= 20; i++)
            {
                Quarter quarter = new Quarter();
                _register.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                _register.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                _register.Add(nickel);
            }
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                _register.Add(penny);

            }


    
        }     
        //A method to fill the sodamachines inventory with soda can objects.
        public void FillInventory()
        {
            this.GetSodaFromInventory(_inventory);
        }

        private void GetSodaFromInventory(List<Can> inventory)
        {
            throw new NotImplementedException();
        }

        //Method to be called to start a transaction.
        //Takes in a customer which can be passed freely to which ever method needs it.
        public void BeginTransaction(Customer customer)
        {
            bool willProceed = UserInterface.DisplayWelcomeInstructions(_inventory);
            if (willProceed)
            {
                Transaction(customer);
            }
        }
        
        //This is the main transaction logic think of it like "runGame".  This is where the user will be prompted for the desired soda.
        //grab the desired soda from the inventory.
        //get payment from the user.
        //pass payment to the calculate transaction method to finish up the transaction based on the results.
        private void Transaction(Customer customer)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please select which soda you would like");
            Console.ReadLine();
        }
        //Gets a soda from the inventory based on the name of the soda.
        private Can GetSodaFromInventory(string nameOfSoda)
        {
            foreach (Can item in _inventory)
            {
                if (item.Name == nameOfSoda)
                {
                    return item;
                }
            }
            return null;


        }
            //This is the main method for calculating the result of the transaction.
            //It takes in the payment from the customer, the soda object they selected, and the customer who is purchasing the soda.
            //This is the method that will determine the following:
            //If the payment is greater than the price of the soda, and if the sodamachine has enough change to return: Dispense soda, and change to the customer.
            //If the payment is greater than the cost of the soda, but the machine does not have ample change: Dispense payment back to the customer.
            //If the payment is exact to the cost of the soda:  Dispense soda.
            //If the payment does not meet the cost of the soda: dispense payment back to the customer.
            private void CalculateTransaction(List<Coin> payment, Can chosenSoda, Customer customer)
        {
            bool something = RegisterHasCoin("Dime");
        }



        //Takes in the value of the amount of change needed.
        //Attempts to gather all the required coins from the sodamachine's register to make change.
        //Returns the list of coins as change to despense.
        //If the change cannot be made, return null.
        private List<Coin> GatherChange(double changeValue)
        {
             // you need a list coin to return
            while (true) //while there is still change due
            {

                if (changeValue > 0.25 && RegisterHasCoin("Quarter"))
                {
                    return _register;

                }
                
                else if (changeValue > 0.10 && RegisterHasCoin("Dime"))
                {
                    return _register;

                }
                else if (changeValue > .01 && RegisterHasCoin("Penny"))
                {
                    return _register;

                }
                else if (changeValue > 0.05 && RegisterHasCoin("NIckel"))
                {
                    return _register;

                }
                return null;

                

               
            }
        }
        //Reusable method to check if the register has a coin of that name.
        //If it does have one, return true.  Else, false.
        private bool RegisterHasCoin(string name)
        {
            for (int i = 0; i < _register.Count; i++)
            {
                if (_register[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        //Reusable method to return a coin from the register.
        //Returns null if no coin can be found of that name.
        private Coin GetCoinFromRegister(string name)
        {
            for (int i = 0; i < _register.Count; i++)
            {
                if (_register[i].Name == name)
                {
                    return _register[i];
                }
            }
            return null;

        }
        //Takes in the total payment amount and the price of can to return the change amount.
        private double DetermineChange(double totalPayment, double canPrice)
        {

           double subtract = totalPayment -= canPrice;

        }
         

        //Takes in a list of coins to returnt he total value of the coins as a double.
        private double TotalCoinValue(List<Coin> payment)
        {
            double coinValuesTotal = 0;
            foreach (Coin item in payment)
            {
                coinValuesTotal += item.Value;
            }
            return coinValuesTotal;

        }
        double valueOfCoinsInWallet = TotalCoinValue(Wallet.coinList);
        
        
        //Puts a list of coins into the soda machines register.
        private void DepositCoinsIntoRegister(List<Coin> coins)
        {
            for (int i = 0; i < _register.Count; i++)
            {

                if (_register[i].Count = DepositCoinsIntoRegister)
                {
                    return _register[i];
                }
                return false;




            }

        }
    }
}
