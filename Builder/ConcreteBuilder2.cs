namespace Builder;

/// <summary>
/// 具体创建者，具体的某个人为具体创建者，例如：装机小李啊
/// 又装另一台电脑了
/// </summary>
public class ConcreteBuilder2 : IBuilder
{
    Computer computer = new Computer();

    public void BuildPartCPU() => computer.Add("CPU2");

    public void BuildPartMainBoard() => computer.Add("Mainboard2");

    public Computer GetComputer() => computer;
}
