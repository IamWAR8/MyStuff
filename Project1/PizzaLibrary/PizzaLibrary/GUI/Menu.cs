﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary.GUI
{
    class Menu
    {
        public void User()
        {
           
            Console.WriteLine("Please enter your : ");
            Console.WriteLine("FirstName: ");
            String name = Console.ReadLine();
            Console.WriteLine("LastName: ");
            String lname = Console.ReadLine();
            // new implemtation for tomorrow -> this part will be a select AdressLine1 from Locations; and then display
            // to the user, then the user will press the ID and then a search method will be activated to search if the
            // ID is equal to the input of the user (will need a parse and its own draw, the user will have to reenter his data or loop )
            //Console.WriteLine("Choose your Location:\n" +
            //    "1. Reston\n2. Florida\n3. Washington \n press the number or write the city you would like to choose");
            //string Choose = Console.ReadLine();
            //while (loop)
            //{
            //    if (Choose == "1" || Choose == "Reston")
            //    {
            //        loc = "Reston";
            //        loop = false;
            //    }
            //    else if (Choose == "2" || Choose == "Florida")
            //    {
            //        loc = "Florida";
            //        loop = false;
            //    }
            //    else if (Choose == "3" || Choose == "Washington")
            //    {
            //        loc = "Washington";
            //        loop = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Try Agian or press X to Exit");
            //        input = Console.ReadLine();
            //        if (input.ToUpper() == "X") { Exit(); }
            //   }
            // }
            StoreLocation();
        }
        public void NewUser()
        {
            StoreLocation();
        }
        public void StartingMenu()
        {
            Console.WriteLine("Press 1 to Register or Press 2 if you are a returning customer press x to exit ");
            string Input = Console.ReadLine();
            if (Input.Equals("1"))
            {
                NewUser();
            }
            else if (Input.Equals("2"))
            {
                User();
            }
            else if (Input.ToLower().Equals("x"))
            {
                Exit();


            }
            else { Console.WriteLine("Wrong Input try Again"); StartingMenu(); }
        }
        public void MainMenu()
        {
            Console.WriteLine("Welcome to Pizza Store: "+
                "How can I help you today?" +
                "Press 1. to Order a pizza\n" +
                "Press 2. to search users by name\n" +
                "Press 3. to display a detail of an order\n" +
                "Press 4. to display all orders history of a location\n" +
                "Press 5. to display all orders histpry of a user" +
                "Press 6. to sorting order history" +
                "press x. to exit the apication");
            string input = Console.ReadLine();
            switch (input.ToUpper()) //Returns input
            {
                case "1":

                    break;
                case "2":
                    break;
                case "3":


                    break;
                case "4":


                    break;
                case "5":

                    break;
                case "6":

                    break;
                case "X":

                    break;
                default:

                    break;
            }
        }
        public void StoreLocation()
        {
            OrderingInput();
        }
        public void OrderingInput()
        {
            MakingPizzaInput();
        }
        public void MakingPizzaInput()
        {

        }

        private void Exit()
        {
            Console.WriteLine("Bye, come again");
            System.Environment.Exit(0);
        }

    }
}
