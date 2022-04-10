using System;
using System.Collections.Generic;
using System.Linq;
using HCTPRosterRandomizer.Superstars;

namespace HCTPRosterRandomizer.Utils {
    public static class TitleHoldersExcluder {
        public static List<Wrestler> MaleExcluder(List<Wrestler> maleWrestlers) {
            Console.WriteLine("Who is the WWE Champion?");
            var wWEChampion = Console.In.ReadLine();

            Console.WriteLine("Who is the World HeavyWeight Champion?");
            var worldChampion = Console.In.ReadLine();

            Console.WriteLine("Who is the first WWE Tag Team Champion?");
            var firstWWETagChampion = Console.In.ReadLine();

            Console.WriteLine("Who is the second WWE Tag Team Champion?");
            var secondWWETagChampion = Console.In.ReadLine();

            Console.WriteLine("Who is the first World Tag Team Champion?");
            var firstWorldTagChampion = Console.In.ReadLine();

            Console.WriteLine("Who is the second World Tag Team Champion?");
            var secondWorldTagChampion = Console.In.ReadLine();

            Console.WriteLine("Who is the WWE Intercontinental Champion?");
            var wWEIntercontinentalChampion = Console.In.ReadLine();

            Console.WriteLine("Who is the WWE US Champion?");
            var wWEUSChampion = Console.In.ReadLine();

            Console.WriteLine("Who is the WWE CruiserWeight Champion?");
            var wWECruiserWeightChampion = Console.In.ReadLine();

            Console.WriteLine("Who is the WWE Hardcore Champion?");
            var wWEHardCoreChampion = Console.In.ReadLine();

            foreach (var male in maleWrestlers.Where(male =>
                         male.Name == wWEChampion ||
                         male.Name == worldChampion ||
                         male.Name == firstWWETagChampion ||
                         male.Name == secondWWETagChampion ||
                         male.Name == firstWorldTagChampion ||
                         male.Name == secondWorldTagChampion ||
                         male.Name == wWEIntercontinentalChampion ||
                         male.Name == wWEUSChampion ||
                         male.Name == wWECruiserWeightChampion ||
                         male.Name == wWEHardCoreChampion)) {
                male.TitleHolder = true;
            }

            return maleWrestlers.Where(male => !male.TitleHolder).ToList();
        }

        public static List<Wrestler> FemaleExcluder(List<Wrestler> femaleWrestlers) {
            Console.WriteLine("Who is the WWE Women's Champion?");
            var wWEWomenChampion = Console.In.ReadLine();
            foreach (var female in femaleWrestlers.Where(female => female.Name == wWEWomenChampion)) {
                female.TitleHolder = true;
            }

            return femaleWrestlers.Where(female => !female.TitleHolder).ToList();
        }
    }
}