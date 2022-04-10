namespace HCTPRosterRandomizer.Superstars {
    
    public enum Gender {
        Male,
        Female,
        Other
    }
    
    public class Wrestler {
        public string Name { get; set; }
        public bool TitleHolder { get; set; }
        
        public Wrestler(string name, bool titleHolder) {
            this.Name = name;
            this.TitleHolder = titleHolder;
        }
    }
}