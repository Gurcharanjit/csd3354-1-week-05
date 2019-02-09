using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csd3354_1_week05
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Elevator e = new Elevator();
                e.setup();
                e.TraverseList();
            }
        }

        class Node
        {
            public Node() { }
            public Node floor;
            public Node elevatorUp;
            public string FloorNumber;
        }

        class Elevator
        {
            Node Head;
            Node FirstFloor;
            Node SecondFloor;
            Node ThirdFloor;
            Node FourthFloor;

            public void setup()
            {
                FirstFloor = new Node();
                SecondFloor = new Node();
                ThirdFloor = new Node();
                FourthFloor = new Node();
                Head = FirstFloor;
                FirstFloor.FloorNumber = "First Floor";
                FirstFloor.elevatorUp = SecondFloor;
                SecondFloor.FloorNumber = "Second Floor";
                SecondFloor.elevatorUp = ThirdFloor;
                ThirdFloor.FloorNumber = "Third Floor";
                ThirdFloor.elevatorUp = FourthFloor;
                FourthFloor.FloorNumber = "Fourth Floor";
                FourthFloor.elevatorUp = null;
            }

            public void TraverseList()
            {
                Node temp;
                temp = Head;

                // where am I going to start?
                Console.WriteLine("The first floor is " + Head.FloorNumber);
                while (temp != null)
                {
                    // NOW GET TO THE SECOND FLOOR!!!!
                    temp = temp.elevatorUp;
                    Console.WriteLine(temp.FloorNumber);

                }

            }
        }
    }
}