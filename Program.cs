using System;

namespace lab4
{
    class Regions
    {
        static string countryName;
        public static void Main(string arg)
        {
            countryName = arg;
            CreateRegion reg = initReg(countryName);
            showDefaultSettings(reg);
        }

        static void showDefaultSettings(CreateRegion reg)
        {
            Console.WriteLine(countryName);
            var creg = reg.createReg();

            Console.WriteLine("Language: " + creg.lang());
            Console.WriteLine("Currency: " + creg.currency(false));
            Console.WriteLine("Date: " + creg.dateFormat(DateTime.Now));
            Console.WriteLine("Time: " + creg.timeFormat(DateTime.Now));
            Console.WriteLine("Capital time zone: " + creg.timeZone());
            Console.WriteLine("Week starts at " + creg.weekStart());
            Console.WriteLine("Uses metric system: " + creg.isMetric());
            Console.WriteLine("Reading direction: " + creg.readingDirection());
            Console.WriteLine("Encoding: " + creg.encoding(false));
            Console.WriteLine("Full name: " + creg.nameFormat(new string[]{"First", "Midle", "Last"}));
        }

        static CreateRegion initReg (string regName)
        {
            switch(regName)
            {
                case "Russia" : return new CreateRussia();
                case "Germany" : return new CreateGermany();
                case "China" : return new CreateChina();
                default : return null;
            }
        }
    }
}
