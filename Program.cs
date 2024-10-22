using static CustomList.List;

CustomList<int> list = new CustomList<int>();

list.Add(21);
list.Add(52);
list.Add(33);
list.Add(54);
list.Add(50);

list.PrintList();

Console.WriteLine(list.Get(2));

list.Remove(2); 

list.PrintList();