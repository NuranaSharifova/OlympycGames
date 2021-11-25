using System;
using PracticeEntiry.Models;
namespace PracticeEntiry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DtbaseContext db = new DtbaseContext();
            Adddata(db);
        }
        private static void Adddata(DtbaseContext db)
        {

            db.Countries.Add(new Countries { Name = "Azerbaijan" });
            db.Countries.Add(new Countries { Name = "Turkey" });
            db.Countries.Add(new Countries { Name = "France" });
            db.Countries.Add(new Countries { Name = "Italy" });
            db.Countries.Add(new Countries { Name = "Russia" });
            db.Countries.Add(new Countries { Name = "USA" });

            db.Medals.Add(new Medals { Name = "Gold" });
            db.Countries.Add(new Countries { Name = "Silver" });
            db.Countries.Add(new Countries { Name = "Bronze" });
            db.Countries.Add(new Countries { Name = "No" });

            db.Sports.Add(new Sports { Name = "FootBall" });
            db.Sports.Add(new Sports { Name = "Basketball" });
            db.Sports.Add(new Sports { Name = "Swimming" });
            db.Sports.Add(new Sports { Name = "Voleyball" });


            db.Partipicants.Add(new Partipicants { FirstName = "Part1", LastName = "Participant1", CountryID = 1 });
            db.Partipicants.Add(new Partipicants { FirstName = "Part2", LastName = "Participant2", CountryID = 2 });
            db.Partipicants.Add(new Partipicants { FirstName = "Part3", LastName = "Participant3", CountryID = 3 });
            db.Partipicants.Add(new Partipicants { FirstName = "Part4", LastName = "Participant4", CountryID = 4 });
            db.Partipicants.Add(new Partipicants { FirstName = "Part5", LastName = "Participant5", CountryID = 5 });
            db.Partipicants.Add(new Partipicants { FirstName = "Part6", LastName = "Participant6", CountryID = 6 });

            db.PartMedals.Add(new PartMedals { PartID = 1, SportID = 2, MedalID = 1 });
            db.PartMedals.Add(new PartMedals { PartID = 2, SportID = 1, MedalID = 2 });
            db.PartMedals.Add(new PartMedals { PartID = 3, SportID = 3, MedalID = 1 });
            db.PartMedals.Add(new PartMedals { PartID = 4, SportID = 4, MedalID = 2 });
            db.PartMedals.Add(new PartMedals { PartID = 5, SportID = 5, MedalID = 3 });
            db.SaveChanges();

        }
    }
}
