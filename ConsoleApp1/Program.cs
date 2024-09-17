while (true)
{


    Console.WriteLine("Vällkommen till Antons Fråge sport");
    Console.WriteLine("Denna fråge sport kommer vara om...");
    Thread.Sleep(2500);
    Console.WriteLine("Christiano Ronaldo");
    Thread.Sleep(2500);
    Console.WriteLine("Hur många Ballon d´Or har han vunnit?");
    Thread.Sleep(2500);
    Console.WriteLine("A=5  B=6  C=4");

    int score = 0;
    
    String fråga1 = Console.ReadLine().ToLower();

    if (fråga1 == "a")
    {
        Console.WriteLine("Rätt");
        score += 1;

        Console.WriteLine("Christiano Ronadlo har vunnit 5 stycken Ballon d Or");
    }
    else if (fråga1 == "b")
    {
        Console.WriteLine("Fel");
    }
    else
    {
        Console.WriteLine("Väldigt fel");
    }
    Thread.Sleep(2500);
    Console.Clear();

    Console.WriteLine("Nästa fråga ...");
    Thread.Sleep(1500);
    Console.WriteLine("Vilken klubb spelar Ronaldo för idag");
    Thread.Sleep(2500);
    Console.WriteLine("A=manchester united");
    Console.WriteLine("B=Al nassir");
    Console.WriteLine("C=Real Madrid");

    String fråga2 = Console.ReadLine().ToLower();

    if (fråga2 == "a")
    {
        Console.WriteLine("Fel");
    }
    else if (fråga2 == "b")
    {
        Console.WriteLine("Rätt");
        Console.WriteLine("Ronaldo spelar nuvarande i Al Nassir i Soudi Arabien");
        score += 1;
    }
    else
    {
        Console.WriteLine("Fel");
    }
    Thread.Sleep(2500);
    Console.Clear();

    Console.WriteLine("nästa fråga...");
    Thread.Sleep(2500);
    Console.WriteLine("hur lång är Ronaldo?");
    Thread.Sleep(2500);
    Console.WriteLine("A= 1,97");
    Console.WriteLine("B= 1.87");
    Console.WriteLine("C= 1.77");


    String fråga3 = Console.ReadLine().ToLower();

    if (fråga3 == "a")
    {
        Console.WriteLine("Fel");
    }
    else if (fråga3 == "b")
    {
        Console.WriteLine("rätt");
        Console.WriteLine("Ronaldo är 1.87 meter lång");
        score += 1;
    }
    else
    {
        Console.WriteLine("fel");
    }
    Thread.Sleep(2500);
    Console.Clear();

    Thread.Sleep(1500);
    Console.WriteLine($"{score} totala poäng");
    if (score == 3)
    {
        Console.WriteLine("wow du vet ganska mycket om Ronaldo");
    }
    else if (score == 2)
    {
        Console.WriteLine("du har nog kollat på Ronaldo men inte tillräckligt");
    }
    else if (score == 1)
    {
        Console.WriteLine("gissade du eller?");
    }
    else if (score == 0)
    {
        Console.WriteLine("vet du ens vem Ronaldo är?");
    }

    Console.WriteLine("tryck på enter knappen för att börja om");
    Console.ReadLine();
    Console.Clear();
}