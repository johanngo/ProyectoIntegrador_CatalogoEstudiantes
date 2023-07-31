namespace ProyectoIntegrador_CatalogoEstudiantes
{
    public class Program
    {
        /// <summary>
        /// ContinueExcecution is a global flag for the application, if the user inpunts Salir this flag will exit the program.
        /// </summary>
        public static bool ContinueExcecution { get; set; } = true;

        /// <summary>
        /// Students control the current state of the application, it acts as in memory DB of all the students created.
        /// </summary>
        public static List<Student> Students;

        /// <summary>
        /// Definition of struct Student, it contains all the displayable text and the fields for a Student.
        /// </summary>
        public struct Student
        {
            public const string DISPLAY_ENROLL_ID = "Ingrese la matricula del estudiante: \r\n";
            public const string DISPLAY_NAME = "Ingrese el nombre: \r\n";
            public const string DISPLAY_F_LAST_NAME = "Ingrese el apellido paterno: \r\n";
            public const string DISPLAY_M_LAST_NAME ="Ingrese el apellido materno: \r\n";
            public const string DISPLAY_CARREER = "Ingrese la carrera: \r\n";
            public const string DISPLAY_EMAIL = "Ingrese el correo electrónico: \r\n";
            public const string DISPLAY_PHONE = "Ingrese el teléfono: \r\n";

            public string EnrollmentId;
            public string FirstName;
            public string FathersLastName;
            public string MothersLastName;
            public string Carreer;
            public string StudentEmail;
            public string StudentPhone;

        }

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("******************************* ¡Bienvenido al Catalogo de Estudiantes! ***********************************************");
            Console.WriteLine("**********************************************************************************************************************\r\n");

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.WriteLine("A continuacion seleccione una opcion del menu: \r\n");

                DisplayMenu();


                //Console.WriteLine("Programa finalizado!, presione cualquier tecla para salir");
                //Console.ReadKey();
                //Console.Clear();

                var menuSelection = ReadCharFromConsole("---------------> ");
                HandleMenuGUI(menuSelection);
            } while (ContinueExcecution);

            Console.WriteLine("******************************* Gracias por usar Catalogo de Estudiantes ***********************************************\r\n");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }

        /// <summary>
        /// Generic method to Read a char from console, you can add displayInput to display a message for the user
        /// </summary>
        /// <param name="displayInput"></param>
        /// <returns></returns>

        private static object ReadCharFromConsole(string displayInput = "")
        {
            Console.Write($"{displayInput}");
            var input = Console.ReadKey(false);
            return input.KeyChar;
        }

        /// <summary>
        /// Generic method to Read a string from console, you can add displayInput to display a message for the user
        /// </summary>
        /// <param name="displayInput"></param>
        /// <returns></returns>
        private static object ReadStringFromConsole(string displayInput = "")
        {
            Console.Write($"{displayInput}");
            var input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// Method to display a Menu
        /// </summary>
        private static void DisplayMenu()
        {
            Console.WriteLine("1. Alta de estudiantes");
            Console.WriteLine("2. Baja de estudiantes");
            Console.WriteLine("3. Modificaciones de estudiantes");
            Console.WriteLine("4. Búsquedas de estudiantes");
            Console.WriteLine("5. Salir");
            
        }

        /// <summary>
        /// Method that controls the Menu UI, given the user input it will redirect to the selected option screen, or exit the program
        /// </summary>
        /// <param name="menuSelection"></param>
        private static void HandleMenuGUI(object menuSelection)
        {
            int index;

            var result = int.TryParse(menuSelection.ToString(), out index);


            // Invalid Input
            if (!result)
            {
                Console.WriteLine("\r\nOpcion Invalida!!!");
                Console.Clear();
                return;
            }

            if (index > 5 || index < 1)
            {
                Console.WriteLine("\r\nOpcion Invalida!!!");
                Console.Clear();
                return;
            }

            // Exit Program
            if(index == 5)
            {
                ExitCatalog();
                Console.Clear();
                return;
            }

            HandleMenuSelection(index);

            Console.Clear();
        }

        /// <summary>
        /// Invokes the Program available options method: CreateStuden, DeleteStudent, ModifyStudent, SearchStudent.
        /// </summary>
        /// <param name="index"></param>
        private static void HandleMenuSelection(int index)
        {
            Console.Clear();
            switch (index)
            {
                case 1:
                    CreateStudent();
                    break;
                case 2:
                    DeleteStudent();
                    break;
                case 3:
                    ModifyStudent();
                    break;
                case 4:
                    SearchStudent();
                    break;
            }

            Console.Clear();
        }

        /// <summary>
        /// Search a user
        /// </summary>
        private static void SearchStudent()
        {
            ReadStringFromConsole("Proporcione el Id del estudiante a a buscar: ");

            Console.WriteLine("\r\n********** Estudiante encontrado con Exito!!! *********\r\n");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            // TODO: Implement method logic
        }

        /// <summary>
        /// Modifies a user
        /// </summary>
        private static void ModifyStudent()
        {
            ReadStringFromConsole("Proporcione el Id del estudiante a modificar: ");

            Console.WriteLine("\r\n********** Estudiante modificado con Exito!!! *********\r\n");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            // TODO: Implement method logic
        }

        /// <summary>
        /// Deletes a user
        /// </summary>
        private static void DeleteStudent()
        {
            ReadStringFromConsole("Proporcione el Id del estudiante para darlo de baja: ");

            Console.WriteLine("\r\n********** Estudiante dado de baja con Exito!!! *********\r\n");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            // TODO: Implement method logic
        }

        /// <summary>
        /// Creates  User
        /// </summary>
        private static void CreateStudent()
        {
            ReadStringFromConsole(Student.DISPLAY_ENROLL_ID);
            ReadStringFromConsole(Student.DISPLAY_NAME);
            ReadStringFromConsole(Student.DISPLAY_F_LAST_NAME);
            ReadStringFromConsole(Student.DISPLAY_M_LAST_NAME);
            ReadStringFromConsole(Student.DISPLAY_CARREER);
            ReadStringFromConsole(Student.DISPLAY_EMAIL);
            ReadStringFromConsole(Student.DISPLAY_PHONE);

            Console.WriteLine("\r\n********** Estudiante guardado con Exito!!! *********\r\n");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            // TODO: Implement method logic
        }

        private static void ExitCatalog()
        {
            ContinueExcecution = false;
        }
    }
}