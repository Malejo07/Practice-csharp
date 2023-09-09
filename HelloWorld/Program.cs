namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            /* Data type
            Int myNum = 5;
            double myNum = 5.70;
            char myLetter = 'M';
            bool myBool = true or false;
            string myText = "Hello";
            var Name = "Malejo"; //Cuando ponemos var el sistema automaticamente detecta el tipo de dato
            String name = "Alejo";*/

            // Console.WriteLine($"Hello World {name}!");
            // Console.WriteLine();

            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string birthdayInput;
            Console.WriteLine("¡Hola, Bienvenido al calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Es un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en el siguiente formato dd/mm/yy: ");
            birthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted);
            if (isDateValid == false)
                Console.WriteLine($"La fecha de nacimiento esta en un formato inválido {birthdayInput}");

            var person = new Person
            {
                Name = nameInput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };
            Console.WriteLine($"Tu nombre es: {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento es: {person.Birthday}");
            Console.WriteLine($"Tu edad es: {person.Age} años");

            Console.WriteLine();


        }

    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}
