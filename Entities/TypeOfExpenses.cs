using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CulcExp.Entities
{
    public class TypeOfExpenses
    {
        public int _id { get; private set; }
        public bool _isDeleted { get; set; }
        public string _name { get; private set; }
        public string _description { get; private set; }
        public LevelPriority _priority { get; private set; }
        public TypeOfExpenses(string name, string description, LevelPriority level)
        {
            _name = name; _description = description; _priority = level;
        }
        public override string ToString()
        {
            return $"Name : {_name} ,Level of priority: {_priority}\n" +
            $"Description : {_description}";
        }
    }

}
