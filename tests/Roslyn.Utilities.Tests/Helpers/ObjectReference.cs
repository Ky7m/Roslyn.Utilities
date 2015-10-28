using System;

namespace Roslyn.Utilities.Tests.Helpers
{
    internal class ObjectReference
    {
        public object Strong;
        public readonly WeakReference Weak;

        public ObjectReference(object target)
        {
            this.Strong = target;
            this.Weak = new WeakReference(target);
        }

        public ObjectReference() : this(new object())
        {
        }
    }
}