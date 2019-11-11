using System;
using System.Collections.Generic;
using System.Text;

namespace Trest_01
{
    class Family_members
    {
        private readonly List<Member> members;

        public Family_members()
        {
            members = new List<Member>
            {
            new Member("Kika", "sestra1", 100, 47, 50),
            new Member("Dominika", "sestra2", 100, 61, 30),
            new Member("Maja", "sestra3", 78, 90, 49),
            new Member("Peťa", "sestra4", 50, 48, 72),
            new Member("Emma", "sestra5", 86, 74, 16),
            new Member("Eva", "sestra6", 59, 50, 62),
            };
        }
        public void Update()
        {
            foreach (var member in members)
            {
                member.Update();  
            }
        }
        public void Update2()
        {
            foreach (var member in members)
            {
                member.Update2();
            }
        }

        public void Feed(string name, int amount)
        {
            Member member = FindMemberBy(name);
            if (member != null)
            {
                member.Eat(amount);
            }
        }

        private Member FindMemberBy(string name)
        {
            foreach (var member in members)
            {
                if (member.Name.ToLower() == name.ToLower())
                {
                    return member;
                }
            }

            return null;
        }

        public void Sleep(string name, int amount)
        {

            Member member = FindMemberBy2(name);
            if (member != null)
            {
                member.Time_in_Bed(amount);
            }
        }

        private Member FindMemberBy2(string name)
        {
            foreach (var member in members)
            {
                if (member.Name.ToLower() == name.ToLower())
                {
                    return member;
                }
            }

            return null;
        }
    }
}
