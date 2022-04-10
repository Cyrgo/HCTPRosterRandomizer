using System;
using System.Collections.Generic;
using System.Linq;
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

            Console.WriteLine("MALE WRESTLERS: " + eligibleMales.Count);
            Console.WriteLine("FEMALE WRESTLERS: " + eligibleFemales.Count);

            var random = new Random();
            var randomizedMales = eligibleMales.OrderBy(wrestler => random.Next()).ToList();
            var randomizedFemales = eligibleFemales.OrderBy(wrestler => random.Next()).ToList();
            foreach (var male in randomizedMales) {
                Console.WriteLine(male.Name);
            }
            foreach (var female in randomizedFemales) {
                Console.WriteLine(female.Name);
            }

            var maleSplit = randomizedMales.Count / 2;
            Console.WriteLine(maleSplit.ToString());
            var maleRemainder = athletes.MaleWrestlers.Count - maleSplit;
            Console.WriteLine(maleRemainder.ToString());
            
        }
    }
}