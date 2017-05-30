namespace ITTerminal
{
    class User
    {
        public string Name { get; }
        public string Id { get; }

        public User(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
}
