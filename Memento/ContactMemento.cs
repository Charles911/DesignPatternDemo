namespace Memento;

/// <summary>
/// 备忘录
/// </summary>
public class ContactMemento
{
    public List<ContactPerson> ContactPersonBack { get; set; }

    public ContactMemento(List<ContactPerson> persons) => ContactPersonBack = persons;
}
