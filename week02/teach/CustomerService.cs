using System.Security.Cryptography;

/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Is the default size 10?
        // Expected Result: Size is 0 max_size is 10
        var queue1 = new CustomerService(0);
        Console.WriteLine(queue1);

        // Defect(s) Found: None

        Console.WriteLine("=================");

        // // Test 2
        // // Scenario: Maxsize being 5, can I add 6 customers? 
        // // Expected Result: Error should be printed saying that the Queue is at capacity.
        Console.WriteLine("Test 2");
        var queue2 = new CustomerService(5);
        queue2.AddNewCustomer();
        queue2.AddNewCustomer();
        queue2.AddNewCustomer();
        queue2.AddNewCustomer();
        queue2.AddNewCustomer();
        queue2.AddNewCustomer();
        Console.WriteLine(queue2);
        // // Defect(s) Found: I had to add '=' to the AddNewCustomer confirmation of the max limit

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: Will ServeCustomer show details and remove the customer from the queue? And will it do it in the correct order.
        // Expected Result: Add 2 customers, Serve 2 customers, print queue after each ServeCustomer to make sure the first customer was served first
        Console.WriteLine("Test 3");
        var queue3 = new CustomerService(5);
        queue3.AddNewCustomer();
        queue3.AddNewCustomer();
        Console.WriteLine(queue3);
        queue3.ServeCustomer();
        Console.WriteLine(queue3);
        queue3.ServeCustomer();
        Console.WriteLine(queue3);

        // Defect(s) found: The code was removing the customers in ServeCustomer before it could store the Customer in a variable. 

        // Test 4
        // Scenario: Can I serve 0 customers?
        // Expected Result: The program will give me an error message.
        Console.WriteLine("Test 4");
        var queue4 = new CustomerService(5);
        queue4.ServeCustomer();
        Console.WriteLine(queue4);

        // Defect(s) found: The code was removing the customers in ServeCustomer before it could store the Customer in a variable. 
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        if(_queue.Count <= 0)
        {
            Console.WriteLine("There are no customers to serve.");
            return;
        }
        
        var customer = _queue[0];
        _queue.RemoveAt(0);
        Console.WriteLine(customer);
        
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}