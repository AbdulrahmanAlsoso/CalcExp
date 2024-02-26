using System;
using CulcExp.Entities;

namespace CalcExp.Entities
{
    public class OutCome
    {
        public bool _isDeleted { get; set; }
        public int _no { get;set; }
        public DateTime _dateOfOutCome { get;private set; }
        private string _description { get; set;}
        public decimal _amount { get; private set;}
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
