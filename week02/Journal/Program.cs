// I have exceeded the requirements by making a Menu.cs class and by allowing the user to read/write either .txt or.json files.
using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        Menu myMenu = new Menu();
        
        while(running){
            myMenu.DisplayMenu();
            myMenu.MenuOption();
            running = myMenu.runChoice();
        }

    }
}