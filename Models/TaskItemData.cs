namespace CRUDCalendar.Models
{
    public class TaskItemData
    {
        public DateOnly _taskDate;
        public Dictionary<DateOnly, Dictionary<TimeOnly, string>> _taskList = new();


        public TaskItemData(DateOnly taskDate)
        {
            _taskDate = taskDate;


        }
        public void AddTask(TimeOnly taskTime,string taskToBeAdded)
        {
            if (!_taskList.ContainsKey(_taskDate))
            {
                _taskList[_taskDate] = new Dictionary<TimeOnly, string>();
            }
            _taskList[_taskDate][taskTime] = taskToBeAdded;



        }
    }
    
}


   