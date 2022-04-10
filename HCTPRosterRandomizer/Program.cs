using System;
using HCTPRosterRandomizer.Superstars;
using HCTPRosterRandomizer.Utils;

namespace HCTPRosterRandomizer {
    internal static class Program {
        public static void Main(string[] args) {
            var athletes = new Athletes();
            Console.WriteLine("MALE WRESTLERS: " + athletes.MaleWrestlers.Count);
            Console.WriteLine("FEMALE WRESTLERS: " + athletes.FemaleWrestlers.Count);

            var eligibleMales = TitleHoldersExcluder.MaleExcluder(athletes.MaleWrestlers);
            var eligibleFemales = TitleHoldersExcluder.FemaleExcluder(athletes.FemaleWrestlers);
            
            Console.WriteLine("MALE WRESTLERS: " + athletes.MaleWrestlers.Count);
            Console.WriteLine("FEMALE WRESTLERS: " + athletes.FemaleWrestlers.Count);
            
            // var random = new Random();
            // var randomizedMales = athletes.MaleWrestlers.OrderBy(wrestler => random.Next()).ToList();
            // var randomizedFemales = athletes.FemaleWrestlers.OrderBy(wrestler => random.Next()).ToList();
            // foreach (var male in randomizedMales) {
            //     Console.WriteLine(male.Name);
            // }

            // foreach (var female in randomizedFemales) {
            //     Console.WriteLine(female.Name);
            // }
        }
    }
}