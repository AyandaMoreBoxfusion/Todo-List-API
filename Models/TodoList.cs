using System;

namespace TodoListAPI.Models
{
	public class TodoList
	{
		public string Id { get; set; }
		public string TaskName { get; set; }
		public bool IsCompleted { get; set; }
		public bool IsPriority { get; set; }
		
	}
}

