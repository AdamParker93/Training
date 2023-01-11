{
    Console.WriteLine("What is your name?");
    var name = Console.ReadLine();

    var array = new char[name.Length];
    for (var inverse = name.Length; inverse > 0; inverse--)
        array[name.Length - inverse] = name[inverse - 1];

    var reversed = new string(array);
    Console.WriteLine($"Reversed name : {reversed}");

}
