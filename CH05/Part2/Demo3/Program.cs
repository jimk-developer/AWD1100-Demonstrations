// Variables to track miles for each zone
double northMiles = 0;
double southMiles = 0;
double westMiles = 0;

string zone;
double miles;

// Indefinite loop - continues until user enters 'q'
while (true)
{
    // Prompt for zone initial
    Console.Write("Which zone was the delivery (n for North, s for South, w for West, q to Quit)? ");
    
    zone = Console.ReadLine();

    // Convert to lowercase for case-insensitive comparison
    zone = zone.ToLower();

    // Check for exit sentinel
    if (zone == "q")
    {
        break;
    }

    // Validate the zone
    if (zone == "n" || zone == "s" || zone == "w")
    {
        // Valid zone - prompt for miles
        Console.Write("How many miles was the delivery? ");

        //double.TryParse(userInput, out miles)
        string userInput = Console.ReadLine();

        if (double.TryParse(userInput, out miles))
        {
            // Add miles to appropriate zone using if-else
            if (zone == "n")
            {
                northMiles += miles;
            }
            else if (zone == "s")
            {
                southMiles += miles;
            }
            else if (zone == "w")
            {
                westMiles += miles;
            }

            Console.WriteLine();  // Blank line for readability
        }
        else
        {
            // Invalid zone - display error
            Console.WriteLine("Invalid zone");
            Console.WriteLine();
        }
    }
}

// Calculate total miles
double totalMiles = northMiles + southMiles + westMiles;

// Display results
Console.WriteLine();
Console.WriteLine("North Zone Miles: " + northMiles.ToString("F1"));
Console.WriteLine("South Zone Miles: " + southMiles.ToString("F1"));
Console.WriteLine("West Zone Miles: " + westMiles.ToString("F1"));
Console.WriteLine();
Console.WriteLine("Total Miles: " + totalMiles.ToString("F1"));

// Determine which zone had the most miles
if (northMiles >= southMiles && northMiles >= westMiles)
{
    Console.WriteLine("North zone has the most miles");
}
else if (southMiles >= northMiles && southMiles >= westMiles)
{
    Console.WriteLine("South zone has the most miles");
}
else
{
    Console.WriteLine("West zone has the most miles");
}

Console.WriteLine();
Console.WriteLine("Press any key to continue . . .");
Console.ReadKey();