using System.Collections.Generic;

namespace HCTPRosterRandomizer.Superstars {
    public class Athletes {
        public List<Wrestler> MaleWrestlers { get; set; }
        public List<Wrestler> FemaleWrestlers { get; set; }
        // public List<Wrestler> OtherWrestlers { get; }

        public Athletes() {
            this.MaleWrestlers = new List<Wrestler>() {
                new Wrestler("A-Train", Gender.Male, false),
                new Wrestler("Animal", Gender.Male, false),
                new Wrestler("Batista", Gender.Male, false),
                new Wrestler("Big Show", Gender.Male, false),
                new Wrestler("Booker T", Gender.Male, false),
                new Wrestler("Brock Lesnar", Gender.Male, false),
                new Wrestler("Bubba Ray Dudley", Gender.Male, false),
                new Wrestler("Charlie Haas", Gender.Male, false),
                new Wrestler("Chavo Guerrero", Gender.Male, false),
                new Wrestler("Chris Benoit", Gender.Male, false),
                new Wrestler("Chris Jericho", Gender.Male, false),
                new Wrestler("Christian", Gender.Male, false),
                new Wrestler("D-Von Dudley", Gender.Male, false),
                new Wrestler("Eddie Guerrero", Gender.Male, false),
                new Wrestler("Edge", Gender.Male, false),
                // RAW GM
                // new Wrestler("Eric Bischoff", Gender.Male, false),
                new Wrestler("George Steele", Gender.Male, false),
                new Wrestler("Goldberg", Gender.Male, false),
                new Wrestler("Goldust", Gender.Male, false),
                new Wrestler("Hawk", Gender.Male, false),
                new Wrestler("Hillbilly Jim", Gender.Male, false),
                new Wrestler("The Hurricane", Gender.Male, false),
                new Wrestler("Iron Sheik", Gender.Male, false),
                new Wrestler("Jeff Hardy", Gender.Male, false),
                new Wrestler("John Cena", Gender.Male, false),
                new Wrestler("Kane", Gender.Male, false),
                new Wrestler("Kevin Nash", Gender.Male, false),
                new Wrestler("Kurt Angle", Gender.Male, false),
                new Wrestler("Lance Storm", Gender.Male, false),
                new Wrestler("Matt Hardy", Gender.Male, false),
                new Wrestler("Nikolai Volkoff", Gender.Male, false),
                new Wrestler("Randy Orton", Gender.Male, false),
                new Wrestler("Rey Mysterio", Gender.Male, false),
                new Wrestler("Rhyno", Gender.Male, false),
                new Wrestler("Ric Flair", Gender.Male, false),
                new Wrestler("Rico", Gender.Male, false),
                new Wrestler("Rikishi", Gender.Male, false),
                new Wrestler("Rob Van Damn", Gender.Male, false),
                new Wrestler("The Rock", Gender.Male, false),
                new Wrestler("Roddy Piper", Gender.Male, false),
                new Wrestler("Rodney Mack", Gender.Male, false),
                new Wrestler("Scott Steiner", Gender.Male, false),
                new Wrestler("Sean O'Haire", Gender.Male, false),
                new Wrestler("Sgt. Slaughter", Gender.Male, false),
                new Wrestler("Shawn Micheals", Gender.Male, false),
                new Wrestler("Shelton Benjamin", Gender.Male, false),
                new Wrestler("Steve Austin", Gender.Male, false),
                new Wrestler("Steven Richards", Gender.Male, false),
                new Wrestler("Tajiri", Gender.Male, false),
                new Wrestler("Ted Dibiase", Gender.Male, false),
                new Wrestler("Test", Gender.Male, false),
                new Wrestler("Triple H", Gender.Male, false),
                new Wrestler("Ultimo Dragon", Gender.Male, false),
                new Wrestler("The Undertaker/Undertaker", Gender.Male, false),
                new Wrestler("Val Venis", Gender.Male, false),
                // WWE Owner
                // new Wrestler("Vince McMahon", Gender.Male, false),
                // Custom Wrestlers
                new Wrestler("Anime Man", Gender.Male, false),
                new Wrestler("Bionic Man", Gender.Male, false),
                new Wrestler("Scorpion", Gender.Male, false),
                new Wrestler("Joe Biden", Gender.Male, false),
            };
            this.FemaleWrestlers = new List<Wrestler>() {
                new Wrestler("Jazz", Gender.Female, false),
                new Wrestler("Lita", Gender.Female, false),
                new Wrestler("Sable", Gender.Female, false),
                new Wrestler("Stacy Keibler", Gender.Female, false),
                // SmackDown! GM
                // new Wrestler("Stephanie McMahon", Gender.Female, false),
                new Wrestler("Torrie Wilson", Gender.Female, false),
                new Wrestler("Trish Stratus", Gender.Female, false),
                new Wrestler("Victoria", Gender.Female, false),
                // Custom Wrestlers
                new Wrestler("Domino", Gender.Female, false),
                new Wrestler("Anime Woman", Gender.Female, false),
                new Wrestler("Jubilee", Gender.Female, false),
            };
        }
    }
}