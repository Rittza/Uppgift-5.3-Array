namespace Upggifter_array
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            string[] frågor = new string[4];
            string[] svar = new string[4];
            frågor[0] = "Vad är Sveriges huvudstad?";
            frågor[1] = "Vad är Sveriges tredje största stad?";
            frågor[2] = "Vad är USA:S huvudstad?";
            frågor[3] = "Vad är texas:s huvudstad?";
            svar[0] = "Stockholm";
            svar[1] = "Malmö";
            svar[2] = "Washington dc";
            svar[3] = "Dallas";

            Console.WriteLine("Välj en fråga att svara på 1-4");

            int usersvar = int.Parse(Console.ReadLine()) -1;

            Console.WriteLine(" fråga " + frågor[usersvar]);

            Console.WriteLine("Skriv in ditt svar");
            string answer = Console.ReadLine();

            if (answer.ToLower () == svar[usersvar].ToLower())
            {
                    Console.WriteLine("Rätt svar");
            }
            else
            {
                Console.WriteLine("Fel svar, rätt svar är " + svar[usersvar] );
            }

            }

            catch
            {
                Console.WriteLine("Denna frågan existerar inte");
            }
            Console.ReadKey();

        }
    }
}