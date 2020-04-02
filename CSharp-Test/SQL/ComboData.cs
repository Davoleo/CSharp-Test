namespace CSharp_Test.SQL
{
    class ComboData
    {

        private string description;
        private int id;

        public int ID { get; }

        public ComboData(string description, int id)
        {
            this.description = description;
            this.id = id;
        }

        public override string ToString()
        {
            return description;
        }
    }
}
