namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id=1, Name = "Ali", Email = "abffc@gmail.com", Phone = "0555 555 55 55", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Veli", Email = "abadascd@gmail.com", Phone = "0465 654 77 37", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Mehmet", Email = "abasdsacdf@gmail.com", Phone = "0464 463 26 71", WillAttend = false });
            _users.Add(new UserInfo() { Id = 4, Name = "Ahmet", Email = "abcasdad@gmail.com", Phone = "0837 747 74 78", WillAttend = true });
        }


        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id );
        }

    }
}
