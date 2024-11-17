using System.Collections;

namespace Vistor;

//对象结构
public class ObjectStructure
{
    private readonly ArrayList elements = [];

    public ArrayList Elements { get => elements; }

    public ObjectStructure()
    {
        var r = new Random();
        for (int i = 0; i < 6; i++)
        {
            int n = r.Next(10);
            if (n > 5)
            {
                elements.Add(new ElementA());
            }
            else
            {
                elements.Add(new ElementB());
            }
        }
    }
}
