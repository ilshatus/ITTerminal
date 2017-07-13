namespace ITTerminal
{
    class User
    {
        public string Name { get; }
        public string Id { get; }
        public string Position { get; }

        public User(string name, string id)
        {
            Name = name;
            Id = id;
        }
        
        public User(string name, string id, string position)
        {
            Name = name;
            Id = id;
            Position = position;
        }
    }
}
