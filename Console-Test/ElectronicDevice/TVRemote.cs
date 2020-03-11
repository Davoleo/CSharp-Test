namespace Console_Test.ElectronicDevice
{
    class TVRemote
    {
        public static IElettronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
