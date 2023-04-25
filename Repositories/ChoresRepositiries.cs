namespace cSharpDayOne.Repositories;

public class ChoresRepository {
  private readonly FakeDB _db; 
  public ChoresRepository(FakeDB db)
  {
    _db = db;
  }

  internal Chore Create(Chore choreData) 
  {
    int choreId = _db.Chores[_db.Chores.Count - 1].Id + 1;
    Chore newChore = new Chore(choreData.Name, choreData.Description, choreData.Importance, choreData.Color, choreData.Completed, choreId);
    _db.Chores.Add(newChore);
    return newChore;
  }

  internal List<Chore> Get()
  {
    return _db.Chores;
  }

  internal Chore GetOne(int choreId)
  {
Chore chore = _db.Chores.Find(c => c.Id == choreId);
return chore;
  }

  internal void Remove(int choreId)
  {
Chore chore = this.GetOne(choreId);
_db.Chores.Remove(chore);
  }
}