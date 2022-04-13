using System;

namespace Lab1
{
    public static class NodesManipulator
    {
        public static INode SetNodeToBroken(INode node, string message)
        {
            return new BrokenNode(node, message);
            // throw new NotImplementedException();
        }
        
        public static INode MakeNodeSmart(INode node)
        {
            return new SmartNode(node);
            //throw new NotImplementedException();
        }
        
        public static INode EncryptMessages(INode node, int offset, int maxCalls)
        {
            return new EncryptNode(node, offset, maxCalls);
            //throw new NotImplementedException();
        }
        
        public static INode DecryptMessages(INode node, int offset)
        {
            return new DecryptNode(node, offset);
            //throw new NotImplementedException();
        }
    }
}