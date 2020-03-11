namespace Console_Test.ElectronicDevice
{
    class PowerButton : ICommand
    {
        private IElettronicDevice device;

        public PowerButton(IElettronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}
