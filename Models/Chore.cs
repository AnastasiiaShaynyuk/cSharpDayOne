using System.ComponentModel.DataAnnotations;

namespace cSharpDayOne.Models;

public class Chore {
  public Chore()
  {
  }

  public Chore(string name, string description, int importance, string color, bool completed, int id) {
    Name = name;
    Description = description;
    Importance = importance;
    Color = color;
    Completed = completed;
    Id = id;
  }


  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  [Range(1, 10)]
  public int Importance { get; set; }
  public string Color { get; set; }
  public bool Completed {get; set; } 

}