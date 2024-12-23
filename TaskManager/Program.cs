﻿using System;
using TaskManagerApp; 

class Program
{
    static void Main(string[] args)
    {
        TaskManager manager = new TaskManager();

        while (true)
        {
            Console.WriteLine("\n--- Управление списком дел ---");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Показать список задач");
            Console.WriteLine("4. Выйти");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите задачу: ");
                    string task = Console.ReadLine();
                    manager.AddTask(task); // вызываем метод добавления задачи
                    break;
                case "2":
                    manager.ShowTasks(); // показываем список задач перед удалением
                    Console.Write("Введите номер задачи для удаления: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        manager.RemoveTask(index); // вызываем метод удаления задачи
                    }
                    else
                    {
                        Console.WriteLine("Неверный номер задачи.");
                    }
                    break;
                case "3":
                    manager.ShowTasks(); // вызываем метод отображения задач
                    break;
                case "4":
                    Console.WriteLine("Выход из программы...");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}