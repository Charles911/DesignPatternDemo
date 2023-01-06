namespace State;

/// <summary>
/// 状态模式
/// </summary>
/// <remarks>
/// 允许一个对象在其内部状态改变时自动改变其行为，对象看起来就像是改变了它的类。
/// 
/// 优点：
/// 1.将状态判断逻辑每个状态类里面，可以简化判断的逻辑。
/// 2.当有新的状态出现时，可以通过添加新的状态类来进行扩展，扩展性好。
/// 
/// 缺点：
/// 1.如果状态过多的话，会导致有非常多的状态类，加大了开销。
/// 
/// 应用场景：
/// 1.当一个对象状态转换的条件表达式过于复杂时可以使用状态者模式。
///   把状态的判断逻辑转移到表示不同状态的一系列类中，可以把复杂的判断逻辑简单化。
/// 2.当一个对象行为取决于它的状态，并且它需要在运行时刻根据状态改变它的行为时，就可以考虑使用状态者模式。
/// </remarks>
class Program
{
    static void Main(string[] args)
    {
        //开一个新的账户
        var account = new Account("Learning Hard");

        //存款
        account.Deposit(1000.00);
        account.Deposit(200.00);
        account.Deposit(600.00);

        //利息
        account.PayInterest();

        //取款
        account.Withdraw(2000.00);
        account.Withdraw(500.00);
    }
}
