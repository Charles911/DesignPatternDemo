namespace Memento;

/// <summary>
/// 备忘录模式
/// </summary>
/// <remarks>
/// 在不破坏封装的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态，这样以后就可以把该对象恢复到原先的状态。
/// 
/// 优点：
/// 1.如果某个操作错误地破坏了数据的完整性，此时可以使用备忘录模式将数据恢复成原来正确的数据。
/// 2.备份的状态数据保存在发起人角色之外，这样发起人就不需要对各个备份的状态进行管理。
///   而是由备忘录角色进行管理，而备忘录角色又是由管理者角色管理，符合单一职责原则。
/// 
/// 缺点：
/// 1.在实际的系统中，可能需要维护多个备份，需要额外的资源，这样对资源的消耗比较严重。
/// 
/// 应用场景：
/// 1.如果系统需要提供回滚操作时，使用备忘录模式非常合适。
///   例如文本编辑器的Ctrl+Z撤销操作的实现，数据库中事务操作。
/// </remarks>
class Program
{
    static void Main(string[] args)
    {
        var persons = new List<ContactPerson>()
        {
            new ContactPerson() { Name = "Learning Hard", MobileNum = "123456"},
            new ContactPerson() { Name = "Tony", MobileNum = "234567"},
            new ContactPerson() { Name = "Jock", MobileNum = "345678"}
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

            int index = -1;
            try
            {
                index = Int32.Parse(Console.ReadLine() ?? "-1");
            }
            catch (System.Exception)
            {
                Console.WriteLine("输入的格式错误");
                continue;
            }

            ContactMemento? contactMemento = null;
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
