using System;

namespace CulcExp.Entities
{
    public static class Calculat{
        public static decimal CalcOutComeFromType(TypeOfExpenses expenses){
            decimal Total = 0m;
            foreach (var outCome in expenses._outComes){
                Total+= outCome._amount;
            }
            return Total;
        }
        // to return out come from type and specific month 
        public static decimal CalcOutComeFromType(TypeOfExpenses expenses,DateTime month){
            decimal Total = 0m;
            foreach (var outCome in expenses._outComes){
                //here 
                if (outCome)
                Total+= outCome._amount;
            }
            return Total;
        }
    }

}
