using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 3 elements and dequeue one
    // Expected Result: The element with the highest priority (highest int value) should be returned
    // Defect(s) Found: None (after loop fix)
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low Priority", 1);
        priorityQueue.Enqueue("Medium Priority", 5);
        priorityQueue.Enqueue("High Priority", 10);
        var dequeuedValue = priorityQueue.Dequeue();
        Assert.AreEqual("High Priority", dequeuedValue);
    }

    [TestMethod]
    // Scenario: Add items with same priority, ensure the one added last (with equal priority) is dequeued
    // Expected Result: If priorities are equal, latest item should be returned (due to >= comparison)
    // Defect(s) Found: None (after fix) 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item A", 2);
        priorityQueue.Enqueue("Item B", 2);
        var dequeuedValue = priorityQueue.Dequeue();
        Assert.AreEqual("Item A", dequeuedValue);
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: InvalidOperationException is thrown.
    public void TestPriorityQueue_EmptyDequeue()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}