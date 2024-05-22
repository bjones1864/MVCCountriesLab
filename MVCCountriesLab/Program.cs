using MVCCountriesLab;

List<Country> states = new List<Country>()
{
    new Country("USA", "North America", new List<string>(){"Red", "White", "Blue"}),
    new Country("France", "Europe", new List<string>(){"Red", "White", "Blue"}),
    new Country("Austria", "Europe", new List<string>(){"Red", "White"}),
    new Country("Colombia", "South America", new List<string>(){"Red", "Yellow", "Blue"}),
    new Country("Egypt", "Africa", new List<string>(){"Red", "White", "Black"}),
    new Country("Japan", "Asia", new List<string>(){"Red", "White"}),
    new Country("Brazil", "South America", new List<string>(){"Green", "Yellow" })
};

states = states.OrderBy(x => x.Name).ToList();

CountryController control = new CountryController(states);

control.WelcomeAction();