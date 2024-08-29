﻿using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      RandomMode();
      BuildACreature("ghost","ghost","ghost");
    }
    static void BuildACreature(string head, string body, string feet){
      int headnum= TranslateToNumber(head);
      int bodynum= TranslateToNumber(body);
      int feetnum=TranslateToNumber(feet);
      SwitchCase(headnum,bodynum,feetnum);
   
    }
    static void RandomMode(){
      Random randomNumber = new Random();
      int head = randomNumber.Next(1, 4);
      int body = randomNumber.Next(1, 4);
      int feet  = randomNumber.Next(1, 4);
      SwitchCase(head,body,feet);
      }
    static void SwitchCase(int head, int body, int feet){
        switch(head){
        case 1:
        GhostHead();
        break;
        case 2:
        MonsterHead();
        break;
        case 3:
        BugHead();
        break;
        default:
        Console.WriteLine("not found");
        break;
      }
      switch(body){
        case 1:
        GhostBody();
        break;
        case 2:
        MonsterBody();
        break;
        case 3:
        BugBody();
        break;
        default:
        Console.WriteLine("not found");
        break;
      }
      switch(feet){
        case 1:
        GhostFeet();
        break;
        case 2:
        MonsterFeet();
        break;
        case 3:
        BugFeet();
        break;
        default:
        Console.WriteLine("not found");
        break;
      }
    
    }
    static int TranslateToNumber(string creature){
    switch(creature){
        case "ghost":
        return 1;
        break;
        case "bug":
        return 2;
        break;
        case "monster":
        return 3;
        break;
        default:
        return 1;
        break;
      }

    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
