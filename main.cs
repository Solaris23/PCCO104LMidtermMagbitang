using System;

class Program
{
    static int GetValidFanSpeed()
    {
        while (true)
        {
            Console.Write("Enter fan speed (1, 2, or 3): ");
            if (int.TryParse(Console.ReadLine(), out int fanSpeed) && fanSpeed >= 1 && fanSpeed <= 3)
            {
                return fanSpeed;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
            }
        }
    }

    static char GetValidOscillateOption()
    {
        while (true)
        {
            Console.Write("Do you want to oscillate? (Y/N): ");
            char oscillateOption = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (oscillateOption == 'Y' || oscillateOption == 'N')
            {
                return oscillateOption;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter Y or N.");
            }
        }
    }

    static void DisplayFanPower(int fanSpeed, char oscillateOption)
    {
        int baseFanPower = 10;
        int fanPowerOutput = baseFanPower * fanSpeed;

        Console.WriteLine("Fan power output:");
        if (oscillateOption == 'N')
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(new string('~', fanPowerOutput));
            }
        }
        else
        {
            for (int i = 1; i <= fanPowerOutput; i += 2)
            {
                Console.WriteLine(new string('~', i));
            }
            for (int i = fanPowerOutput - 2; i >= 1; i -= 2)
            {
                Console.WriteLine(new string('~', i));
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("InterProg Midterms: Electric Fan");
        int fanSpeed = GetValidFanSpeed();
        char oscillateOption = GetValidOscillateOption();
        DisplayFanPower(fanSpeed, oscillateOption);
    }
}




/*
During heat of summer, we intend to cool ourselves using various approaches and technologies with basic appliance like an electric fan. Observing the movement of the fan is quite amusing as it swings (or not) across the room.

Create a Console application that intends to simulates the fan output power.


Application must:

1. Accept only valid input value for fan speed: 1, 2, or 3. Prompt user if INVALID value has been entered and allow to enter again. // c

2. Accept only valid input value for oscillate option: Y or N. Prompt user if INVALID value has been entered and allow to enter again. // c

3. Base fan power has a value of 10, which is multiplied by the inputted fan speed. (~ symbol for fan power)

fanPowerOutput = baseFanPower * fanSpeed

Maximum fanPowerOutput is 30 or (10 * 3).  // c | Won't exceed 30 because the only options are 1,2,3

Fan power is consistent in non-oscillate configuration, while fan power is swinging on oscillate configuration.

4. If oscillate option is Y, display oscillate output. // c




*/


//ang inet meyn

/*

Act 4 
  |
  v

static void BuildPyramid()
{
    int inputValue;
    do
    {
        Console.Write("Enter a non-negative number (0 to exit): ");
        if (!int.TryParse(Console.ReadLine(), out inputValue))
        {
            Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
            continue;
        }

        if (inputValue == 0)
        {
            Console.WriteLine("Exiting program...");
            return;
        }

        if (inputValue < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
            continue;
        }

        for (int i = 1; i <= inputValue; i++)
        {
            for (int j = 1; j <= inputValue - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    } while (true);
}


Modified


            for (int i = 1; i <= inputValue; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = inputValue - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        } while (true);
    }
}


*/