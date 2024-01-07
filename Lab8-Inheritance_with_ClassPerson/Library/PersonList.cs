namespace PersonLib
{
    public class PersonList
    {
        // Declear empty list of person
        protected List<Person> _pers = new();
        // Method to add value to List of Person
        public virtual bool Add(Person per)
        {
            if(_pers.Any(x=> x.No == per.No)) return false;
            _pers.Add(per);
            return true;
        }

        // Edit a person List
        public virtual Person? Modify(int targetNo, string name, string gender, byte age)
        {
            // Found store value of type Person
            var found = _pers.FirstOrDefault(x => x.No == targetNo);
            if(found != null)
            {
                found.Name = name;
                found.Gender = gender;
                found.Age = age;
            }

            return found;
        }

        // Create Method to remove or delete type f person from the Person List
        public virtual Person? Remove(int targetNo)
        {
            // mean that we remove person bace on TargetNo that given

            var found = _pers.FirstOrDefault(x => x.No==targetNo);
            if(found != null)
            {
                if(_pers.Remove(found)) 
                    return found;
                else 
                    return null;
            }

            return null;
        }

        public virtual bool Remove(Person per)
        {
            return _pers.Remove(per);
        }
        public virtual void Clear()
        {
            _pers.Clear();
        }

        public List<Person> People => _pers;
        public byte MaxAge => _pers.Max(x => x.Age);
        public int Count => _pers.Count;

    }
}
