using System;

namespace Check
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference type
            string name = null;

            //value type made nullable
            int? number = null;

            //value type by default is null
            bool? isTrue;

            ProgramX program = null;

            //Evaluates to null
            Console.WriteLine(program?.Name);

            program = new ProgramX();

            //Evaluates to null
            Console.WriteLine(program?.Name);

            program = new ProgramX() { Name = "Rumpley" };

            //Evaluates to Rumpley

            Console.WriteLine(program?.Name);

            program = new ProgramX();

            //Evaluates to No Name
            Console.Write(program.Name ?? "No Name\n");

            //ProgramX programBreak = null;

            //Run Time Error
            //Console.WriteLine(programBreak.Name ?? "No Name");

            //Evaluates to no name
            Console.WriteLine(program.Name != null ? program.Name : "No Name\n");

            Console.ReadLine();
        }

    }

    class ProgramX
    {
        public string Name { get; set; }
    }
}
