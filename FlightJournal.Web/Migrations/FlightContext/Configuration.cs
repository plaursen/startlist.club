using System.Collections.Generic;
using FlightJournal.Web.Models;
using FlightJournal.Web.Models.Training;

namespace FlightJournal.Web.Migrations.FlightContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FlightJournal.Web.Models.FlightContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; 
            AutomaticMigrationDataLossAllowed = false;
            MigrationsDirectory = @"Migrations\FlightContext";
        }

        protected override void Seed(FlightJournal.Web.Models.FlightContext context)
        {
            //  This method will be called after migrating to the latest version.

            var forceTrainingProgramRecreation = true;

            if (forceTrainingProgramRecreation
                || !context.TrainingPrograms.Any()
                || !context.TrainingLessons.Any()
                || !context.TrainingExercises.Any()
                || !context.TrainingProgramLessonRelations.Any()
                || !context.TrainingLessonExerciseRelations.Any()
                )
            {
                InitializeTrainingLessons(context);
            }

            //  Only seed if the database is empty
            if (!context.StartTypes.Any() 
                && (!context.Clubs.Any())
                && (!context.Pilots.Any())
                && (!context.Planes.Any()))
            {
                InitializeDemoFlights(context);
            }

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        private void InitializeTrainingLessons(Models.FlightContext context)
        {
            // ren r�v
            context.TrainingPrograms.RemoveRange(context.TrainingPrograms);
            context.TrainingLessons.RemoveRange(context.TrainingLessons);
            context.TrainingExercises.RemoveRange(context.TrainingExercises);
            context.TrainingProgramLessonRelations.RemoveRange(context.TrainingProgramLessonRelations);
            context.TrainingLessonExerciseRelations.RemoveRange(context.TrainingLessonExerciseRelations);


            var tpSPL_S = new Training2Program("SPL-S", "SPL, spilstart",
                @"S�rligt for elever, der indtr�der i tr�ningsprogrammet fra en anden DTO/ATO: 
N�r elever, der er startet p� uddannelsen til SPL - certifikat i en anden DTO / ATO, �nsker at forts�tte uddannelsen i DSvU�s DTO, skal den uddannelsesansvarlige p� den flyveplads, hvor eleven �nsker at forts�tte uddannelsen, skabe sig overblik over, hvor langt eleven er kommet i sin uddannelse.
Den uddannelsesansvarlige skal hvis muligt indhente oplysninger hos Assisterende Head of Training i den ATO / DTO, som eleven kommer fra.Inden uddannelsen kan forts�tte i DSvU�s DTO, skal den uddannelsesansvarlige flyve en eller flere flyvninger med eleven for at konstatere det aktuelle uddannelsesniveau.
 
Operationelle bestemmelser for at flyve f�rste soloflyvning: 
Ved f�rste soloflyvning m� vindhastigheden ikke overstige 20 kts, og sidevindskomponenten m� ikke overstige 12 kts.Eleven skal forud for soloflyvningen have vist evnen til at kunne starte i den maksimale sidevindskomponent, og begr�nsninger i skoleflyets h�ndbog skal under alle omst�ndigheder overholdes. ")
                {Url = @"https://medlem.dsvu.dk/grp900/2129-uhb922-flyvelektioner-til-spl-certifikat-spilstart/file/menu-id-117" };

            var lessSPL_A0 =  new Models.Training.Training2Lesson(
                "A0",
                @"Eleven skal instrueres i, hvordan skoleflyet er indrettet og hvilke elementer, der skal betjenes under flyvningen. Lektionen b�r gennemf�res som det allerf�rste i elevens uddannelsen. �velsen i sig selv medf�rer ikke flyvning.
                Eleven skal instrueres i sin rolle, hvis der skulle opst� en faresituation under flyvning, og hvilke ting han skal g�re i en s�dan situation. Eleven skal endvidere instrueres i, at der under uddannelsen vil opst� situationer som led i tr�ningen, og som ikke er hverken en faretilstand eller en n�dsituation.
                Instrukt�ren skal vise eleven, hvordan han kan rapportere sikkerhedsm�ssige oplevelser til DSvU�s Safety Management System, for at andre kan l�re af denne oplevelse. Han skal endvidere orientere om, hvordan en pilot forholder sig, hvis der sker h�ndelse eller havari, og hvordan en pilot kan lave en rapportering, hvis han g�r sig skyldig i noget, som medf�rer overtr�delse af regler og bestemmelser")
            {
                Precondition = @"Eleven skal v�re fyldt 14 �r for at kunne flyve solo efter afsluttet uddannelse som sv�veflyvepilot"
            };
            var lessSPL_A1 = new Models.Training.Training2Lesson(
                "A1",
                @"Eleven skal orienteres om, hvad der skal v�re p� plads, inden man kan flyve, og at enhver skolingsflyvning starter med en briefing om, hvad der skal ske under flyvningen.
                Eleven skal hj�lpe med til at f� fly ud af hangaren og hj�lpe med til Dagligt Tilsyn.
                Eleven skal instrueres i, hvad han skal have med i flyet, for at tyngdepunktet ligger korrekt og for at sidde godt, s� han kan n� styregrejerne og have et tilstr�kkeligt udsyn.
                Eleven skal l�re at lave cockpitcheck efter flyets checkliste. Han skal forberede sig mentalt p� en afbrudt start samt l�re, at wiren under spilstart skal udkobles, hvis min. hastighed eller max. hastighed i spilstart n�s.
                Eleven skal orienteres om, hvordan flyveplads og terr�n ser ud fra luften, og han skal l�re at kigge ud inden �ndring af flyveretning."
            );
;

            var exSPL_A0_1 = new Training2Exercise("Sv�veflyets karakteristika", true);
            var exSPL_A0_2 = new Training2Exercise("Cockpit, instrumenter og udstyr", true);
            var exSPL_A0_3 = new Training2Exercise("Styregrejer, h�ndtag og kontakter", true);
            var exSPL_A0_4 = new Training2Exercise("Checkliste, procedure og kontrol", true);
            var exSPL_A0_5 = new Training2Exercise("N�dkast af f�rersk�rm og funktion af faldsk�rm", true){Note= @"f.eks. blokeret ror, luftbremse, udl�ser til kobling osv. " };
            var exSPL_A0_6 = new Training2Exercise("Systemsvigt � hvad g�r man?", true);
            var exSPL_A0_7 = new Training2Exercise("Procedure for udspring", true);
            var exSPL_A0_8 = new Training2Exercise("DSvU�s Safety Management System", true){Note= @"Grundlag for at �ge den fremtidige flyvesikkerhed" };
            var exSPL_A0_9 = new Training2Exercise("Rapportering af h�ndelser m.v.", true){Note= @"Ogs� hvor der ikke skete noget, men hvor risikoen var der" };
            var exSPL_A0_10 = new Training2Exercise("Hvordan rapporterer man", true){Note= @"Via DSvU�s hjemmeside" };

            var exSPL_A1_1 = new Training2Exercise("Briefing inden flyvning", true){Note= @"Instrukt�ren har forud kigget i elevens uddannelseslog." };
            var exSPL_A1_2 = new Training2Exercise("Dokumenter til r�dighed", true){Note= @"Flyets dokumenter mv" };
            var exSPL_A1_3 = new Training2Exercise("N�dvendigt udstyr", true);
            var exSPL_A1_4 = new Training2Exercise("H�ndtering af fly f�r flyvning");
            var exSPL_A1_5 = new Training2Exercise("Tilsyn og kontrol med fly");
            var exSPL_A1_6 = new Training2Exercise("Max. og min. v�gt / tyngdepunkt"){Note= @"Evt. ballast ved elev med lav v�gt" };
            var exSPL_A1_7 = new Training2Exercise("Indstilling af s�de, pedaler og seler");
            var exSPL_A1_8 = new Training2Exercise("Cockpitcheck efter checkliste");
            var exSPL_A1_9 = new Training2Exercise("Hvad er flyets mindste hastighed i spilstart") { Note = @"Udkobling hvis min. hastighed n�s " };
            var exSPL_A1_10 = new Training2Exercise("Hvad er flyets maksimale hastighed i spilstart") { Note = @"Udkobling hvis max. hastighed n�s " };
            var exSPL_A1_11 = new Training2Exercise("Forberedelse til afbrudt start"){Note= @"Eleven l�rer, at han fremover skal fort�lle om sine overvejelser om en evt. afbrudt start" };
            var exSPL_A1_12 = new Training2Exercise("Orientering fra luften"){Note= @"Markante terr�npunkter" };
            var exSPL_A1_13 = new Training2Exercise("Procedure for udkig");


            context.TrainingPrograms.AddOrUpdate(
                tpSPL_S
                );
            context.TrainingLessons.AddOrUpdate(
                lessSPL_A0,                
                lessSPL_A1                
                );


            context.TrainingExercises.AddOrUpdate(
                exSPL_A0_1,
                exSPL_A0_2,
                exSPL_A0_3,
                exSPL_A0_4,
                exSPL_A0_5,
                exSPL_A0_6,
                exSPL_A0_7,
                exSPL_A0_8,
                exSPL_A0_9,
                exSPL_A0_10,
                exSPL_A1_1,
                exSPL_A1_2,
                exSPL_A1_3,
                exSPL_A1_4,
                exSPL_A1_5,
                exSPL_A1_6,
                exSPL_A1_7,
                exSPL_A1_8,
                exSPL_A1_9,
                exSPL_A1_10,
                exSPL_A1_11,
                exSPL_A1_12,
                exSPL_A1_13
                );


            context.TrainingProgramLessonRelations.AddOrUpdate(
                new Training2ProgramLessonRelation(tpSPL_S, lessSPL_A0, 1),
                new Training2ProgramLessonRelation(tpSPL_S, lessSPL_A1, 2)
                );

            context.TrainingLessonExerciseRelations.AddOrUpdate(
                new Training2LessonExerciseRelation(lessSPL_A0, exSPL_A0_1,1),
                new Training2LessonExerciseRelation(lessSPL_A0, exSPL_A0_2, 2),
                new Training2LessonExerciseRelation(lessSPL_A0, exSPL_A0_3, 3),
                new Training2LessonExerciseRelation(lessSPL_A0, exSPL_A0_4, 4),
                new Training2LessonExerciseRelation(lessSPL_A0, exSPL_A0_5, 5),
                new Training2LessonExerciseRelation(lessSPL_A0, exSPL_A0_6, 6),
                new Training2LessonExerciseRelation(lessSPL_A0, exSPL_A0_7, 7),
                new Training2LessonExerciseRelation(lessSPL_A0, exSPL_A0_8, 8),
                new Training2LessonExerciseRelation(lessSPL_A0, exSPL_A0_9, 9),
                new Training2LessonExerciseRelation(lessSPL_A0, exSPL_A0_10, 10),

                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_1,1),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_2, 2),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_3, 3),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_4, 4),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_5, 5),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_6, 6),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_7, 7),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_8, 8),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_9, 9),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_10, 10),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_11, 11),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_12, 12),
                new Training2LessonExerciseRelation(lessSPL_A1, exSPL_A1_13, 13)

                );

            context.SaveChanges();
        }

        internal static void InitializeDemoFlights(Models.FlightContext context)
        {
            // StartType
            var start = new StartType() { Name = "Spilstart", ShortName = "S" };
            context.StartTypes.Add(start);
            context.StartTypes.Add(new StartType() { Name = "Flysl�b", ShortName = "F" });
            context.StartTypes.Add(new StartType() { Name = "Selvstart", ShortName = "M" });
            context.SaveChanges();

            // Locations
            var location = new Location { Name = "Kongsted", Country = "DK", ICAO = "EKKL" };
            context.Locations.Add(location);
            var location2 = new Location { Name = "True", Country = "DK"};
            context.Locations.Add(location2);
            var location3 = new Location { Name = "Slaglille", Country = "DK", ICAO = "EKSL" };
            context.Locations.Add(location3);
            var location4 = new Location { Name = "T�ll�se" };
            context.Locations.Add(location4);
            var location5 = new Location { Name = "Martin", Country = "SK", ICAO = "LZMA" };
            context.Locations.Add(location5);
            
            context.Locations.Add(new Location() { Name = "Arnborg", Country = "DK", ICAO = "EK51" });
            context.SaveChanges();

            // Clubs
            var club = new Club() { ClubId = 38, ShortName = "�SF", Name = "�st-Sj�llands Flyveklub", Location = location, Website = "http://flyveklubben.dk"};
            context.Clubs.Add(club);
            var club2 = new Club() { ClubId = 99, ShortName = "AASVK", Name = "�rhus Sv�veflyveklub", Location = location2, Website = "http://www.aasvk.dk" };
            context.Clubs.Add(club2);
            var club3 = new Club() { ClubId = 199, ShortName = "MSF", Name = "Midtsj�llands Sv�veflyveklub", Location = location3, Website = "http://slaglille.dk" };
            context.Clubs.Add(club3);
            var club4 = new Club() { ClubId = 210, ShortName = "T�L", Name = "T�ll�se Flyveklub", Location = location4, Website = "http://www.cumulus.dk/" };
            context.Clubs.Add(club4);
            context.SaveChanges();

            // Planes
            var pl2 = new Plane
            {
                CompetitionId = "R2",
                Registration = "OY-XKO",
                Type = "ASK21",
                Seats = 2,
                DefaultStartType = start,
                Engines = 0
            };
            context.Planes.Add(pl2);
            var pla = new Plane
            {
                CompetitionId = "RR",
                Registration = "OY-RRX",
                Class = "Open",
                Type = "Duo Discus",
                Seats = 2,
                DefaultStartType = start,
                Engines = 1
            };
            context.Planes.Add(pla);
            var pl1 = new Plane
            {
                CompetitionId = "PU",
                Registration = "OY-XPU",
                Class = "15-Meter",
                Type = "LS6",
                Model = "LS6a",
                Seats = 1,
                DefaultStartType = start,
                Engines = 0
            };
            context.Planes.Add(pl1);
            context.SaveChanges();

            // Pilots
            var pilot = new Pilot { Name = "Jan Hebnes", MemberId = "1241", Club = club, Email = "jan.hebnes@gmail.com", MobilNumber = "+4500000000" };
            context.Pilots.Add(pilot);
            var pilot1 = new Pilot { Name = "Mr Demo Manager", MemberId = "9991", Club = club, MobilNumber = "+4500000001" };
            context.Pilots.Add(pilot1);
            var pilot2 = new Pilot { Name = "Mr Demo Editor", MemberId = "9992", Club = club, MobilNumber = "+4500000002" };
            context.Pilots.Add(pilot2);
            var pilot3 = new Pilot {Name = "Mr Demo Pilot", MemberId = "9993", Club = club, MobilNumber = "+4500000003"};
            context.Pilots.Add(pilot3);
            var pilot1B = new Pilot { Name = "Mr Demo OtherClub Manager", MemberId = "9995", Club = club3, MobilNumber = "+4500000005" };
            context.Pilots.Add(pilot1B);
            var pilot2B = new Pilot { Name = "Mr Demo OtherClub Editor", MemberId = "9996", Club = club3, MobilNumber = "+4500000006" };
            context.Pilots.Add(pilot2B);
            var pilot3B = new Pilot { Name = "Mr Demo OtherClub Pilot", MemberId = "9997", Club = club3, MobilNumber = "+4500000007" };
            context.Pilots.Add(pilot3B);


            context.SaveChanges();

            GenerateFlights(pl1, pl2, location, pilot, start)
                .ForEach(b => context.Flights.Add(b));

            GenerateFlights(pl1, pl2, location, pilot2, start)
                .ForEach(b => context.Flights.Add(b));
            
            GenerateFlights(pl1, pl2, location, pilot3, start)
                .ForEach(b => context.Flights.Add(b));


            GenerateFlights(pl1, pl2, location3, pilot2B, start)
                .ForEach(b => context.Flights.Add(b));

            GenerateFlights(pl1, pl2, location3, pilot3B, start)
                .ForEach(b => context.Flights.Add(b));
            
            GenerateFlights(pl1, pl2, location5, pilot3B, start)
                .ForEach(b => context.Flights.Add(b));

            context.SaveChanges();

        }

        private static List<Flight> GenerateFlights(Plane pl1, Plane pl2, Location location, Pilot pilot, StartType start)
        {
            var s = new List<Flight>
            {
                new Flight
                {
                    Departure = DateTime.Now.AddHours(-3),
                    Landing = DateTime.Now.AddHours(-3).AddMinutes(15),
                    Plane = pl1,
                    StartedFrom = location,
                    LandedOn = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    Description = "Demo flight",
                    LastUpdatedBy = pilot.ToString()
                },
                new Flight
                {
                    Plane = pl2,
                    StartedFrom = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    Description = "Demo flight",
                    LastUpdatedBy = pilot.ToString()
                },
                new Flight
                {
                    Departure = DateTime.Now.AddHours(-2),
                    Plane = pl2,
                    StartedFrom = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    LastUpdatedBy = pilot.ToString(),
                    Description = "Demo flight"
                },
                new Flight
                {
                    Departure = DateTime.Now.AddHours(-1),
                    Plane = pl2,
                    StartedFrom = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    Description = "Demo flight",
                    LastUpdatedBy = pilot.ToString()
                },
                new Flight
                {
                    Departure = DateTime.Now.AddHours(-4),
                    Plane = pl2,
                    StartedFrom = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    LastUpdatedBy = pilot.ToString(),
                    Description = "Demo flight"
                },
                new Flight
                {
                    Departure = DateTime.Now.AddHours(-3).AddMinutes(10),
                    Plane = pl2,
                    StartedFrom = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    Description = "Demo flight",
                    LastUpdatedBy = pilot.ToString()
                }
            };
            return s;
        }
    }
}
