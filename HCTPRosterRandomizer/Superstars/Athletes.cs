using System.Collections.Generic;

namespace HCTPRosterRandomizer.Superstars {
    public class Athletes {
        public List<Wrestler> MaleWrestlers { get; }
        public List<Wrestler> FemaleWrestlers { get; }
        // public List<Wrestler> OtherWrestlers { get; }

        public Athletes() {
            MaleWrestlers = new List<Wrestler>() {
                new Wrestler("A-Train", Gender.Male),
                new Wrestler("Animal", Gender.Male),
                new Wrestler("Batista", Gender.Male),
                new Wrestler("Big Show", Gender.Male),
                new Wrestler("Booker T", Gender.Male),
                new Wrestler("Brock Lesnar", Gender.Male),
                new Wrestler("Bubba Ray Dudley", Gender.Male),
                new Wrestler("Charlie Haas", Gender.Male),
                new Wrestler("Chavo Guerrero", Gender.Male),
                new Wrestler("Chris Benoit", Gender.Male),
                new Wrestler("Chris Jericho", Gender.Male),
                new Wrestler("Christian", Gender.Male),
                new Wrestler("D-Von Dudley", Gender.Male),
                new Wrestler("Eddie Guerrero", Gender.Male),
                new Wrestler("Edge", Gender.Male),
                // RAW Manager
                // new Wrestler("Eric Bischoff", Gender.Male),
                new Wrestler("George Steele", Gender.Male),
                new Wrestler("Goldberg", Gender.Male),
                new Wrestler("Goldust", Gender.Male),
                new Wrestler("Hawk", Gender.Male),
                new Wrestler("Hillbilly Jim", Gender.Male),
                new Wrestler("The Hurricane", Gender.Male),
                new Wrestler("Iron Sheik", Gender.Male),
                new Wrestler("Jeff Hardy", Gender.Male),
                new Wrestler("John Cena", Gender.Male),
                new Wrestler("Kane", Gender.Male),
                new Wrestler("Kevin Nash", Gender.Male),
                new Wrestler("Kurt Angle", Gender.Male),
                new Wrestler("Lance Storm", Gender.Male),
                new Wrestler("Matt Hardy", Gender.Male),
                new Wrestler("Nikolai Volkoff", Gender.Male),
                new Wrestler("Randy Orton", Gender.Male),
                new Wrestler("Rey Mysterio", Gender.Male),
                new Wrestler("Rhyno", Gender.Male),
                new Wrestler("Ric Flair", Gender.Male),
                new Wrestler("Rico", Gender.Male),
                new Wrestler("Rikishi", Gender.Male),
                new Wrestler("Rob Van Damn", Gender.Male),
                new Wrestler("The Rock", Gender.Male),
                new Wrestler("Roddy Piper", Gender.Male),
                new Wrestler("Rodney Mack", Gender.Male),
                new Wrestler("Scott Steiner", Gender.Male),
                new Wrestler("Sean O'Haire", Gender.Male),
                new Wrestler("Sgt. Slaughter", Gender.Male),
                new Wrestler("Shawn Micheals", Gender.Male),
                new Wrestler("Shelton Benjamin", Gender.Male),
                new Wrestler("Steve Austin", Gender.Male),
                new Wrestler("Steven Richards", Gender.Male),
                new Wrestler("Tajiri", Gender.Male),
                new Wrestler("Ted Dibiase", Gender.Male),
                new Wrestler("Test", Gender.Male),
                new Wrestler("Triple H", Gender.Male),
                new Wrestler("Ultimo Dragon", Gender.Male),
                new Wrestler("The Undertaker/Undertaker", Gender.Male),
                new Wrestler("Val Venis", Gender.Male),
                // WWE Owner
                // new Wrestler("Vince McMahon", Gender.Male),
                // Custom Wrestlers
                new Wrestler("Anime Man", Gender.Male),
                new Wrestler("Bionic Man", Gender.Male),
                new Wrestler("Scorpion", Gender.Male),
                new Wrestler("Joe Biden", Gender.Male),
            };
            FemaleWrestlers = new List<Wrestler>() {
                new Wrestler("Jazz", Gender.Female),
                new Wrestler("Lita", Gender.Female),
                new Wrestler("Sable", Gender.Female),
                new Wrestler("Stacy Keibler", Gender.Female),
                // Smackdown GM
                // new Wrestler("Stephanie McMahon", Gender.Female),
                new Wrestler("Torrie Wilson", Gender.Female),
                new Wrestler("Trish Stratus", Gender.Female),
                new Wrestler("Victoria", Gender.Female),
                // Custom Wrestlers
                new Wrestler("Domino", Gender.Female),
                new Wrestler("Anime Woman", Gender.Female),
                new Wrestler("Jubilee", Gender.Female),
                
            };
        }
    }
}