//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//Console.WriteLine("Enter A:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter B:");
//int b = Convert.ToInt32(Console.ReadLine());
//int sum = a + b;
//app.MapGet("/", () => sum);

//app.Run();

//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//Console.WriteLine("Enter N:");
//int n = Convert.ToInt32(Console.ReadLine());
//int sum = n*n;
//app.MapGet("/", () => sum);

//app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//Console.WriteLine("Enter A:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter B:");
//int b = Convert.ToInt32(Console.ReadLine());
//int sum = a + b;
app.MapGet("/add/{a}/{b}",(int a ,int b)=> a+b);

app.Run();