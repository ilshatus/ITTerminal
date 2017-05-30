namespace ITTerminal
{
    class Equipment
    {
        public string Name { get; }
        public string Type { get; }
        public string Id { get; }
        public string Serial { get; }

        public Equipment(string name, string type, string id, string serial)
        {
            this.Name = name;
            this.Type = type;
            this.Id = id;
            this.Serial = serial;
        }
    }
}
