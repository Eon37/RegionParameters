using System;

namespace lab4
{
    ///<summary>
    ///Defines settings for all regions
    ///</summary>
    interface IRegParams
    {
        ///<summary>
        ///Defines language
        ///</summary>
        ///<returns>
        ///Language of a region
        ///</returns>
        string lang();
        
        ///<summary>
        ///Defines Currency
        ///</summary>
        ///<param name="symb">Defines whether to write a currency symbol or a three-letter code</param>
        ///<returns>
        ///Currency of a region
        ///</returns>
        string currency(bool symb);

        ///<summary>
        ///Defines the date format
        ///</summary>
        ///<param name="dt">Contains date</param>
        ///<returns>
        ///Reformated date
        ///</returns>
        string dateFormat(DateTime dt);

        ///<summary>
        ///Defines the time format
        ///</summary>
        ///<param name="dt">Contains time</param>
        ///<returns>
        ///Reformated time
        ///</returns>
        string timeFormat(DateTime dt);

        ///<summary>
        ///Defines the day of a week beginning
        ///</summary>
        ///<returns>
        ///The first day of a week
        ///</returns>
        string weekStart();

        ///<summary>
        ///Defines whether country uses the metric measurement system or not
        ///</summary>
        ///<returns>
        ///True if uses the metric system, otherwise False
        ///</returns>
        bool isMetric();

        ///<summary>
        ///Defines a reading direction
        ///</summary>
        ///<returns>
        ///Reading direction of a region
        ///</returns>
        string readingDirection();

        ///<summary>
        ///Writes name in appropriate format for a region
        ///</summary>
        ///<param name="name">Contains full name of a person</param>
        ///<returns>
        ///Reformated name
        ///</returns>
        string nameFormat(params string[] name);

        ///<summary>
        ///Defines which encoding to use
        ///</summary>
        ///<param name="universal">Defines whether to use UTF-8 or country-specific encoding</param>
        ///<returns>
        ///Encoding for a region
        ///</returns>
        string encoding(bool universal);

        ///<summary>
        ///Defines time zone of a country or a capital
        ///</summary>
        ///<returns>
        ///Time zone of a region
        ///</returns>
        string timeZone();
    }
}
