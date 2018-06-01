using AddingBaseClass.Core.Interfaces;
using System;

namespace AddingBaseClass.Services.New.Services
{
    public abstract class BaseService : IInterfaceWithTooManyMethods
    {
        //We always need this guy, therefore he'll be abstract.
        public abstract void MethodOne();

        public virtual void MethodThree()
        {
            //This fellow may not be needed.
            //We can add some default code here, if appropriate.
        }

        public virtual void MethodTwo()
        {
            //This fellow also may not be needed.
            //Here, though, we do choose to throw an exception if this is called without being overridden.
            throw new NotImplementedException();
        }
    }
}
