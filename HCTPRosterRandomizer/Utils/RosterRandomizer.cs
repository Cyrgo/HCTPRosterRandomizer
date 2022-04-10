using System;
using System.Collections.Generic;
using System.Linq;
using HCTPRosterRandomizer.Superstars;

namespace HCTPRosterRandomizer.Utils {
    public static class RosterRandomizer {
        private static void MaleDraw(List<Wrestler> randomizedMales) {
            var maleSplit = randomizedMales.Count / 2;
            // Console.WriteLine(maleSplit.ToString());
            var maleRemainder = randomizedMales.Count - maleSplit;
            // Console.WriteLine(maleRemainder.ToString());

            Console.WriteLine("--------------SMACKDOWN-------------");

            var smackDown = randomizedMales.GetRange(0, maleSplit);
            foreach (var wrestler in smackDown) {
                Console.WriteLine(wrestler.Name);
            }

            Console.WriteLine("--------------RAW-------------");

            var raw = randomizedMales.GetRange(maleSplit, maleRemainder);
            foreach (var wrestler in raw) {
                Console.WriteLine(wrestler.Name);
            }
        }

        private static void FemaleDraw(List<Wrestler> randomizedFemales) {
            var femaleSplit = randomizedFemales.Count / 2;
            // Console.WriteLine(femaleSplit.ToString());
            var femaleRemainder = randomizedFemales.Count - femaleSplit;
            // Console.WriteLine(femaleRemainder.ToString());

            Console.WriteLine("--------------SMACKDOWN-------------");
            var smackDown = randomizedFemales.GetRange(0, femaleSplit);
            foreach (var wrestler in smackDown) {
                Console.WriteLine(wrestler.Name);
            }

            Console.WriteLine("--------------RAW-------------");
            var raw = randomizedFemales.GetRange(femaleSplit, femaleRemainder);
            foreach (var wrestler in raw) {
                Console.WriteLine(wrestler.Name);
            }
        }

        public static void Randomize() {
            var athletes = new Athletes();
            Console.WriteLine("TOTAL MALE WRESTLERS: " + athletes.MaleWrestlers.Count);
            Console.WriteLine("TOTAL FEMALE WRESTLERS: " + athletes.FemaleWrestlers.Count);
            Console.WriteLine("---------------------------");

            var eligibleMales = TitleHoldersExcluder.MaleExcluder(athletes.MaleWrestlers);
            var eligibleFemales = TitleHoldersExcluder.FemaleExcluder(athletes.FemaleWrestlers);

            Console.WriteLine("ELIGIBLE MALE WRESTLERS FOR TRANSFER: " + eligibleMales.Count);
            Console.WriteLine("ELIGIBLE FEMALE WRESTLERS FOR TRANSFER: " + eligibleFemales.Count);

            var random = new Random();
            var randomizedMales = eligibleMales.OrderBy(wrestler => random.Next()).ToList();
            var randomizedFemales = eligibleFemales.OrderBy(wrestler => random.Next()).ToList();

            MaleDraw(randomizedMales);
            FemaleDraw(randomizedFemales);
        }
    }
}