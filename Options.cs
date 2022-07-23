using System;
using System.IO;
using QuickTools;


namespace Program
{
  public class Options
  {



    public void Option ()
    {
      Do.Cle ();

    
      Do.Label("Console Notepad"+" Version: "+MainProgram.Version);
      Do.LabelSide(DateTime.Now.ToString());
      Do.W("");
      Console.WriteLine ("Press The Number of your option");
      Console.WriteLine ("1. New Note");
      Console.WriteLine ("2. Open Note");
      Console.WriteLine("3. Delete Note");
      Console.WriteLine("4. Delete All Notes");
      Console.WriteLine("5. Exit");
      //string[] optionList = { "1. New Document", "2. Open Document", "3. Delete Document", "4. Exit" };
     //new CostumOptions(optionList);
      //using the try parse  to reduce the amount of issues posible
      //end using the variable answer,question,check to verified the input
                  int answer = 0;
                  // just get the number , but you may still get another number from it 
                  string parse = Get.KeyInput().ToString().Replace("D","");
                  // if the number has 2 numbers just return the first number 
                  string question = parse.Length == 1 ?parse : parse.Substring(0, 0);  
                  Get.Box(question); 

      bool check = int.TryParse (question, out answer);
      if (check == true)
	{
	  switch (answer)
	    {
	    case 1:		// new doc
	      var create = new NewDoc ();
	      create.DocFile ();
	      break;

	      case 2:		//Open
	      var file = new Open ();
	      file.OpenFile ();
	      break;

	      case 3:		//Delete
	      var docFile = new Delete ();
	      docFile.DeleteFile ();
	      break;
                              case 4:
                                    // here im passing all the files to be deleted
                                    var listOf = new Open();
                                    DeleteAll.CollectFiles(); 
                                    break; 
	      case 5:		// exit
	      MainProgram.Exit ();
	      break;

	      default:
            //Do.
	//Yellow("Incorrect selection , please press one of the Fallowing ONLY");
	      //Do.Wait ();
	      // go back to options 
	      this.Option ();
	      break;
	    }
	}
      else
	{
	// Do.Alert("Incorrect Option , please try again!!!");
    // Do.Wait();
     // go back to this function 
     this.Option();
	}


    }
    // whis method was added on the 03/04/2022
    // to improve flexsibi
    public static void Final ()
    {
      
      
     
      Do.W ("Options");
      Do.W ("1. Go Back");
      Do.W ("2. Exit");
      // this will give me the number for the anser

                  var goTo = new Options();
      switch (Get.KeyNumber())
	{
	case 1:		// Go Back 
	 
	  goTo.Option ();
	  break;

	case 2:           //EXitcle

                              MainProgram.Exit();
                          break;

	default:
	  Do.Yellow ("Not Valid Option Try Again Please");
	  Get.WaitTime(1000);		// wait for a key being pressed 
	  Do.Cle ();            //clear de console 
                              goTo.Option();  

	  break;
	}
    }




  }
}
