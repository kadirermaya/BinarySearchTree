namespace BinarySearchTreeProject
{
    public class BinarySearchTree
    {
        //member variables (has a)
        public Node root;

        //constructor (spawner)
        public BinarySearchTree()
        {
            root = null;
        }

        //member methods (can do)
        public void Add(int value)
        {
            Node newNode = new Node(value);
            Node temp;

            if (root == null)
            {
                root = newNode;
            }

            temp = root;

            while (temp.right != null || temp.left != null)
            {
                if (value > temp.value && temp.right != null)
                {
                    temp = temp.right;
                }
                else if (value < temp.value && temp.left != null)
                {
                    temp = temp.left;
                }
                else
                {
                    break;
                }
            }

            if (value > temp.value)
            {
                temp.right = newNode;
            }
            else if (value < temp.value)
            {
                temp.left = newNode;
            }
        }

        public bool Search(int value)
        {
            bool isFound = false;
            if (value == root.value)
            {
                isFound = true;
                return isFound;
            }

            while (!isFound)
            {
                if (value <= root.value && root.left != null)
                {
                    root = root.left;
                    if (value == root.value)
                    {
                        isFound = true;
                        return isFound;
                    }
                    else if (root == null)
                    {
                        break;
                    }
                }
                else if (value >= root.value && root.right != null)
                {
                    root = root.right;
                    if (value == root.value)
                    {
                        isFound = true;
                        return isFound;
                    }
                    else if (root == null)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return isFound;
        }
    }
}
