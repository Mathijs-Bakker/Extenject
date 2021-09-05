using UnityEngine;
using Zenject;

namespace Zenject.Tests.Installers.CompositeMonoInstallers
{
    public class FooInjectee
    {
        public FooInjectee(Foo foo)
        {
            Foo = foo;
        }

        public Foo Foo { get; }
    }
}