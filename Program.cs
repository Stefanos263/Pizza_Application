//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new TomatoSauce());
//pizza.AddIngredient(new Mozzarella());

//Console.WriteLine(pizza.Describe());

var cheddar = new Cheddar();
Console.WriteLine(cheddar.PublicMethod());

Console.ReadKey();


public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public string Describe() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    public string PublicMethod() =>
        "This method is PUBLIC in the Ingredient class.";
}


public class Cheddar : Ingredient
{
    public string Name => "Cheddar cheese";
    public int agedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
    public string Name => "Tomato sauce";
    public int tomatoesIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public string Name => "Mozzarella";
    public bool isLight { get; }
}