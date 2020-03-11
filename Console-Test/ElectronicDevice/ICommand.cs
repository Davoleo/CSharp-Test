using System;

namespace Console_Test.ElectronicDevice
{
    interface ICommand
    {
        void Execute();

        void Undo();
    }
}
