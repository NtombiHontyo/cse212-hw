using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a list with the following items and their priorities: Cellphone (3), Shoes (5), Jacket (7) and dequeue them according the priority number.
    // Expected Result: Jacket, Shoes 
    // Defect(s) Found: RemoveAt method was not incorperated. It did not dequeue as it should. 
    public void TestPriorityQueue_1()
    {

        var shoes = new PriorityItem("shoes", 5);
        var cellphone = new PriorityItem("cellphone", 3);
        var jacket = new PriorityItem("jacket", 7);
        PriorityItem[] expectedResult = [jacket, shoes];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(shoes.Value, shoes.Priority);
        priorityQueue.Enqueue(cellphone.Value, cellphone.Priority);
        priorityQueue.Enqueue(jacket.Value, jacket.Priority);

        
       
        for (int i = 0; i < 2; i++)
        {
            Assert.AreEqual(expectedResult[i].Value, priorityQueue.Dequeue());
        }
        
        
        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: The queue will include some items that have the same priority value. It must dequeue according to highest priority and when the priority is the 
    // it must take the one closest to the front input will be: Cellphone (4), Shoes (7), jacket (8), T-shirt(7)
    // Expected Result: jacket, Shoes
    // Defect(s) Found: Operator used to update the highest was incorrect. It included "=". It should be omited so that it can add the duplicate priority with the smallest index number.
    public void TestPriorityQueue_2()
    {
        var shoes = new PriorityItem("shoes", 7);
        var cellphone = new PriorityItem("cellphone", 4);
        var jacket = new PriorityItem("jacket", 8);
        var tshirt = new PriorityItem("t-shirt", 7);

        PriorityItem[] expectedResult = [jacket, shoes];

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(cellphone.Value, cellphone.Priority);
        priorityQueue.Enqueue(shoes.Value, shoes.Priority);
        priorityQueue.Enqueue(jacket.Value, jacket.Priority);
        priorityQueue.Enqueue(tshirt.Value, tshirt.Priority);

        for (int i = 0; i < 2; i++)
        {
            Assert.AreEqual(expectedResult[i].Value, priorityQueue.Dequeue());
        }

        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}