using System;

class Program {
    static void Main()
    {
        string begin_str = "Welcome to our fortune teller! Type your name:";
        Console.WriteLine(begin_str);

        // read input
        string? name = Console.ReadLine();

        string name_str = $"Hey {name}!";
        Console.WriteLine(name_str);

        Random rnd = new Random();

        List<string> t = new List<string>
        {
            "You're in the matrix!",
            "You aren't in the matrix!",
            "You're going to live your dream life!",
            "You may get scammed at some point!",
            "You don't believe in fortune tellers!",
            "You will discover an infinite money glitch!"
        };

        // pick from the list
        int rnd_index = rnd.Next(t.Count);

        // display the result
        string rnd_result = t[rnd_index];

        string result_str = $"Oh! {rnd_result}";
        Console.Write(result_str);
    }
}