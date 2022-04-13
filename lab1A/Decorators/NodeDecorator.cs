namespace Lab1
{
    public abstract class NodeDecorator : INode
    {
        protected INode _node;

        public NodeDecorator(INode node)
        {
            this._node = node;
        }
        public virtual string GetName()
        {
            return this._node.GetName();
        }
        public virtual int GetCapacity()
        {
            return this._node.GetCapacity();
        }
        public virtual NodeType GetNodeType()
        {
            return this._node.GetNodeType();
        }
        public virtual string ProcessMessage(string message)
        {
            return this._node.ProcessMessage(message);
        }
        public virtual int GetCapacityLeft()
        {
            return this._node.GetCapacityLeft();
        }
    }
}
