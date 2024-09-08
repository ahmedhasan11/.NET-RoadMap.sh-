using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_tutorial_5
{
    abstract class training
    {
        public abstract void name ();
        public abstract void email ();
    }
    class Lokesh : training
    {
        public override void email()
        {
            throw new NotImplementedException();
        }

        public override void name()
        {
            throw new NotImplementedException();
        }

    }
    class rahul :training
    {
        public override void email()
        {
            throw new NotImplementedException();
        }

        public override void name()
        {
            throw new NotImplementedException();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
