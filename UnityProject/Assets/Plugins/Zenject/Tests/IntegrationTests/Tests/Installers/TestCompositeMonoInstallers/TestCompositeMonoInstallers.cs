using System.Collections;
using ModestTree;
using UnityEngine;
using UnityEngine.TestTools;
using Zenject;
using Zenject.Tests;
using Zenject.Tests.Installers.CompositeMonoInstallers;

namespace Zenject.Tests.Installers
{
    public class TestCompositeMonoInstallers : ZenjectIntegrationTestFixture
    {
        [UnityTest]
        public IEnumerator TestZeroParameters()
        {
            PreInstall();
            InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/FooInstaller/TestCompositeMonoFooInstaller", Container);
            PostInstall();

            FixtureUtil.AssertResolveCount<Foo>(Container, 1);
            yield break;
        }

        [UnityTest]
        public IEnumerator TestZeroParametersDeep()
        {
            PreInstall();
            InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/FooInstaller/TestCompositeMonoDeepFooInstaller1", Container);
            PostInstall();

            FixtureUtil.AssertResolveCount<Foo>(Container, 1);
            yield break;
        }

        [UnityTest]
        public IEnumerator TestOneParameter()
        {
            PreInstall();
            InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/BarInstaller/TestCompositeMonoBarInstaller", Container);
            PostInstall();

            Assert.IsEqual(Container.Resolve<string>(), "composite mono installer blurg");
            yield break;
        }

        [UnityTest]
        public IEnumerator TestOneParameterDeep()
        {
            PreInstall();
            InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/BarInstaller/TestCompositeMonoDeepBarInstaller1", Container);
            PostInstall();

            Assert.IsEqual(Container.Resolve<string>(), "composite mono installer blurg");
            yield break;
        }

        [UnityTest]
        public IEnumerator TestThreeParameters()
        {
            PreInstall();
            InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/QuxInstaller/TestCompositeMonoQuxInstaller", Container);
            PostInstall();

            Assert.IsEqual(Container.Resolve<string>(), "composite mono installer string");
            Assert.IsEqual(Container.Resolve<float>(), 23.45f);
            Assert.IsEqual(Container.Resolve<int>(), 7890);
            yield break;
        }

        [UnityTest]
        public IEnumerator TestThreeParametersDeep()
        {
            PreInstall();
            InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/QuxInstaller/TestCompositeMonoDeepQuxInstaller1", Container);
            PostInstall();

            Assert.IsEqual(Container.Resolve<string>(), "composite mono installer string");
            Assert.IsEqual(Container.Resolve<float>(), 23.45f);
            Assert.IsEqual(Container.Resolve<int>(), 7890);
            yield break;
        }

        [UnityTest]
        public IEnumerator TestMultipleInstallers()
        {
            PreInstall();
            FooInjecteeInstaller.InstallFromResource("TestCompositeMonoInstallers/FooInjecteeInstaller/FooInjecteeInstaller", Container);
            InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/FooInstaller/TestCompositeMonoFooInstaller", Container);
            PostInstall();

            FixtureUtil.AssertResolveCount<Foo>(Container, 1);
            FixtureUtil.AssertResolveCount<FooInjectee>(Container, 1);
            yield break;
        }

        [UnityTest]
        public IEnumerator TestMultipleInstallersDeep()
        {
            PreInstall();
            InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/FooInjecteeInstaller/TestCompositeMonoFooInjecteeInstaller", Container);
            InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/FooInstaller/TestCompositeMonoFooInstaller", Container);
            PostInstall();

            FixtureUtil.AssertResolveCount<Foo>(Container, 1);
            FixtureUtil.AssertResolveCount<FooInjectee>(Container, 1);
            yield break;
        }

        [UnityTest]
        public IEnumerator TestDuplicateInstallers()
        {
            PreInstall();
            InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/FooInstaller/TestCompositeMonoFooInstaller", Container);
            Assert.Throws<ZenjectException>(() =>
            {
                InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/FooInstaller/TestCompositeMonoDeepFooInstaller1", Container);
            });
            PostInstall();

            yield break;
        }

        [UnityTest]
        public IEnumerator TestAssertWithCircularReference()
        {
            PreInstall();

            Assert.Throws<ZenjectException>(() =>
            {
                InstallCompositeMonoInstallerFromResource("TestCompositeMonoInstallers/CircularReferenceCompositeInstaller/CircularReferenceCompositeMonoInstaller", Container);
            });

            PostInstall();

            yield break;
        }

        // An installation method for "CompositeMonoInstaller".
        // MonoInstaller.InstallFromResource uses "GetComponentsInChildren", so it can't be used for "CompositeMonoInstaller" if the prefab has multiple "CompositeMonoInstaller".
        public static void InstallCompositeMonoInstallerFromResource(string resourcePath, DiContainer container)
        {
            var installerPrefab = Resources.Load<CompositeMonoInstaller>(resourcePath);
            var installer = GameObject.Instantiate(installerPrefab);
            container.Inject(installer);
            installer.InstallBindings();
        }
    }
}
