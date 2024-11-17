namespace Memento;

/// <summary>
/// 管理者
/// </summary>
public class Caretaker
{
    public Dictionary<string, ContactMemento> ContactMementoDic { get; set; }

    public Caretaker() => ContactMementoDic = [];
}
