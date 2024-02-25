using System.Collections;
using System.Collections.Generic;
using CalcExp.Data;
using CalcExp.Entities;

namespace CulcExp.Entities
{
    public class TypeOfExpenses
    {
        public int _id { get; private set; }
        public bool _isDeleted { get; set; }
        public string _name { get; private set; }
        public string _description { get; private set; }
        public LevelPriority _priority { get; private set; }
        public ICollection<OutCome> _outComes {get;set;}
        public TypeOfExpenses(string name, string description, LevelPriority level)
        {
            _name = name; _description = description; _priority = level;
        }
        public void AddOutCome(OutCome outCome){
            if (outCome != null && outCome._amount != 0){
                outCome._no = _outComes.Count;
                _outComes.Add(outCome);
            }
        }
        public override string ToString()
        {
            return $"Name : {_name} ,Level of priority: {_priority}\n" +
            $"Description : {_description}";
        }
    }

}
