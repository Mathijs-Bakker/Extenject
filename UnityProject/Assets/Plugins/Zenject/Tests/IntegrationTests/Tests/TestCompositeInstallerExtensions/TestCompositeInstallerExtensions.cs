using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Zenject;

namespace Zenject.Tests.Installers
{
    public class TestCompositeInstallerExtensions
    {
        TestInstaller _installer1;

        TestCompositeInstaller _compositeInstaller1;
        TestCompositeInstaller _compositeInstaller2;

        TestCompositeInstaller _circularRefCompositeInstaller1;

        List<TestCompositeInstaller> _parentInstallers1;

        TestInstaller _dummyInstaller1;
        TestInstaller _dummyInstaller2;
        TestInstaller _dummyInstaller3;

        TestCompositeInstaller _dummyCompositeInstaller1;

        [SetUp]
        public void SetUp()
        {
            _installer1 = new TestInstaller();

            _compositeInstaller1 = new TestCompositeInstaller
            {
                _leafInstallers = new List<TestInstaller>()
            };
            _compositeInstaller2 = new TestCompositeInstaller
            {
                _leafInstallers = new List<TestInstaller>
                {
                    _compositeInstaller1,
                },
            };

            _circularRefCompositeInstaller1 = new TestCompositeInstaller
            {
                _leafInstallers = new List<TestInstaller>()
            };
            _circularRefCompositeInstaller1._leafInstallers.Add(_circularRefCompositeInstaller1);

            _parentInstallers1 = new List<TestCompositeInstaller>
            {
                _compositeInstaller1,
            };

            _dummyInstaller1 = new TestInstaller();
            _dummyInstaller2 = new TestInstaller();
            _dummyInstaller3 = new TestInstaller();

            _dummyCompositeInstaller1 = new TestCompositeInstaller
            {
                _leafInstallers = new List<TestInstaller>()
            };
        }

        [Test]
        public void TestValidateAsCompositeZeroParent()
        {
            var circular = _circularRefCompositeInstaller1;

            Assert.True(_installer1.ValidateAsComposite());

            Assert.True(_compositeInstaller1.ValidateAsComposite());

            Assert.False(circular.ValidateAsComposite<IInstaller>());
            Assert.False(circular.ValidateAsComposite<TestInstaller>());

            // T will be infered as TestCompositeInstaller, so parent will be "ICompositeInstaller<TestCompositeInstaller>>"
            Assert.True(circular.ValidateAsComposite());
        }

        [Test]
        public void TestValidateAsCompositeOneParent()
        {
            var dummy = _dummyCompositeInstaller1;
            var circular = _circularRefCompositeInstaller1;

            Assert.True(_installer1.ValidateAsComposite(dummy));
            Assert.True(_installer1.ValidateAsComposite(circular));

            Assert.True(_compositeInstaller1.ValidateAsComposite(dummy));
            Assert.False(_compositeInstaller1.ValidateAsComposite(_compositeInstaller1));

            Assert.False(circular.ValidateAsComposite(dummy));
            Assert.False(_compositeInstaller2.ValidateAsComposite(_compositeInstaller1));
        }

        [Test]
        public void TestValidateAsCompositeTwoParents()
        {
            var dummy = _dummyCompositeInstaller1;
            var circular = _circularRefCompositeInstaller1;

            Assert.True(_installer1.ValidateAsComposite(dummy, dummy));
            Assert.True(_installer1.ValidateAsComposite(circular, circular));

            Assert.True(_compositeInstaller1.ValidateAsComposite(dummy, dummy));
            Assert.False(_compositeInstaller1.ValidateAsComposite(_compositeInstaller1, dummy));
            Assert.False(_compositeInstaller1.ValidateAsComposite(dummy, _compositeInstaller1));

            Assert.False(circular.ValidateAsComposite(dummy, dummy));
            Assert.False(_compositeInstaller2.ValidateAsComposite(_compositeInstaller1, dummy));
            Assert.False(_compositeInstaller2.ValidateAsComposite(dummy, _compositeInstaller1));
        }

        [Test]
        public void TestValidateAsCompositeThreeParents()
        {
            var dummy = _dummyCompositeInstaller1;
            var circular = _circularRefCompositeInstaller1;

            Assert.True(_installer1.ValidateAsComposite(dummy, dummy, dummy));
            Assert.True(_installer1.ValidateAsComposite(circular, circular, circular));

            Assert.True(_compositeInstaller1.ValidateAsComposite(dummy, dummy, dummy));
            Assert.False(_compositeInstaller1.ValidateAsComposite(_compositeInstaller1, dummy, dummy));
            Assert.False(_compositeInstaller1.ValidateAsComposite(dummy, _compositeInstaller1, dummy));
            Assert.False(_compositeInstaller1.ValidateAsComposite(dummy, dummy, _compositeInstaller1));

            Assert.False(circular.ValidateAsComposite(dummy, dummy, dummy));
            Assert.False(_compositeInstaller2.ValidateAsComposite(_compositeInstaller1, dummy, dummy));
            Assert.False(_compositeInstaller2.ValidateAsComposite(dummy, _compositeInstaller1, dummy));
            Assert.False(_compositeInstaller2.ValidateAsComposite(dummy, dummy, _compositeInstaller1));
        }

        [Test]
        public void TestValidateAsCompositeFourParents()
        {
            var dummy = _dummyCompositeInstaller1;
            var circular = _circularRefCompositeInstaller1;

            Assert.True(_installer1.ValidateAsComposite(dummy, dummy, dummy, dummy));
            Assert.True(_installer1.ValidateAsComposite(circular, circular, circular, circular));

            Assert.True(_compositeInstaller1.ValidateAsComposite(dummy, dummy, dummy, dummy));
            Assert.False(_compositeInstaller1.ValidateAsComposite(_compositeInstaller1, dummy, dummy, dummy));
            Assert.False(_compositeInstaller1.ValidateAsComposite(dummy, _compositeInstaller1, dummy, dummy));
            Assert.False(_compositeInstaller1.ValidateAsComposite(dummy, dummy, _compositeInstaller1, dummy));
            Assert.False(_compositeInstaller1.ValidateAsComposite(dummy, dummy, dummy, _compositeInstaller1));

            Assert.False(circular.ValidateAsComposite(dummy, dummy, dummy, dummy));
            Assert.False(_compositeInstaller2.ValidateAsComposite(_compositeInstaller1, dummy, dummy, dummy));
            Assert.False(_compositeInstaller2.ValidateAsComposite(dummy, _compositeInstaller1, dummy, dummy));
            Assert.False(_compositeInstaller2.ValidateAsComposite(dummy, dummy, _compositeInstaller1, dummy));
            Assert.False(_compositeInstaller2.ValidateAsComposite(dummy, dummy, dummy, _compositeInstaller1));
        }

        [Test]
        public void TestValidateLeafInstallers()
        {
            Assert.True(_compositeInstaller1.ValidateLeafInstallers());
        }

        [Test]
        public void TestValidateLeafInstallersWithCircularRef()
        {
            Assert.False(_circularRefCompositeInstaller1.ValidateLeafInstallers());
        }

        [Test]
        public void TestValidateLeafInstallersWithCircularRefLeaf()
        {
            _compositeInstaller1._leafInstallers = new List<TestInstaller>
            {
                _circularRefCompositeInstaller1,
            };
            Assert.False(_compositeInstaller1.ValidateLeafInstallers());
        }

        [Test]
        public void TestValidateAsCompositeWithInstaller()
        {
            Assert.True(_installer1.ValidateAsComposite(_parentInstallers1));
        }

        [Test]
        public void TestValidateAsCompositeWithCompositeInstallerWithoutCircularRef()
        {
            _parentInstallers1 = new List<TestCompositeInstaller>
            {
                new TestCompositeInstaller(),
                new TestCompositeInstaller(),
                new TestCompositeInstaller(),
            };
            bool actual = _compositeInstaller1.ValidateAsComposite(_parentInstallers1);
            Assert.True(actual);
        }

        [Test]
        public void TestValidateAsCompositeWithCompositeInstallerWithoutCircularRefDeep()
        {
            var compositeInstaller1 = new TestCompositeInstaller();
            var compositeInstaller2 = new TestCompositeInstaller();
            var compositeInstaller3 = new TestCompositeInstaller();

            compositeInstaller1._leafInstallers = new List<TestInstaller>
            {
                _dummyInstaller1,
                compositeInstaller2,
                _dummyInstaller2,
            };
            compositeInstaller2._leafInstallers = new List<TestInstaller>
            {
                compositeInstaller3,
            };
            compositeInstaller3._leafInstallers = new List<TestInstaller>
            {
                _dummyInstaller3,
            };

            bool actual = compositeInstaller1.ValidateAsComposite(_parentInstallers1);

            Assert.True(actual);
        }

        [Test]
        public void TestValidateAsCompositeWithCompositeInstallerAndParentAsSelf()
        {
            _parentInstallers1 = new List<TestCompositeInstaller>
            {
                _compositeInstaller1,
            };

            bool actual = _compositeInstaller1.ValidateAsComposite(_parentInstallers1);
            Assert.False(actual);
        }

        [Test]
        public void TestValidateAsCompositeWithCompositeInstallerAndSelfCircularRef()
        {
            _parentInstallers1.Clear();

            bool actual = _circularRefCompositeInstaller1.ValidateAsComposite(_parentInstallers1);
            Assert.False(actual);
        }

        [Test]
        public void TestValidateAsCompositeWithCompositeInstallerAndSelfCircularRefDeep()
        {
            var installer1 = new TestCompositeInstaller();
            var installer2 = new TestCompositeInstaller();
            var installer3 = new TestCompositeInstaller();

            installer1._leafInstallers = new List<TestInstaller>
            {
                _dummyInstaller1,
                installer2,
                _dummyInstaller2,
            };
            installer2._leafInstallers = new List<TestInstaller>
            {
                installer3,
            };
            installer3._leafInstallers = new List<TestInstaller>
            {
                installer1,  // a circular reference
                _dummyInstaller3,
            };

            bool actual = installer1.ValidateAsComposite(_parentInstallers1);
            Assert.False(actual);
        }

        [Test]
        public void TestValidateAsCompositeWithCompositeInstallerAndParentCircularRef()
        {
            var installer = new TestCompositeInstaller
            {
                _leafInstallers = new List<TestInstaller>
                {
                    _compositeInstaller1,
                },
            };

            _parentInstallers1 = new List<TestCompositeInstaller>
            {
                _compositeInstaller1,
            };

            bool actual = installer.ValidateAsComposite(_parentInstallers1);
            Assert.False(actual);
        }

        [Test]
        public void TestValidateAsCompositeWithCompositeInstallerAndParentCircularRefDeep()
        {
            var installer1 = new TestCompositeInstaller();
            var installer2 = new TestCompositeInstaller();
            var installer3 = new TestCompositeInstaller();

            installer1._leafInstallers = new List<TestInstaller>
            {
                _dummyInstaller1,
                installer2,
                _dummyInstaller2,
            };
            installer2._leafInstallers = new List<TestInstaller>
            {
                installer3,
            };
            installer3._leafInstallers = new List<TestInstaller>
            {
                _compositeInstaller1,  // a circular reference
                _dummyInstaller3,
            };

            bool actual = installer1.ValidateAsComposite(_parentInstallers1);

            Assert.False(actual);
        }

        [Test]
        public void TestValidateAsCompositeWithCompositeInstallerAndAnotherCircularRef()
        {
            var installer1 = new TestCompositeInstaller();
            var installer2 = new TestCompositeInstaller();
            var installer3 = new TestCompositeInstaller();

            installer1._leafInstallers = new List<TestInstaller>
            {
                _dummyInstaller1,
                installer2,
                _dummyInstaller2,
            };
            installer2._leafInstallers = new List<TestInstaller>
            {
                installer3,
            };
            installer3._leafInstallers = new List<TestInstaller>
            {
                installer2,  // a circular reference
                _dummyInstaller3,
            };

            bool actual = installer1.ValidateAsComposite(_parentInstallers1);

            Assert.False(actual);
        }

        [Test]
        public void TestValidateAsCompositeWithCompositeInstallerAndAnotherCircularRefDeep()
        {
            var installer1 = new TestCompositeInstaller();
            var installer2 = new TestCompositeInstaller();
            var installer3 = new TestCompositeInstaller();
            var installer4 = new TestCompositeInstaller();
            var installer5 = new TestCompositeInstaller();

            installer1._leafInstallers = new List<TestInstaller>
            {
                _dummyInstaller1,
                installer2,
                _dummyInstaller2,
            };
            installer2._leafInstallers = new List<TestInstaller>
            {
                installer3,
            };
            installer3._leafInstallers = new List<TestInstaller>
            {
                installer4,
                _dummyInstaller3,
            };
            installer4._leafInstallers = new List<TestInstaller>
            {
                installer5,
            };
            installer5._leafInstallers = new List<TestInstaller>
            {
                installer3,  // a circular reference
            };

            bool actual = installer1.ValidateAsComposite(_parentInstallers1);

            Assert.False(actual);
        }

        [Test]
        public void TestValidateAsCompositeSavedAllocWithInstaller()
        {
            var reusableParentInstallers = new List<ICompositeInstaller<TestInstaller>>
            {
                new TestCompositeInstaller(),
                new TestCompositeInstaller(),
                new TestCompositeInstaller(),
            };

            Assert.True(_installer1.ValidateAsCompositeSavedAlloc(reusableParentInstallers));
            Assert.AreEqual(3, reusableParentInstallers.Count);
        }

        [Test]
        public void TestValidateAsCompositeSavedAllocWithCompositeInstaller()
        {
            var reusableParentInstallers = new List<ICompositeInstaller<TestInstaller>>
            {
                new TestCompositeInstaller(),
                new TestCompositeInstaller(),
                new TestCompositeInstaller(),
            };

            Assert.True(_compositeInstaller2.ValidateAsCompositeSavedAlloc(reusableParentInstallers));
            Assert.AreEqual(3, reusableParentInstallers.Count);
        }

        [Test]
        public void TestValidateAsCompositeSavedAllocWithCompositeInstallerSelfInParent()
        {
            var reusableParentInstallers = new List<ICompositeInstaller<TestInstaller>>
            {
                new TestCompositeInstaller(),
                _compositeInstaller1,
                new TestCompositeInstaller(),
            };

            Assert.False(_compositeInstaller1.ValidateAsCompositeSavedAlloc(reusableParentInstallers));
            Assert.AreEqual(3, reusableParentInstallers.Count);
        }

        [Test]
        public void TestValidateAsCompositeSavedAllocWithCompositeInstallerParentCircularRef()
        {
            var reusableParentInstallers = new List<ICompositeInstaller<TestInstaller>>
            {
                new TestCompositeInstaller(),
                _compositeInstaller1,
                new TestCompositeInstaller(),
            };

            Assert.False(_compositeInstaller2.ValidateAsCompositeSavedAlloc(reusableParentInstallers));
            Assert.AreEqual(3, reusableParentInstallers.Count);
        }

        public class TestInstaller : IInstaller
        {
            public bool IsEnabled => false;
            public void InstallBindings() { }
        }

        public class TestCompositeInstaller : TestInstaller, ICompositeInstaller<TestInstaller>
        {
            public List<TestInstaller> _leafInstallers;
            public IReadOnlyList<TestInstaller> LeafInstallers => _leafInstallers;
        }
    }
}