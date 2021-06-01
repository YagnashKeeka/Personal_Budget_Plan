using System;
using System.Collections.Generic;//In order to use List<T>

abstract class Expense
{   //Expense is declared as an Abstract Class. Classes are created that will inherit from the abstract class Expense through the Expenditure class
    public abstract double TaxDeduction { get; set; }
    public abstract double GroceryCost { get; set; }
    public abstract double LightsWater { get; set; }
    public abstract double TravelCost { get; set; }
    public abstract double Telephone { get; set; }
    public abstract double ExtraExpense { get; set; }
    public abstract double Rent { get; set; }
    public abstract double PropertyPrice { get; set; }
    public abstract double TotalDeposit { get; set; }
    public abstract double Interestrate { get; set; }
    public abstract double NumberOfMonths { get; set; }
    public abstract double VehiclePurchasePrice { get; set; }
    public abstract double VehicleTotalDeposit { get; set; }
    public abstract double VehhicleInterestRate { get; set; }
    public abstract double VehicleInsurancePremium { get; set; }
    public abstract double HomeLoan();
    public abstract double VehicleCalculation();
}   //get and set declared in each class

//Get and set methods created in the classes. 
//Set method is used to set the value that is entered by the user.
//Get method is used to get the value that was set by the user and return that value

class Expenditure : Expense
{ //Expenditure class created. Inherits from abstract class Expense
    //Double variables created to hold input annd output values
    double tax, costGrocery, waterLights, travel, phone, extra, monthlyRent, purchasePrice, deposit, rate, months, vehiclePrice,  vehicleDeposit, vehicleInterest, vehicleInsurance = 0;

    //Classes are created and implements override properties.
    //These classes inherit from the abstract class Expense

    public override double TaxDeduction
    {
        get { return tax; }
        set { tax = value; }
    }

    public override double GroceryCost
    {
        get { return costGrocery; }
        set { costGrocery = value; }
    }

    public override double LightsWater
    {
        get { return waterLights; }
        set { waterLights = value; }
    }

    public override double TravelCost
    {
        get { return travel; }
        set { travel = value; }
    }

    public override double Telephone
    {
        get { return phone; }
        set { phone = value; }
    }

    public override double ExtraExpense
    {
        get { return extra; }
        set { extra = value; }
    }

    public override double Rent
    {
        get { return monthlyRent; }
        set { monthlyRent = value; }
    }

    //Value is added for calculation in HomeLoan() Method
    public override double PropertyPrice
    {
        get { return purchasePrice; }
        set { purchasePrice = value; }
    }

    //Value is added for calculation in HomeLoan() Method
    public override double TotalDeposit
    {
        get { return deposit; }
        set { deposit = value; }
    }

    //Value is added for calculation in HomeLoan() Method
    public override double Interestrate
    {
        get { return rate; }
        set { rate = value; }
    }

    //Value is added for calculation in HomeLoan() Method
    public override double NumberOfMonths
    {
        get { return months; }
        set { months = value; }
    }
    //Value is used for calculation in VehicleCalculation() Method
    public override double VehiclePurchasePrice
    {
        get { return vehiclePrice; }
        set { vehiclePrice = value; }
    }
    //Value is used for calculation in VehicleCalculation() Method
    public override double VehicleTotalDeposit
    {
        get { return vehicleDeposit; }
        set { vehicleDeposit = value; }
    }
    //Value is used for calculation in VehicleCalculation() Method
    public override double VehhicleInterestRate
    {
        get { return vehicleInterest; }
        set { vehicleInterest = value; }
    }
    //Value is used for calculation in VehicleCalculation() Method
    public override double VehicleInsurancePremium
    {
        get { return vehicleInsurance; }
        set { vehicleInsurance = value; }
    }

    public override double HomeLoan()
    {//Method class HomeLoan created. To calculate the monthly repayments on the home loan
        //Variables created to hold calculation values
        double monthlyRepayment, loanAmount1, loanAmount2;

        //Calculates the principal loan amount
        loanAmount1 = purchasePrice - deposit;

        //Simple interest formula: A = P(1 + in). Calculates the accumulated loan amount
        loanAmount2 = loanAmount1 * (1 + (rate * (1 / 100)) * (months / 12));

        //Calculates the monthly repayment amount
        return monthlyRepayment = loanAmount2 / months;
    }

    public override double VehicleCalculation()
    {//Method class VehicleCalculation created. To calculate the monthly repayments on the vehicle
        double monthlyRepayment, principleAmount, loanAmount;

        //Calculates the principal loan amount
        principleAmount = VehiclePurchasePrice - vehicleDeposit;

        //Simple interest formula: /A = P(1 + in)
        //Years has been assumed as 5 years (5 years = 60 months)
        loanAmount = principleAmount * (1 + (vehicleInterest * (1 / 100)) * (5));

        //Calculates the monthly repayment amount. Accumulated amount (loanAmount) divided by the number of months
        return monthlyRepayment = (loanAmount / 60) + vehicleInsurance;
    }

}

delegate String ExpenseExceedAlert(String alert);
namespace BudgetPlanning_POE_Task2
{
    class DelegateEvent
    {//Delegate class created
        public static String ExpenseAlert1(String errMessage)
        {//Holds a string value when the expense has exceeded a certain amount
            errMessage = "Your expenses has exceeded your income. If you have puchased a vehicle or a property, you do not qualify for a loan.\nYou may try again to budget your expenses. Thank you for using the application.";
            return errMessage;
        }

        class Program
        {
            static void Main(string[] args)
            {
                //Expenditure class is instantiated
                Expenditure costExpense = new Expenditure();
                //Delegate class is instantiated
                ExpenseExceedAlert exceedExpense = new ExpenseExceedAlert(ExpenseAlert1);
                //Variables declared to hold values
                double grossIncome;
                String choice, vehicleChoice, modelAndMake;
                //Try statement created
                String restartApplication;
                do
                {
                    try
                    {   //Double.Parse() is used. It converts a string value to a double
                        //User will input values
                        //Values will be input for gross income, tax, water and lights, travel cost, cellphone and telephone, and other expenses
                        Console.WriteLine("Enter your gross monthly income(excluding deductions)");
                        grossIncome = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter monthly tax deductions: ");
                        costExpense.TaxDeduction = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter monthly expense on groceries: ");
                        costExpense.GroceryCost = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter monthly expense on water and lights: ");
                        costExpense.LightsWater = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter monthly expense on travel costs (petrol included): ");
                        costExpense.TravelCost = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the monthly expense on cellphone and telephone: ");
                        costExpense.Telephone = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the monthly expense on other expense: ");
                        costExpense.ExtraExpense = Double.Parse(Console.ReadLine());

                        Console.Write("Will you be Purchasing or Renting a property? \nEnter (1) to purchase a property. Enter (2) if you are renting.\n");
                        choice = Console.ReadLine(); //A choice created to chooses between purchasing a property or renting

                        switch (choice)
                        {//Switch statment created to chooses between buying or renting a property
                            case "1":
                                //Sets the users input on the price, total deposit, interest rate and number of month of the property
                                Console.WriteLine("Enter the price of the property: ");
                                costExpense.PropertyPrice = Double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter the total deposit for the property: ");
                                costExpense.TotalDeposit = Double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter the interest rate on the property(Enter in normal form: 1% = 0.01): ");
                                costExpense.Interestrate = Double.Parse(Console.ReadLine());
                                //Interest rate of the property that will apply (1% = 0.01)

                                Console.WriteLine("Enter the number of months to repay the loan of the property (between 240 to 360 months): ");
                                costExpense.NumberOfMonths = Double.Parse(Console.ReadLine());
                                break;

                            case "2":
                                //Sets the users input on the rent expense
                                Console.Write("Enter monthly expense on the rent: ");
                                costExpense.Rent = Double.Parse(Console.ReadLine());

                                break;
                        }

                        Console.Write("Would you like to buy a vehicle? \nEnter (1) to purchase a vehicle. Enter (2) if you are NOT purchasing a vehicle.\n");
                        vehicleChoice = Console.ReadLine();
                        switch (vehicleChoice)
                        {//Switch statement created to choose between buying or not buying a vehicle
                            case "1"://If choice 1 is chosen
                                     //Sets the users input on the model and make, price, total deposit, interest rate and insurance of the vehicle
                                Console.WriteLine("Enter the Model and Make of the vehicle. (For example: Model is Audi and Make is A3):");
                                modelAndMake = Console.ReadLine();

                                Console.WriteLine("Enter the purchase price of the vehicle:");
                                costExpense.VehiclePurchasePrice = Double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter the total deposit of the vehicle:");
                                costExpense.VehicleTotalDeposit = Double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter the interest rate of the vechicle. Enter in normal form (1% = 0.01):");
                                Double.Parse(Console.ReadLine());
                                //Interest rate of the vehicle that will apply (1% = 0.01)

                                Console.WriteLine("Enter the insurance premium of the vehicle.(You may put an estimate amount for the insurance):");
                                Double.Parse(Console.ReadLine());
                                //Sets the indurance premium of the vehicle
                                break;

                            case "2"://If choice 2 is chosen
                                Console.WriteLine("The user will not be purchasing a vehicle");
                                break;
                        }
                        //Generic Collections. List<T>
                        List<double> listExpenses = new List<double>();
                        //Adding values to the list
                        listExpenses.Add(costExpense.TaxDeduction);
                        listExpenses.Add(costExpense.GroceryCost);
                        listExpenses.Add(costExpense.LightsWater);
                        listExpenses.Add(costExpense.TravelCost);
                        listExpenses.Add(costExpense.Telephone);
                        listExpenses.Add(costExpense.ExtraExpense);
                        listExpenses.Add(costExpense.HomeLoan());
                        listExpenses.Add(costExpense.Rent);
                        listExpenses.Add(costExpense.VehicleCalculation());
                        //Sorts the list of values displayed
                        listExpenses.Sort();
                        listExpenses.Reverse();
                        //The sorted list is reversed. To display the values in decending order

                        //variable created to add all the expenses together
                        double sumDeductions = costExpense.TaxDeduction + costExpense.GroceryCost + costExpense.LightsWater + costExpense.TravelCost + costExpense.Telephone + costExpense.ExtraExpense +
                                        +costExpense.Rent + costExpense.VehicleCalculation();

                        //double percentOfIncome = grossIncome * (0.75);
                        double percentOfIncome = grossIncome * (0.75);
                        //If statement created to determine whether the user has went above75% of their income
                        if (sumDeductions > percentOfIncome)
                        {   //Displayed if the expense has exceeded
                            //Delegate used to display if the user exceeds their expenses. It would show by how it has exceeded
                            Console.WriteLine("\n" + exceedExpense + "\n");
                        }
                        //Shows the availible money after all expenses made
                        double availibleIncome = grossIncome - sumDeductions;
                        Console.WriteLine("The availible gross income after all the deductions is R {0}", Math.Round(availibleIncome, 2));
                        //Shows the availible money after all expenses made
                        //foreach used to display the user input values in decending order
                        foreach (double num in listExpenses)
                        {   //Shows the expense values listed by the user in decending value
                            //Math.Round() used to display to 2 digits
                            Console.WriteLine(Math.Round(num, 2));// Displays the value
                        }
                        Console.WriteLine("Thank you for using the application.\n If you would like to try again, you may open the application and restart your process.");
                        //The applcation closes

                    }

                    catch (Exception)
                    {//Catches an error if the user has the correct input
                        Console.WriteLine("An error has been committed. An incorrect value has been entered.");
                    }
                    //Asked if there was an invvalid input
                    //To restart the process or to end the process
                    Console.WriteLine("Enter (y) to restart the process or enter (0) to exit the process");
                    restartApplication = Console.ReadLine().ToLower();
                } while (restartApplication.Equals("y"));//Restarts the process
                Console.ReadLine();
                while (restartApplication == "0")
                {//Ends the process
                    System.Environment.Exit(0);
                }

            }
                }
            }
        }
/*References
 * A-Z Tech. 2018. How to sort a list in C#?. [online] Available at: <https://www.jquery-az.com/c-sharp-list-sort/#:~:text=The%20reverse()%20method%20is,that%20list%20in%20descending%20order.> [Accessed 28 May 2021].
 * Bullock, J., 2020. 5 Alternatives to ‘If’ Statements for Conditional Branching. [online] Medium. Available at: <https://betterprogramming.pub/5-alternatives-to-if-statements-for-conditional-branching-6e8e6e97430b> [Accessed 28 May 2021].
 * Docs.microsoft.com. 2015. How to declare, instantiate, and use a delegate - C# Programming Guide. [online] Available at: <https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/how-to-declare-instantiate-and-use-a-delegate> [Accessed 28 May 2021].
 * Linus Tech Tips. 2014. Press Y to re-run program and E to exit. How do I do this in C#. [online] Available at: <https://linustechtips.com/topic/237337-press-y-to-re-run-program-and-e-to-exit-how-do-i-do-this-in-c/> [Accessed 31 May 2021].
 * Troelsen, A. and Japikse, P., 2017. Pro C# 7: With .NET and .NET Core. 8th ed. Apress.
 * Tutorialspoint.com. n.d.C# - Delegates - Tutorialspoint. [online] Available at: <https://www.tutorialspoint.com/csharp/csharp_delegates.htm> [Accessed 28 May 2021].
 * W3schools.com. n.d. C# Exceptions (Try..Catch). [online] Available at: <https://www.w3schools.com/cs/cs_exceptions.asp> [Accessed 29 May 2021].
 */