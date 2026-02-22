using System;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ReflectionLab.Exercises;

// TODO: Run this benchmark using BenchmarkRunner.Run<PerformanceExperiment>() in Program.cs
[MemoryDiagnoser]
public class PerformanceExperiment
{
    private readonly MathOperations _mathOps = new();
    private readonly MethodInfo _addMethod;
    private readonly object[] _args = new object[] { 5, 10 };

    public PerformanceExperiment()
    {
        // Cache the MethodInfo for the reflection benchmark
        _addMethod = typeof(MathOperations).GetMethod(nameof(MathOperations.Add))!;
    }

    [Benchmark(Baseline = true)]
    public int DirectCall()
    {
        // TODO: Call the Add method directly on _mathOps
        return 0;
    }

    [Benchmark]
    public int ReflectionCall()
    {
        // TODO: Call the Add method using reflection (_addMethod.Invoke)
        return 0;
    }
}

public class MathOperations
{
    public int Add(int a, int b) => a + b;
}
