using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //  first remark: the original sentence was "Go to your c:\ drive"
            //  that's not going to work because you have to write "Go to your c:\\ drive", so with a double backslash
            //  to make this work
            //
            //  string myString = "Go to your c:\\ drive";

            //  second remarkt: the original sentence was "My "so called" life" 
            //  where you can see that 'so called' is written in double quotation marks.
            //  To make this work you have to use a Escape character, in this case a backslash
            //  so it looks like this "My \"so called\" life"

            //  Please visit "http://is.gd/escape_sequence" for more escape character sequences

            //  This sentence creates a new line in a Console windows  "string myString = "What if I need a \n new line?";"

            //  This is a more complicated way to use String "string myString = string.Format("{0}!", "Tjakkaaaaa!!!!");"

            //  In this example we use two strings like Make and Model
            // "string myString = string.Format("Make: {0} (Model: {1})", "BMW", "760li");"

            //  This example show a number in the Currency format. Thats why this is used "{0:C}"
            //  because the C stands for currency. Please note, the Currency will be used
            //  set by your language preference on your computer. 
            //  It is possible to alter this in code. 
            //  "string myString = string.Format("{0:C}", 123.45);"

            //  This example converts a regular number into a Nummeric number by using the N in 
            //  "{0:N}" like "string myString = string.Format("{0:N}", 123456789);"

            //  This example is using the percentage format multiplied by 100 like this...
            // "string myString = string.Format("{0:P}", 0.025);"

            //  For more information about String Formate please visit: http://is.gd/string_format

            /*
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                //myString = myString + "--" + i.ToString();
                myString += "--" + i.ToString();

            }
            */

            //  while using the StringBuilder the performance should be improved
            /*
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            */

            string myString = " This piece of code will show you only a part of this message  ";

            //  This line will show you only the words 'piece of code'
            //  myString = myString.Substring(5, 13);

            //  This line will capitalize the whole sentence
            //  myString = myString.ToUpper();

            //  This line will replace al the empty spaces with double dashes
            //  myString = myString.Replace(" ", "--");

            //  This piece of code will show you how many characters are counted before trimming
            //  so at first we have 63 characters in total, after Trim (it will remove the empty
            //  spaces and then there are just 60 characters left

            myString = string.Format("Length before: {0} -- After: {1}",
                myString.Length, myString.Trim().Length);

            Console.WriteLine(myString);
            Console.ReadLine();


        }
    }

}
