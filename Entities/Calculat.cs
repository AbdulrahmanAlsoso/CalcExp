using System;
using System.Collections.Generic;
using CalcExp.Entities;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CulcExp.Entities
{
    public static class Calculat{
        public delegate bool theSameSpecificTime(DateTime typeDate,DateTime intendedDate);
        // to return out come from type and specific month in the year
        public static decimal CalcOutComeFromTypeAndSpicificDate(TypeOfExpenses expenses,
        DateTime date,theSameSpecificTime dateIntendedToCalc){
            decimal Total = 0m;
            foreach (var outCome in expenses._outComes){
                if (dateIntendedToCalc(outCome._dateOfOutCome,date))
                        Total+= outCome._amount;
            }
            return Total;
        }
        public static decimal CalcInComeInSpicificTime(List<InCome> inComes,DateTime Date, theSameSpecificTime dateintendedToCalc){
            decimal Total =0m;
            foreach(var income in inComes){
                if (dateintendedToCalc(income.,Date)){
                    Total+=income.
                }
            }
            return Total;
        }
        public static bool theSameYear(DateTime typeYear,DateTime intendedYear)=> typeYear.Year == intendedYear.Year;
        public static bool theSameMonthInYear(DateTime typeMonthFromYear,DateTime intendedMonthFromYear)=> 
        typeMonthFromYear.Year == intendedMonthFromYear.Year && typeMonthFromYear.Month == intendedMonthFromYear.Month;
    }

}
