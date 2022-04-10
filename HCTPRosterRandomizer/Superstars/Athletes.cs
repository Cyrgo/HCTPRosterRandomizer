using System.Collections.Generic;

namespace HCTPRosterRandomizer.Superstars {
    public class Athletes {
        public List<Wrestler> MaleWrestlers { get; set; }
        public List<Wrestler> FemaleWrestlers { get; set; }
        // public List<Wrestler> OtherWrestlers { get; }

        public Athletes() {
            this.MaleWrestlers = new List<Wrestler>() {
                new Wrestler("A-Train", false),
                new Wrestler("Animal", false),
                new Wrestler("Batista", false),
                new Wrestler("Big Show", false),
                new Wrestler("Booker T", false),
                new Wrestler("Brock Lesnar", false),
                new Wrestler("Bubba Ray Dudley", false),
                new Wrestler("Charlie Haas", false),
                new Wrestler("Chavo Guerrero", false),
                new Wrestler("Chris Benoit", false),
                new Wrestler("Chris Jericho", false),
                new Wrestler("Christian", false),
                new Wrestler("D-Von Dudley", false),
                new Wrestler("Eddie Guerrero", false),
                new Wrestler("Edge", false),
                // RAW GM
                // new Wrestler("Eric Bischoff", false),
                new Wrestler("George Steele", false),
                new Wrestler("Goldberg", false),
                new Wrestler("Goldust", false),
                new Wrestler("Hawk", false),
                new Wrestler("Hillbilly Jim", false),
                new Wrestler("The Hurricane", false),
                new Wrestler("Iron Sheik", false),
                new Wrestler("Jeff Hardy", false),
                new Wrestler("John Cena", false),
                new Wrestler("Kane", false),
                new Wrestler("Kevin Nash", false),
                new Wrestler("Kurt Angle", false),
                new Wrestler("Lance Storm", false),
                new Wrestler("Matt Hardy", false),
                new Wrestler("Nikolai Volkoff", false),
                new Wrestler("Randy Orton", false),
                new Wrestler("Rey Mysterio", false),
                new Wrestler("Rhyno", false),
                new Wrestler("Ric Flair", false),
                new Wrestler("Rico", false),
                new Wrestler("Rikishi", false),
                new Wrestler("Rob Van Damn", false),
                new Wrestler("The Rock", false),
                new Wrestler("Roddy Piper", false),
                new Wrestler("Rodney Mack", false),
                new Wrestler("Scott Steiner", false),
                new Wrestler("Sean O'Haire", false),
                new Wrestler("Sgt. Slaughter", false),
                new Wrestler("Shawn Micheals", false),
                new Wrestler("Shelton Benjamin", false),
                new Wrestler("Steve Austin", false),
                new Wrestler("Steven Richards", false),
                new Wrestler("Tajiri", false),
                new Wrestler("Ted Dibiase", false),
                new Wrestler("Test", false),
                new Wrestler("Triple H", false),
                new Wrestler("Ultimo Dragon", false),
                new Wrestler("The Undertaker/Undertaker", false),
                new Wrestler("Val Venis", false),
                // WWE Owner
                // new Wrestler("Vince McMahon", false),
                // Custom Wrestlers
                new Wrestler("Anime Man", false),
                new Wrestler("Bionic Man", false),
                new Wrestler("Scorpion", false),
                new Wrestler("Joe Biden", false),
            };
            this.FemaleWrestlers = new List<Wrestler>() {
                new Wrestler("Jazz", false),
                new Wrestler("Lita", false),
                new Wrestler("Sable", false),
                new Wrestler("Stacy Keibler", false),
                // SmackDown! GM
                // new Wrestler("Stephanie McMahon", false),
                new Wrestler("Torrie Wilson", false),
                new Wrestler("Trish Stratus", false),
                new Wrestler("Victoria", false),
                // Custom Wrestlers
                new Wrestler("Domino", false),
                new Wrestler("Anime Woman", false),
                new Wrestler("Jubilee", false),
            };
        }
    }
}