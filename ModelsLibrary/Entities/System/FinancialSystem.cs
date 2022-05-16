using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;

namespace ModelsLibrary.Entities
{
    public class FinancialSystem
    {
        string[] dbNames = new[] {
            "Liam", "Noah", "Oliver", "Elijah", "Lucas", "Levi", "Mason", "Asher", "James", "Ethan", "Mateo", "Leo", "Jack", "Benjamin", "Aiden", "Logan", "Grayson", "Jackson", "Henry", "Wyatt", "Sebastian", "Carter", "Daniel", "William", "Alexander", "Ezra", "Owen", "Michael", "Muhammad", "Julian", "Hudson", "Luke", "Samuel", "Jacob", "Lincoln", "Gabriel", "Jaden", "Luca", "Maverick", "David", "Josiah", "Thomas", "Nolan", "Waylon", "Ryan", "Easton", "Roman", "Adrian", "Miles", "Greyson", "Cameron", "Colton", "Landon", "Santiago", "Andrew", "Hunter", "Legend", "Jonah", "River", "Tyler", "Cole", "Braxton", "George", "Milo", "Zachary", "Ashton", "Luis", "Jasper", "Kaiden", "Adriel", "Gavin", "Bentley", "Calvin", "Zion", "Juan", "Maxwell", "Max", "Ryker", "Carlos", "Emmanuel", "Olivia", "Emma", "Amelia", "Ava", "Sophia", "Charlotte", "Isabella", "Mia", "Luna", "Harper", "Gianna", "Evelyn", "Aria", "Ella", "Ellie", "Alice", "Aubrey", "Savannah", "Serenity", "Autumn", "Leah", "Sophie", "Natalie", "Athena", "Lillian", "Hailey", "Audrey", "Eva", "Everleigh", "Kennedy", "Maria", "Natalia", "Nevaeh", "Brooklyn", "Raelynn", "Arya", "Ariana", "Madelyn", "Claire", "Valentina", "Sadie", "Gabriella", "Ruby", "Anna"
        };
        string[] dbLastNames = new[] {
            "Smith", "Jones", "Williams", "Brown", "Johnson", "Taylor", "Davis", "Miller", "Wilson", "Thompson", "Thomas", "Anderson", "White", "Martin", "Moore", "Jackson", "Clark", "Walker", "Evans", "Lee", "Lewis", "King", "Harris", "Roberts", "Robinson", "Wright", "Young", "Scott", "Reed", "Murphy", "Hill", "Wood", "Hall", "Green", "Allen", "Kelly", "Campbell", "Edwards", "Adams", "Baker", "Watson", "Mitchell", "Phillips", "Cooper", "Turner", "Morris", "Carter", "Morgan", "Hughes", "Cook", "Ward", "Collins", "James", "Parker", "Bell", "Nelson", "Stewart", "Bailey", "Stevens", "Cox", "Bennett", "Murray", "Rogers", "Gray", "Price", "Ryan", "McDonald", "Russell", "Richardson", "Harrison", "Sanders", "Walsh", "O'Connor", "Simpson", "Marshall", "Ross", "Perry", "O'Brien", "Kennedy", "Graham", "Foster", "Shaw", "Ellis", "Griffiths", "Fisher", "Butler", "Reynolds", "Fox", "Robertson", "Barnes", "Chapman", "Powell", "Fraser", "Mason", "Henderson", "Hamilton", "Peterson", "Howard", "O'Sullivan", "Brooks"
        };
        public List<Bank> Banks { get; set; }
        public List<CompanyUser> CompanyUsers { get; set; }
        public List<ClientUser> ClientUsers { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Actions Actions { get; set; }
        public Log Log { get; set; }
        public Operator OperatorUser { get; set; }
        public Manager ManagerUser { get; set; }
        public Administrator AdministratorUser { get; set; }
        public int CurrentTransactionID { get; set; }
        public int CurrentActionID { get; set; }
        public int CurrentAccountID { get; set; }
        public FinancialSystem()
        {
            CurrentAccountID = 10000000;
            CurrentTransactionID = 20000000;
            CurrentActionID = 30000000;
            Banks = new List<Bank>();
            CompanyUsers = new List<CompanyUser>();
            ClientUsers = new List<ClientUser>();
            Transactions = new List<Transaction>();
            Actions = new Actions();
            Log = new Log("D://OOP//lab1//logfile");
            InitializeBanks();
            InitOneClient();
            InitSuperUsers();
        }
        public void InitializeDB()
        {
            InitializeAccountClients();
            InitializeBanks();
        }
        public void InitOneClient()
        {
            IClientUser usr = new ClientUser();
            usr.FirstName = "Maksim";
            usr.LastName = "Vasilevich";
            usr.PassportNum = "MP543633";
            usr.Telephone = "375295672390";
            usr.Email = "imaksus@gmail.com";
            usr.PassportID = 1234567;
            usr.Password = "123";
            usr.Login = "maks";
            ClientUsers.Add((ClientUser)usr);
        }
        public void InitSuperUsers()
        {
            OperatorUser = new Operator("operator", "1111");
            ManagerUser = new Manager("manager", "1111");
            AdministratorUser = new Administrator("administrator", "1111");
        }
        public void InitializeAccountClients()
        {
            int[] numberCode = new[] { 25, 29, 44 };
            string[] mail = new[] { "@tut.by", "@gmail.com", "@dev.by" };
            var rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                IClientUser clUser = new ClientUser();
                clUser.FirstName = dbNames[rnd.Next(dbNames.Length)];
                clUser.LastName = dbLastNames[rnd.Next(dbNames.Length)];
                clUser.PassportNum = Convert.ToChar(rnd.Next(65, 90)) + Convert.ToChar(rnd.Next(65, 90)) + Convert.ToString(rnd.Next(100000, 999999));
                clUser.PassportID = rnd.Next(1000000, 9999999);
                clUser.Telephone = "375" + Convert.ToString(rnd.Next(numberCode.Length)) + Convert.ToString(rnd.Next(1000000, 9999999));
                clUser.Email = clUser.FirstName + clUser.LastName + Convert.ToString(rnd.Next(1000, 9999)) + Convert.ToString(rnd.Next(mail.Length));
                ClientUsers.Add((ClientUser)clUser);
            }
        }
        public void InitializeBanks()
        {
            var names = new[] { "Беларускi народны банк", "Беларуска-Польскi банк", "Банк развiцця" };
            var idxs = new[] { 16873947, 29692837, 75928738 };
            for (int i = 0; i < 3; i++)
            {
                Banks.Add(new Bank(names[i], idxs[i]));
            }
        }
        public void InitializeCompanys()
        {

        }

        // Registrate Client User
        public void RegistrateUser(string name, string login, string password, string telephone, string email, string passportNum, int passportID)
        {
            ClientUsers.Add(new ClientUser(name, login, password, telephone, email, passportNum, passportID));
            Log.WriteLog("Registrate Company User ", String.Format("name : \"{0}\", Login : {1}, Password : {2}, telephone : {3}, passportNum : {4}, passportID : {5}", name, login, password, telephone, passportNum, passportID));
        }

        // Registrate Company User
        public void RegistrateUser(string Login, string Password, string Email, string Telephone, string CompanyName, int UNP, string Address, int BanckID, string CompanyType)
        {
            if (Banks.FirstOrDefault(item => item.BankID == BanckID) == null) throw new Exception("No such bank with the Bank ID. Choose existing bank");
            if(CompanyUsers.FirstOrDefault(item => item.UNP == UNP) != null) throw new Exception("Company with this UNP already exists. You can't registrate.");
            CompanyUsers.Add(new CompanyUser(Login, Password, Email, Telephone, CompanyName, UNP, Address, BanckID, CompanyType));
            Log.WriteLog("Registrate Company User ", String.Format("CompanyName : \"{0}\", Login : {1}, Password : {2}, UNP : {3}, Address : {4}, BanckID : {5}", CompanyName, Login, Password, UNP, Address, BanckID));
        }

        public void CreateTransaction(int SourceAccountID, int SourceBankID, int DestinationAccountID, int DestinationBankID, int Sum)
        {
            TransactionStatus status = TransactionStatus.Approved;
            IBankAccount srcacc = null;
            IBankAccount dstacc = null;
            foreach (var company in CompanyUsers)
            {
                var _srcacc = company.Accounts.FirstOrDefault(item => item.AccountID == SourceAccountID);
                var _dstacc = company.Accounts.FirstOrDefault(item => item.AccountID == DestinationAccountID);
                if (_srcacc != null)
                {
                    srcacc = _srcacc;
                    //status = TransactionStatus.NotApproved;
                }
                if (_dstacc != null) dstacc = _dstacc;
                if (dstacc != null && srcacc != null) break;
            }
            foreach (var client in ClientUsers)
            {
                var _srcacc = client.BankAccounts.FirstOrDefault(item => item.AccountID == SourceAccountID);
                var _dstacc = client.BankAccounts.FirstOrDefault(item => item.AccountID == DestinationAccountID);
                if (_srcacc != null) srcacc = _srcacc;
                if (_dstacc != null) dstacc = _dstacc;
                if (dstacc != null && srcacc != null) break;
            }
            foreach (var bank in Banks)
            {
                foreach (var emps in bank.SalaryProjects.Values)
                {
                    var dstemp = emps.FirstOrDefault(item => item.AccountID == DestinationAccountID);
                    foreach (var emp in emps)
                    if (dstemp != null) dstacc = dstemp;
                    if (dstacc != null) break;
                }
                if (dstacc != null) break;
            }
            if (dstacc == null || srcacc == null) throw new Exception(String.Format("Incorrect Account ID to transfer money between {0} and {1}", SourceAccountID, DestinationAccountID));
            var ts = new Transaction(SourceAccountID, SourceBankID, DestinationAccountID, DestinationBankID, Sum, CurrentTransactionID, status);
            Transactions.Add(ts);
            ExecuteTransaction(CurrentTransactionID);
            CurrentTransactionID++;
        }

        public void ExecuteTransaction(int id)
        {
            var ts = Transactions.FirstOrDefault(item => item.ID == id);
            if (ts == null) throw new Exception(String.Format("No such transaction with {0} ID", id));
            if (ts.Status == TransactionStatus.NotApproved) return;
            var SourceAccountID = ts.SourceAccountID;
            var DestinationAccountID = ts.DestinationAccountID;
            IBankAccount srcacc = null;
            IBankAccount dstacc = null;
            foreach (var company in CompanyUsers)
            {
                var _srcacc = company.Accounts.FirstOrDefault(item => item.AccountID == SourceAccountID);
                var _dstacc = company.Accounts.FirstOrDefault(item => item.AccountID == DestinationAccountID);
                if (_srcacc != null) srcacc = _srcacc;
                if (_dstacc != null) dstacc = _dstacc;
                if (dstacc != null && srcacc != null) break;
            }
            foreach (var client in ClientUsers)
            {
                var _srcacc = client.BankAccounts.FirstOrDefault(item => item.AccountID == SourceAccountID);
                var _dstacc = client.BankAccounts.FirstOrDefault(item => item.AccountID == DestinationAccountID);
                if (_srcacc != null) srcacc = _srcacc;
                if (_dstacc != null) dstacc = _dstacc;
                if (dstacc != null && srcacc != null) break;
            }
            foreach (var bank in Banks)
            {
                foreach (var emps in bank.SalaryProjects.Values)
                {
                    var dstemp = emps.FirstOrDefault(item => item.AccountID == DestinationAccountID);
                    foreach (var emp in emps)
                        if (dstemp != null) dstacc = dstemp;
                    if (dstacc != null) break;
                }
                if (dstacc != null) break;
            }
            if (dstacc == null || srcacc == null || dstacc == srcacc) throw new Exception("Incorrect Account ID to transfer money");
            if (srcacc.Money < ts.Sum) throw new Exception(String.Format("Not enough money to execute transaction between {0} and {1}", srcacc.AccountID, dstacc.AccountID));
            srcacc.Money -= ts.Sum;
            dstacc.Money += ts.Sum;
            Actions.WriteAction(ts, CurrentActionID);
            CurrentActionID++;
            Log.WriteLog("Execute Transaction", String.Format("between {0} and {1} sum = {2}", srcacc.AccountID, dstacc.AccountID, ts.Sum));
        }

        public IUser FindUser(string login)
        {
            var usr1 = ClientUsers.FirstOrDefault(item => item.Login == login);
            if (usr1 != null) return usr1;
            var usr2 = CompanyUsers.FirstOrDefault(item => item.Login == login);
            if (usr2 != null) return usr2;
            else return null;
        }
        public IClientUser FindClientByPassNum(string passnum)
        {
            var usr = ClientUsers.FirstOrDefault(item => item.PassportNum == passnum);
            if (usr == null)
            {
                throw new Exception("Unable to find user with Passport Num");
            }
            return usr;
        }
        public IUser FindSuperUser(string login)
        {
            if (login == OperatorUser.Login) return OperatorUser;
            else if (login == ManagerUser.Login) return ManagerUser;
            else if (login == AdministratorUser.Login) return AdministratorUser;
            else
            {
                return null;
            }
        }

        public bool ComparePasswords(IUser usr, string passwords)
        {
            if (usr.Password == passwords)
            {
                Log.WriteLog("Loging in", String.Format("by \"{0}\" user", usr.Login));
                return true;
            }
            else
            {
                Log.WriteLog("Failed loging in", String.Format("by \"{0}\" user with failed password {1}", usr.Login, usr, passwords));
                throw new Exception(String.Format("Invalid password"));
            }
        }

        public void AddSalaryAccountFromCompany(string passportNum, CompanyBankAccount acc)
        {
            var bank = Banks.FirstOrDefault(item => item.BankID == acc.BankID);
            var usr = ClientUsers.FirstOrDefault(item => item.PassportNum == passportNum);
            if (usr == null) throw new Exception("No such user with the passport num");
            bank.AddSalaryProjectFromCompany(usr, acc);
            bank.CompareSP();
            var sp = bank.SalaryProjects;
            Log.WriteLog("Added Salary Account", String.Format("from company {0}, bank : {1}, employee : {2}", acc.CompanyName, bank.Name, usr.PassportNum));
        }

        public void AddSalaryAccountFromClient(int UNP, ClientUser usr)
        {
            var company = CompanyUsers.FirstOrDefault(item => item.UNP == UNP);
            if (company == null) throw new Exception("No such company with the UNP");
            var bank = Banks.FirstOrDefault(item => item.BankID == company.BankID);
            CurrentAccountID = bank.AddSalaryProjectFromClient(usr, 0, company, CurrentAccountID);
            bank.CompareSP();
            var sp = bank.SalaryProjects;
            Log.WriteLog("Added Salary Account", String.Format("from client {0}, bank : {1}, company UNP : {2}", usr.PassportNum, bank.Name, company.UNP));
        }

        public void CreateCompanyAccount(CompanyUser company)
        {
            var acc = company.CreateNewAccount(CurrentAccountID);
            CurrentAccountID++;
            Banks.Find(item => item.BankID == company.BankID).AddNewCompany(acc);
            Actions.WriteAction(acc, CurrentActionID++);
            Log.WriteLog("Created Account", String.Format("from company {0}", company.CompanyName));
        }
        public void CreateClientAccount(ClientUser client, Bank bank)
        {
            var acc = client.CreateNewAccount(CurrentAccountID, bank.BankID);
            CurrentAccountID++;
            Banks.Find(item => item.BankID == bank.BankID).AddNewClient(acc);
            Actions.WriteAction(acc, CurrentActionID++);
            Log.WriteLog("Created Account", String.Format("from client {0}, bank : {1}", client.PassportNum, bank.Name));

        }

        public void RemoveAccount(IBankAccount acc)
        {
            // Remove Client Account
            foreach (var bank in Banks)
            {
                var accToRemove1 = bank.ClientAccounts.SingleOrDefault(item => item.AccountID == acc.AccountID);
                if (accToRemove1 != null)
                {
                    foreach (var client in ClientUsers)
                    {
                        var accToRemoveInner = client.BankAccounts.SingleOrDefault(item => item.AccountID == acc.AccountID);
                        if(accToRemoveInner != null)
                        {
                            client.BankAccounts.Remove(accToRemoveInner);
                            break;
                        }
                    }
                    bank.ClientAccounts.Remove(accToRemove1);
                    acc = null;
                    Log.WriteLog("Account Removed", String.Format("from client {0}, accountID : {1}", accToRemove1.PassportNum, accToRemove1.AccountID));
                    return;
                }
                // Remove Company Account
                var accToRemove2 = bank.CompanyAccounts.SingleOrDefault(item => item.AccountID == acc.AccountID);
                if (accToRemove2 != null)
                {
                    foreach (var company in CompanyUsers)
                    {
                        var accToRemoveInner = company.Accounts.SingleOrDefault(item => item.AccountID == acc.AccountID);
                        if (accToRemoveInner != null)
                        {
                            if(accToRemoveInner.Employees.Count() != 0)
                            {
                                // remove employees
                                var spacc = bank.SalaryProjects.Keys.SingleOrDefault(item => item.AccountID == accToRemoveInner.AccountID);
                                    bank.SalaryProjects.Remove(spacc);
                                foreach (var client in ClientUsers)
                                {
                                    var emp = accToRemoveInner.Employees.FirstOrDefault(item => item.PassportNum == client.PassportNum);
                                    if (emp != null)
                                    {
                                        client.SalaryProjectAccount = null;
                                        Log.WriteLog("Account Removed", String.Format("(employee) from company \"{0}\", accountID : {1}", accToRemove2.CompanyName, emp.AccountID));

                                    }
                                }
                            }
                            company.Accounts.Remove(accToRemoveInner);
                            break;
                        }
                    }
                    bank.CompanyAccounts.Remove(accToRemove2);
                    acc = null;
                    Log.WriteLog("Account Removed", String.Format("from company \"{0}\", accountID : {1}", accToRemove2.CompanyName, accToRemove2.AccountID));
                    return;
                }
                if (acc == null) return;
            }
            throw new Exception("No account to close with this Accound ID");
        }
        public void AddMoneyToAccount(BankAccount acc, int money)
        {
            acc.AddMoney(money);
            Log.WriteLog("Added money", String.Format("to accountID \"{0}\", sum : {1}", acc.AccountID, money));
        }
        public void TakeOffMoneyAccount(BankAccount acc, int money)
        {
            acc.TakeOffMoney(money);
            Log.WriteLog("Take off money", String.Format("from accountID \"{0}\", sum : {1}", acc.AccountID, money));
        }



        // --------   SUPER USER FUNCTIONS   --------


        public Dictionary<CompanyBankAccount, SalaryProjectAccount> GetUnapprovedSP()
        {
            Dictionary<CompanyBankAccount, SalaryProjectAccount> SPTemp = new Dictionary<CompanyBankAccount, SalaryProjectAccount>();
            foreach (var bank in Banks)
            {
                if (bank.SalaryProjects.Count == 0) continue;
                foreach (var sp in bank.SalaryProjects)
                {
                    var companyAcc = sp.Key;
                    var employees = sp.Value;
                    foreach (var employee in employees)
                    {
                        if (employee.EmployeeStatus == EmployeeStatus.NotApproved)                            SPTemp.Add(companyAcc, employee);
                    }
                }
            }
            return SPTemp;
        }
        public void UpproveSP()
        {
            foreach (var bank in Banks)
            {
                if (bank.SalaryProjects.Count == 0) continue;
                foreach (var sp in bank.SalaryProjects)
                {
                    var companyAcc = sp.Key;
                    var employees = sp.Value;
                    foreach (var employee in employees)
                    {
                        if (employee.EmployeeStatus == EmployeeStatus.NotApproved)
                        {
                            employee.EmployeeStatus = EmployeeStatus.Approved;
                            var usr = ClientUsers.Find(item => item.PassportNum == employee.PassportNum);
                            usr.SalaryProjectAccount = employee;
                            //var company = CompanyUsers.Find(item => item.UNP == companyAcc.UNP);
                            companyAcc.Employees.Add(employee);
                        }
                    }
                }
            }
        }

        public void UndoAction()
        {
            int id = CurrentActionID - 1;
            if (Actions.FindActionTS(id))
            {
                UndoTS(Actions.LastActionTS());
            }
            else if (Actions.FindActionClAcc(id))
            {
                UndoClAcc(Actions.LastActionClAcc());
            }
            else if (Actions.FindActionCompAcc(id))
            {
                UndoCompAcc(Actions.LastActionCompAcc());
            }
            Actions.DeleteAction(id);
            CurrentAccountID = id;
        }
        public void UndoTS(Transaction ts)
        {
            var SourceAccountID = ts.SourceAccountID;
            var DestinationAccountID = ts.DestinationAccountID;
            IBankAccount srcacc = null;
            IBankAccount dstacc = null;
            foreach (var company in CompanyUsers)
            {
                var _srcacc = company.Accounts.FirstOrDefault(item => item.AccountID == SourceAccountID);
                var _dstacc = company.Accounts.FirstOrDefault(item => item.AccountID == DestinationAccountID);
                if (_srcacc != null) srcacc = _srcacc;
                if (_dstacc != null) dstacc = _dstacc;
                if (dstacc != null && srcacc != null) break;
            }
            foreach (var client in ClientUsers)
            {
                var _srcacc = client.BankAccounts.FirstOrDefault(item => item.AccountID == SourceAccountID);
                var _dstacc = client.BankAccounts.FirstOrDefault(item => item.AccountID == DestinationAccountID);
                if (_srcacc != null) srcacc = _srcacc;
                if (_dstacc != null) dstacc = _dstacc;
                if (dstacc != null && srcacc != null) break;
            }
            srcacc.Money += ts.Sum;
            dstacc.Money -= ts.Sum;
            Log.WriteLog("Undo Transaction", String.Format("between {0} and {1} sum = {2}", srcacc.AccountID, dstacc.AccountID, ts.Sum));
        }

        public void UndoClAcc(ClientBankAccount acc)
        {
            RemoveAccount(acc);
            Log.WriteLog("Undo Create Account", String.Format("account ID : {0}",acc.AccountID));
        }

        public void UndoCompAcc(CompanyBankAccount acc)
        {
            RemoveAccount(acc);
            Log.WriteLog("Undo Create Account", String.Format("account ID : {0}",acc.AccountID));
        }
    }
}
