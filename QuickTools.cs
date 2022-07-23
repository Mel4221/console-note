/*
This Contains all the shortcuts for the Alerts
and events of colors for the display of the 
text. 
*/

using System;
using System.IO;
using System.Collections.Generic;
namespace QuickTools
{

  public static class Do
  {

    static public bool Validate ()
    {

      Do.Input ();

      List < char >notValidChars = new List < char >();
        notValidChars.Add ('.');
        notValidChars.Add (',');
        notValidChars.Add ('#');
        notValidChars.Add ('$');
        notValidChars.Add ('*');
        notValidChars.Add (' ');
        notValidChars.Add ('!');
        notValidChars.Add ('+');
        notValidChars.Add ('=');
        notValidChars.Add ('-');
        notValidChars.Add (';');
        notValidChars.Add (')');
        notValidChars.Add ('(');
        notValidChars.Add ('@');
        notValidChars.Add ('%');
        notValidChars.Add ('^');
        notValidChars.Add (':');
        notValidChars.Add ('/');
        notValidChars.Add ('[');
        notValidChars.Add (']');
        notValidChars.Add ('?');

      bool validChar = false;

        foreach (char item in notValidChars)
      {
	bool isValid = Do.Text.Contains (item);


	if (isValid == true)
	  {
	    validChar = false;
	    break;

	  }
	else
	  {
	    validChar = true;
	  }
      }
      return validChar;
    }


    public static void Wrong ()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine ("Something Was Wrong!!!");
      Console.ResetColor ();
    }
    public static void Wrong (string text)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine ("Something Was Wrong!!!");
      Console.WriteLine ("This" + ":=>>>> " + text);
      Console.ResetColor ();
    }
    public static void WrongIn ()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine (" Wrong Input!!!");
      Console.ResetColor ();
    }

    public static void WrongIn (string msg)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.
	WriteLine
	(" Wrong Input!!!, this is not a valid input:=====>>>>  '{0}' ", msg);

      Console.ResetColor ();
    }

    public static void NotFound ()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine ("File Not Founded");
      Console.ResetColor ();
    }
    public static void NotFound (string msg)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine ("This File Was Not Founded '{0}' ", msg);
      Console.ResetColor ();
    }
    public static void Wait ()
    {
      Do.W ("Type any key to continue");
      Console.ReadKey ();
    }

    public static void Good ()
    {
      Console.ForegroundColor = ConsoleColor.Green;
    }
    public static void Ok ()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine ("OK");
      Console.ResetColor ();
    }
    public static void Good (string msg)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine (msg);
      Console.ResetColor ();
    }
    public static void Bad ()
    {
      Console.ForegroundColor = ConsoleColor.Red;
    }
    public static void Bad (string msg)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine (msg);
      Console.ResetColor ();
    }
    public static void Alert ()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
    }
    public static void Alert (string msg)
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine (msg);
      Console.ResetColor ();
    }
    public static void Hide ()
    {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.Black;

    }
    public static string Text;
    public static int Number;
    public static void InputN ()
    {
      bool isnumber;
      string input = Console.ReadLine ();
      int number;
      isnumber = int.TryParse (input, out number);
      if (isnumber)
	{
	  Number = number;
	}
      else
	{
	  Do.WrongIn (input);
	}
    }
    public static void Input ()
    {
      string text = Console.ReadLine ();
      Text = text;
    }


    public static void Reset ()
    {
      Console.ResetColor ();
    }
    public static void Cle ()
    {
      Console.Clear ();
    }
    // quick WriteLine just as a quick method while im using an online editor 
    public static void W (string text)
    {
      Console.WriteLine (text);
    }
    public static void C (string text)
    {
      Console.WriteLine (text);
    }
    /*
       here im just going to add some shortcuts for the console colors
       sadly it will be for type string only 
     */


    public static void Red (string text)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine (text);
      Do.Reset ();
    }
    public static void Blue (string text)
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine (text);
      Do.Reset ();
    }

    public static void Green (string text)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine (text);
      Do.Reset ();
    }




    public static void Pink (string text)
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine (text);
      Do.Reset ();
    }

    public static void Back_Red (string text)
    {
      Console.BackgroundColor = ConsoleColor.Red;
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine (text);
      Do.Reset ();
    }

    public static void Back_Blue (string text)
    {
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine (text);
      Do.Reset ();
    }

    public static void Back_Pink (string text)
    {
      Console.BackgroundColor = ConsoleColor.Magenta;
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine (text);
      Do.Reset ();
    }
    public static void Back_Green (string text)
    {
      Console.BackgroundColor = ConsoleColor.Green;
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine (text);
      Do.Reset ();
    }


   public static void Side(string msg)
    {
        Console.Write("  "+msg+"  ");
        Console.WriteLine();
    }

    public static void Label(string msg)
    {
      Console.BackgroundColor = ConsoleColor.Magenta;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write(" "+msg+" ");
      Do.Reset ();
         
    }








  }
}
