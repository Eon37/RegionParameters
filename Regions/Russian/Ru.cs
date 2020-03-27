using System;
using System.Globalization;

namespace lab4
{
    class Ru : IRegParams
    {
        string IRegParams.lang()
        {
            return new string("Русский");
        }

        string IRegParams.currency(bool symb)
        {
            RegionInfo ri = new RegionInfo("ru");
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
            return new string("Понедельник");
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
            if (name.Length != 3) throw new FormatException("Введено не полное имя.");
            return new string(name[0]+" "+name[1]+" "+name[2]);
        }

        string IRegParams.encoding(bool universal)
        {
            return universal ? new string("UTF-8") : new string("Windows-1251");
        }
        
        string IRegParams.timeZone()
        {
            return new string("Moscow UTC+3");
        }
    }
}