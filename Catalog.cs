public class Catalog {
    private List<book> _books = new List<book>();

    public int BookCount {
        get { return _books.Count; }
    }

    public bool AddBook(book item) {
        if (FindBook(item.Name) != null) {
            return false;
        }

        _books.Add(item);
        return true;
    }

    public book? FindBook(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return null;
        }

        string searchName = name.Trim();

        foreach (book item in _books) {
            if (string.Equals(item.Name, searchName, StringComparison.OrdinalIgnoreCase)) {
                return item;
            }
        }

        return null;
    }

    public bool RemoveBook(string name) {
        book? item = FindBook(name);
        if (item == null) {
            return false;
        }
        return _books.Remove(item);
    }

    public List<book> GetBooks() {
        List<book> result = new List<book>();
        foreach (book item in _books) {
            result.Add(item);
        }
        return result;
    }

    public int CountExpensive(int minPrice) {
        int count = 0;
        foreach (book item in _books) {
            if (item.Price >= minPrice) {
                count += 1;
            }
        }
        return count;
    }
}