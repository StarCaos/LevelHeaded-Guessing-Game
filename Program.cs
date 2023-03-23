using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LevelHeaded20
{
   internal static class Program
   {
        static string filePath = "cat.png";

        /// </summary>
        //[STAThread]
        static void Main(string[] args)
        {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // generate a random number between 1 and 100

        Console.WriteLine("Guess the secret number between 1 and 100:");
        
        
        while (true) // keep looping until the user guesses correctly
        {
          string guess = Console.ReadLine();
          int input = int.Parse(guess);

          if (input < secretNumber)
          {
            Console.WriteLine("The secret number is higher.");
          }
        else if (input > secretNumber)
          {
            Console.WriteLine("The secret number is lower.");
          }
        else
          {
            Console.WriteLine("You guessed correctly!");
            DisplayImage("cat.png"); // call the DisplayImage function to display the PNG file
            break; // exit the loop
          }
        }

        Console.ReadLine(); // pause the program so the user can see the result
     }
   static void DisplayImage(string filename)
   {
      // create a new form to display the image
      Form form = new Form();
      form.StartPosition = FormStartPosition.CenterScreen;
      form.FormBorderStyle = FormBorderStyle.FixedDialog;
      form.MaximizeBox = false;
      form.MinimizeBox = false;
      form.ShowIcon = false;
      form.ShowInTaskbar = false;

      // create a new PictureBox to display the image
      PictureBox pictureBox = new PictureBox();
      pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
      pictureBox.Image = Image.FromFile(filePath);

      // add the PictureBox to the form
      form.Controls.Add(pictureBox);

      // show the form
      form.ShowDialog();
   }

   }
}





