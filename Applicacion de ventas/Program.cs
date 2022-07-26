// See https://aka.ms/new-console-template for more information
const string DetergenteCode = "DET";
const string JabonPolvoCode = "JP";
const string DesodoranteCode = "DES";
Console.WriteLine("Bienvenido a la aplicación de ventas!");
Console.WriteLine("Ingrese codigo de producto:");
string UserInputCode = Console.ReadLine();




void ValidateUserInputCode(string code)
{
    if (code.Equals(DetergenteCode))
    {

    }
    else if (code.Equals(JabonPolvoCode))
    {

    }
    else if (code.Equals(DesodoranteCode))
    {

    }
    else
    {
        Console.WriteLine("Codigo ingresado es invalido");
    }
}