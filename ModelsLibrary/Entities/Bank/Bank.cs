using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;

namespace ModelsLibrary.Entities
{
    public class Bank : IBank
    {
        public String Name { get; set; }
        public Guid ID { get; set; }
        public int BankID { get; set; }
        public List<ClientBankAccount> ClientAccounts { get; set; }
        public List<CompanyBankAccount> CompanyAccounts { get; set; }
        public Dictionary<CompanyBankAccount, List<SalaryProjectAccount>> SalaryProjects { get; set; }
        // key - УНП потенциальной компании
        public Dictionary<int, SalaryProjectAccount> UnComposedSPEmployees { get; set; }
        // key - номер паспорта потенциального сотрудника
        public Dictionary<string, CompanyBankAccount> UnComposedSPCompanyAccounts { get; set; }
        public Bank()
        {
        }
        public Bank(string bankName, int bankID)
        {
            ID = Guid.NewGuid();
            Name = bankName;
            BankID = bankID;
            ClientAccounts = new List<ClientBankAccount>();
            CompanyAccounts = new List<CompanyBankAccount>();
            SalaryProjects = new Dictionary<CompanyBankAccount, List<SalaryProjectAccount>>();
            UnComposedSPCompanyAccounts = new Dictionary<string, CompanyBankAccount>();
            UnComposedSPEmployees = new Dictionary<int, SalaryProjectAccount>();
        }

        public void AddNewCompany(CompanyBankAccount acc)
        {
            CompanyAccounts.Add(acc);
        }
        public void AddNewClient(ClientBankAccount acc)
        {
            ClientAccounts.Add(acc);
        }

        public int AddSalaryProjectFromClient(ClientUser usr, int salary, CompanyUser company, int AccountID)
        {
            var employee = new SalaryProjectAccount(usr.FirstName, usr.LastName, usr.PassportNum, usr.PassportID, usr.Telephone, usr.Email, company.BankID, AccountID, salary);
            AccountID++;
            UnComposedSPEmployees.Add(company.UNP, employee);
            return AccountID;
        }
        public void AddSalaryProjectFromCompany(ClientUser usr, CompanyBankAccount compAcc)
        {
            UnComposedSPCompanyAccounts.Add(usr.PassportNum, compAcc);
        }
        public void CompareSP()
        {
            foreach (var unp in UnComposedSPEmployees.Keys)
            {
                foreach (var passNum in UnComposedSPCompanyAccounts.Keys)
                {
                    if (UnComposedSPCompanyAccounts[passNum].UNP == unp)
                    {
                        var comp = UnComposedSPCompanyAccounts[passNum];
                        var emp = UnComposedSPEmployees.Values.First(item => item.PassportNum == passNum);
                        emp.EmployeeStatus = EmployeeStatus.NotApproved;
                        if (SalaryProjects.ContainsKey(comp))
                        {
                            SalaryProjects[comp].Add(emp);
                        }
                        else
                        {
                            var empList = new List<SalaryProjectAccount>();
                            empList.Add(emp);
                            SalaryProjects.Add(comp, empList);
                        }
                    }
                }
            }
        }



        //public void AddNewClient(ClientBankAccount client)
        //{
        //    Clients.Add(client);
        //}

        //public void AddNewClient(string firstName, string lastName, string passportNum, int passportID, string telephone, string email)
        //{
        //    ClientBankAccount client = new ClientBankAccount(firstName, lastName, passportNum, passportID, telephone, email, BankID);
        //    Clients.Add(client);
        //}

        //public void AddNewClients(List<ClientBankAccount> clients)
        //{
        //    Clients.AddRange(clients);
        //}

        //public void DeleteClient(Guid id)
        //{
        //    Clients.Remove(Clients.Find(item => item.AccountID == id));
        //}

        //public IEnumerable<ClientBankAccount> GetAllClients()
        //{
        //    return Clients;
        //}

        //public ClientBankAccount GetClient(string passportNum)
        //{
        //    return Clients.Find(item => item.PassportNum == passportNum);
        //}


        //public bool AddSalaryProjectFromCompany(ClientUser usr, int salary, CompanyBankAccount acc, int AccountID)
        //{
        //    if (!SalaryProjects.ContainsKey(acc))
        //    {
        //        // salary project требует инициализации
        //        var salprAccounts = new List<SalaryProjectAccount>();
        //        SalaryProjects.Add(acc, salprAccounts);
        //    }
        //    var emp = SalaryProjects[acc].FirstOrDefault(item => item.PassportNum == usr.PassportNum);
        //    if (emp != null)
        //    {
        //        // этот employee уже добавлен в salary project
        //        throw new Exception("This employee already added to the salary project.");
        //        //emp.Salary = salary;
        //        //emp.EmployeeStatus = EmployeeStatus.NotApproved;
        //        //UnapprovedSalaryAccounts.Add(emp);
        //        //return false;
        //    }
        //    else
        //    {
        //        // этот employee еще не добавлен в salary project, но salary project уже инициализирован
        //        SalaryProjects[acc].Add(new SalaryProjectAccount(usr.FirstName, usr.LastName, usr.PassportNum, usr.PassportID, usr.Telephone, usr.Email, acc.BankID, AccountID, salary));
        //        return true;
        //    }
        //}

        //public int AddSalaryProjectFromCompany(ClientUser usr, int salary, CompanyBankAccount compAcc)
        //{
        //    if (UnComposedSPEmployees.ContainsKey(compAcc.UNP))
        //    {
        //        // сотрудник уже подавал заявку на это предприятие
        //        var employee = UnComposedSPCompanyAccounts[usr.PassportNum];
        //    }
        //    else
        //    {

        //    }
        //}



        //public int AddSalaryProjectFromClient(ClientUser usr, int salary, CompanyUser company, int AccountID)
        //{
        //    //UnComposedSPCompanyAccounts.Keys.FirstOrDefault(item => item == usr.PassportNum);
        //    if (UnComposedSPCompanyAccounts.ContainsKey(usr.PassportNum))
        //    {
        //        // компания уже подавала заявку на этого сотрудника
        //        var compAcc = UnComposedSPCompanyAccounts[usr.PassportNum];
        //        var employee = new SalaryProjectAccount(usr.FirstName, usr.LastName, usr.PassportNum, usr.PassportID, usr.Telephone, usr.Email, compAcc.BankID, AccountID, salary);
        //        AccountID++;
        //        if (SalaryProjects.ContainsKey(compAcc))
        //        {
        //            // в salary project уже есть аккаунт этой компании
        //            SalaryProjects[compAcc].Add(employee);
        //        }
        //        else
        //        {
        //            // в salary project еще не было аккаунта этой компании
        //            var empList = new List<SalaryProjectAccount>();
        //            empList.Add(employee);
        //            SalaryProjects.Add(compAcc, empList);
        //        }
        //    }
        //    else
        //    {
        //        // компания еще не подавала заявку на этого client
        //        var employee = new SalaryProjectAccount(usr.FirstName, usr.LastName, usr.PassportNum, usr.PassportID, usr.Telephone, usr.Email, company.BankID, AccountID, salary);
        //        AccountID++;
        //        UnComposedSPEmployees.Add(company.UNP, employee);
        //    }
        //    return AccountID;
        //if(compAcc != null)
        //{
        //    // компания уже подала заявку
        //    if (SalaryProjects.ContainsKey(compAcc))
        //    {
        //        // компания подала заявку на аккаунт который уже есть в salary project
        //        SalaryProjects[compAcc].Add(new SalaryProjectAccount(usr.FirstName, usr.LastName, usr.PassportNum, usr.PassportID, usr.Telephone, usr.Email, compAcc.BankID, AccountID, salary));
        //        AccountID++;
        //        // salary project осталось только approve менеджеру
        //    }
        //    else
        //    {
        //        // компания подала заявку на аккаунт которого еще нет в salary project
        //        if(UnComposedSPEmployees.ContainsKey)
        //        var dd = UnComposedSPEmployees.FirstOrDefault(item => item.UNP == company.UNP);
        //        var
        //        UnComposedSPEmployees.Add(company.UNP, )
        //    }
        //}



        //bool isacc = false;
        //CompanyBankAccount acc = null;
        //foreach (var _acc in company.Accounts)
        //{
        //    if (SalaryProjects.ContainsKey(_acc))
        //    {
        //        isacc = true;
        //        acc = _acc;
        //        break;
        //    }
        //}
        //if (!isacc)
        //{
        //    // salary project требует инициализации
        //    // company account для salary project требует инициализации
        //    var newacc = new CompanyBankAccount(company.Email, company.Telephone, company.CompanyName, company.UNP, company.Address, company.BankID, company.CompanyType, AccountID);
        //    AccountID++;
        //    acc = newacc;
        //    var salprAccounts = new List<SalaryProjectAccount>();
        //    SalaryProjects.Add(acc, salprAccounts);
        //}
        //var emp = SalaryProjects[acc].FirstOrDefault(item => item.PassportID == usr.PassportID);
        //if (emp != null)
        //{
        //    // company уже запрашивал заявку на salary project данного cllient, подтверждаем compose
        //    emp.EmployeeStatus = EmployeeStatus.NotApproved;
        //}
        //else
        //{
        //    // создаем заявку на новый salary project
        //    SalaryProjects[acc].Add(new SalaryProjectAccount(usr.FirstName, usr.LastName, usr.PassportNum, usr.PassportID, usr.Telephone, usr.Email, acc.BankID, AccountID, salary));
        //    AccountID++;
        //}
        //return AccountID;
        //}
    }
}
