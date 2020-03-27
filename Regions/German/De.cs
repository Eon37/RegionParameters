using System;
using System.Globalization;

namespace lab4
{
    class De : IRegParams
    {
        string IRegParams.lang()
        {
            return new string("Deutsch");
        }

        string IRegParams.currency(bool symb)
        {
            RegionInfo ri = new RegionInfo("de");
            return symb? ri.CurrencySymbol : ri.ISOCurrencySymbol;
        }

        string IRegParams.dateFormat(DateTime dt)
        {
            return new string(dt.Day + "." + dt.Month + "." + dt.Year);
        }

        string IRegParams.timeFormat(DateTime dt)
        {
            return new string(dt.Hour + ":" + dt.Minute);
        }

        string IRegParams.weekStart()
        {
            return new string("Montag");
        }

        bool IRegParams.isMetric()
        {
            return true;
        }

        string IRegParams.readingDirection()
        {
            return new string("LTR");
        }

        string IRegParams.nameFormat(params string[] name)
        {
            if (name.Length < 2) throw new FormatException("Unvollständiger Name.");
            string fullName="";
            foreach(string n in name)
            {
                fullName+= (n+" ");
            }
            return new string(fullName);
        }

        string IRegParams.encoding(bool universal)
        {
            return universal ? new string("UTF-8") : new string("ISO/IEC 8859-15");
        }

        string IRegParams.timeZone()
        {
            return new string("UTC+1");
        }
          
    }
}