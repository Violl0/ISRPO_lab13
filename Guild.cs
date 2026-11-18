public class Guild {
    private List<Hero> _heroes = new List<Hero>();

    public string Name { get; private set; }

    public int MemberCount {
        get { return _heroes.Count; }
    }

    public Guild(string name) {
        Name = name;
    }

    public bool AddHero(Hero hero) {
        _heroes.Add(hero);
        return true;
    }

    public List<Hero> GetMembers() {
        List<Hero> result = new List<Hero>();
        foreach (Hero hero in _heroes) {
            result.Add(hero);
        }
        return result;
    }
}