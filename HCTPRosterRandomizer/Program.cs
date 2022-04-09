using System;
using System.Linq;
using HCTPRosterRandomizer.Superstars;

namespace HCTPRosterRandomizer {
    internal static class Program {
        public static void Main(string[] args) {
            var athletes = new Athletes();
            Console.WriteLine("MALE WRESTLERS: " + athletes.MaleWrestlers.Count);
            // foreach (var athlete in athletes.MaleWrestlers) {
            //     Console.WriteLine(athlete.Name);
            // }
            Console.WriteLine("FEMALE WRESTLERS: " + athletes.FemaleWrestlers.Count);
            // foreach (var athlete in athletes.FemaleWrestlers) {
            //     Console.WriteLine(athlete.Name);
            // }

            var random = new Random();
            var randomizedMales = athletes.MaleWrestlers.OrderBy(wrestler => random.Next());
            var randomizedFemales = athletes.FemaleWrestlers.OrderBy(wrestler => random.Next());
            // foreach (var male in randomizedMales) {
            //     Console.WriteLine(male.Name);
            // }

            // foreach (var female in randomizedFemales) {
            //     Console.WriteLine(female.Name);
            // }

            
        }
    }
}