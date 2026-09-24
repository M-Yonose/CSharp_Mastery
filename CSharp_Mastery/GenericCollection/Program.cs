

using System.Collections;
using System.Collections.Specialized;

List<string> names = new List<string>();
names.Add("jalaluddin");
names.Add("hasan");

names.Clear();

names.Add("tareq");
names.Add("arif");

string friend = names[1];
names[1] = "rafi";

//Key,  Value
Dictionary<string, int> person = new Dictionary<string, int>();
person.Add("jalaluddin", 33);
person.Add("hasan", 22);

int score = person["hasan"];
person["hasan"] = 33;

HashSet<string> s = new HashSet<string>();
s.Add("hasan");
s.Add("arif");
s.Add("hasan");

LinkedList<string> list = new LinkedList<string>();
list.AddLast("arif");
list.AddFirst("monir");

SortedDictionary<string, int> n = new SortedDictionary<string, int>();
n.Add("babul", 33);
n.Add("arif", 22);
n.Add("tareq", 44);

foreach (var item in n)
    Console.WriteLine($"{item.Key}, {item.Value}");

SortedSet<int> m = new SortedSet<int>();
m.Add(44);
m.Add(33);
m.Add(55);
foreach (var item in m)
    Console.WriteLine(item);

Stack<int> stack = new Stack<int>();
stack.Push(20);
int i = stack.Pop();

Queue<int> q = new Queue<int>();
q.Enqueue(i);
int r = q.Dequeue();


ArrayList a = new ArrayList();
a.Add(3);
a.Add(true);
a.Add("hello");

NameValueCollection nvc = new NameValueCollection();
nvc.Add("Hello", "33e");

Stack s2 = new Stack();
Queue q2 = new Queue();

Hashtable h = new Hashtable();

ListDictionary ld = new ListDictionary();




