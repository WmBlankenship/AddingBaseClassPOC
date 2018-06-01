using AddingBaseClass.Core.Interfaces;
using System;

namespace AddingBaseClass.Services.Old.Services
{
    public class ImplementationTwo : IInterfaceWithTooManyMethods
    {
        public void MethodOne()
        {
            //We need this method.
        }

        public void MethodThree()
        {
            //This one, not so much.
            throw new NotImplementedException();
        }

        public void MethodTwo()
        {
            //This one is also just a bit extra.
            throw new NotImplementedException();
        }
    }
}
