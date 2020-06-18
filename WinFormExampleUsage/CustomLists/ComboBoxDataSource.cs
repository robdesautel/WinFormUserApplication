using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormExampleUsage.CustomLists
{
    public static class ComboBoxDataSource
    {
        public static  List<PersonType> personTypes()
        {
            var personTypes = new List<PersonType>();

            personTypes.AddRange(new[]
            {
                new PersonType("",""),
                new PersonType("Store Contact", "SC"),
                new PersonType("Indvidual (retail) customer", "IN"),
                new PersonType("Sales person", "SP"),
                new PersonType("Employee (non-sales)", "EM"),
                new PersonType("Vendor contact", "VC"),
                new PersonType("General contact", "GC")
            });
            return personTypes;
        }

        public static List<PersonTitle> personTitles()
        {
            List<PersonTitle> personTitles = new List<PersonTitle>();

            personTitles.AddRange(new[]
            {
                new PersonTitle(""),
                new PersonTitle("Mr."),
                new PersonTitle("Ms."),
                new PersonTitle("Mrs."),
                new PersonTitle("Other")
            }) ;

            return personTitles;
        }

        public static List<PersonSuffix> personSuffixes()
        {
            List<PersonSuffix> personSuffixes = new List<PersonSuffix>();

            personSuffixes.AddRange(new[]
            {
                new PersonSuffix(""),
                new PersonSuffix("Sr"),
                new PersonSuffix("Jr"),
                new PersonSuffix("III"),
                new PersonSuffix("IV")

            });

            return personSuffixes;
        }


    }
}
