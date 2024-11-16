public class TodoItemDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }

    public TodoItemDTO() { }

    // => = Expression-bodied Constructor
    // (Id, Name, IsComplete) = (todoItem.Id, todoItem.Name, todoItem.IsComplete); =  on the left-hand side is a tuple deconstruction, which initializes multiple variables or properties from a tuple on the right-hand side.
    public TodoItemDTO(Todo todoItem) =>
    (Id, Name, IsComplete) = (todoItem.Id, todoItem.Name, todoItem.IsComplete);
}
