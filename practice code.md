**class employee
{**

**static string companyname = "MyGoMinds";**

**int eno;**

**int name;**

**double bsal;**



**void calculateDa(double daamt)**

**{**

**double da = bsal + daamt;**

**}**



**void displaytotalsal()**

**{**

**console.writeLine("Amount after calculating Dearness allowence", da);**



**}**

**static void Main(){**



**employee e1 = new e1();**

**cosole.writeline(employee.companyname);**

**e1.calculateDa(123.4);**

**e1.displaytotalsal();**

**}**





**class Student  
{**

**static string collegename = "MyGoMinds";**

**int sno;**

**int sname;**



**int calculateTotalMarks(int m1, int m2, int m3)**

**{**

&nbsp;   \*\*int totalMarks = m1 + m2 +m3;\*\*


**}**





**}**



**class employee{**



\*\*int empno = 1001;\*\*

	\*\*string empname = "Safal";\*\*

	\*\*string companyname = "MygoMinds";\*\*

	\*\*long phoneno = 8792440714;\*\*






**}**



**int no1 = 12;**

**int no2 = 56;**







**class MygoMinds
{**

&nbsp;	\*\*int x;\*\*

		\*\*int y;\*\*

		\*\*int z;\*\*

		\*\*void setInput()\*\*

			\*\*{
			x = 5;\*\*

			\*\*y = 10;\*\*

			\*\*}\*\*



		\*\*void calculateSum()\*\*



			\*\*{\*\*

				\*\*z = x + y;\*\*

			\*\*}\*\*



		\*\*void displaySum(){\*\*

				\*\*console.writeLine(z)
			}\*\*



          \*\*static void Main()
	{\*\*

		\*\*MygoMinds m1 = new MygoMainds();\*\*

		\*\*m1.setInput();\*\*

		\*\*m1.calculateSum();\*\*

		\*\*m1.displaySum();\*\*

	\*\*}\*\*

 	\*\*}\*\*










**class MygoMinds**

**{**

**public void printResults(int x,int y)**





**class Safal**

**{**

**static Safal()**

\*\*{\*\*

		\*\*Console.WriteLine("I am static constructor");\*\*

	\*\*}\*\*






**static void Main()**

\*\*{\*\*

	\*\*Console.WriteLine("I am main method");\*\*

	\*\*}\*\*


**}**









**class MygoMinds**

**{**

\*\*int x;\*\*

	\*\*double y;\*\*

	\*\*char c;\*\*

	\*\*string s;\*\*

	\*\*bool b;\*\*

	\*\*void print()\*\*

	\*\*{\*\*

		\*\*Console.WriteLine(x);\*\*

		\*\*Console.WriteLine(y);\*\*

		\*\*Console.WriteLine(c);\*\*

		\*\*Console.WriteLine(s);\*\*

		\*\*Console.WriteLine(b);\*\*

	\*\*}\*\*



	\*\*static void Main()\*\*

	\*\*{\*\*

		\*\*MygoMinds mgm = new MygoMinds();\*\*

		\*\*mgm.print();\*\*

	\*\*}\*\*


**}**





**class A**



**{**

\*\*int x;\*\*

	\*\*int y;\*\*

	\*\*public A()\*\*

	\*\*{\*\*

		\*\*x = 5;\*\*

		\*\*y = 6;\*\*

	\*\*}\*\*






**static void Main()**

\*\*{\*\*

		\*\*A a = new A();\*\*

		\*\*}\*\*


**}**











**class Account**

\*\*{\*\*

		\*\*long accno;\*\*

		\*\*double mbal;\*\*

		\*\*public Account()\*\*

			\*\*{\*\*

			\*\*bal = 1000;\*\*

			\*\*}\*\*

		\*\*public void Deposit(long no, double amount)\*\*

			\*\*{\*\*

			\*\*accno = no;\*\*

			\*\*bal = bal + amount;\*\*

			\*\*}\*\*

		\*\*static void Main()\*\*

			\*\*{\*\*

				\*\*Account a1 = new Account();\*\*

				\*\*a1.Deposit(101,5000);\*\*

				\*\*Account a2 = new Account();\*\*

				\*\*a2.Deposit(102,4000);\*\*

			\*\*}\*\*



	\*\*}\*\*










**class Student**

**{**

\*\*int sno;\*\*

	\*\*string sname;\*\*

	\*\*public Student(int no, string name)\*\*

	\*\*{\*\*

		\*\*sno = no;\*\*

		\*\*sname = name;\*\*

	\*\*}\*\*

	

	\*\*public void print()\*\*	

	\*\*{\*\*

		\*\*Console.WriteLine(sno);\*\*

		\*\*Console.WriteLine(sname);\*\*

	\*\*}\*\*






**static void Main()**

\*\*{\*\*

		\*\*Student s1 = new Student(101,'Safal');\*\*



		\*\*s1.print();\*\*



		\*\*Student s2 = new Student(102,'Sunil');

		s2.print();\*\*






	\*\*}\*\*


**}**



**class MygoMinds**

	**{**

		**void m1**





**class A								o/p - I am main**

**{**

	**static void show()**

	**{**

		**Console.WriteLine("I am show");**

	**}**



	**static void Main()**

	**{**

		**Console.WriteLine("I am main");**

	**}**

**}**







**class A										o/p - I am show**

**{**

	**void show()**

	**{**

		**Console.WriteLine("I am show");**

	**}**



**static void Main()**

**{**

	**A a1 = new A();**

	**a1.show();**

**}**

**}**













**class A**

**{**

	**int getValue()**

	**{**

		**return 10;**

	**}**



**static void Main()**

**{**



	**A a1 = new A();**

	**int value = a1.getValue();**

	**Console.WriteLine(value);**

**}**

**}**







**class A**

**{**

	**static int getValue()**

	**{**

		**return 10;**

	**}**

**static void Main()**

**{**

	**int r =	A.getValue();**

	**Console.WriteLine(r);**

**}**

**}**





**class MygoMinds**

**{**

	**string getResult()**

	**{**

		**return "Learn Full Stack from MGM";**

	**}**



**static void Main()**

**{**



	**MygoMinds obj = new MygoMinds();**

	**string result = obj.getResult();**

	**Console.WriteLine(result);**

**}**

**}**







**class Addition**

**{**

	**int getSum(int x, int y)**

	**{**

	**return x + y;**

	**}**

**static void Main()**

**{**

	**Addition a1 = new Addition();**

        **int sum = a1.getSum(5,4);**

        **Console.WriteLine(sum);**

**}**

**}**



**class TotalMarks**

**{**

	**float english,nepali,history,math;**

	**public void getMarks(float e,float n,float h,float m)**

	**{**

	**english = e;**

        **nepali = n;**

	**history = h;**

	**math = m;**

	**}**



	**public float total()**

	**{**

	**float totalm = english + nepali + history + math;**

	**return totalm;**

	**}**



**static void Main()**

	**{**

	**TotalMarks tm = new TotalMarks();**

	**tm.getMarks(50,45,44,76);**

	**float t = tm.total();**

	**Console.WriteLine("Total Marks Obtained :",t);**

	

**}**

**}**





**class A**

**{**

 **public static void show(int x, int y)**

 **{**

	**x= 4;**

	**y= 2;**

	**Console.WriteLine(x);**

&nbsp;	Console.WriteLine(y);



 **}**



**public static void Main()**

**{**

 **int a =5;**

 **int b = 10;**



 **A.show(a,b);**

**}**

**}**









**class Calc**

**{**

	**public static void calculate(int x, int y, out int sum, out int diff)**

	**{**

		**sum = x + y;**

		**diff = x - y;**

	**}**



**public static void Main()**

**{**

	**int s, d;**

	**Calc.calculate(16,12,out s, out d);**

	**Console.WriteLine(s);**

	**Console.WriteLine(d);**

**}**

**}**









**class A**

**{**

  **public void show()**

	**{**

		**Console.WriteLine("I am show");**

	**}**

  **public void display()**

	**{**

		**Console.WriteLine("I am display");**

	**}**



**public static void Main()**

	**{**

		**A a1 = new A();**

		**a1.show();**

		**a1.dispaly();**

	**}**

**}**



**class A**

**{**

	**int x;**

	**int y;**

	**int z;**

	

         **public A()**

		**{**

		 **x = 5;**

		 **y = 7;**

		**}**



	**public void calculateSum()**

		**{**

		 **z = x + y;**

		**}**



	**public display()**

		**{**

			**Console.WriteLine(z);**

		**}**

	**public static void Main()**

		**{**

		**A a1 = new A();**

		**a1.calculateSum();**

		**a1.dispaly();**

		**}**

**}**

		







**class A**

**{**

	**int x = 5;**

	**int y = 7;**



	**public void printSum()**

	**{**

		**Console.WriteLine(x + y);**

	**}**

**}**



**class Calci**

**{**

	**public Static A getObject()**

	**{**

		**return new A();**

	**}**

**}**

**class Test**

**{**

	**static void Main()**

	**{**

		**A a = Calci.getObject();**

		**a.printSum();**

	**}**

**}**





**class Employee**

**{**

	**public static SqlConnection getConnection()**

	**{**

	**return new SqlConnection();**

	**}**



**}**

**class Test**

**{**

	**public static void Main()**

	**{**

	**Sqlconnection con = Employee.getConnection();**

	**con.Open();**

	**con.Close();**

	**}**

**}**



**class A**

**{**

	**int x = 5;**

	**int y = 7;**



**}**



**class Calc**

**{**

	**public static void getObject(A a1)**

	**{**

		**Console.WriteLine(a1.x + a1.y);**

	**}**

**}**



**class Test**

**{**

	**public static void Main()**

	**{**

	**A a = new A();**

	**calc.getObject(a)**

**}**

**}**













**class Classname**

**{**

	**variables;**

	**methods;**

**}**



**class Student**

**{**

	**int sno;**

	**string sname;**

	**int age;**

	**string gender;**

	**long phoneno;**

	**long aadharno;**

	**void calculatetotalmarks()**

	**{**

	**}**

	**void calculatepercentage()**

	**{**

	**}**

**}**



**class Employee**

**{**

	**int eno;**

	**string ename;**

	**double bsal;**

	**string designation;**

	**string skills;**

	**long phoneno;**

	**long aadharno;**

	**string gender;**

        **public calculateda()**

	**{**

	**}**

	**public calculatehra()**

	**{**

	**}**

	

**}**





**class Student**

**{**

	**static string collegename = "MygoMinds";**

	**int sno;**

	**string sname;**

	**int calculatetotalmarks(int no, string name, int menglish, int mnepali, int mmath)**

	**{**

	**sno = no;**

	**sname = name;**

	**int totalmarks = 0;**

	**totalmarks = totalmarks + menglish + mnepali + mmath;**

	**return totalmarks;**

	**}**

	**void display()**

	**{**

	**Console.WriteLine("College Name = " + collegename);**

	**Console.WriteLine("Student No = " + sno);**

	**Console.WriteLine("Student Name = " + sname);**

	**Console.WriteLine("Total Marks obtained = " + totalmarks)**

	**}**



	**static void Main()**

	**{**

	**Student st = new Student();**

	**st.calculatetotalmarks(101,'Safal', 70,80,90)**

	**st.display();**

	**}**

**}**







**syntax to create object:-**

		**Classname objectname = new Classname();**



**Consider class name is Employee. Create object**



		**Employee em1 = new Employee();**









**class Student**

**{**

	**int sno;**

	**string sname;**

	**void Student(int no, string name)**

	**{**

		**sno = no;**

		**sname = name;**

	**}**



	**void getStudent()**

	**{**

		**Console.WriteLine("Student name is {0} and Student No is {1}", sname,sno);**

	**}**



	**static void Main()**

	**{**

		**Student s1 = new Student(101, "Safal");**

		**s1.getStudent();**

		**Student s2 = new Student(102, "Neera");
		s2.getStudent();**




	

	**}**







**}**









**class Student**

**{**

	**string static collegeName = "MygoMinds";**

	**string static collegeAddress = "Hyderabad";**

	**int sno;**

	**string sname;**

	**int mmath, menglish, mnepali**

	**int total;**

	

	**public Student(int no, string name)**

	**{**

		**sno = no;**

		**sname = name;**

	**}**

	**public settotalmarks(int math, int english, int nepali)**

	**{**

	**mmath = math;**

	**menglish = English**

	**mnepali = nepali**

	**}** 

	

	**public void displaystd()**

	**{**

		**Console.WriteLine("Student name is {0} and Student No is {1}, sname, sno");**

	**}**

	**public int calculatetotal()**

	**{**

	**total = mmath + menglish + mnepali;**

	**return total;**

	**}**



**public static void Main()**

	**{**

	**Student s1 = new Student(101, "Safal");**

	**s1.settatalmarks(87,89,90);**

	**Console.WriteLine(collegeName);**

	**Console.WriteLine(collegeAddress);**

	**s1.displaystd();**

	**int tmarks = s1.calculatetotal();**

	**Console.WriteLine("Total Marks Obtained", total);**

	**}**

	

**}**



















**class mgm**

**{**



	**public void calculate(int x, int y, ref int sum, ref int diff)**

	**{**

		**sum = x + y;**

		**diff = x - y;**

	**}**



**}**



**class program**

**{**

	**public static void Main(string args\[])**

	**{**

		**int s = 0, d = 0;**

		**mgm m1 = new mgm();**

		**m1.calculate(5,3,ref s, ref d);**

		**Console.WriteLine(s);**

		**Console.WriteLine(d);**

	**}**

**}**









**class Deposit**

	**{**

		**public static double depositamt(double amt, ref double cbal)**

		**{**

			**cbal = cbal + amt;**

			**return cbal;**

		**}**

	**}**

**class Program**

	**{**

		**bal = 1000;**

		**double total = Deposit.depsitamt(8000, ref bal);**

		**Console.WriteLine("Total Balance after deposit is " + total);**

		

	**}**





**using System;**



**namespace ConsoleApp2**

	**{**

		**interface IPaymentGateway**	

		**{**

			**void ProcessPayment(double amt);**

			**void RefundPayment(string transactionId);**

		**}**

	**}**



**class PayPalpayment : IPaymentGateway**

**{**

	**public void ProcessPayment(double amt)**

	**{**

		**Console.WriteLine("Paypal process payment amount" + amt);**

	**}**

	**public void RefundPayment(string transactionId)**

	**{**

		**Console.WriteLine("Paypal refund tansactionId" + transactionId);**

	**}**

**}**



**class Stripepayment : IPaymentGateway**

**{**

public void ProcessPayment(double amt)

	{

		Console.WriteLine("Stripe process payment amount" + amt);

	}

	public void RefundPayment(string transactionId)

	{

		Console.WriteLine("Stripe refund tansactionId" + transactionId);

	}


**}**



**class Program**

**{**



**static void Main()**

	**{**

		**IPaymentGateway ipay = new IPaymentGateway();**

		**ipay.**ProcessPayment(5000);

&nbsp;		

	**}**



**}**

























































































**class A**

**{**

	**int x;**

	**int y;**

**}**



**class B:A**

**{**

	**int z;**

**}**



**new B()**







**class Student**

**{**

	**int sno;**

	**string sname;**

	**public Student(int no, string name)**

	**{**

		**sno = no;**

		**sname = name;**

	**}**



 **public void print()**

	**{**

		**Console.WriteLine("Student Name {0} has Student No {0}", sname, sno);**

	**}**

**}**



**class Program**

**{**

	**Student s1 = new Student(101,'Safal');**

	**s1.print();**

**}**













**Constructor Overloading**



**class A**

**{**

	**public A()**

	**{**

	**Console.WriteLine("I am default constructor");**

	**}**

	

	**public A(int x)**

	**{**

	**Console.WriteLine("I am single parametrized constructor and the parameter I took is {0}", x);**

	**}**



	**public A(int x, int y)**	

	**{**

	**Console.WriteLine("I am double parameterized constructor and the parameter I took is {0} and {1}", x, y);**

	**}**

**}**



**class Program**

**{**

	**static void Main()**

	**{**

		**new A();**

		**new A(45);**

		**new A(34,67);**

	**}**

**}**











**class Student**

**{**

	**public Student()**

	**{**

		**Console.WriteLine("I am a default constructor");**

	**}**



	**public Student(int x):this()**

	**{**

		**Console.WriteLine("I am single parametrized constructor taking value {0}", x);**

	**}**



	**public Student(int x, int y):this(4)**

	**{**

		**Console.WriteLine("I am double parameterized constructor taking value {0} and {1}", x,y)**

	**}**



**}**



**class Program**

**{**

	**static void Main()**

	**{**

	**new Student(5,3);**

	**}**

**}**





**class A**

**{**

 **public A()**

	**{**

		**Console.WriteLine("I am a default A constructor");**

	**}**

**public A(int x):this()**

	**{**

		**Console.WriteLine("I am a single parameterized A constructor with value {0} ", x);**

	**}**

**public A(int x, int y):this(4)**

	**{**

		**Console.WriteLine("I am a double parameterized A constructor with value {0} and {1}", x,y);**

	**}**

**}**



**class B:A**

**{**

**public B():base(4,5)**

	**{**

	**Console.WriteLine("I am a default B constructor");**

	**}**

**public B(int x):this()**

	**{**

	**Console.WriteLine("I am a single parameterized B constructor with value {0} ", x);**

	**}**

**public B(int x, int y):this(4)**

	**{**

	**Console.WriteLine("I am a double parameterized B constructor with value {0} and {1}");**

	**}**

**}**



**class Program**

**{**

	**static void Main()**

	**{**

	**new B(4,5);**

**}**

	**}**

**}**



































**class A**

**{**

**B b1 = new B();**

**}**



**class B**

**{**

	**C c1 = new C();**

**}**



**class C**

**{**

**}**



**class Program**

**{**

**static void Main()**

	**{**

		**A a1 = new A();**

	**}**

**}**























**class Student**

**{**

 **int sno;**

 **string sname;**

 **Address tadd ;**

 **Address padd;**

**}**





**class Address**

**{**

	**string streetname;**	

	**int houseno;**

	**string landmark;**

**}**



**class Program**

**{**

	**static void Main()**

	**{**

	**Student s1 = new Student();**

	**s1.sno = 101**

	**s1.sname = "Safal";**

	**s1.tadd = new Address();**

	**s1.padd = new Address();**

	**s1.tadd.streetname = "SK road"**

	**s1.tadd.houseno = 101**

	**s1.tadd.landmark = 'Ghoom';**

	**}**

**}**















**class Account**

**{**

 **sealed long acno;**

 **double cbal;**

 **public Account(long accountno, double minbal)**

	**{**

		**acno = accountno;**

		**cbal = minbal;**

	**}**



**public void Deposit(double amt)**

	**{**

		**cbal+ = amt**

	**}**



**public void print()**

	**{**

		**Console.WriteLine(cbal);**

	**}**

**}**



**class Program**

**{**

	**static void Main()**

	**{**

	**Account a1 = new Account(101,1000);**

	**a1.deposit(5000)**

	**a1.print();**

	**}**

**}**







**abstract class A**

**{**

	**public abstract void Show();**

**}**



**class B : A**

**{**

 **public void Show()**

**{**

**Console.WriteLine("I am show");**

**}**

**}**







**using ConsoleApp2;**

**using System;**



**namespace ConsoleApp2**

**{**

    **interface IPrintable**

    **{**

        **void Print();**

    **}**

    **interface ISavable**

    **{**

        **void Save();**

    **}**

**}**



**class Document : IPrintable, ISavable**

**{**

    **public void Print()**

    **{**

        **Console.WriteLine("Document Printed");**

    **}**

    **public void Save()**

    **{**

        **Console.WriteLine("Document Saved");**

    **}**

**}**





**class Program**

**{**



    **static void Main()**

    **{**

        **Document doc = new Document();**

        **doc.Print();**

        **doc.Save();**



    **}**



**}**





















**using System;**



**abstract class A**

**{**

    **public abstract void Show();**

**}**



**class B : A**

**{**

    **public void Show()**

    **{**

        **Console.WriteLine("I am show");**

    **}**

**}**





**class Program**

**{**

    **static void Main()**

    **{**

        **B a = new B();**

        **a.Show();**

    **}**

**}**







**abstract class RBI**

**{**

**long accno;**

**double cbal;**

 **public class RBI(long accno)**

**{**

**this.accno = accno;**

**cbal = 3000**

**}**



**public void Deposit(int amount)**

**{**

  **cbal + = amount;**

**}**

**public void Withdraw(int amount)**

**{**

 **cbal - = amount;**

**}**

**public abstract void IssueLoan();**

**}**



**class SBI : RBI**

**{**

  **public void SBI(long accno):base(long accno){}**

  **public void IssueLoan()**

**{**

 **Console.WriteLine("5% rate of Interest");**

**}**

**}**



**class ICICI : RBI**

**{**

**public void ICICI(long accno):base(long accno){}**



**public void IssueLoan()**

**{**

 **Console.WriteLine("7% rate of Interest");**

**}**

**}**



**class Program**

**{**

**static void Main()**

**{**



 **SBI s1 = new SBI(1001);**

 **s1.Deposit(4000);**

 **s1.IssueLoan();**

 **ICICI i1 = new ICICI(1002);**

 **i1.Withdraw(1000);**

 **i1.IssueLoan();**

**}**



**}**





**class DbContext**

**{**

	**public DBContext(string connectionString)**

	**{**

	**}**

**}**



**class EmpDbContext : DbContext**

**{**

	**public EmpDbContext(string constr):base(constr)**

	**{**

		

	**}**

**}**



**class Test**

**{**

  **static void Main()**

	**{**

		**EmpDbContext e1 = new EmpDbContext("user id = sa; password = abc; database = mygominds; data source = .");**

	**}**

**}**











**abstract class A**

**{**

  **public abstract void Show();**

**}**



**class B:A**

**{**

	**public override void Show()**

**{**

   **Console.WriteLine("I am show");**

**}**

**}**







**using System;**



**abstract class RBI**

**{**

    **protected long accno;**

    **protected double cbal;**



    **// Constructor (no 'class' keyword and no return type)**

    **public RBI(long accno)**

    **{**

        **this.accno = accno;**

        **cbal = 3000;**

    **}**



    **public void Deposit(int amount)**

    **{**

        **cbal += amount;**

    **}**



    **public void Withdraw(int amount)**

    **{**

        **if (amount > cbal)**

        **{**

            **Console.WriteLine("Insufficient funds");**

            **return;**

        **}**

        **cbal -= amount;**

    **}**



    **public double GetBalance()**

    **{**

        **return cbal;**

    **}**



    **public abstract void IssueLoan();**

**}**



**class SBI : RBI**

**{**

    **// Constructor: no return type, call base like this**

    **public SBI(long accno) : base(accno) { }**



    **// Must use override for abstract method**

    **public override void IssueLoan()**

    **{**

        **Console.WriteLine("SBI: 5% rate of Interest");**

    **}**

**}**



**class ICICI : RBI**

**{**

    **public ICICI(long accno) : base(accno) { }**



    **public override void IssueLoan()**

    **{**

        **Console.WriteLine("ICICI: 7% rate of Interest");**

    **}**

**}**



**class Program**

**{**

    **static void Main()**

    **{**

        **SBI s1 = new SBI(1001);**

        **s1.Deposit(4000);**

        **Console.WriteLine($"SBI Balance (1001): {s1.GetBalance()}");**

        **s1.IssueLoan();**



        **ICICI i1 = new ICICI(1002);**

        **i1.Withdraw(1000);**

        **Console.WriteLine($"ICICI Balance (1002): {i1.GetBalance()}");**

        **i1.IssueLoan();**

    **}**

**}**





**using System;**



**interface A**

**{**

    **void show();**

**}**



**class B : A**

**{**

    **public void show()**

    **{**

        **Console.WriteLine("I am show");**

    **}**

**}**



**class Test**

**{**

    **static void Main()**

    **{**

        **B b = new B();**

        **b.show();**

        **A a = new B();**

        **a.show();**

    **}**

**}**









**using System;**



**interface A**

**{**

    **void show();**

**}**



**interface B**

**{**

    **void show();**

**}**



**class C : A, B**

**{**

    **void A.show()**

    **{**

        **Console.WriteLine("I am A show");**

    **}**

    **void B.show()**

    **{**

        **Console.WriteLine("I am B show");**

    **}**

    **public void show()**

    **{**

        **Console.WriteLine("I am C show");**

    **}**

**}**



**class Test**

**{**

    **static void Main()**

    **{**

        **C c = new C();**

        **c.show();**

        **((A)c).show();**

        **((B)c).show();**

    **}**

**}**













**using System;**



**class Employee**

**{**

    **private int eno;**

    **private string ename = string.Empty; // Initialize to avoid CS8618**



    **public int Eno**



    **{**

        **set { eno = value; }**

        **get { return eno; }**

    **}**

    **public string Ename**

    **{**

        **set { ename = value; }**

        **get { return ename; }**

    **}**



**}**



**class Program**

    **{**

    **static void Main()**

    **{**

        **Employee emp = new Employee();**

        **emp.Eno = 101;**

        **emp.Ename = "John Doe";**

        **Console.WriteLine("Employee Number: " + emp.Eno);**

        **Console.WriteLine("Employee Name: " + emp.Ename);**

    **}**

**}**













**using System;**



**class Employee**

**{**

    **public int eno { get; set; }**

    **public string ename { get; set; }**

    **public float esal { get; set; }**

**}**



**class Program**

**{**

    **static void Main(string\[] args)**

    **{**

        **Employee emp = new Employee();**

        **emp.eno = 101;**

        **emp.ename = "John Doe";**

        **emp.esal = 50000.50f;**

        **Console.WriteLine($"Employee Number: {emp.eno}");**

        **Console.WriteLine($"Employee Name: {emp.ename}");**

        **Console.WriteLine($"Employee Salary: {emp.esal}");**

    **}**

**}**







   **ArrayList list = new ArrayList();**

   **list.Add(1);**

   **list.Add(2);**

   **list.Add(3);**

   **list.Add(4);**

   **list.Add(5);**

   **list.Add(6);**

   **Console.WriteLine("1. Print ArrayList Elements : ");**

   **foreach (var item in list)**

   **{**

       **Console.WriteLine(item);**

   **}**

   **Console.WriteLine("Add element at index 2");**

   **list.Insert(2, 70);**

   **foreach (var item in list)**

   **{**

       **Console.WriteLine(item);**

   **}**

   **Console.WriteLine("Remove element at index 4");**

   **list.Remove(5);**

   **foreach (var item in list)**

   **{**

       **Console.WriteLine(item);**

   **}**



   **Console.WriteLine("Print the sum of elements");**

   **int sum = 0;**

   **foreach (var item in list)**

   **{**

       **sum += (int)item;**

      





   **}**

   **Console.WriteLine(sum);**





**using System;**

**using System.Collections;**



**class A**

**{**

    **static void Main(string\[] args)**

    **{**

      **List<int> list = new List<int>();**

        **list.Add(1);**

        **list.Add(2);**

        **list.Add(3);**

        **list.Add(4);**

        **foreach (var item in list)**

        **{**

            **Console.WriteLine(item);**

        **}**

        **int sum = 0;**

        **foreach (var item in list)**

        **{**

            **sum += item;**

        **}**

        **Console.WriteLine($"Sum: {sum}");**

    **}**

**}**

























**public class HomeController:Controller**

**{**

	**public ActionResult Index()**

	**{**

		**return View();**

	**}**



	**public ActionResult Aboutus()**

	**{**

		**return View();**

	**}**

**}**























































































































































































































































































































































































































































