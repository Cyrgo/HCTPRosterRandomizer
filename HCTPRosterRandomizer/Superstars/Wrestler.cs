namespace HCTPRosterRandomizer.Superstars {
    
    public enum Gender {
        Male,
        Female,
        Other
    }
    
    public class Wrestler {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        
        public Wrestler(string name, Gender gender) {
            this.Name = name;
            this.Gender = gender;
        }
    }
}