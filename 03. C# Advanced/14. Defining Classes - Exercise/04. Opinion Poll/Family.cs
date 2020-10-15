using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.members
                .OrderByDescending(p => p.Age)
                .First();
        }

        public List<Person> Sort()
        {
            return this.members
                .OrderBy(n => n.Name)
                .Where(a => a.Age > 30)
                .ToList();
        }
    }
}