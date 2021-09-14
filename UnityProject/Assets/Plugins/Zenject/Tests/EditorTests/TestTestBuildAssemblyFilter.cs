using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;
using Zenject.Internal;

namespace Zenject.Tests.Internal
{
    public class TestTestBuildAssemblyFilter
    {
        TestBuildAssemblyFilter _target;

        BuildOptions _buildOptions;

        [SetUp]
        public void SetUp()
        {
            _target = new TestBuildAssemblyFilter();
            _buildOptions = BuildOptions.None;
        }

        [Test]
        public void TestOnFilterAssemblies()
        {
            var actual = _target.OnFilterAssemblies(_buildOptions, assemblies: Assemblies);
            Assert.AreEqual(ExpectedFilteredAssemblies, actual);
        }

        [Test]
        public void TestOnFilterAssembliesWithBuildOptionsIncludeTestAssemblies()
        {
            _buildOptions |= BuildOptions.IncludeTestAssemblies;

            var actual = _target.OnFilterAssemblies(_buildOptions, assemblies: Assemblies);
            Assert.AreEqual(Assemblies, actual);
        }

        readonly string[] Assemblies = new string[]
        {
            "Library/PlayerScriptAssemblies/Runner.dll",
            "Library/PlayerScriptAssemblies/Zenject-TestFramework.dll",
            "Library/PlayerScriptAssemblies/Zenject.dll",
        };

        readonly string[] ExpectedFilteredAssemblies = new string[]
        {
            "Library/PlayerScriptAssemblies/Runner.dll",
            "Library/PlayerScriptAssemblies/Zenject.dll",
        };
    }
}
