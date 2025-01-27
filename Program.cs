// See https://aka.ms/new-console-template for more information

//declarations
int length = 0;
int width = 0;
int area = length * width;
int perimeter = width + length + width + area;


//this is the prompt asking what the length is
Console.WriteLine("Enter the length of the recatngle:");
length = Convert.ToInt32(Console.ReadLine());


//this is the prompt asking what the width is
Console.WriteLine("Enter the width of the rectangle:");
width = Convert.ToInt32(Console.ReadLine());

//
Console.WriteLine("The perimeter is" + (width * 2) + (length * 2) );


Console.WriteLine("The area is" + (length * width));

