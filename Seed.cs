using TodoListAPI.Models;
using ToDoListAPI.Data;

namespace ToDoListAPI
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public Todo Todo { get; private set; }

        public void SeedDataContext()
        {
            if (!dataContext.Todo.Any())
            {
               Todo todo =  new Todo()
                {
                      
                        TaskName = "Do Laundry",
                        IsCompleted = false,
                        IsPriority = true,
                    
                };
            }
        }
    }
}
