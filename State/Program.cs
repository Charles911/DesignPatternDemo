using State;

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