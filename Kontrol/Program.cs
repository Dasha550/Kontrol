void Text(string[] args)
{
    string[] textGiven = {"hello","2","world",":-)"};
        Console.Write("[");
    List<int> lengths = textGiven.Select(text => text.Length).ToList();
    foreach (int length in lengths)
    
     if (length  <=3)
        {
        Console.Write($"{textGiven[length]};");
        }
  Console.Write("]");
}

Text(args);
