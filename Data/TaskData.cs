using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace TrelloButInBlazor.Data
{
    public class TaskData
    {
        public string name { get; set; }
        public string description { get; set; }

        public List<TaskChecklistData> checklists { get; set; }
        [JsonConstructor]
        public TaskData(string name = "New Task", string description = "", List<TaskChecklistData> checklists = null)
        {
            this.name = name;
            this.description = description;
            if (checklists == null)
                this.checklists = new List<TaskChecklistData>();
            else
                this.checklists = checklists;
        }

        public TaskData(TaskData copyFrom)
        {
            name = copyFrom.name;
            description = copyFrom.description;
            if (checklists == null)
                checklists = new List<TaskChecklistData>();
            else
                checklists = copyFrom.checklists;
        }
    }

    public class TaskChecklistData
    {
        public string checklistName { get; set; }
        public List<TaskChecklistItemData> list { get; set; }

        [JsonConstructor]
        public TaskChecklistData(string checklistName, List<TaskChecklistItemData> list)
        {
            this.checklistName = checklistName;
            this.list = list;
        }
    }

    public class TaskChecklistItemData
    {
        public bool value { get; set; }
        public string name { get; set; }

        [JsonConstructor]
        public TaskChecklistItemData(bool value, string name)
        {
            this.value = value;
            this.name = name;
        }
    }

}
