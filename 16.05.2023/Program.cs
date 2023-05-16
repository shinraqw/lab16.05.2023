namespace _16._05._2023
{
    class Program
    {
        static void Main()
        {
            using (var film = new Film("Початок", "Warner Bros.", "Трилер", 148, 2010))//1
            {
                film.Play();
                Console.WriteLine(film);
            }
            var actors = new List<string> { "Actor 1", "Actor 2", "Actor 3" };//2
            var leadActors = new List<string> { "Lead Actor 1", "Lead Actor 2" };

            using (var performance = new Performance("Hamlet", "Shakespeare Theatre", "Tragedy", 180, actors, leadActors))
            {
                performance.Start();
                performance.AddAudienceMember("John");
                performance.AddAudienceMember("Alice");
                Console.WriteLine(performance);
                // Додатковий код для роботи з об'єктом "performance"
            }

        }
    }
}
