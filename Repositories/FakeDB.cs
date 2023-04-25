namespace cSharpDayOne.Repositories;

public class FakeDB
{
  public List<Chore> Chores;

public FakeDB() {
    Chores = new List<Chore>();
    Chores.Add(new Chore("Do laundry", "Wash and fold my laundry", 5, "green", false, 1));
    Chores.Add(new Chore("Wash dishes", "Make my dishes clean", 7, "orange", false, 2));
    Chores.Add(new Chore("Walking Cat", "My Cat needs to go for a walk", 10, "red", false, 3));
    Chores.Add(new Chore("Cook lunch", "Prepare lunch for a week", 6, "yellow", false, 4));
    
  }
}