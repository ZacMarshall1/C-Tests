Console.WriteLine("## Login Test ##");

string userOne = "admin";
string userTwo = "maria";
string password = "123";

Console.WriteLine("Enter your user: ");
string selectedUser = Console.ReadLine();
Console.WriteLine("Enter your password");
string selectedPassword = Console.ReadLine();


string result = ((selectedUser == userOne || selectedUser == userTwo) && selectedPassword == password)
    ? "Login Successful" : "Unable to log in";

Console.WriteLine(result);

