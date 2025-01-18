using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class NestedInterfaces
    {
    }

    public interface IOuter
    {
        interface INested
        {
            void NestedMethod();
        }

        void OuterMethod();
    }

    public class Implementation : IOuter
    {
        public void OuterMethod()
        {
            throw new NotImplementedException();
        }
    }

    public class ImplementationInner : IOuter.INested
    {
        public void NestedMethod()
        {
            throw new NotImplementedException();
        }
    }
}
