using System.Diagnostics;

public class Node
{
        
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node (int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data)
        {
            return;
        }
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
         if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            // Insert to the left
            if (Left is null)
            {
                return false;
            }
            else
            {
                return Left.Contains(value);
            }
        }
        else
        {
            // Insert to the right
            if (Right is null)
            {
                return false;
            }
            else
            {
                return Right.Contains(value);
            }
        }
        
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int highest_tree = 1;
        if (Left is null && Right is null)
        {
            int node_count = 1;
            return node_count;
        }

        else
        {
            if (Data > Left.Data)
            {
                int height = 1 + Left.GetHeight();
                if (height > highest_tree)
                {
                    highest_tree = height;
                }
                return highest_tree;
            }
            else 
            {
                int height = 1 + Right.GetHeight();
                if (height > highest_tree)
                {
                    highest_tree = height;
                }
                return highest_tree;
            }
            
        }
            
        // Replace this line with the correct return statement(s)

    }
}