using System;

namespace lab4
{
    ///<summary>
    ///Class that initializes the apropriate settings depending on the input region
    ///</summary>
    class Regions
    {
        ///<summary>
        ///Variable to keep and manipulate the input country name
        ///</summary>
        public static string countryName;

        ///<summary>
        ///Entry point
        ///</summary>
        ///<remarks>
        ///Initializes the apropriate region
        ///</remarks>
        ///<param name="arg">Contains the entered country name</param>
        public static void Main(string arg)
        {
            countryName = arg.ToUpper();

            try
            {
                CreateRegion reg = initReg(countryName);
                showDefaultSettings(reg);
            }
            catch(System.NullReferenceException)
            {
                Console.WriteLine("Incorrect country name.");
            }
            catch(System.FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
            }
        }

        ///<summary>
        ///Prints settings to the console
        ///</summary>
        ///<param name="reg">A type that creates initialized region</param>
        ///<exception cref="System.FormatException">Thrown when the input name is incomplete</exception>
        public static void showDefaultSettings(CreateRegion reg)
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

        ///<summary>
        ///Initializes region depending on its name
        ///</summary>
        ///<param name="regName">Name of the region</param>
        ///<returns>
        ///A type that creates initialized region
        ///</returns>
        ///<exception cref="System.NullReferenceException">Thrown when input name is incorrect or there are no country with entered name</exception>
        private static CreateRegion initReg (string regName)
        {
            switch(regName)
            {
                case "RUSSIA" : return new CreateRussia();
                case "GERMANY" : return new CreateGermany();
                case "CHINA" : return new CreateChina();
                default : throw new System.NullReferenceException();
            }
        }
    }
}
