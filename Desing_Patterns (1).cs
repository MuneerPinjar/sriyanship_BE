/// Design Patterns are used to solve the problems of Object Generation and Integration.
////"A pattern is a recurring solution to a problem in a context."

1 . Singleton Desing patter -->  it makes sure that wil have only one instance throught the session.

Note : 1. make the default constructor private in order to avoid creating a multiple instances
2.  decalre static instance variable in order to get the instance through the public method like create instance
3. create a static method in order to Create or get Instance

// Code implememtation
Public sealed class ClassSingleton{
  
   // Private static instance to ensure it's a singleton
  private static ClassSingleton _instance;
  
  private ClassSingleton(){};
  
  // Public method to access the singleton instance
  public static ClassSingleton CreateInstance(){
    
	  
	   // Lazy initialization: create the instance only if it doesn't exist
	if(_instance == null){
	
	  _instance = new ClassSingleton();
	
	}
	
	return _instance;
	
  
  }
  
  
  
  // Other Methods
  
  .....
}




2. Abstract Factory Pattern -- > Its a super factory which creates a other factories i.e set of realted or dependent objects

UML components

1. Client --> Uses the Abstract Product and abstract factory to create a set of dependent objects
2.  Abstract Product --> A interface in order to declare the tpye of the product
3. Abstract Factory --> A interface in order to create a abstract products
3.  Concerete Factory  -->  This class implements the Abstract factory in order to create the concerete products
4.  Concerete Product --> This class implements the Abstract product interface in order to create the Concerete product.


Public Class Client(){
	private AbstractProductA _prodcutA;
	private AbstractProductB _prodcutB;
	
	public Client(AbstractFactory _factory)
	{
		_prodcutA = _factory.CreateProductA();
		_prodcutB = _factory.CreateProductB();
	}
	

}

public abstract AbstractFactory(){
	
	public abstract AbstractProdutA CreateProductA();
	public abstract AbstractProductB CreateProductB();
}

public ConcereteFactory :  AbstractFactory
{
	public override AbstractProductA CreateProductA(){
		
		return new ConcereteProductA();
		
	}
	
	public override AbstractProductB CreateProductB(){
		
		return new ConcereteProductB();
		
	}
	
	
}


public abstract AbstractProductA();
public abstract AbstractProductB();

public class ConcereteProductA:AbstractProductA{
	
	//Data Memebers and functions goes here
	
}


public class ConcereteProductB : AbstractProductB{
	
	//Data Memebers and functions goes here
	
	
}


Real Time World Example

//Abstract Factory --> use can use abstract class or interface to implement it
Public interface IGUIFactory{
	
	
	public IButton CreateButton();
	public ICheckBox CreateCheckBox();
}

//Concerete Factory

pubic class WindowsFactory :  IGUIFactory{
	
	public IButton CreateButton(){
		
		return new WindowsButton();
	}
	
	publiv ICheckBox CreateCheckBox(){
		
		return new WindowsCheckBox();
	}
	
}

pubilc class MacOsFactory :  IGUIFactory{
	
	public IButton CreateButton(){
		
		return new MacOsButton();
	}
	
	public ICheckBox CreateCheckBox(){
		
		return new MacOsCheckBox();
	}
}

// Abstract Products
public interface IButton{
	
	void RenderUI();
}

pubic interface ICheckBox{
	
	void RenderUI();
	
}

//Concerte Products
public Class windowsButton : IButton{
	
	public void RenderUI(){
		//code logic to render the windows UI button here
	}
}

public class MacOsButton : IButton{
	
	public void RenderUI(){
		
		//Code logic to render the MacOs UI button here
		
	}
}


public class WindowsCheckBox : ICheckBox{
	
	public void RenderUI(){
		
		//Code logic to render the windows  Checkbox here
	}
}

public class MacOsCheckBox : ICheckBox
{
	
	public void RenderUI(){
		//code logic to render the MaCOs UI checkbox here
	}
}


// Client Class

public class Client(){
	
	private IGUIFactory _factory;
	private IButton _button;
	private ICheckBox _checkbox;
	
	public Client(IGUIFactory factory){
		
		this._factory = factory;
		this._button = _factory.CreateButton();
		this._checkbox = _factory.CreateCheckBox();
		
	}
	
	Public Void RenderComponents(){
		
		
		this._button.RenderUI();
		this._checkbox.RenderUI();
		
	}
	
	
}


//Driver Class 

public static Main(){
	
	IGUIFactory windowsFactory= new windowsFactory();
	Client _windowsClient =  new Client(windowsFactory);
	
	//render the Windows button and checkbox by calling the below method
	_windowsClient.RenderComponents();
	
	IGUIFactory macOsFactory = new MacOsFactory();
	
	Client _macOsClient = new client(macOsFactory);

//render the Mac OS button and checkbox by calling the below method
	_macOsClient.RenderComponents();
	
}

Factory Design Pattern --> This is like a factory which is used to create products based on the client's demand 
.
Example --> Imagine a Car Factory and wants to create a Car Model based on the client's needs

Real Time code implementation

/// Factroy Class
Public interface ICarFactory{
	
	pubic void ShowCarModel();
	Pubic Car GetCarDetails();
	
}


//Products

public BMWCar : ICarFactory{
	
	public void ShowCarModel(){
		
		// Show car model logic goes here
	}
	
	Public Car GetCarDetails(){
		
		//Return the car model details logic goes here
	}
	
	
	
}

Public FerraiCar : ICarFactory{
	public void ShowCarModel(){
		
		// Show car model logic goes here
	}
	
	Public Car GetCarDetails(){
		
		//Return the car model details logic goes here
	}
	
}

public TataCar :  ICarFactory{
	
	public void ShowCarModel(){
		
		// Show car model logic goes here
	}
	
	Public Car GetCarDetails(){
		
		//Return the car model details logic goes here
	}
	
}

public class Car{
	
	//data fields and methods here
	
	
	
}


// Client or Driver Class


public class Main{
	
	ICarFactory _carFactory;
	
	/// Get the input from the user 
	string carType ="BMW or TATA etc.."
	
	
	
	if(condition to create BMWCarfactory is true then create BMWCarfactory){
		
		_carFactory = new BMWCarfactory();
		
	}
	else if(condition to create TATA factory is true then create TataFactory){
		_carFactory = new TataFactory();
	}
else if(condition to create FerraiCar is true then create FerraiCar){
		_carFactory = new FerraiCar();
	}	
	
	_carFactory.ShowCarModel();
	_carFactory.GetCarDetails();
	
}


Repository Design Pattern  -->Popular design pattern which isolates the data access logic and rest of the applications

Real time example

//Lets create a IEmployeerRepository interface


Public interface IEmployeerRepository{
	
	//Perform CRUD operations 
	
}

public Class EmployeeRepository : IEmployeerRepository{

// Implement IEmployeerRepository methods (CRUD) operations in order to interact with Database	
	
}


Pubic Class EmployeeController {
	
	private readonly IEmployeerRepository _empRepository;
	public EmployeeController(IEmployeerRepository _empRepository){
		
		this._empRepository = _empRepository;
		
	}
	
	
	
	// Rest of the operations Action methods to do all the basic CRUD operations
	
	
	pubic ActionResult GetEmployees(){
		
	   var empResult = _empRepository.GetEmployees();
	   if(empresult != null)
	   Return OKResult(empResult);
		
	}
	
}


