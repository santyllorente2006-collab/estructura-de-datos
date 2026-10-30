using System;

// Clase Nodo
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

// Clase Arbol Binario de Busqueda
public class BSTDeletion
{
    // Insertar un nuevo elemento
    public Node Insert(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = Insert(root.Left, data);
        else if (data > root.Data)
            root.Right = Insert(root.Right, data);

        return root;
    }

    // Eliminar un nodo del arbol
    public Node DeleteNode(Node root, int key)
    {
        if (root == null)
            return root;

        // Buscar el nodo que se desea eliminar
        if (key < root.Data)
        {
            root.Left = DeleteNode(root.Left, key);
        }
        else if (key > root.Data)
        {
            root.Right = DeleteNode(root.Right, key);
        }
        else
        {
            // Caso 1: El nodo no tiene hijos
            // Caso 2: El nodo tiene un solo hijo
            if (root.Left == null)
                return root.Right;

            else if (root.Right == null)
                return root.Left;

            // Caso 3: El nodo tiene dos hijos
            // Buscar el sucesor inorden
            root.Data = MinValue(root.Right);

            // Eliminar el sucesor inorden
            root.Right = DeleteNode(root.Right, root.Data);
        }

        return root;
    }

    // Obtener el valor minimo del subarbol derecho
    private int MinValue(Node root)
    {
        int minv = root.Data;

        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }

        return minv;
    }

    // Mostrar el arbol mediante recorrido Inorden
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
        BSTDeletion bst = new BSTDeletion();

        Node root = null;

        // Insertar elementos en el arbol
        root = bst.Insert(root, 50);
        root = bst.Insert(root, 30);
        root = bst.Insert(root, 70);
        root = bst.Insert(root, 20);
        root = bst.Insert(root, 40);
        root = bst.Insert(root, 60);
        root = bst.Insert(root, 80);

        // Mostrar el arbol antes de eliminar
        Console.WriteLine("ARBOL ORIGINAL:");
        bst.InOrder(root);

        // Eliminar un nodo
        int valorEliminar = 50;

        Console.WriteLine("\n\nEliminando el elemento: " + valorEliminar);

        root = bst.DeleteNode(root, valorEliminar);

        // Mostrar el arbol despues de eliminar
        Console.WriteLine("\nARBOL DESPUES DE ELIMINAR:");
        bst.InOrder(root);

        Console.WriteLine("\n\nProceso finalizado.");

        Console.ReadKey();
    }
}
