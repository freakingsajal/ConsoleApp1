namespace collection
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            /* var MyList = new List<string>();
             MyList.Add("Apple");
             MyList.Add("banana");
             MyList.Add("mango");
             MyList.Add("orange");
             MyList.Add("watermelon");
             //MyList.Add("watermelon");
             foreach (var item in MyList)
             {
                 Console.WriteLine(item);
             }*/
            /*var newHash = new HashSet<int>();
             newHash.Add(1);
             newHash.Add(2);
             newHash.Add(3);
             newHash.Add(4);
             newHash.Add(5);
             newHash.Add(5);
             foreach (var item in newHash)
             {
                 Console.WriteLine(item);
             }*/
            /* var newSortedSet = new SortedSet<int>();
             newSortedSet.Add(1);
             newSortedSet.Add(10);
             newSortedSet.Add(2);
             newSortedSet.Add(50);
             newSortedSet.Add(42);
             newSortedSet.Add(2);

             foreach (var item in newSortedSet)
             {
                 Console.WriteLine(item);
             }

             var newSortedSetString = new SortedSet<String>();
             newSortedSetString.Add("mango");
             newSortedSetString.Add("orange");
             newSortedSetString.Add("banana");
             newSortedSetString.Add("mango");
             newSortedSetString.Add("kiwi");
             newSortedSetString.Add("orange");

             foreach (var item in newSortedSetString)
             {
                 Console.WriteLine(item);
             }*/

            /*  var stack = new Stack<int>();
              stack.Push(1);
              stack.Push(2);
              stack.Push(3);
              stack.Push(4);
              stack.Push(5);
              foreach(var item in stack)
              {
                  Console.WriteLine(item);
              }
              Console.WriteLine("next");
              Console.WriteLine(stack.Peek());
              Console.WriteLine(stack.Pop());
              Console.WriteLine(stack.Peek());
              Console.WriteLine("next");
              foreach (var item in stack)
              {
                  Console.WriteLine(item);
              }*/


            /*   var queue = new Queue<int>();
                 queue.Enqueue(1);
                 queue.Enqueue(2);
                 queue.Enqueue(3);
                 queue.Enqueue(4);
                 queue.Enqueue(5);
                 foreach (var item in queue)
                 {
                     Console.WriteLine(item);
                 }
                 Console.WriteLine("next");
                 Console.WriteLine(queue.Peek());
                 Console.WriteLine(queue.Dequeue());
                 Console.WriteLine(queue.Peek());
                 Console.WriteLine("next");

                 foreach (var item in queue)
                 {
                     Console.WriteLine(item);
                 }*/

            /*var linkedList = new LinkedList<string>();
            linkedList.AddLast("a");
            linkedList.AddLast("b");
            linkedList.AddLast("c");
            linkedList.AddLast("d");
            linkedList.AddLast("e");
            linkedList.AddLast("f");
            linkedList.AddFirst("g");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("next");
            LinkedListNode<string> linknode= linkedList.Find("d");
            linkedList.AddAfter(linknode,"r");
            linkedList.AddAfter(linknode, "t");
            Console.WriteLine("item");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }*/
            /* Dictionary<string, string> dictionary = new Dictionary<string, string>();
             dictionary.Add("1", "apple");
             dictionary.Add("2", "orange");
             dictionary.Add("3", "banana");
             dictionary.Add("4", "kiwi");
             dictionary.Add("5", "kiwi");
             foreach(KeyValuePair<string,string> keyValue in dictionary)
             {
                 Console.WriteLine(keyValue);
             }
             Console.WriteLine("next");
             dictionary.Remove("1");
             foreach (KeyValuePair<string, string> keyValue in dictionary)
             {
                 Console.WriteLine(keyValue);
             }*/


           /* SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
            dictionary.Add("1", "apple");
            dictionary.Add("2", "orange");
            dictionary.Add("3", "banana");
            dictionary.Add("5", "kiwi");
            dictionary.Add("4", "kiwi");
            foreach (KeyValuePair<string, string> keyValue in dictionary)
            {
                Console.WriteLine(keyValue);
            }
            Console.WriteLine("next");
            dictionary.Remove("1");
            foreach (KeyValuePair<string, string> keyValue in dictionary)
            {
                Console.WriteLine(keyValue);
            }*/

            SortedList<int,string> list = new SortedList<int,string>();
            list.Add(1, "Apple");
            list.Add(2, "Appl");
            list.Add(4, "Appe");
            list.Add(3, "Ale");
            list.Add(6, "pple");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }














        }
    }
}