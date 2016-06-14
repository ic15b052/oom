using System;


namespace task6
{
    public interface StellarBody
    {

        string Name { get; }

        decimal Mass { get; }

        void GenerateID();

    }
}
