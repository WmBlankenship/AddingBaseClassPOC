using AddingBaseClass.Core.Interfaces;
using System;

namespace AddingBaseClass.Services.Old.Services
{
    public class ImplementationOne : IInterfaceWithTooManyMethods
    {
        public void MethodOne()
        {
            //This method does some work that need.
        }

        public void MethodThree()
        {
            //We don't need this.
            throw new NotImplementedException();
        }

        public void MethodTwo()
        {
            //We don't need this, either.
            throw new NotImplementedException();
        }
    }
}
