using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public Node Root;

    // Inserción recursiva preservando la propiedad BST
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    // Búsqueda de un elemento
    public bool Search(Node root, int key)
    {
        if (root == null)
            return false;

        if (root.Data == key)
            return true;

        return key < root.Data
            ? Search(root.Left, key)
            : Search(root.Right, key);
    }

    // Recorrido Inorden
    public void InOrder(Node root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }
    }
}

// Clase principal
public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Insertar elementos
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(60);
        bst.Insert(80);

        // Mostrar el árbol en orden
        Console.WriteLine("Elementos del arbol en orden:");
        bst.InOrder(bst.Root);

        // Buscar un elemento
        int buscar = 40;

        Console.WriteLine("\n\nBusqueda del elemento: " + buscar);

        if (bst.Search(bst.Root, buscar))
            Console.WriteLine("El elemento SI existe en el arbol.");
        else
            Console.WriteLine("El elemento NO existe en el arbol.");

        Console.ReadKey();
    }
}
