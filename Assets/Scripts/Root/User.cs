using System;

namespace Root
{
    [Serializable]
    public class User
    {
        public Guid ID => _id;
        public string name;
        public string bio;
        public bool isNew;
        public bool isRegistered;
        public string profilePicture;

        private Guid _id;

        public User(Guid value)
        {
            _id = value;
            name = "guest";
            bio = "...";
            isNew = true;
            isRegistered = false;
        }
    }
}
