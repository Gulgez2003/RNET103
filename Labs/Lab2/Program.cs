Console.Write("Please enter the current air temperature (°C): ");
double temperature = double.Parse(Console.ReadLine());
Console.WriteLine("Weather forecasts based on the air temperature you entered:");
Console.WriteLine();

string result = temperature switch
{
    < 0 => "1. Frosty and cold.\n" +
           "2. Severe frost.\n" +
           "3. Snowfall and icy conditions.",
    < 10 => "1. Cool.\n" +
            "2. Rain or wet snow.\n" +
            "3. Windy.",
    < 20 => "1. Moderate temperature.\n" +
            "2. Rain or partly cloudy skies.\n" +
            "3. Moderate humidity.",
    < 30 => "1. Warm.\n" +
            "2. Sunny and clear.\n" +
            "3. Brief showers.",
    _ => "1. Hot.\n" +
         "2. Sunny weather.\n" +
         "3. Hot winds and potential for drought."
};

Console.WriteLine(result);
Console.WriteLine();
Console.Write("Сhoose and enter the weather forecast number: ");
string weatherForecast = Console.ReadLine();

Console.WriteLine("Here are some examples of activities to do in this weather:");
Console.WriteLine();

switch (temperature)
{
    case < 0:
        {
            string recommendations = weatherForecast switch
            {
                "1" => "1. Ice Skating: Head to a local ice rink and enjoy the crisp, cold air while skating.\n" +
                       "2. Winter Photography: Capture the frosty landscapes and unique beauty of cold weather.\n",
                "2" => "1. Indoor Movie Night: Stay cozy indoors and have a movie night with friends or family.\n" +
                       "2. Read by the Fireplace: Grab a good book and enjoy reading by the warmth of a fireplace.\n",
                "3" => "1. Ski Trip: Take advantage of the snowy weather and plan a skiing or snowboarding trip.\n" +
                       "2. Snowball Fight: Have some playful fun with a friendly snowball fight in the fresh snow.\n",
                _ => "Please enter the correct value."
            };
            Console.WriteLine(recommendations);
            break;
        }
    case < 10:
        {
            string recommendations = weatherForecast switch
            {
                "1" => "1. Autumn Stroll: Take a leisurely walk in a park, enjoying the cool and crisp autumn air.\n" +
                       "2. Cycling Adventure: Go for a bike ride to explore the surroundings while embracing the cool temperatures.\n",
                "2" => "1. Indoor Movie Night: Stay cozy indoors with a movie marathon or binge-watch your favorite TV shows.\n" +
                       "2. Rainy Day Cooking: Experiment with new recipes in the kitchen and savor warm, comforting meals.\n",
                "3" => "1. Kite Flying: Embrace the wind by flying kites in an open area.\n" +
                       "2. Wind Surfing: If you're near a body of water, consider trying wind surfing for an adventurous experience.\n",
                _ => "Please enter the correct value."
            };
            Console.WriteLine(recommendations);
            break;
        }
    case < 20:
        {
            string recommendations = weatherForecast switch
            {
                "1" => "1. Outdoor Concert: Attend an outdoor concert or music festival to enjoy the moderate weather while listening to live music.\n" +
                       "2. Botanical Garden Visit: Explore a botanical garden, taking in the diverse plant life in the comfortable temperatures.\n",
                "2" => "1. Rainy Day Reading: Curl up with a good book at home or in a cozy café, enjoying the soothing sound of rain outside.\n" +
                       "2. Indoor Board Games: Have a board game night with friends or family indoors, creating a fun atmosphere on a partly cloudy day.\n",
                "3" => "1. Al Fresco Dining: Dine at an outdoor restaurant, enjoying the moderate humidity along with delicious food.\n" +
                       "2. Photography Excursion: Take a photography walk in a scenic area, as moderate humidity can enhance the colors and atmosphere in your photos.\n",
                _ => "Please enter the correct value."
            };
            Console.WriteLine(recommendations);
            break;
        }
    case < 30:
        {
            string recommendations = weatherForecast switch
            {
                "1" => "1. Outdoor Barbecue: Take advantage of the warm weather by organizing a barbecue with friends or family in your backyard or at a park.\n" +
                       "2. Picnic in the Sun: Pack a picnic basket and enjoy a relaxing outdoor meal in a sunny and warm environment.\n",
                "2" => "1. Beach Day: Head to the beach to soak up the sun, swim in the ocean, and enjoy various beach activities.\n" +
                       "2. Outdoor Sports: Engage in outdoor sports such as soccer, frisbee, or basketball under the clear and sunny skies.\n",
                "3" => "1. Rainy Day Reading: Embrace the rain by spending a cozy day indoors with a good book or watching movies.\n" +
                       "2. Umbrella Stroll: Take a leisurely walk in the light rain with an umbrella, enjoying the soothing sound of raindrops.\n",
                _ => "Please enter the correct value."
            };
            Console.WriteLine(recommendations);
            break;
        }
    default:
        {
            string recommendations = weatherForecast switch
            {
                "1" => "1. Indoor Spa Day: Relax and rejuvenate in the comfort of an air-conditioned spa.\n" +
                       "2. Water Park Adventure: Spend the day at a water park to cool off and enjoy water slides and pools.\n",
                "2" => "1. Gardening Day: Spend time in your garden or visit a local botanical garden to tend to plants and bask in the sunny weather.\n" +
                       "2. Cycling Tour: Explore your surroundings on a sunny day with a leisurely bike ride.\n",
                "3" => "1. Water Conservation Workshop: Educate yourself and others on water-saving techniques and participate in conservation efforts.\n" +
                       "2. Indoor Gardening: Create an indoor garden to satisfy your green thumb while being mindful of water use during dry periods.\n ",
                _ => "Please enter the correct value."
            };
            Console.WriteLine(recommendations);
            break;
        }
}

