using UnityEngine;
using Zenject;

namespace Zenject.Tests.Installers.CompositeScriptableObjectInstallers
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