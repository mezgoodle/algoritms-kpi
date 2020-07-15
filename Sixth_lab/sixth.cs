using System; 
using System.Collections.Generic; 

// A binary tree node 
public class Node { 

	public int data; 
	public Node left, right; 

	public Node(int d) 
	{ 
		data = d; 
		left = right = null; 
	} 
} 

public class BinarySearchTree { 

	// Root of BST 
	Node root; 

	// Constructor 
	BinarySearchTree() 
	{ 
		root = null; 
	} 

	// Inorder traversal of the tree 
	void inorder() 
	{ 
		inorderUtil(this.root); 
	} 

	// Utility function for inorder traversal of the tree 
	void inorderUtil(Node node) 
	{ 
		if (node == null) 
			return; 

		inorderUtil(node.left); 
		Console.Write(node.data + " "); 
		inorderUtil(node.right); 
	} 

	// This method mainly calls insertRec() 
	void insert(int key) 
	{ 
		root = insertRec(root, key); 
	} 

	/* A recursive function to insert a new key in BST */
	Node insertRec(Node root, int data) 
	{ 

		/* If the tree is empty, return a new node */
		if (root == null) { 
			root = new Node(data); 
			return root; 
		} 

		/* Otherwise, recur down the tree */
		if (data < root.data) 
			root.left = insertRec(root.left, data); 
		else if (data > root.data) 
			root.right = insertRec(root.right, data); 

		return root; 
	} 

	// Method that adds values of given BST into ArrayList and hence returns the ArrayList 
	List<int> treeToList(Node node, List<int> list) 
	{ 
		// Base Case 
		if (node == null) 
			return list; 

		treeToList(node.left, list); 
		list.Add(node.data); 
		treeToList(node.right, list); 

		return list; 
	} 

	// method that checks if there is a pair present 
	bool isPairPresent(Node node, int target) 
	{ 
		// This list a1 is passed as an argument 
		// in treeToList method 
		// which is later on filled by the values of BST 
		List<int> a1 = new List<int>(); 

		// a2 list contains all the values of BST 
		// returned by treeToList method 
		List<int> a2 = treeToList(node, a1); 

		int start = 0; // Starting index of a2 

		int end = a2.Count - 1; // Ending index of a2 

		while (start < end) { 

			if (a2[start] + a2[end] == target) // Target Found! 
			{ 
				Console.WriteLine("Pair Found: " + a2[start] + " + " + a2[end] + " "
								+ "= " + target); 
				return true; 
			} 

			if (a2[start] + a2[end] > target) // decrements end 
			{ 
				end--; 
			} 

			if (a2[start] + a2[end] < target) // increments start 
			{ 
				start++; 
			} 
		} 

		Console.WriteLine("No such values are found!"); 
		return false; 
	} 

	// Driver code 
	public static void Main(String[] args) 
	{ 
		BinarySearchTree tree = new BinarySearchTree(); 

        int[] inputArray = {15, 10, 20, 8, 12, 16, 25, 2, 3};
        foreach (int el in inputArray)
        {
            tree.insert(el); 
        }

        // Input data
        Console.WriteLine("Enter search number:");
        int searchNumber = Convert.ToInt32(Console.ReadLine());
		tree.isPairPresent(tree.root, searchNumber); 
	} 
}