namespace StudyTaskPlanner.Data;

public class TaskRepository
{
    private readonly List<TaskRecord> _tasks = new();

    public IReadOnlyList<TaskRecord> GetAll() => _tasks;

    public void Add(TaskRecord task) => _tasks.Add(task);
}
