// Variables for tracking statistics
int count = 0;
double sum = 0;
double min = double.MaxValue;
double max = double.MinValue;

// Sentinel value to stop input
const int SENTINEL = 999;

// Valid temperature range (in Fahrenheit)
const double MIN_VALID_TEMP = -50;
const double MAX_VALID_TEMP = 150;

double temperature;

// Indefinite loop - continues until sentinel value entered
while (true)
{
    Console.Write("Please enter a temperature reading: ");
    temperature = double.Parse(Console.ReadLine());

    // Check for sentinel value
    if (temperature == SENTINEL)
    {
        // Exit the loop - do NOT display an error message
        break;
    }

    // Validate the temperature is within acceptable range
    if (temperature >= MIN_VALID_TEMP && temperature <= MAX_VALID_TEMP)
    {
        // Accept the temperature - update statistics
        count++;
        sum += temperature;

        // Update min if this temperature is lower
        if (temperature < min)
        {
            min = temperature;
        }

        // Update max if this temperature is higher
        if (temperature > max)
        {
            max = temperature;
        }
    }
    else
    {
        // Invalid temperature - display error message
        Console.WriteLine("Invalid temperature (must be between -50 and 150)");
    }
}

// Display the statistics
Console.WriteLine();
Console.WriteLine("Number of readings: " + count);
Console.WriteLine("Sum of temperatures: " + sum);

// Only calculate average if we have at least one reading
if (count > 0)
{
    double average = sum / count;
    Console.WriteLine("Average temperature: " + average.ToString("F1"));
    Console.WriteLine("Lowest temperature: " + min.ToString("F1"));
    Console.WriteLine("Highest temperature: " + max.ToString("F1"));
}
else
{
    Console.WriteLine("No valid temperatures were entered.");
}

Console.WriteLine();
Console.WriteLine("Press any key to continue . . .");
Console.ReadKey();
