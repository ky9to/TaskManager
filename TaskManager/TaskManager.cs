using System;
using System.Collections.Generic;

namespace TaskManagerApp
{
    public class TaskManager
    {
        private List<string> todoList; // Список задач

        public TaskManager()
        {
            todoList = new List<string>();
        }

        // Добавление задачи
        public void AddTask(string task)
        {
            todoList.Add(task);
            Console.WriteLine($"Задача \"{task}\" добавлена.");
        }

        // Удаление задачи
        public void RemoveTask(int index)
        {
            if (index > 0 && index <= todoList.Count)
            {
                string removedTask = todoList[index - 1];
                todoList.RemoveAt(index - 1);
                Console.WriteLine($"Задача \"{removedTask}\" удалена.");
            }
            else
            {
                Console.WriteLine("Неверный номер задачи.");
            }
        }

        // Отображение списка задач
        public void ShowTasks()
        {
            if (todoList.Count == 0)
            {
                Console.WriteLine("Список задач пуст.");
                return;
            }

            Console.WriteLine("Список задач:");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }
    }
}