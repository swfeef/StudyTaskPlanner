using StudyTaskPlanner.Data;

namespace StudyTaskPlanner.Services;

public class TaskService
{
    private readonly TaskRepository _repository = new();

    public IReadOnlyList<TaskRecord> GetTasks() => _repository.GetAll();

    public void AddTask(TaskRecord task) => _repository.Add(task);
}
