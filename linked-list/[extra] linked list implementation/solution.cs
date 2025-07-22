class Node {
  public int value;
  public Node next;

  // constructor with optional value and next reference
  public Node(int value = 0, Node next = null) {
    this.value = value;
    this.next = next;
  }
}

class LinkedList {
  public Node head;

  // add a new node at the beginning
  public void AddFirst(int data) {
    Node newNode = new Node(data, head);
    head = newNode;
  }

  // add a new node at the end
  public void AddLast(int data) {
    Node newNode = new Node(data, null);

    if (head == null) { // list is empty
      head = newNode; 
      return;
    }

    Node current = head;

    // traverse to the last node
    while (current.next != null) {
      current = current.next;
    }

    // link the new node at the end
    current.next = newNode;
  }

  // remove the first node
  public void RemoveFirst() {
    if (head == null) return; // list is empty
    head = head.next; // move head to the next node
  }

  // *once removed from the list and unreferenced, the node will be collected by the GC (garbage collector).

  // remove the last node
  public void RemoveLast() {
    if (head == null) return; // list is empty

    if (head.next == null) {
      head = null; // only one node
      return;
    }

    Node current = head;

    // traverse to the second-to-last node
    while (current.next.next != null) {
      current = current.next;
    }

    current.next = null; // remove last node
  }

  // count the number of nodes
  public int Count() {
    int count = 0;
    Node current = head;

    while (current != null) {
      count++;
      current = current.next;
    }

    return count;
  }

  // check if a value exists in the list
  public bool Contains(int value) {
    Node current = head;

    while (current != null) {
      if (current.value == value)
        return true;
      current = current.next;
    }

    return false;
  }

  // print all elements in the list
  public void Print() {
    Node current = head;

    while (current != null) {
      Console.Write(current.value + " -> "); // print current node's value
      current = current.next;
    }

    Console.Write("null"); // end of list
  }
}
