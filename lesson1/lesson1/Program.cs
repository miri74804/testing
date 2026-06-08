
//10
using lesson1;

static int NumDigits(Node<int> n)
{
    int count = 0;
    while (n != null)
    {
        count++;
        n = n.GetNext;
    }
    return count;
}

static int Compare(Node<int> n1, Node<int> n2)
{
    int numDigits1 = NumDigits(n1), numDigits2 = NumDigits(n2);
    if (numDigits1 > numDigits2)
        return 1;
    if (numDigits2 > numDigits1)
        return 2;

    //במקרה שמספר הספרות שווה

    while (n1 != null)
    {
        if (n1.GetValue > n2.GetValue)
            return 1;
        if (n2.GetValue > n1.GetValue)
            return 2;

        n1 = n1.GetNext;
        n2 = n2.GetNext;
    }
    return 0;
}


//29
static void One(Queue<int> q, int k)
{
    int count = q.Count, current;

    while (count > 0)
    {
        current = q.Dequeue();
        for (int i = 0; i < k; i++)
            q.Enqueue(current);
        count--;
    }
}
Queue<int> q = new Queue<int>();
q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);
q.Enqueue(4);

for (int i = 0; i < q.Count; i++)
{
    int x = q.Dequeue();
    Console.Write(x + " ");
    q.Enqueue(x);
}

One(q, 3);

Console.WriteLine();
for (int i = 0; i < q.Count; i++)
{
    int x = q.Dequeue();
    Console.Write(x + " ");
    q.Enqueue(x);
}


static void Two(Queue<int> q, int k)
{
    Queue<int> tmp = new Queue<int>();
    int c = q.Count;
    for (int i = 0; i < c; i++)
    {
        int x = q.Dequeue();
        tmp.Enqueue(x);
        q.Enqueue(x);
    }

    for (int i = 1; i < k; i++)
    {
        for (int j = 0; j < c; j++)
        {
            int x = tmp.Dequeue();
            q.Enqueue(x);
            tmp.Enqueue(x);
        }
    }
}

Console.WriteLine();
Two(q, 3);
for (int i = 0; i < q.Count; i++)
{
    int x = q.Dequeue();
    Console.Write(x + " ");
    q.Enqueue(x);
}


//16
static MyNode AddNumber(MyNode list, int val, int position)
{
    int count = 0;
    MyNode temp = list;

    while (temp != null)
    {
        count++;
        temp = temp.Next;
    }

    if (position > count + 1 || position < 1)
        return list;

    MyNode newNode = new MyNode(val);

    if (position == 1)
    {
        newNode.Next = list;
        list = newNode;
    }
    else
    {
        MyNode prev = list;
        for (int i = 1; i < position - 1; i++)
            prev = prev.Next;

        newNode.Next = prev.Next;
        prev.Next = newNode;
    }

    MyNode before = list;
    while (before != newNode)
    {
        if (before.Value < val)
            before.HowManyBig++;
        before = before.Next;
    }

    MyNode after = newNode.Next;
    while (after != null)
    {
        if (after.Value > val)
            newNode.HowManyBig++;
        after = after.Next;
    }

    return list;
}

//5
static bool IsPerfectN(Queue<int> q, int n)
{
    int[] counter = new int[n+1];
    Queue<int> p = new Queue<int>(q);
    int count = 0, curr;

    while (p.Count > 0)
    {
        curr= p.Dequeue();
        count++;
        if(curr <= n && curr >= 1)
            counter[curr]++;
    }

    for (int i = 1; i < counter.Length; i++)
    {
        if(counter[i] == 0)
            return false;
    }
    return true;
}