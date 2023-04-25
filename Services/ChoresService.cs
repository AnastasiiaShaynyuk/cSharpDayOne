namespace cSharpDayOne.Services;

public class ChoresService
{
  private readonly ChoresRepository _repo;
  public ChoresService(ChoresRepository repo)
  {
    _repo = repo;
  }

  internal Chore Create(Chore choreData)
  {
    return _repo.Create(choreData);
  }

  internal List<Chore> Get()
  {
    List<Chore> chores = _repo.Get();
    return chores;
  }

  internal Chore GetOne(int choreId)
  {
Chore chore = _repo.GetOne(choreId);
if (chore == null) throw new Exception($"No chore at id {choreId}");
return chore;
  }

  internal string Remove(int choreId)
  {
Chore chore = this.GetOne(choreId);
_repo.Remove(choreId);
return $"{chore.Name} is done";
  }
}