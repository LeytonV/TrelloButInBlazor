using System.Text.Json.Serialization;
using TrelloButInBlazor.Data;

public class CardData
{
    public string name { get; set; }
    public List<TaskData> tasks { get; set; }
    public CardData(string name)
    {
        this.name = name;
        this.tasks = new List<TaskData>();
    }
	[JsonConstructor]
	public CardData(string name, List<TaskData> tasks)
	{
		this.name = name;
		this.tasks = tasks;
	}
}
