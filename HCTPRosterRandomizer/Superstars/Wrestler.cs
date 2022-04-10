namespace HCTPRosterRandomizer.Superstars {
    
    public enum Gender {
        Male,
        Female,
        Other
    }
    
    public class Wrestler {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public bool TitleHolder { get; set; }
        
        public Wrestler(string name, Gender gender, bool titleHolder) {
            this.Name = name;
            this.Gender = gender;
            this.TitleHolder = titleHolder;
        }
    }
}