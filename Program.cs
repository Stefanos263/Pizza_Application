var pizza = new Pizza();
pizza.AddIngredient(new Cheddar(1));
pizza.AddIngredient(new TomatoSauce(3));
pizza.AddIngredient(new Mozzarella(2));

Console.WriteLine(pizza.Describe());

var cheddar = new Cheddar(1);
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
    public Ingredient(int PriceIfExtraTopping)
    {
        Console.WriteLine("constructor from the Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int priceIfExtraTopping { get; }
    public virtual string Name { get; }
    public  string PublicMethod() =>
        "This method is PUBLIC in the Ingredient class.";
}


public class Cheddar : Ingredient
{
    public Cheddar(int PriceIfExtraTopping) : base(PriceIfExtraTopping)
    {
    }

    public override string Name => "Cheddar cheese";
    public int agedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int PriceIfExtraTopping) : base(PriceIfExtraTopping)
    {
    }

    public override string Name => "Tomato sauce";
    public int tomatoesIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public Mozzarella(int PriceIfExtraTopping) : base(PriceIfExtraTopping)
    {
    }

    public override string Name => "Mozzarella";
    public bool isLight { get; }
}