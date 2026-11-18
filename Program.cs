// Probe.Run();

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(alexander);
guild.AddHero(sergey);

List<Hero> members = guild.GetMembers();

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.MemberCount}");

if (members.Count > 0) {
    Console.WriteLine($"Первый: {members[0].Name}");
    Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in members) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

Hero? found = guild.FindHeroByName(" аРтЁм ");
if (found != null) {
    Console.WriteLine($"Найден по запросу \" аРтЁм \": {found.Name}");
} else {
    Console.WriteLine("По запросу \" аРтЁм \" никого нет.");
}

Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");
Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
Console.WriteLine($"Участников после проверок: {guild.MemberCount}");

int strongCount = 0;
foreach (Hero hero in members) {
    if (hero.Health >= 120) {
        strongCount += 1;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");

if (members.Count > 0) {
    Hero strongest = members[0];
    foreach (Hero hero in members) {
        if (hero.Health > strongest.Health) {
            strongest = hero;
        }
    }
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}


book first  = new book("Мастер и Маргарита",5,"роман",1290);
book second = new book("Дюна",3,"фантастика",1590);
book third  = new book("Шерлок Холмс",7,"детектив",890);

List<book> shelf = new List<book>();
shelf.Add(first);
shelf.Add(second);
shelf.Add(third);

Console.WriteLine($"Книг на полке: {shelf.Count}");

if (shelf.Count > 0) {
    Console.WriteLine($"Первая: {shelf[0].Name}");
    Console.WriteLine($"Последняя: {shelf[shelf.Count - 1].Name}");
}

Console.WriteLine();
foreach (book b in shelf) {
    Console.WriteLine($"{b.Name} - {b.Genre}, цена {b.Price}, на складе {b.Count}");
}

book fourth = new book("Улитка на склоне",2,"фантастика",750);
shelf.Add(fourth);
Console.WriteLine($"После добавления книги: {shelf.Count}");

int expensive = 0;
foreach (book b in shelf) {
    if (b.Price > 1000) {
        expensive += 1;
    }
}
Console.WriteLine($"Книг дороже 1000: {expensive}");

second.Restock(3);
Console.WriteLine($"Через переменную: {second.Count}");
Console.WriteLine($"Через полку: {shelf[1].Count}");