using System;
using System.Collections.Generic;

namespace Zork
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

           //tring CurrentRoom = Rooms[0];

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing";
                        break;

                    case Commands.LOOK:
                        outputString = "There is an open field west of a white house, with a boarded door. \nA rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = $"You moved {command}.";
                        break;

                    default:
                        outputString = "Unknown command";
                        break;

                }

                Console.WriteLine(outputString);
            }

        }

        private string[] Rooms = new string[5] { "Forest", "West of House", "Behind House", "Clearing", "Canyon View" };

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
        }
  }

