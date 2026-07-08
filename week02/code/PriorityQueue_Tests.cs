using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.
// 1. The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
// 2. The Dequeue function shall remove the item with the highest priority and return its value.
// 3. If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
// 4. If the queue is empty, then an error exception shall be thrown. This exception should be an InvalidOperationException with a message of "The queue is empty."

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items and priorities: A (1), B (2), C (3), D (4), E (5), F (6), G (7), H (8), I (9), J (10)
    // Run until the queue is empty.
    // Expected Result: Items dequeued in order of priority (J, I, H, G, F, E, D, C, B, A)
    // Defect(s) Found: I I I I I I I I I I I
    //                  No Items from the queue are being removed.  Highest priority item is not returned.
    // 
    // Defect(s) Found: 
    // 
    public void TestPriorityQueue_1()
    {
        // var A = new PriorityItem("A", 1);
        // var B = new PriorityItem("B", 4);
        // var C = new PriorityItem("C", 3);
        // var D = new PriorityItem("D", 2);
        // var E = new PriorityItem("E", 4);
        // var F = new PriorityItem("F", 1);
        // var G = new PriorityItem("G", 2);
        // var H = new PriorityItem("H", 3);
        // var I = new PriorityItem("I", 4);
        // var J = new PriorityItem("J", 1);
        var A = new PriorityItem("A", 1);
        var B = new PriorityItem("B", 2);
        var C = new PriorityItem("C", 3);
        var D = new PriorityItem("D", 4);
        var E = new PriorityItem("E", 5);
        var F = new PriorityItem("F", 6);
        var G = new PriorityItem("G", 7);
        var H = new PriorityItem("H", 8);
        var I = new PriorityItem("I", 9);
        var J = new PriorityItem("J", 10);

        List<string> items = new List<string>();

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(A.Value, A.Priority);
        priorityQueue.Enqueue(B.Value, B.Priority);
        priorityQueue.Enqueue(C.Value, C.Priority);
        priorityQueue.Enqueue(D.Value, D.Priority);
        priorityQueue.Enqueue(E.Value, E.Priority);
        priorityQueue.Enqueue(F.Value, F.Priority);
        priorityQueue.Enqueue(G.Value, G.Priority);
        priorityQueue.Enqueue(H.Value, H.Priority);
        priorityQueue.Enqueue(I.Value, I.Priority);
        priorityQueue.Enqueue(J.Value, J.Priority);

        for (int i = 0; i < 10; i++)
        {
            var item = priorityQueue.Dequeue();
            items.Add(item);
        }
        Console.Write($"{string.Join(", ", items)} ");
        // Assert.Fail("Implement the test case and then remove this.");
    }


    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}