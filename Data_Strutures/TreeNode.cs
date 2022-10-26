public class TreeNode
{
    TreeNode parent;
    LinkedList<TreeNode> children;
    public string text;

    public TreeNode(string text, TreeNode parent = null)
    {
        this.parent = parent;
        this.children = new LinkedList<TreeNode>();
        this.text = text;
    }

    public void AddChild(TreeNode child)
    {
        children.AddLast(child);
    }

    public void DisplayChildren()
    {
        foreach (var child in children)
            Console.WriteLine("-->" + child.text);
    }

    public TreeNode getChild(int i)
    {
        foreach (var child in children)
            if (--i == 0)
                return child;
        throw new Exception("Child not found");
    }
}