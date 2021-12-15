using System;
using System.Text.Json;

namespace JsonTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // git test

            //var user = new User
            //{
            //    Id = "user id",
            //    Name = "user name",
            //    Password = "user password"
            //};

            //string jsonStr = JsonSerializer.Serialize(user);
            //Console.WriteLine(jsonStr);

            //var DeserializedUser = JsonSerializer.Deserialize<User>(jsonStr);
            //var id = DeserializedUser.Id;
            //var name = DeserializedUser.Name;
            //var password = DeserializedUser.Password;
            //Console.WriteLine($"id: {id} , name: {name}, password: {password}");

            var userSetting = new UserSetting
            {
                Setting1 = "set 1",
                Setting2 = 11,
            };

            var nestedUser = new NestedUser
            {
                Id = "user id",
                Name = "user name",
                Password = "user password",
                UserSetting = userSetting
            };

            string jsonStr = JsonSerializer.Serialize(nestedUser);
            Console.WriteLine(jsonStr);

            var DeserializedNestedUser = JsonSerializer.Deserialize<NestedUser>(jsonStr);
            var setting1 = DeserializedNestedUser.UserSetting.Setting1;
            Console.WriteLine($"setting1 : {setting1}");
        }
    }

    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class NestedUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public UserSetting UserSetting { get; set; }
    }

    public class UserSetting
    {
        public string Setting1 { get; set; }
        public int Setting2 { get; set; }
    }
}
