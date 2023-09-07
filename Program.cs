// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
      


      int myBirthMonth = (int)Months.Sep;
      int myBirthDay = 16;
      int myBirthYear = 2005;
      
      string myBirthDate = $"My Birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

      File.WriteAllText("myFile.txt", "This is my file!\n");
      Console.WriteLine(File.ReadAllText("myFile.txt"));

      File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
      Console.WriteLine(File.ReadAllText("myFile.txt"));

      if (!File.Exists("newFile.txt"))
      {
           File.Copy("myFile.txt", "newFile.txt");
      }
      else
      {
           File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
      }

      File.AppendAllText("newFile.txt", myBirthDate);
      Console.WriteLine(File.ReadAllText("newFile.txt"));

enum Months
{
    Jan = 1,
    Feb,
    Mar,
    Apr,
    Jun,
    Jul,
    Aug,
    Sep,
    Oct,
    Nov,
    Dec
}

