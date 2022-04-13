using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class BrokenNode : NodeDecorator
    {
        private string _msg;

        public BrokenNode(INode node, string msg) : base(node)
        {
            _msg = msg;
        }
        public override NodeType GetNodeType()
        {
            return NodeType.Broken;
        }
        public override string ProcessMessage(string message)
        {
            return _msg;
        }
        public override int GetCapacity()
        {
            return 0;
        }
    }

    public class SmartNode : NodeDecorator
    {
        public SmartNode(INode node) : base(node) { }
        public override NodeType GetNodeType()
        {
            return NodeType.Smart;
        }
        public override string ProcessMessage(string message)
        {
            if (GetCapacityLeft() == 0)
                return "Capacity reached, no new messages will be processed";
            return base.ProcessMessage(message);
        }
    }

    public class EncryptNode : NodeDecorator
    {
        private readonly int _offset;
        private int _autoDestructionCounter;

        public EncryptNode(INode node, int offset, int autoDestructionCounter) : base(node)
        {
            _offset = offset;
            _autoDestructionCounter = autoDestructionCounter;
        }
        public override NodeType GetNodeType()
        {
            return NodeType.Encryption;
        }
        public override int GetCapacityLeft()
        {
            return Math.Min(base.GetCapacityLeft(), _autoDestructionCounter);
        }
        public override string ProcessMessage(string message)
        {
            if (_autoDestructionCounter <= 0)
                return base.ProcessMessage("Node auto-destroyed");
            _autoDestructionCounter--;

            var encryptedMessageBuilder = new StringBuilder();
            foreach (char c in message)
                encryptedMessageBuilder.Append(CaesarCipher.Encrypt(c, _offset));

            return base.ProcessMessage(encryptedMessageBuilder.ToString());
        }
    }

    public class DecryptNode : NodeDecorator
    {
        private readonly int _offset;

        public DecryptNode(INode node, int offset) : base(node)
        {
            _offset = offset;
        }
        public override NodeType GetNodeType()
        {
            return NodeType.Decryption;
        }
        public override string ProcessMessage(string message)
        {
            var decryptedMessageBuilder = new StringBuilder();
            foreach (char c in message)
                decryptedMessageBuilder.Append(CaesarCipher.Decrypt(c, _offset));

            return base.ProcessMessage(decryptedMessageBuilder.ToString());
        }
    }
}
