using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._05._2023
{

        public class Film : IDisposable//1
        {
            private bool disposed = false;

            public string Title { get; set; }
            public string Studio { get; set; }
            public string Genre { get; set; }
            public int Duration { get; set; }
            public int Year { get; set; }

            public Film(string title, string studio, string genre, int duration, int year)
            {
                Title = title;
                Studio = studio;
                Genre = genre;
                Duration = duration;
                Year = year;
            }

            public void Play()
            {
                Console.WriteLine("Зараз грає: " + Title);
            }

            public void Dispose()
            {
                Dispose(true);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!disposed)
                {
                    if (disposing)
                    {
                        // Звільняємо керовані ресурси (якщо є)
                    }

                    // Звільняємо некеровані ресурси (якщо є)
                    disposed = true;
                }
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Title: {Title}");
                sb.AppendLine($"Studio: {Studio}");
                sb.AppendLine($"Genre: {Genre}");
                sb.AppendLine($"Duration: {Duration} min");
                sb.AppendLine($"Year: {Year}");
                return sb.ToString();
            }

            ~Film()
            {
                Dispose(false);
            }
        }

        public class Performance : IDisposable//2
        {
            private bool disposed = false;

            public string Title { get; set; }
            public string Theatre { get; set; }
            public string Genre { get; set; }
            public int Duration { get; set; }
            public List<string> Actors { get; set; }
            public List<string> Audience { get; set; }
            public List<string> LeadActors { get; set; }

            public Performance(string title, string theatre, string genre, int duration, List<string> actors, List<string> leadActors)
            {
                Title = title;
                Theatre = theatre;
                Genre = genre;
                Duration = duration;
                Actors = actors;
                Audience = new List<string>();
                LeadActors = leadActors;
            }

            public void Start()
            {
                Console.WriteLine($"The performance '{Title}' is starting at '{Theatre}'.");
            }

            public void AddAudienceMember(string name)
            {
                Audience.Add(name);
                Console.WriteLine($"{name} is attending the performance '{Title}'.");
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!disposed)
                {
                    if (disposing)
                    {
                        // Звільняємо керовані ресурси (якщо є)
                    }

                    // Звільняємо некеровані ресурси (якщо є)
                    disposed = true;
                }
            }

            public override string ToString()
            {
                return $"Title: {Title}\nTheatre: {Theatre}\nGenre: {Genre}\nDuration: {Duration} minutes\nActors: {string.Join(", ", Actors)}\nLead Actors: {string.Join(", ", LeadActors)}\nAudience: {string.Join(", ", Audience)}";
            }

            ~Performance()
            {
                Dispose(false);
            }
        }
}

