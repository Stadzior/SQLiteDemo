using System;
using System.Text;

namespace SQLiteDemo.Model
{
    public class Customer
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Id: " + Id.ToString());
            builder.AppendLine("FirstName: " + FirstName);
            builder.AppendLine("LastName: " + LastName);
            builder.AppendLine("DateOfBirth: " + DateOfBirth.ToShortDateString());
            return builder.ToString();
        }
    }
}