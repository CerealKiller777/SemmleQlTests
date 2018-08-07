using System;

namespace TestProject
{
    // ReSharper disable once UnusedMember.Global
    internal sealed class LocalVariables
    {
        // ReSharper disable once UnusedMember.Global
        public void LocalVariableShouldBeConstant()
        {
            // ReSharper disable once ConvertToConstant.Local
            ulong localVariable = 7;
            Console.WriteLine(localVariable);
        }
    }
}