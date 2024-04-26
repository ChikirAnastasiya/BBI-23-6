using System.Text.Json;
using System.Text.Json.Serialization;


#region
abstract class Task
{
    protected string text = "No text here yet";

    public string Text
    {
        get => text;
        protected set => text = value;
    }
    public Task(string text)
    { this.text = text;
    }
}
#endregion
#region

class Task1 : Task
{
    [JsonConstructor]
    public Task1(string text) : base(text) { }
    public override string ToString()
    {
        return text;
    }
}
class Task2: Task
{
    private int amount = 1;
    public int Amount
    {
        get => amount;
        private set => amount = value;
    }
    [JsonConstructor]
    public Task2(string text, int amount = 0): base(text)
    {
        this.amount = amount;
    }
    public override string ToString ()

}