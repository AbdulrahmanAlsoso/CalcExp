using System;
using System.Reflection.Emit;

namespace CulcExp.Entities
{
    public class OutCome
    {
        public bool _isDeleted { get; set; }
        private int _no { get;set; }
        private DateTime _dateOfOutCome { get; set; }
        private string _description { get; set;}
        private decimal _amount { get; set;}
        private TypeOfExpenses _typeOfExpenses { get; set;}
        public OutCome(int no ,DateTime date , string description, decimal amount , TypeOfExpenses type)
        {
            _no = no;
            _dateOfOutCome = date;
            _description = description;
            _amount = amount;
            _typeOfExpenses = type;
        }
        public override string ToString()
        {
            return $"No: {_no} ,Date: {_dateOfOutCome} ,Amount : {_amount}\n" +
                $"Description : {_description}\n" + _typeOfExpenses.ToString();
        }
    }

}
