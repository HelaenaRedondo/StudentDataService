using Pointsss;

namespace UserDataAccount
{

    public class UserDataService
    {
        readonly List<user> dummyUser = new List<user>();


        public UserDataService()
        {
            CreateDummyData();
        }
        private void CreateDummyData()
        {

            Point defaultPoints = new Point { value = 100, category = "new member points" };

            user user1 = new user { name = "redondoainaa@iskolarngbayanpupeduph", pass = "1234" };
            user user2 = new user { name = "JethroS@iskolarngbayanpupedu,ph", pass = "1234" };
            user user3 = new user { name = "Kurtyyy@iskolarngbayanpupeduph", pass = "1234" };
        

            dummyUser.Add(user1);
            dummyUser.Add(user2);
            dummyUser.Add(user3);
        }

        public user GetName(string name)
        {
            user foundUser = new user();

            foreach (var dummy in dummyUser)
            {
                if (name == dummy.name)
                {
                    foundUser = dummy;
                }
            }

            return foundUser;
        }
    }
}