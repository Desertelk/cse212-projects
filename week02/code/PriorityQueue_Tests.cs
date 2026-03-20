using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Does it remove items with Different Priorities in the correct order
    // Expected Result: First High, then Med, then low
    // Defect(s) Found: Skipped the last index of the queue and also in the Dequeue method the actual removal of the item wasn't implemented
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(("Low priority"), 1);
        priorityQueue.Enqueue(("High priority"), 5);
        priorityQueue.Enqueue(("Med priority"), 3);

        Assert.AreEqual("High priority", priorityQueue.Dequeue());
        Assert.AreEqual("Med priority", priorityQueue.Dequeue());
        Assert.AreEqual("Low priority", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Items with same priority level being removed at first appearance
    // Expected Result: Items are dequeued in First in First out (FIFO)
    // Defect(s) Found: There was a ">=" part in the Dequeue method that didn't allow the FIFO process.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("C", 6);

        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Highest priority item is the last in the queue
    // Expected Result: The last item should be returned first.
    // Defect(s) Found: No issues found
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 1);
        priorityQueue.Enqueue("C", 10);

        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: The Queue is empty
    // Expected Result: InvalidOperation Thrown
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
    // Add more test cases as needed below.
}