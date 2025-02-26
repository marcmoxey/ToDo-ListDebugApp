

using ToDo_ListDebug;

/*
 * 
 * Build a simple to-do list application where users can add, remove, and view tasks. Use breakpoints
 * to debug the task management logic.
 * 
 * Steps:
 * Create a list to store tasks.
 * Add functionality to add, remove, and display tasks.
 * Set breakpoints to inspect the list after each operation (e.g., after adding a task, after 
 * removing a task).
 * Debug edge cases, such as removing a task from an empty list.
 * 
 */


List<string> tasks = TodoLogic.tasks; // Empty List
string userChoice;

do
{
	Console.WriteLine("1. Add a task to list");
	Console.WriteLine("2. Remove a task to list");
	Console.WriteLine("3. Display task  list");
	Console.WriteLine("4. Exit");
	userChoice = Console.ReadLine();

	switch (userChoice)
	{
		case "1":
			TodoLogic.AddTask(tasks);
			break;
		case "2":
			// check if list is empty
			if (tasks.Count == 0)
			{
				Console.WriteLine($"There nothing in the list to remove");

			}
			else
			{
				TodoLogic.RemoveTask(tasks);
			}

			break;
		case "3":
			TodoLogic.DisplayTasks(tasks);
			break;
		case "4":
			break;
		default:
			Console.WriteLine("Please enter a valid choice");
			break;
	} 
} while (userChoice != "4");