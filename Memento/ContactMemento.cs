namespace Memento;

/// <summary>
/// 备忘录
/// </summary>
public class ContactMemento(List<ContactPerson> persons)
{
    public List<ContactPerson> ContactPersonBack { get; set; } = persons;
}
