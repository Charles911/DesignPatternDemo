namespace Builder;

/// <summary>
/// 具体创建者，具体的某个人为具体创建者，例如：装机小王啊
/// </summary>
public class ConcreteBuilder1 : IBuilder
{
    private readonly Computer computer = new Computer();

    public void BuildPartCPU() => computer.Add("CPU1");

    public void BuildPartMainBoard() => computer.Add("Mainboard1");

    public Computer GetComputer() => computer;
}
