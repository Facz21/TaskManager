using TaskStatus = Task.Domain.Enums.TaskStatus;
using TaskPriority = Task.Domain.Enums.TaskPriority;


namespace Task.Domain.Entities;

public class TaskItem
{
    public Guid Id { get; set; }
    public Guid ProjectId { get; set; }
    public Project? Project { get; set; }
    
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public TaskStatus Status { get; set; } = TaskStatus.Pending;
    public TaskPriority Priority { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}