Typical Interview Questions & Answers
==================

  - [HTML](#html)
  - [CSS](#css)
  - [JavaScript](#javascript)
  - [ASP.NET](#aspnet)
    - [MVC](#mvc)
    - [WebForms](#webforms)
  - [C#](#c-sharp)
    - [Type](#type)
    - [Class](#class)
    - [Method](#method)
    - [Keyword](#keyword)
    - [Generic C# Questions](#generic-c-sharp)
    - [Entity](#entity-framework)
    - [ADO.NET](#adonet)
  - [SQL](#sql)
  - [Generic / Leftovers](#generic--leftovers)
 
## HTML
<li>What is HTML?</li>
  <h6>HTML is short for HyperText Markup Language, and is the language of the World Wide Web. It is the standard text formatting language used for creating and displaying pages on the Web.</h6>

<li>How do you insert a comment in html?</li>
  <h6>Using the <!-dash and --></h6>
  
<li>What are Web Workers?</li>
  <h6>Web workers at long last bring multi-threading to JavaScript.<br />
  A web worker is a script that runs in the background (i.e., in another thread) without the page needing to wait for it to complete. The user can continue to interact with the page while the web worker runs in the background. Workers utilize thread-like message passing to achieve parallelism.</h6>
  
<li>What is HTML 5 WebStorage? Explain the difference between localStorage and sessionStorage.</li>
  <h6>With HTML5, web pages can store data locally within the user’s browser. <br/>
Earlier, this was done with cookies. However, Web Storage is more secure and faster. The data is not included with every server request, but used ONLY when asked for.<br/>
The data is stored in name/value pairs, and a web page can only access data stored by itself. Unlike cookies, the storage limit is far larger (at least 5MB) and information is never transferred to the server.<br />
The difference between localStorage and sessionStorage involves the lifetime and scope of the storage.<br />
Data stored through localStorage is permanent: it does not expire and remains stored on the user’s computer until a web app deletes it or the user asks the browser to delete it. SessionStorage has the same lifetime as the top-level window or browser tab in which the script that stored it is running. When the window or tab is permanently closed, any data stored through sessionStorage is deleted. <br/>
Both forms of storage are scoped to the document origin so that documents with different origins will never share the stored objects. But sessionStorage is also scoped on a per-window basis. If a user has two browser tabs displaying documents from the same origin, those two tabs have separate sessionStorage data: the scripts running in one tab cannot read or overwrite the data written by scripts in the other tab, even if both tabs are visiting exactly the same page and are running exactly the same scripts.</h6>

## CSS

## JavaScript


## ASP.NET

### MVC

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
  
### WebForms

<li>List all page life-cycle events.</li>
   <h6>
   <ul>
   <li>PreInit</li>
   <li>Init</li>
   <li>InitComplete</li>
   <li>LoadViewState</li>
   <li>LoadPostData</li>
   <li>PreLoad</li>
   <li>Load</li>
   <li>LoadComplete</li>
   <li>PreRender</li>
   <li>PreRenderComplete</li>
   <li>SaveStateComplete</li>
   <li>Unload</li>
   </ul>
   </h6>

## C-Sharp

### Type
<li>What kind of type is a string?</li>
	<h6>Reference</h6>
<li>What kind of type is a double?</li>
	<h6>Value</h6>
<li>What keyword defines a custom value type?</li>
  <h6>struct</h6>
  
### Class
<li>Can a class have more than one direct base class?</li>
	<h6>No</h6>
<li>Difference between Abstract class & Interface</li>
<h6>An abstract class can have shared state or functionality. An interface is only a promise to provide the
	 state or functionality. A good abstract class will reduce the amount of code that has to be rewritten 
	 because it's functionality or state can be shared. The interface has no defined information to be shared
	 just a contract of what the class will include.
</h6>	

### Method

<li>What method do you call on a delegate to run it on a background thread?</li>
	<h6>BeginInvoke</h6>
<li>Describe Overriding</li>
  <h6>Overriding means that a method shares the same name and signature of a base or abstract calss, but is overriden in the inhertted class</h6>
<li>Describe Overloading</li>
  <h6>Overloading means that a method has the same name in the class but a different method signature</h6>

	
### Keyword

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

### Generic C-Sharp

<li>What are extension methods? What are some examples.</li>
  <h6>Extension methods are a special kind of static method, but they are called as if they were instance methods on the extended type<br/>LINQ, ToString, Split...</h6>
	
### Entity Framework
	
### ADO.NET

<li>Should you use ADO.NET DataReader or Dataset?  Why?</li>
	<h6>It depends on your needs. One of the most important differences is that a DataReader will retain an open connection 
	to your database until you're done with it while a DataSet will be an in-memory object. If you bind a control to a 
	DataReader then it's still open. In addition, a DataReader is a forward only approach to reading data that can't be 
	manipulated. With a DataSet you can move back and forth and manipulate the data as you see fit.</h6>

## SQL

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

<li>What are the difference between clustered and a non-clustered index?</li><h6>
<li>A clustered index is a special type of index that reorders the way records in the table are physically stored.</li>
<li>A non clustered index is a special type of index in which the logical order of the index does not match the physical stored order of the rows on disk.</li></h6>

<li>Is it possible to have temporary tables in Views?</li>
   <h6>No, a view consists of a single SELECT statement. You cannot create or drop tables in a view.</h6>
   
<li>What are the different types of triggers?</li><h6>
   <li>DDL - Data Definition Language (trigger based on CREATE, ALTER, DROP)</li>
   <li>DML - Data Manipulation Language (trigger based on INSERT, UPDATE, DELETE)</li>
   <li>CLR - based on the CLR (Common Language Runtime) in .NET framework</li>
   <li>Login - fire when LOGON event of Sql Server is raised.</li>
</h6>

<li>What's the difference between a primary key and a unique key?</li>
   <h6>
   Both primary key and unique key enforces uniqueness of the column on which they are defined. But by default primary key creates a clustered index on the column, where are unique creates a nonclustered index by default. Another major difference is that, primary key doesn't allow NULLs, but unique key allows one NULL only.
   </h6>
   
<li>What is Log Shipping?</li>
   <h6>
   Log shipping is the process of automating the backup of database and transaction log files on a production SQL server, and then restoring them onto a standby server.
   </h6>
   
<li>What is a Foreign Key?</li>
   <h6>
   A FOREIGN KEY constraint prevents any actions that would destroy links between tables with the corresponding data values. A foreign key in one table points to a primary key in another table. Foreign keys prevent actions that would leave rows with foreign key values when there are no primary keys with that value. The foreign key constraints are used to enforce referential integrity.
   </h6>
   
<li>How to implement one-to-one, one-to-many, and many-to-many tables?
  <h6>
  One-to-One relationship can be implemented as a single table and rarely as two tables with primary and foreign key relationships. One-to-Many relationships are implemented by splitting the data into two tables with primary key and foreign key relationships. Many-to-Many relationships are implemented using a junction table with the keys from both the tables forming the composite primary key of the junction table.
  </h6>

## Generic / Leftovers

<li>Explain the difference between managed and unmanaged code.</li>
	<h6>Managed code is code that has its execution managed by the .NET Framework Common Language Runtime.</h6>
	
<li>Inheritance vs Composition.  Which one should you choose?</li>
	<h6>Favor composition over inheritance</h6>


