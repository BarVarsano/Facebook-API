using System;
using System.Windows.Forms;

namespace FacebookPlayerLogics
{
    public class TreeNodeProxy : TreeNode
    {
        public TreeNodeProxy(string i_TitleName) : base(i_TitleName)
        {
            if (Parent != null && !(Parent.Tag is IPlayerComponent))
            {
                throw new Exception("The Parent is not a IPlayerComponent");
            }
        }

        public object Tag
        {
            get
            {
                return base.Tag;
            }

            set
            {
                IPlayerComponent i_PlayerComponent = value as IPlayerComponent;
                if (i_PlayerComponent != null)
                {
                    if (base.Tag != null)
                    {
                        ((IPlayerComponent)base.Tag).OnComponentAdded -= AddNode;
                        ((IPlayerComponent)base.Tag).OnComponentRemoved -= RemoveNode;
                    }

                    base.Tag = i_PlayerComponent;
                    i_PlayerComponent.OnComponentAdded += AddNode;
                    i_PlayerComponent.OnComponentRemoved += RemoveNode;
                }
                else
                {
                    throw new Exception("Tag is only IPlayerComponent");
                }
            }
        }

        private void AddNode(IPlayerComponent i_ToAdd)
        {
            Nodes.Add(new TreeNodeProxy(i_ToAdd.Name) { Tag = i_ToAdd });
        }

        private void RemoveNode(IPlayerComponent i_ToRemove)
        {
            TreeNode nodeToRemove = getTreeNodeToRemove(i_ToRemove);

            if (nodeToRemove == null)
            {
                throw new Exception("node wasent found!");
            }
            else
            {
                Nodes.Remove(nodeToRemove);
            }
        }

        private TreeNode getTreeNodeToRemove(IPlayerComponent i_ToRemove)
        {
            TreeNode nodeToRemove = null;

            foreach (TreeNode child in Nodes)
            {
                if (child.Tag == i_ToRemove)
                {
                    nodeToRemove = child;
                    break;
                }
            }

            return nodeToRemove;
        }
    }
}
