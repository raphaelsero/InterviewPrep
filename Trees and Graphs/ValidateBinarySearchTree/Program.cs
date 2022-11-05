/*
 
Given the root of a binary tree, determine if it is a valid binary search tree (BST).

A valid BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.

Input: root = [2,1,3]
Output: true

Input: root = [5,1,4,null,null,3,6]
Output: false
Explanation: The root node's value is 5 but its right child's value is 4.
 
Constraints:
The number of nodes in the tree is in the range [1, 104].
-231 <= Node.val <= 231 - 1

 */

namespace ValidateBinarySearchTree {

    class Program 
    {
        static void Main(string[] args)
        {

        }

        public bool Validate(TreeNode root, int? low, int? high)
        {
            if (root == null) return true;
            if ((low != null && root.val <= low) || (high != null && root.val >= high)) return false;
            return Validate(root.right, root.val, high) && Validate(root.left, low, root.val);
        }

        public bool IsValidBST(TreeNode root)
        {
            return Validate(root, null, null);
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

    }
}