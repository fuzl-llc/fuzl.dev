/*

Ok, this time we're going to do more than just write text to the console. Let's get some user 
input this time. We'll start out with basically what we had before with two changes. First, we 
added "using System;" to the top. We'll learn about this more later but for now, it just means 
we can write just Console intead of System.Console. We're going to be referencing the Console 
a few times in this program so this will save us some time. Second, we changed the "Hello World" 
text to "What is your name?" Check out the code below this comment - it should look very 
familiar, with just the two changes above.

Next, we're going to get user input by asking a question and letting them type an answer. Add 
the line below after Console.WriteLine below:

var name = Console.ReadLine();

The part on the left is new "var name" means create a variable called "name." If you're familiar 
with variables in math this should be easy to understand. Just like we use variables like x and y 
in math to store numbers, we can create variables like "name" to store all kinds of things. In 
this case we're going to store a piece of text, namely the user's name. How do we store their name 
in the variable? Well, we'll get that from reading the console input.

The part on the right should be somewhat intuitive, instead of writing a line to the console, 
we're reading a line from it. Code execution will pause on this line until the user enters their 
name and hits the enter key.

Next, we'll greet the user by name with this code:

Console.WriteLine($"Hi {name}!");

The Console.WriteLine part should be familiar but instead of a simple bit of quoted text. We'll 
learn more about this syntax later but for now, know it will add whatever is in the name variable 
to the "Hi" and output a greeting like "Hi Bob."

So, add the two lines of code and then press F5 to run it. Once it runs, the terminal will open up 
and you can click Ctrl+` to focus the terminal and type your name and the Enter key.

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
    }
}
