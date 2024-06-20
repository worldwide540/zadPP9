using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Просмотреть задачи");
            Console.WriteLine("2. Добавить задачу");
            Console.WriteLine("3. Удалить задачу");
            Console.WriteLine("4. Редактировать задачу");
            Console.WriteLine("5. Выйти");

            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayTasks();
                    break;
                case "2":
                    AddTask();
                    break;
                case "3":
                    RemoveTask();
                    break;
                case "4":
                    EditTask();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, попробуйте снова.");
                    break;
            }
        }
    }

    static void DisplayTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст.");
        }
        else
        {
            Console.WriteLine("Список задач:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Введите новую задачу: ");
        string newTask = Console.ReadLine();
        tasks.Add(newTask);
        Console.WriteLine("Задача успешно добавлена.");
    }

    static void RemoveTask()
    {
        DisplayTasks();
        if (tasks.Count == 0)
        {
            return;
        }

        Console.Write("Введите номер задачи для удаления: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("Задача успешно удалена.");
        }
        else
        {
            Console.WriteLine("Некорректный номер задачи.");
        }
    }

    static void EditTask()
    {
        DisplayTasks();
        if (tasks.Count == 0)
        {
            return;
        }

        Console.Write("Введите номер задачи для редактирования: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            Console.Write("Введите новое описание задачи: ");
            string newDescription = Console.ReadLine();
            tasks[taskNumber - 1] = newDescription;
            Console.WriteLine("Задача успешно отредактирована.");
        }
        else
        {
            Console.WriteLine("Некорректный номер задачи.");
        }
    }
}

