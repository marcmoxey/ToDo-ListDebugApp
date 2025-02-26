using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_ListDebug
{
    public static class TodoLogic
    {

        public static List<string> tasks = new();

        public static List<string> AddTask(List<string> tasks)
        {
            
            string userTask;

            do
            {
                Console.Write("Enter a task to add(yes/no): ");
                userTask = Console.ReadLine();
                tasks.Add(userTask);

                

            } while (userTask.ToLower() != "no");

            return tasks;
        }

        public static List<string> RemoveTask(List<string> tasks)
        {
            string taskToRemove;
     

                do
                {

                    Console.Write("Enter the task you want to remove(type 'exit' to quit): ");
                    taskToRemove = Console.ReadLine();


                    if (tasks.Contains(taskToRemove))
                    {
                        tasks.Remove(taskToRemove);
                        Console.WriteLine($"{taskToRemove} was remove from todo list");
                    }
                    else
                    {
                        Console.WriteLine($"{taskToRemove} was not in list");
                    }

                } while (taskToRemove.ToLower() != "exit");
                

            return tasks;
           
        }

        public static List<string> DisplayTasks(List<string> tasks)
        {
            Console.WriteLine("\nToDo List");
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task}");
            }

            return tasks;
        }

        
    }
}
