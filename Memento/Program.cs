namespace Memento;


internal class Program
{
    private static void Main(string[] args)
    {
        var persons = new List<ContactPerson>()
        {
            new() { Name = "Learning Hard", MobileNum = "123456"},
            new() { Name = "Tony", MobileNum = "234567"},
            new() { Name = "Jock", MobileNum = "345678"}
        };

        MobileOwner mobileOwner = new(persons);
        mobileOwner.Show();

        //创建备忘录并保存备忘录对象
        Caretaker caretaker = new();
        caretaker.ContactMementoDic.Add(DateTime.Now.ToString(), mobileOwner.CreateMemento());

        //更改发起人联系人列表
        Console.WriteLine("----移除最后一个联系人--------");
        mobileOwner.ContactPersons.RemoveAt(2);
        mobileOwner.Show();

        Thread.Sleep(1000);
        caretaker.ContactMementoDic.Add(DateTime.Now.ToString(), mobileOwner.CreateMemento());

        //恢复到原始状态
        Console.WriteLine("-------恢复联系人列表,请从以下列表选择恢复的日期------");
        var keyCollection = caretaker.ContactMementoDic.Keys;
        foreach (var k in keyCollection)
        {
            Console.WriteLine("Key = {0}", k);
        }

        while (true)
        {
            Console.Write("请输入数字,按窗口的关闭键退出:");

            int index;
            try
            {
                index = Int32.Parse(Console.ReadLine() ?? "-1");
            }
            catch (System.Exception)
            {
                Console.WriteLine("输入的格式错误");
                continue;
            }

            ContactMemento? contactMemento;
            if (index < keyCollection.Count &&
                caretaker.ContactMementoDic.TryGetValue(keyCollection.ElementAt(index), out contactMemento))
            {
                mobileOwner.RestoreMemento(contactMemento);
                mobileOwner.Show();
            }
            else
            {
                Console.WriteLine("输入的索引大于集合长度！");
            }
        }
    }
}
