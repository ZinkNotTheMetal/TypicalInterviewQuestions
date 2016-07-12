<h1>Typical Interview Questions & Answers</h1>

<ul>
  <li><a href="#htmlSection">HTML</a></li>
  <li>JavaScript</li>
  <li>ASP.NET MVC</li>
  <li>ASP.NET WebForms</li>
  <li>C#</li>
  <li>SQL</li>
  <li>Generic</li>
</ul>

<h2 id="#htmlSection">HTML</h2>


<h2>JavaScript</h2>


<h2>ASP.NET MVC</h2>
<li>How can we maintain sessions in MVC?</li>
 <h6>
 <li>tempdata</li>
 <li>viewdata</li>
 <li>viewbag</li>
 </h6>
 
 <li>Explain the MVC Lifecycle?</li>
  <h6>
  <ol>
    <li>Routing - Basically it is a pattern matching system that matches the request’s URL against the registered URL patterns in the Route Table</li>
    <li>MVC Handler - responsible for initiating the real processing inside ASP.NET MVC</li>
    <li>Controller - is intantiated or retreived from memory</li>
    <li>Action Executed - Controller's ActionInvoker determines which specific action to invoke on the controller. Action to be execute is chosen based on attributes</li>
    <li>View Result - The action method receives user input, prepares the appropriate response data, and then executes the result by returning a result type</li>
    <li>View Engine - retrieves the setup view engine in the application start (typically Razor)</li>
    <li>View - Action method may returns a text string,a binary file or a Json formatted data. The most important Action Result is the ViewResult, which renders and returns an HTML page to the browser by using the current view engine</li>
  </ol>
  </h6>
  
<h2>ASP.NET WebForms</h2>


<h2>C#</h2>
<h4>Types</h4>
<li>What kind of type is a string?</li>
	<h6>Reference</h6>
<li>What kind of type is a double?</li>
	<h6>Value</h6>
<li>What keyword defines a custom value type?</li>
  <h6>struct</h6>
  
<h4>Classes</h4>
<li>Can a class have more than one direct base class?</li>
	<h6>No</h6>
<li>Difference between Abstract class & Interface</li>
<h6>An abstract class can have shared state or functionality. An interface is only a promise to provide the
	 state or functionality. A good abstract class will reduce the amount of code that has to be rewritten 
	 because it's functionality or state can be shared. The interface has no defined information to be shared
	 just a contract of what the class will include.
</h6>	
<h4>Methods</h4>
<li>What method do you call on a delegate to run it on a background thread?</li>
	<h6>BeginInvoke</h6>
<li>Describe Overriding</li>
  <h6>Overriding means that a method shares the same name and signature of a base or abstract calss, but is overriden in the inhertted class</h6>
<li>Describe Overloading</li>
  <h6>Overloading means that a method has the same name in the class but a different method signature</h6>

	
<h4>Keywords</h4>
<li>What keyword makes a member visible to inherited classes?</li>
	<h6>protected</h6>
<li>What keyword makes a class visible only within its assembly?</li>
	<h6>internal</h6>
<li>What keyword allows a method to be overridden?</li>
	<h6>virtual</h6>
<li>What keyword requires a method to be overridden?</li>
	<h6>abstract</h6>
<li>What keyword prevents a class from being used as a base class?</li>
	<h6>sealed</h6>
<li>What keyword returns true if a cast will succeed?</li>
	<h6>is</h6>	
<li>What keyword returns true if a cast will succeed?</li>
	<h6>is</h6>	
<li>What keyword returns null if a cast will not succeed?</li>
	<h6>as</h6>	
<li>What keyword ensures code execution even if an exception occurs?</li>
  <h6>finally</h6>
<li>What keyword calls IDisposable.Dispose?</li>
	<h6>using</h6>
<li>What keyword constrains a generic type argument to derive from a particular class?</li>
	<h6>where</h6>
<li>What two keywords used together return IEnumerable<T>?</li>
	<h6>yield return</h6>
<li>What keyword would you use to define an inline variable in a LINQ query?</li>
	<h6>let</h6>
<li>What keyword brings an extension method into scope?</li>
	<h6>using (these are typically at the top of the file)</h6>
<li>What keyword do you add to a delegate to force subscribers to use += or –=?</li>
	<h6>event</h6>
<li>What keyword provides thread synchronization?</li>
	<h6>lock</h6>
<li>Protected Internal</li>
  <h6>(combination of these two) will be visible only to classes that derive from the 
  class that declares that member *and* are declared in a file in the same assembly.</h6>
<li>What is a static method?</li>
  <h6>If you apply static keyword with any method, it is known as static method. 
	A static method belongs to the class rather than object of a class. 
	A static method invoked without the need for creating an instance of a class.</h6>

<h4>Generic</h4>
<li>What are extension methods? What are some examples.</li>
  <h6>Extension methods are a special kind of static method, but they are called as if they were instance methods on the extended type
	LINQ, ToString, Split...</h6>
	
<h4>ADO.NET</h4>
<li>Should you use ADO.NET DataReader or Dataset?  Why?</li>
	<h6>It depends on your needs. One of the most important differences is that a DataReader will retain an open connection 
	to your database until you're done with it while a DataSet will be an in-memory object. If you bind a control to a 
	DataReader then it's still open. In addition, a DataReader is a forward only approach to reading data that can't be 
	manipulated. With a DataSet you can move back and forth and manipulate the data as you see fit.</h6>

<h2>SQL</h2>
<li>What is a left outer join? What is an example.</li>
  <h6>Outer is an optional keyword in sql server. That being said this would be a LEFT JOIN.
	A LEFT JOIN gets all data from the left (or first table) and joins it to the right (or second table) matching null where they do not line up.
	Customers LEFT JOIN Orders (will show all customers but they might not have any orders which will return null)</h6>
	
<li>What are some advantages to using Stored Procedures? Disadvantages?</li>
<h6>
	<li>Advantages</li>
	<ul>
	  <li>Testability outisde of the application</li>
	  <li>Security</li>
	  <li>Speed / Optimization</li>
	</ul>
	<li>Disadvantages</li>
	<ul>
	  <li>Errors are typically found in runtime</li>
	  <li>Stored procedure code is not as robust as application code, particularly in the area of looping
	    (not to mention that iterative constructs, like cursors, are slow and processor intensive)</li>
	  <li>Lot of overhead for simple stored procedures</li>
	</ul>
</h6>
<li>What are advantages to using indexes?  Disadvantages?</li>
	<h6>Indexes (typically) speed up SELECT's and slow down INSERT's.</h6>

<h2>Generic</h2>
<li>Explain the difference between managed and unmanaged code.</li>
	<h6>Managed code is code that has its execution managed by the .NET Framework Common Language Runtime.</h6>
	
<li>Inheritance vs Composition.  Which one should you choose?</li>
	<h6>Favor composition over inheritance</h6>
