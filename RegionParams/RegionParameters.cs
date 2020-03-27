using System;

namespace lab4
{
    interface IRegParams
    {
        string lang();
        string currency(bool symb);
        string dateFormat(DateTime dt);
        string timeFormat(DateTime dt);
        string weekStart();
        bool isMetric();
        string readingDirection();
        string nameFormat(params string[] name);
        string encoding(bool universal);
        string timeZone();
    }
}