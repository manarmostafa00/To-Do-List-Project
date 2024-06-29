using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

  namespace TO_DO_LIST
{
    class Program

    {
        static List<string> toDoList = new List<string>();
        static void Main(string[] args)

        {
            Console.WriteLine("To Do List");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1.Add task");
                Console.WriteLine("2.Mark task completed");
                Console.WriteLine("3.View All Tasks In the to-do list");
                Console.WriteLine("4.Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;

                    case "2":
                        MarkTaskIsCompleted();
                        break;

                    case "3":
                        ViewAllTasks();
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Please enter a number from 1 to 4.");
                        break;
                }
            }
        }


        static void AddTask()
        {
            Console.Write("Enter Your New Task: ");
            string task = Console.ReadLine();
            toDoList.Add(task);
            Console.WriteLine("Done");
        }
        static void MarkTaskIsCompleted()
        {
            if (toDoList.Count == 0)
            {
                Console.WriteLine("No tasks");
                return;
            }
            Console.WriteLine("To-Do List:");
            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {toDoList[i]}");
            }

            Console.Write("Please Enter the number of the task: ");

            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                if (taskNumber >= 1 && taskNumber <= toDoList.Count)
                {
                    Console.WriteLine($"Marked task '{toDoList[taskNumber - 1]}' as completed.");
                    toDoList.RemoveAt(taskNumber - 1);
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        static void ViewAllTasks()
        {
            if (toDoList.Count == 0)
            {
                Console.WriteLine("No tasks");
            }
            else
            {
                Console.WriteLine("To-Do List:");
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {toDoList[i]}");
                }
            }
        }
    }
}

