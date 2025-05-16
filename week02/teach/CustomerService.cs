/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        
        // Test Cases

        // Test 1
        // Scenario: Tying to add  customer when the capacity is full
        // Expected Result: An message should be raised when the capacity is full
        Console.WriteLine("Test 1");
        var cs = new CustomerService(3);
        Console.WriteLine(cs);
        cs.AddNewCustomer();
        cs.AddNewCustomer();
        
        
        Console.WriteLine(cs._queue.Count);
        Console.WriteLine(cs);
        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Trying to dequeue a customer from an empty line
        // Expected Result: 
        Console.WriteLine("Test 2");
        
        // Defect(s) Found: 

        Console.WriteLine("=================");
        cs.ServeCustomer();
        cs.ServeCustomer();
        try {
            cs.ServeCustomer();
            Console.WriteLine("I don't wanna see this line_________");
        }
        catch (IndexOutOfRangeException){
            Console.WriteLine("I got the exception I expected.");
        }
        
        Console.WriteLine(cs._queue.Count);
        Console.WriteLine(cs);

        // Add more Test Cases As Needed Below



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
        if (_queue.Count <= 0) 
        throw new IndexOutOfRangeException();


        _queue.RemoveAt(0);
        // var customer = _queue[0];
        // Console.WriteLine(customer);
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