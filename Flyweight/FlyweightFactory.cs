namespace Flyweight;

public class FlyweightFactory
{
    //最好使用泛型Dictionary<string, Flyweight>
    public Dictionary<string, Flyweight> flyweights = [];
    // public Hashtable flyweights = new Hashtable();

    public FlyweightFactory()
    {
        flyweights.Add("A", new ConcreteFlyweight("A"));
        flyweights.Add("B", new ConcreteFlyweight("B"));
        flyweights.Add("C", new ConcreteFlyweight("C"));
    }

    public Flyweight GetFlyweight(string key)
    {
        Flyweight flyweight;
        if (flyweights.ContainsKey(key))
        {
            flyweight = flyweights[key] as Flyweight;
        }
        else
        {
            Console.WriteLine($"驻留池中不存在字符串{key}");
            flyweight = new ConcreteFlyweight(key);
            flyweights.Add(key, flyweight);
        }
        return flyweight;
        // return flyweights[key] as Flyweight;
    }
}