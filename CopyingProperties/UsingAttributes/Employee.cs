using Common;

namespace CopyingProperties.Attributes
{
    public class Employee
    {
        public int EmployeeNumber { get; set; }
        [MatchParent("FirstName")]
        public string FName { get; set; }
        [MatchParent("LastName")]
        public string LName { get; set; }
    }
}