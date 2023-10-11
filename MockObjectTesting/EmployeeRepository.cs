using MockObjectTesting.Core;

namespace MockObjectTesting.Infrastructure
{
    public class EmployeeRepository : IGetDataRepository
    {
        public string GetNameById(int id)
        {
            string name;

            if (id == 1001)
            {
                name = "Arun";
            }
            else if(id == 3066)
            {
                name = "Diya";
            }
            else
            {
                name = "Not Exists";
            }
            return name;
        }
    }
}
