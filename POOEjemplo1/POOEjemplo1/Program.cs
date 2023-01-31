namespace POOEjemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            for(int contador = 0; contador< 5; contador++)
            {
                Console.WriteLine("Ingrese el nombre de la persona:");
                persona.Nombre = Console.ReadLine();
                Console.WriteLine("el nombre ingresado es: " + persona.Nombre.ToString());
            }
            



        }
    }
}