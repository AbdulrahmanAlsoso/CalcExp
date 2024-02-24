using System;

namespace CalcExp.Entities
{
    public class InCome
    {
        private int _no { get;set; }
        public bool _isDeleted { get; set;}
        private string _description { get; set;}
        private DateTime _dateOfInComing { get; set;}
        private string _from { get; set;}
        private decimal _amount { get; set;}
        public InCome(int no,string description, DateTime date, string from, decimal amount)
        {
            _no = no; _description = description;
            _dateOfInComing = date; _from = from;
            _amount = amount;
        }
        public override string ToString()
        {
            return $"No: {_no} ,Date: {_dateOfInComing} ,From : {_from} ,Amount : {_amount}\n" +
                $"Description : {_description}";
        }
    }

}
