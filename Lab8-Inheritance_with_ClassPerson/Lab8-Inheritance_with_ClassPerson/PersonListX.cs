using PersonLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Inheritance_with_ClassPerson
{
    public delegate void PersonEventHandler(object? sender, PersonLib. Person? per);
    public class PersonListX : PersonList
    {
        public event PersonEventHandler? Added;
        public event PersonEventHandler? Removed;
        public event PersonEventHandler? Modified;
        public event PersonEventHandler? Cleared;

        // Override method that derive from class PersonList
        public override bool Add(PersonLib.Person pp)
        {
            var result = base.Add(pp);
            if (result == true) Added?.Invoke(this, pp);
            return result;
        }

        public override bool Remove(PersonLib.Person per)
        {
            var result = base.Remove(per);
            if (result == true) Added?.Invoke(this, per);
            return result;
          
        }

        public override PersonLib.Person? Remove(int targetNo)
        {
            var result = base.Remove(targetNo);
            if(result != null) Removed?.Invoke(this, result); 
            return result;
        }
        public override PersonLib.Person? Modify(int targetNo, string name, string gender, byte age)
        {
            var result = base.Modify(targetNo, name, gender, age);
            if (result != null) Modified?.Invoke(this, result);

            return result;
        }

        public override void Clear()
        {
            base.Clear();
            Cleared?.Invoke(this, null);
        }
        public PersonLib.Person? this[int key] => _pers.FirstOrDefault(x => x.No == key);
    }
}
