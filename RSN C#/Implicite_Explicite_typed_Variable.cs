C# Implicitly-Typed Local Variable - var

C# 3.0 introduced the implicit typed local variable "var". Var can only be defined in a method as a local variable. 
The compiler will infer its type based on the value to the right of the "=" operator.

Example: Explicitly Typed Variable
int i = 100;// explicitly typed 
var j = 100; // implicitly typed


The following example shows how var can have a different type based on its value:

Example: Implicitly-Typed Variable
static void Main(string[] args)
{
    var i = 10;
    Console.WriteLine("Type of i is {0}",i.GetType().ToString());

    var str = "Hello World!!";
    Console.WriteLine("Type of str is {0}", str.GetType().ToString());

    var d = 100.50d;
    Console.WriteLine("Type of d is {0}", d.GetType().ToString());

    var b = true;
    Console.WriteLine("Type of b is {0}", b.GetType().ToString());
}
Output:
Type of i is System.Int32
Type of str is System.String
Type of d is System.Double
Type of b is System.Boolean


Implicitly-typed variables must initialized at the time of declaration, otherwise C# compiler would give an error: 
Implicitly-typed variables must be initialized.

var i = 100; // Valid
var j; // Compile-time error: Implicitly-typed variables must be initialized

Multiple declerations of var variables in a single statement is not allowed.

var i = 100, j = 200, k = 300; // Compile-time error

var i = 100; var j = 200; var k = 300; // Valid
// the followings are also valid
var i = 100; 
var j = 200; 
var k = 300; 
var cannot be used for function parameters.

void Display(var param) //Compile-time error
{
    Console.Write(param);
}
var variables can be used in the following different contexts:

	*	Local variable in a function
	*	For loop
	*	Foreach loop
	*	Using statement
	*	As an anonymous type

	In a LINQ query expression
	
	Points to Remember :

	*	var can only be declared and initialized in a single statement. Following is not valid:
	*	var i; i = 10;
	*	var cannot be used as a field type at the class level.
	*	var cannot be used in an expression like var i += 10;

	Multiple vars cannot be declared and initialized in a single statement. For example, var i=10, j=20; is invalid.