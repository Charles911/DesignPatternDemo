namespace Memento;

/// <summary>
/// 发起人
/// </summary>
public class MobileOwner(List<ContactPerson> persons)
{
    public List<ContactPerson> ContactPersons { get; set; } = persons;

    /// <summary>
    /// 创建备忘录，将要保存的联系人列表导入到备忘录中
    /// </summary>
    public ContactMemento CreateMemento() =>
        //这里也应该传递深拷贝，new List方式传递的是浅拷贝，
        //因为ContactPerson类中都是string类型, 所以这里new list方式对ContactPerson对象执行了深拷贝
        //如果ContactPerson包括非string的引用类型就会有问题，所以这里也应该用序列化传递深拷贝
        new(new List<ContactPerson>(ContactPersons));

    /// <summary>
    /// 将备忘录中的数据备份导入到联系人列表中
    /// </summary>
    public void RestoreMemento(ContactMemento memento)
    {
        if (memento != null)
        {
            //下面这种方式是错误的，因为这样传递的是引用，
            //则删除一次可以恢复，但恢复之后再删除的话就恢复不了.
            //所以应该传递contactPersonBack的深拷贝，深拷贝可以使用序列化来完成
            ContactPersons = memento.ContactPersonBack;
        }
    }

    public void Show()
    {
        Console.WriteLine($"联系人列表中有{ContactPersons.Count}个人，他们是:");
        foreach (var p in ContactPersons)
        {
            Console.WriteLine($"姓名：{p.Name} 号码是: {p.MobileNum}");
        }
    }
}
