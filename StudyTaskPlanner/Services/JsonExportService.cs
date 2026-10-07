using System.Text.Json;
using StudyTaskPlanner.Data;

namespace StudyTaskPlanner.Services;

public class JsonExportService
{
    public string Export(IEnumerable<TaskRecord> tasks)
    {
        return JsonSerializer.Serialize(tasks, new JsonSerializerOptions
        {
            WriteIndented = true
        });
    }
}
