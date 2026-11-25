//Console.WriteLine("Hello, World!");
using System.ComponentModel.Design;
using System.Threading;

bool supersecretdevmode = false;
bool superdupersecretdevmode = false;
bool xnegative = false;
bool ynegative = false;
string a = "";
string[] x;
string c = "";
string[] y;
string operand;
bool xparsecomplete = false;
bool yparsecomplete = false;
List<object> positive = new List<object>();
List<object> negative = new List<object>();
List<object> positive2 = new List<object>();
List<object> negative2 = new List<object>();
List<object> finalpositive = new List<object>();
List<object> finalnegative = new List<object>();
List<object> final = new List<object>();
List<object> i = new List<object>();
List<object> i2 = new List<object>();
List<object> i3 = new List<object>();
List<object> i4 = new List<object>();
List<object> i5 = new List<object>();
List<object> i6 = new List<object>();
List<object> xlength = new List<object>();
List<object> ylength = new List<object>();
//just some setup stuff, and also random letters used later because c# scopes^

Console.WriteLine("hi, this calculator doesnt use mathimatical operators");

Console.WriteLine("whats ya first number");
while (true)
{
    a = "";
    a = Console.ReadLine();

    //process that input frfr

    if (a == "")
    {
        continue;
    }

    if (a == "opensesame")
        supersecretdevmode = true;
    if (a == "saysopensesame")
    {
        supersecretdevmode = true;
        superdupersecretdevmode = true;
    }

    x = a.Split('.');

    if (double.TryParse(a, out _) == false && a != "opensesame" && a != "saysopensesame")
    {
        Console.WriteLine("i think the code hates you idk, try again");
    }
    if (a == "opensesame" || a == "saysopensesame")
    {
        Console.WriteLine("i think the code likes you idk, try again");
    }
    if (double.TryParse(a, out _) == true)
    {
        break;
    }
}

Console.WriteLine("whats ya second number");
while (true)
{
    c = "";
    c = Console.ReadLine();

    //process that input frfr

    if (c == "")
    {
        continue;
    }

    if (c == "opensesame")
        supersecretdevmode = true;

    y = c.Split('.');
    if (double.TryParse(c, out _) == false)
    {
        Console.WriteLine("i think the code hates you idk, try again");
    }
    else
        break;
}

Console.WriteLine("what doth thyne operation of choice be...");
while (true)
{
    operand = Console.ReadLine();

    if (operand != "+" && operand != "-" && operand != "x" && operand != "/")
    {
        Console.WriteLine("try again i think");
    }
    else
    {
        break;
    }
}

//flags if y inputs are negative and removes negative sign so loops can work
if (y[0][0] == '-')
{
    ynegative = true;
    y[0] = y[0].Remove(0, 1);
}


Console.WriteLine("processing inputs...");

//flags if inputs x are negative and removes negative sign so loops can work
if (x[0][0] == '-')
{
    xnegative = true;
    x[0] = x[0].Remove(0, 1);
}


//determines x and y input precision
while (i.Count < x[0].Length)
{
    i.Add(null);
    xlength.Add(null);
}

while (i.Count > 0)
{
    i.Remove(null);
}

if (x.Length > 1)
    while (i.Count < x[1].Length)
    {
        i.Add(null);
        xlength.Add(null);
    }

while (i.Count > 0)
{
    i.Remove(null);
}

while (i.Count < y[0].Length)
{
    i.Add(null);
    ylength.Add(null);
}

while (i.Count > 0)
{
    i.Remove(null);
}

if (y.Length > 1)
{
    while (i.Count < y[1].Length)
    {
        i.Add(null);
        ylength.Add(null);
    }
}
while (i.Count > 0)
{
    i.Remove(null);
}

if (superdupersecretdevmode)
{
    Console.WriteLine($"x length is {xlength.Count}");
    Console.WriteLine($"y length is {ylength.Count}");
}

//progress updates
if (xlength.Count > 6 || ylength.Count > 6)
{
    Thread updates = new Thread(() =>
    {
        while (xnegative == false && xparsecomplete == false && xlength.Count > 6)
        {
            Console.Write($"x counted so far: {positive.Count}          large/precise numbers may take a while.");
            Thread.Sleep(1000);
            Console.Write("\r");
            Console.Write(new string(' ', Console.WindowWidth));
            Console.Write("\r");
        }
        while (xnegative == true && xparsecomplete == false && xlength.Count > 6)
        {
            Console.Write($"x counted so far: {negative.Count}          large/precise numbers may take a while");
            Thread.Sleep(1000);
            Console.Write("\r");
            Console.Write(new string(' ', Console.WindowWidth));
            Console.Write("\r");

        }

        while (ynegative == true && yparsecomplete == false && ylength.Count > 6)
        {
            Console.Write($"ycounted so far: {negative2.Count}");
            Thread.Sleep(1000);
            Console.Write("\r");
            Console.Write(new string(' ', Console.WindowWidth));
            Console.Write("\r");
        }
        while (ynegative == false && yparsecomplete == false && ylength.Count > 6)
        {
            Console.Write($"ycounted so far: {positive2.Count}");
            Thread.Sleep(1000);
            Console.Write("\r");
            Console.Write(new string(' ', Console.WindowWidth));
            Console.Write("\r");
        }
    });
    updates.Start();
}



//creates the whole number thingo
if (xnegative)
{
    while (i.Count < int.Parse(x[0]))
    {
        negative.Add(null);
        i.Add(null);
    }
}
else
{
    while (i.Count < int.Parse(x[0]))
    {
        positive.Add(null);
        i.Add(null);
    }
}


//clears shi
while (i.Count > 0)
    i.Remove(null);
while (i2.Count > 0)
    i2.Remove(null);
while (i3.Count > 0)
    i3.Remove(null);
while (i4.Count > 0)
    i4.Remove(null);

//sets shi idk
while (i.Count < 9)
{
    i4.Add(null);
    i.Add(null);
}
while (i.Count > 0)
    i.Remove(null);

if (xnegative)
{
    while (i.Count < negative.Count)
    {
        i5.Add(null);
        i.Add(null);
    }
}
else
{
    while (i.Count < positive.Count)
    {
        i5.Add(null);
        i.Add(null);
    }
}
while (i.Count > 0)
    i.Remove(null);


//does stuff
if (y.Length > 1 && x.Length > 1)
{
    if (x[1].Length > y[1].Length)
    {
        //loops for amount of decimal places
        while (i2.Count < x[1].Length)
        {
            //loops for amount of positives or negatives stored
            while (i3.Count < i5.Count)
            {
                //loops nine times because 1z + 9z = z times 10
                foreach (object o in i4)
                {
                    if (xnegative)
                    {
                        negative.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented negative list");
                        }
                    }
                    else
                    {
                        positive.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented positive list");
                        }
                    }
                    if (superdupersecretdevmode)
                    {
                        Console.WriteLine("completed x increment times 10");
                    }
                }
                //increments i3 for a counter
                i3.Add(null);
                if (superdupersecretdevmode)
                {
                    Console.WriteLine("a");
                }
            }
            //clears i3 after it has been used as a counter
            while (i3.Count > 0)
                i3.Remove(null);
            //clears i5 after it has been used to represent positive.Count or negative.Count
            while (i5.Count > 0)
                i5.Remove(null);
            //sets i5 equal to positive2.Count or negative2.Count
            if (xnegative)
            {
                while (i6.Count < negative.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            else
            {
                while (i6.Count < positive.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            //clears i6 after it has been used as a counter
            while (i6.Count > 0)
                i6.Remove(null);
            //increments i2 for a counter
            i2.Add(null);
        }
        //clears i2 after it has been used as a counter
        while (i2.Count > 0)
            i2.Remove(null);
    }
    else
    {
        //loops for amount of decimal places
        while (i2.Count < y[1].Length)
        {
            //loops for amount of positives or negatives stored
            while (i3.Count < i5.Count)
            {
                //loops nine times because 1z + 9z = z times 10
                foreach (object o in i4)
                {
                    if (xnegative)
                    {
                        negative.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented negative list");
                        }
                    }
                    else
                    {
                        positive.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented positive list");
                        }
                    }
                    if (superdupersecretdevmode)
                    {
                        Console.WriteLine("completed x increment times 10");
                    }
                }
                //increments i3 for a counter
                i3.Add(null);
                if (superdupersecretdevmode)
                {
                    Console.WriteLine("a");
                }
            }
            //clears i3 after it has been used as a counter
            while (i3.Count > 0)
                i3.Remove(null);
            //clears i5 after it has been used to represent positive.Count or negative.Count
            while (i5.Count > 0)
                i5.Remove(null);
            //sets i5 equal to positive.Count or negative.Count
            if (xnegative)
            {
                while (i6.Count < negative.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            else
            {
                while (i6.Count < positive.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            //clears i6 after it has been used as a counter
            while (i6.Count > 0)
                i6.Remove(null);
            //increments i2 for a counter
            i2.Add(null);
        }
        //clears i2 after it has been used as a counter
        while (i2.Count > 0)
            i2.Remove(null);
    }
}

//scales if only one has length
if (y.Length > 1 ^ x.Length > 1)
{
    if (y.Length > x.Length)
    {
        //loops for amount of decimal places
        while (i2.Count < y[1].Length)
        {
            //loops for amount of positives or negatives stored
            while (i3.Count < i5.Count)
            {
                //loops nine times because 1z + 9z = z times 10
                foreach (object o in i4)
                {
                    if (xnegative)
                    {
                        negative.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented negative list");
                        }
                    }
                    else
                    {
                        positive.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented positive list");
                        }
                    }
                    if (superdupersecretdevmode)
                    {
                        Console.WriteLine("completed x increment times 10");
                    }
                }
                //increments i3 for a counter
                i3.Add(null);
                if (superdupersecretdevmode)
                {
                    Console.WriteLine("a");
                }
            }
            //clears i3 after it has been used as a counter
            while (i3.Count > 0)
                i3.Remove(null);
            //clears i5 after it has been used to represent positive2.Count or negative2.Count
            while (i5.Count > 0)
                i5.Remove(null);
            //sets i5 equal to positive2.Count or negative2.Count
            if (xnegative)
            {
                while (i6.Count < negative.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            else
            {
                while (i6.Count < positive.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            //clears i6 after it has been used as a counter
            while (i6.Count > 0)
                i6.Remove(null);
            //increments i2 for a counter
            i2.Add(null);
        }
        //clears i2 after it has been used as a counter
        while (i2.Count > 0)
            i2.Remove(null);
    }
    else
    {
        //loops for amount of decimal places
        while (i2.Count < x[1].Length)
        {
            //loops for amount of positives or negatives stored
            while (i3.Count < i5.Count)
            {
                //loops nine times because 1z + 9z = z times 10
                foreach (object o in i4)
                {
                    if (xnegative)
                    {
                        negative.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented negative list");
                        }
                    }
                    else
                    {
                        positive.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented positive list");
                        }
                    }
                    if (superdupersecretdevmode)
                    {
                        Console.WriteLine("completed x increment times 10");
                    }
                }
                //increments i3 for a counter
                i3.Add(null);
                if (superdupersecretdevmode)
                {
                    Console.WriteLine("a");
                }
            }
            //clears i3 after it has been used as a counter
            while (i3.Count > 0)
                i3.Remove(null);
            //clears i5 after it has been used to represent positive.Count or negative.Count
            while (i5.Count > 0)
                i5.Remove(null);
            //sets i5 equal to positive.Count or negative.Count
            if (xnegative)
            {
                while (i6.Count < negative.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            else
            {
                while (i6.Count < positive.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            //clears i6 after it has been used as a counter
            while (i6.Count > 0)
                i6.Remove(null);
            //increments i2 for a counter
            i2.Add(null);
        }
        //clears i2 after it has been used as a counter
        while (i2.Count > 0)
            i2.Remove(null);
    }

}

//clears i2 after it has been used as a counter
while (i2.Count > 0)
    i2.Remove(null);

//I HAVE SPENT. THE LAST GODDAMN. FIVE HOURS STRAIGHT. ON THIS^. JUST THIS. IT DOESNT EVEN WORK YET. OMFG.
//its 4 am

//OH MY GOD IT WORKS, i have slept and awoken already since last comments BUT IT WORKS
//i spent like, SEVEN HOURS on this./
//dfghjdfghfdghlfgkjlhjl;jk
//actually 8 of my last 11 conscious hours were on this
//still havent added negative implementation yet but how hard could it be fr
//update, i added negative implementation, and it was not in fact very hard
//update, the length of the code responsible for scaling logic has quadroupled in length,
//so your not really looking at the same code i was freaking out about

if (supersecretdevmode)
{
    Console.WriteLine("for x before decimal addition");
    Console.WriteLine("positive list 1 is " + positive.Count);
    Console.WriteLine("negative list 1 is " + negative.Count);
    if (superdupersecretdevmode)
    {
        Console.WriteLine("i is " + i.Count);
        Console.WriteLine("i2 is " + i2.Count);
        Console.WriteLine("i3 is " + i3.Count);
        Console.WriteLine("i4 is " + i4.Count);
        Console.WriteLine("i5 is " + i5.Count);
        Console.WriteLine("i6 is " + i6.Count);
    }
}


while (i.Count > 0)
    i.Remove(null);
while (i2.Count > 0)
    i2.Remove(null);
while (i3.Count > 0)
    i3.Remove(null);
while (i4.Count > 0)
    i4.Remove(null);
while (i5.Count > 0)
    i5.Remove(null);
while (i6.Count > 0)
    i6.Remove(null);

//ok ok its the next day time for the decimal converter

if (x.Length > 1)
{
    while (i.Count < int.Parse(x[1]))
    {
        if (xnegative)
        {
            i.Add(null);
            negative.Add(null);
        }
        else
        {
            i.Add(null);
            positive.Add(null);
        }
    }
}



if (supersecretdevmode)
{
    Console.WriteLine("for x after decimal addition");
    Console.WriteLine("positive list is " + positive.Count);
    Console.WriteLine("negative list is " + negative.Count);
    if (superdupersecretdevmode)
    {
        Console.WriteLine("i is " + i.Count);
        Console.WriteLine("i2 is " + i2.Count);
        Console.WriteLine("i3 is " + i3.Count);
        Console.WriteLine("i4 is " + i4.Count);
        Console.WriteLine("i5 is " + i5.Count);
        Console.WriteLine("i6 is " + i6.Count);
    }
}

while (i.Count > 0)
    i.Remove(null);
while (i2.Count > 0)
    i2.Remove(null);
while (i3.Count > 0)
    i3.Remove(null);
while (i4.Count > 0)
    i4.Remove(null);
while (i5.Count > 0)
    i5.Remove(null);
while (i6.Count > 0)
    i6.Remove(null);

xparsecomplete = true;

//literally the same code but for y :downarrow:
//some of the comments prolly be outdated but like screw you it works im too lazy to go through each one

//creates the whole number thingo
if (ynegative)
{
    while (i.Count < int.Parse(y[0]))
    {
        negative2.Add(null);
        i.Add(null);
    }
}
else
{
    while (i.Count < int.Parse(y[0]))
    {
        positive2.Add(null);
        i.Add(null);
    }
}


//clears shi
while (i.Count > 0)
    i.Remove(null);
while (i2.Count > 0)
    i2.Remove(null);
while (i3.Count > 0)
    i3.Remove(null);
while (i4.Count > 0)
    i4.Remove(null);
while (i5.Count > 0)
    i5.Remove(null);
while (i6.Count > 0)
    i6.Remove(null);

//sets shi idk
while (i.Count < 9)
{
    i4.Add(null);
    i.Add(null);
}
while (i.Count > 0)
    i.Remove(null);

if (ynegative)
{
    while (i.Count < negative2.Count)
    {
        i5.Add(null);
        i.Add(null);
    }
}
else
{
    while (i.Count < positive2.Count)
    {
        i5.Add(null);
        i.Add(null);
    }
}
while (i.Count > 0)
    i.Remove(null);

//scales the whole number thingo
//if x and y [1] have length
if (y.Length > 1 && x.Length > 1)
{
    if (y[1].Length > x[1].Length)
    {
        //loops for amount of decimal places
        while (i2.Count < y[1].Length)
        {
            //loops for amount of positives or negatives stored
            while (i3.Count < i5.Count)
            {
                //loops nine times because 1z + 9z = z times 10
                foreach (object o in i4)
                {
                    if (ynegative)
                    {
                        negative2.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented negative 2 list");
                        }
                    }
                    else
                    {
                        positive2.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented positive 2 list");
                        }
                    }
                    if (superdupersecretdevmode)
                    {
                        Console.WriteLine("completed y increment times 10");
                    }
                }
                //increments i3 for a counter
                i3.Add(null);
                if (superdupersecretdevmode)
                {
                    Console.WriteLine("a");
                }
            }
            //clears i3 after it has been used as a counter
            while (i3.Count > 0)
                i3.Remove(null);
            //clears i5 after it has been used to represent positive2.Count or negative2.Count
            while (i5.Count > 0)
                i5.Remove(null);
            //sets i5 equal to positive2.Count or negative2.Count
            if (ynegative)
            {
                while (i6.Count < negative2.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            else
            {
                while (i6.Count < positive2.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            //clears i6 after it has been used as a counter
            while (i6.Count > 0)
                i6.Remove(null);
            //increments i2 for a counter
            i2.Add(null);
        }
        //clears i2 after it has been used as a counter
        while (i2.Count > 0)
            i2.Remove(null);
    }
    else
    {
        //loops for amount of decimal places
        while (i2.Count < x[1].Length)
        {
            //loops for amount of positives or negatives stored
            while (i3.Count < i5.Count)
            {
                //loops nine times because 1z + 9z = z times 10
                foreach (object o in i4)
                {
                    if (ynegative)
                    {
                        negative2.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented negative 2 list");
                        }
                    }
                    else
                    {
                        positive2.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented positive 2 list");
                        }
                    }
                    if (superdupersecretdevmode)
                    {
                        Console.WriteLine("completed y increment times 10");
                    }
                }
                //increments i3 for a counter
                i3.Add(null);
                if (superdupersecretdevmode)
                {
                    Console.WriteLine("a");
                }
            }
            //clears i3 after it has been used as a counter
            while (i3.Count > 0)
                i3.Remove(null);
            //clears i5 after it has been used to represent positive2.Count or negative2.Count
            while (i5.Count > 0)
                i5.Remove(null);
            //sets i5 equal to positive2.Count or negative2.Count
            if (ynegative)
            {
                while (i6.Count < negative2.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            else
            {
                while (i6.Count < positive2.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            //clears i6 after it has been used as a counter
            while (i6.Count > 0)
                i6.Remove(null);
            //increments i2 for a counter
            i2.Add(null);
        }
        //clears i2 after it has been used as a counter
        while (i2.Count > 0)
            i2.Remove(null);
    }
}

//scales if only one has length
if (y.Length > 1 ^ x.Length > 1)
{
    if (y.Length > x.Length)
    {
        //loops for amount of decimal places
        while (i2.Count < y[1].Length)
        {
            //loops for amount of positives or negatives stored
            while (i3.Count < i5.Count)
            {
                //loops nine times because 1z + 9z = z times 10
                foreach (object o in i4)
                {
                    if (ynegative)
                    {
                        negative2.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented negative 2 list");
                        }
                    }
                    else
                    {
                        positive2.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented positive 2 list");
                        }
                    }
                    if (superdupersecretdevmode)
                    {
                        Console.WriteLine("completed y increment times 10");
                    }
                }
                //increments i3 for a counter
                i3.Add(null);
                if (superdupersecretdevmode)
                {
                    Console.WriteLine("a");
                }
            }
            //clears i3 after it has been used as a counter
            while (i3.Count > 0)
                i3.Remove(null);
            //clears i5 after it has been used to represent positive2.Count or negative2.Count
            while (i5.Count > 0)
                i5.Remove(null);
            //sets i5 equal to positive2.Count or negative2.Count
            if (ynegative)
            {
                while (i6.Count < negative2.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            else
            {
                while (i6.Count < positive2.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            //clears i6 after it has been used as a counter
            while (i6.Count > 0)
                i6.Remove(null);
            //increments i2 for a counter
            i2.Add(null);
        }
        //clears i2 after it has been used as a counter
        while (i2.Count > 0)
            i2.Remove(null);
    }
    else
    {
        //loops for amount of decimal places
        while (i2.Count < x[1].Length)
        {
            //loops for amount of positives or negatives stored
            while (i3.Count < i5.Count)
            {
                //loops nine times because 1z + 9z = z times 10
                foreach (object o in i4)
                {
                    if (ynegative)
                    {
                        negative2.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented negative 2 list");
                        }
                    }
                    else
                    {
                        positive2.Add(null);
                        if (superdupersecretdevmode)
                        {
                            Console.WriteLine("incremented positive 2 list");
                        }
                    }
                    if (superdupersecretdevmode)
                    {
                        Console.WriteLine("completed y increment times 10");
                    }
                }
                //increments i3 for a counter
                i3.Add(null);
                if (superdupersecretdevmode)
                {
                    Console.WriteLine("a");
                }
            }
            //clears i3 after it has been used as a counter
            while (i3.Count > 0)
                i3.Remove(null);
            //clears i5 after it has been used to represent positive2.Count or negative2.Count
            while (i5.Count > 0)
                i5.Remove(null);
            //sets i5 equal to positive2.Count or negative2.Count
            if (ynegative)
            {
                while (i6.Count < negative2.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            else
            {
                while (i6.Count < positive2.Count)
                {
                    i5.Add(null);
                    i6.Add(null);
                }
            }
            //clears i6 after it has been used as a counter
            while (i6.Count > 0)
                i6.Remove(null);
            //increments i2 for a counter
            i2.Add(null);
        }
        //clears i2 after it has been used as a counter
        while (i2.Count > 0)
            i2.Remove(null);
    }

}

if (supersecretdevmode)
{
    Console.WriteLine("for y before decimal addition");
    Console.WriteLine("positive list 2 is " + positive2.Count);
    Console.WriteLine("negative list 2 is " + negative2.Count);
    {
        Console.WriteLine("i is " + i.Count);
        Console.WriteLine("i2 is " + i2.Count);
        Console.WriteLine("i3 is " + i3.Count);
        Console.WriteLine("i4 is " + i4.Count);
        Console.WriteLine("i5 is " + i5.Count);
        Console.WriteLine("i6 is " + i6.Count);
    }
}


while (i.Count > 0)
    i.Remove(null);
while (i2.Count > 0)
    i2.Remove(null);
while (i3.Count > 0)
    i3.Remove(null);
while (i4.Count > 0)
    i4.Remove(null);
while (i5.Count > 0)
    i5.Remove(null);
while (i6.Count > 0)
    i6.Remove(null);

if (y.Length > 1)
{
    while (i.Count < int.Parse(y[1]))
    {
        if (ynegative)
        {
            i.Add(null);
            negative2.Add(null);
        }
        else
        {
            i.Add(null);
            positive2.Add(null);
        }
    }
}



if (supersecretdevmode)
{
    Console.WriteLine("for y after decimal addition");
    Console.WriteLine("positive 2 list is " + positive2.Count);
    Console.WriteLine("negative 2 list is " + negative2.Count);
    if (superdupersecretdevmode)
    {
        Console.WriteLine("i is " + i.Count);
        Console.WriteLine("i2 is " + i2.Count);
        Console.WriteLine("i3 is " + i3.Count);
        Console.WriteLine("i4 is " + i4.Count);
        Console.WriteLine("i5 is " + i5.Count);
        Console.WriteLine("i6 is " + i6.Count);
    }
}

yparsecomplete = true;

while (i.Count > 0)
    i.Remove(null);
while (i2.Count > 0)
    i2.Remove(null);
while (i3.Count > 0)
    i3.Remove(null);
while (i4.Count > 0)
    i4.Remove(null);
while (i5.Count > 0)
    i5.Remove(null);
while (i6.Count > 0)
    i6.Remove(null);

//add ts
if (operand == "+")
{
    foreach (object o in positive)
    {
        finalpositive.Add(null);
    }
    foreach (object o in negative)
    {
        finalnegative.Add(null);
    }
    foreach (object o in positive2)
    {
        finalpositive.Add(null);
    }
    foreach (object o in negative2)
    {
        finalnegative.Add(null);
    }
}


//simplify ts i think
if (finalnegative.Count > finalpositive.Count)
{
    foreach (object o in finalnegative)
        final.Add(null);

    foreach (object o in finalpositive)
    {
        final.Remove(null);
    }
    Console.WriteLine($"the answer is: -{final.Count}");
}
if (finalnegative.Count < finalpositive.Count)
{
    foreach (object o in finalpositive)
        final.Add(null);

    foreach (object o in finalnegative)
    {
        final.Remove(null);
    }
    Console.WriteLine($"the answer is: {final.Count}");
}
//doesnt unscale, fix later^










//TO DO LIST:
//get x and y to scale to the same number
    //everything else put on hold until i fix ts i think^
    //ok basically, shi kinda works, x and y scale correctly, EXCEPT, the decimal converters assume they can add the smallest scale, when really it should be scaled according to the most precise 
//however by allowing it to pass if the other has decimal points, it tries accessing its own decimal points to compare which is more precise, when it may not have decimal points
//this could likely be easily solved by checking if it has decimal before trying to access it, however i am too lazy to do that currently.
//figure out the 4 main operations for those classes with output positiveresult and negitiveresult
//collapse positiveresult and negativeresult into finalresult
//print that
//like, decide what repeat logic ya want
//probs an option to skip x input and have it equal to finalresult