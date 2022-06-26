using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IMemberRepository
    {
        public IEnumerable<Member> FilterMemberByString(string name);
        public Member Login(string email, string password);
        public IEnumerable<Member> GetMemberList();
        public Member GetMemberByEmail(string email);
        public Member GetMemberById(int id);
        public void AddMember(Member _Member);
        public void UpdateMember(Member _Member);
        public void RemoveMember(Member _Member);
    }
}
