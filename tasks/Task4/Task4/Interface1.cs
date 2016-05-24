using System;


namespace Task4
{
    public interface StellarBody
    {

        string Name { get; }

        decimal Mass { get; }

        void GenerateID();

    }
}
