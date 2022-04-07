using System;
using ToDoListAPI;


namespace TodoListAPI.Models
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPriority { get; set; }
        //public Todo? Todo { get; internal set; }
    }
}

