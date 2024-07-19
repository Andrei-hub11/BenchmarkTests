using BenchmarkDotNet.Attributes;
using System;
using System.Text.RegularExpressions;

namespace BenchmarkTests;

public class BenchmarkRegex
{
    // Regex Compilados
    private static readonly Regex CompiledNumericRegex = new Regex("^[0-9]*$", RegexOptions.Compiled);
    private static readonly Regex CompiledAlphanumericRegex = new Regex("^[a-zA-Z0-9]*$", RegexOptions.Compiled);
    private static readonly Regex CompiledEmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

    // Regex Interpretação
    private static readonly Regex InterpretedNumericRegex = new Regex("^[0-9]*$");
    private static readonly Regex InterpretedAlphanumericRegex = new Regex("^[a-zA-Z0-9]*$");
    private static readonly Regex InterpretedEmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

    private const string NumericValue = "1234567890";
    private const string AlphanumericValue = "abc123XYZ";
    private const string MixedValue = "abc123!@#";
    private const string ValidEmail = "example@test.com";
    private const string InvalidEmail = "example@.com";

    [Benchmark]
    public bool TestCompiledNumericRegex()
    {
        return CompiledNumericRegex.IsMatch(NumericValue);
    }

    [Benchmark]
    public bool TestInterpretedNumericRegex()
    {
        return InterpretedNumericRegex.IsMatch(NumericValue);
    }

    [Benchmark]
    public bool TestCompiledAlphanumericRegex()
    {
        return CompiledAlphanumericRegex.IsMatch(AlphanumericValue);
    }

    [Benchmark]
    public bool TestInterpretedAlphanumericRegex()
    {
        return InterpretedAlphanumericRegex.IsMatch(AlphanumericValue);
    }

    [Benchmark]
    public bool TestCompiledMixedValueNumericRegex()
    {
        return CompiledNumericRegex.IsMatch(MixedValue);
    }

    [Benchmark]
    public bool TestInterpretedMixedValueNumericRegex()
    {
        return InterpretedNumericRegex.IsMatch(MixedValue);
    }

    [Benchmark]
    public bool TestCompiledMixedValueAlphanumericRegex()
    {
        return CompiledAlphanumericRegex.IsMatch(MixedValue);
    }

    [Benchmark]
    public bool TestInterpretedMixedValueAlphanumericRegex()
    {
        return InterpretedAlphanumericRegex.IsMatch(MixedValue);
    }

    [Benchmark]
    public bool TestCompiledValidEmailRegex()
    {
        return CompiledEmailRegex.IsMatch(ValidEmail);
    }

    [Benchmark]
    public bool TestInterpretedValidEmailRegex()
    {
        return InterpretedEmailRegex.IsMatch(ValidEmail);
    }

    [Benchmark]
    public bool TestCompiledInvalidEmailRegex()
    {
        return CompiledEmailRegex.IsMatch(InvalidEmail);
    }

    [Benchmark]
    public bool TestInterpretedInvalidEmailRegex()
    {
        return InterpretedEmailRegex.IsMatch(InvalidEmail);
    }
}
