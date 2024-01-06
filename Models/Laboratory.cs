namespace MvcLabManager.Models;

public class Laboratory
{
    public int Id { get; set; }
    public int Number { get; set; }
    public string Name { get; set; }
    public string Block { get; set; }

    public Laboratory() { }

    public Laboratory(int id, int number, string name, string block)
    {
        Id = id;
        Number = number;
        Name = name;
        Block = block;
    }
}