using System;

class ControlFlow
{
    public ControlFlow()
    {
        IfStatements();
        SwitchStatements();
    }

    void IfStatements()
    {
        Console.WriteLine("Favour curly brace on new line for ifs");

        if (1 == 2)
        {
        }
        else if (3 == 4)
        {

        }
        else
        {

        }
    }

    void SwitchStatements()
    {
        Console.WriteLine("Can filter through switch statements");
        uint number = 2; // uint: unsigned int, meaning it CANT hold negatives
        switch (number)
        {
            case 0:
            case 1:
                break;
            default:
                break;
        }
    }
}
