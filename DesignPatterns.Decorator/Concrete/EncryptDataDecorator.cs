using DesignPatterns.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Concrete
{
    internal class EncryptDataDecorator : DataDecorator, IDataSource
    {
        public EncryptDataDecorator(IDataSource source) : base(source)
        {
        }

        private void Encrypt()
        {
            Console.WriteLine("Data is encrypted");
        }

        private void Decrypt()
        {
            Console.WriteLine("Data is decrypted");
        }

        public override void WriteData()
        {
            Encrypt();
        }

        public override void ReadData()
        {
            Decrypt();
        }
    }
}
