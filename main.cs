/*
This system has been created by MBV  which  has created this System 
as a Beta version with the aim of creatting a note saver by putting on practice 
object oriented programming  , this system is supposed to create file notes along with 
the avility to delete  , update , rename , save in the cloud all this notes it may not look
so pretty because is literally a console application but ti can be used on differents aspects of it.
*/
/*
as this program has been crated while im at work , some times i just document the changes
or the funtionality that it does , from now on i will also be adding more stuff such as dates and the changes added
during that date , today  is 03/04/2022
1.  Open 
2.  Options
3.  Delete 
*/
/*
    Final version of this sysstem is been relased under my public license 
    03/05/2022  Was done the Completed version and it is ready to be compiled
    Prior Compilation there are a couple of things that needs to be ajusted , so please refer to 
    Delete
    NewDoc
    Open 
    ____________________________________________________________
    in there is included the corrections that needs to be added 
    lastly there is a general path that needs to be added
    like a fild  of one class just to have the path for all the notes created 
    on a single spot 
*/

using System;
using System.IO;
using QuickTools;
using System.Collections.Generic;
using System.Threading;
using System.Text;
namespace Program
{
    
      class Do : Get
      {
            /*
                  //this class is completly useless 
                  // but it was easier to add this class
                  // than overritten all the codes 
            */
      }


      class MainProgram
  {
    // this method just use the methods W that was previusly C
    // along with the method Input and the field Text 
    // to verified and make sure that the caracter does not contain any of the 
    // current simbols 
    
    public static string Version = "M1.0.0.0F";
    static void Main ()
    {


                  //Get.Wait(Get.Input());
                  /*
                   *how to get the name of the file in a URI                 
                  string file = "data/bin/file.txt";
                  string path = "/bin/l/ct/r/" + file;
                  string onlyName = path.Substring(path.LastIndexOf("/")+1);

                  Get.Wait(onlyName);
                  */

                  /*
                   * 
                   * 
                   * all this has been just messing around to 
                   *  waste some time working around this mess
                  List<string> input = new List<string>();
                 
                  while (Get.Input().ToString() != "exit") {
                        
                        input.Add(Get.Text); 
                  }
                  foreach (string text in input)
                        Get.Write(" > "+text);

                  /* more examples
                   *           Get.Hide(); 
                  Get.Write(Get.Input());
                  Console.WriteLine("hello");
                  Console.SetCursorPosition(0, 0);
                  Console.WriteLine("      ");


                   * 
                   * this those the same too 
                   *     for (int i = 0; i < 100; ++i)
                  {
                        Thread.Sleep(100); 
                        Console.Write("\r{0}%   ", i);
                  }                  
                   * 
                   *                   
                   * This can write progress                  
                  Console.WriteLine();
                  for (int i = 0; i <= 100; i++)
                  {
                        System.Threading.Thread.Sleep(10);
                        Console.Write("\x000DProgress: " + i);
                  }
                  Console.Write(""); 
                  Get.Wait(Get.Text);  
                  */
                  //---------------------------------------------------------
                  //Where The Program is supposed to start when is not 
                  // commented out with "//" or with /*
                  try
                  {
                        var start = new Options();
                        start.Option();
                  }
                  catch(Exception e)
                  {
                        Get.Alert("Something Went really wrong , and the ConsoleNotepad could not be stopped it, more details : " + e);
                        Options.Final(); 
                  }
                 
                  //---------------------------------------------------------


            }
            // this is the program exit
            public static void Exit ()
    {
      Do.Cle ();
      Do.Green ("Bye");
      Thread.Sleep (1000);
      Environment.Exit(0);

    }

  }
}



/*
HERE IS LOCATED NOTES FROM THE SYSTEM THAT COULD BE used
AS REFERENCESS TO GET SOME STUFF DONE
NOTHING IMPORTANTNT IS WRITTEN HERE 
JUST IN CASE 
*/



/*
      string currentPath = Directory.GetCurrentDirectory ();
       
        // check if home exist 
        Console.WriteLine (Directory.Exists ("notes"));
        // this create the directory notes
       //  DirectoryInfo newDirectory = Directory.CreateDirectory("notes");
         
        Console.WriteLine (Directory.GetCurrentDirectory());
        
       string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        DirectoryInfo dirs = new DirectoryInfo(docPath);
        foreach (var files in dirs.EnumerateFiles())
        {
            Console.WriteLine(files);
        }*/
