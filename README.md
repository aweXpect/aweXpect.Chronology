# aweXpect.Chronology
[![Nuget](https://img.shields.io/nuget/v/aweXpect.Chronology)](https://www.nuget.org/packages/aweXpect.Chronology) 
[![Build](https://github.com/aweXpect/aweXpect.Chronology/actions/workflows/build.yml/badge.svg)](https://github.com/aweXpect/aweXpect.Chronology/actions/workflows/build.yml)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=aweXpect_aweXpect.Chronology&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=aweXpect_aweXpect.Chronology)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=aweXpect_aweXpect.Chronology&metric=coverage)](https://sonarcloud.io/summary/new_code?id=aweXpect_aweXpect.Chronology)
[![Mutation testing badge](https://img.shields.io/endpoint?style=flat&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2FaweXpect%2FaweXpect.Chronology%2Fmain)](https://dashboard.stryker-mutator.io/reports/github.com/aweXpect/aweXpect.Chronology/main)

Extension methods for creating a `TimeSpan` that reads more natural.

```csharp
// ↓ Using traditional creation of TimeSpan
await Expect.That(someAction).Should().ExecuteWithin(TimeSpan.FromSeconds(10));
await Expect.That(someAction).Should().ExecuteWithin(10.Seconds());
// ↑ Using the extension methods from this library
```

It is also possible to combine multiple extension methods:
```csharp
TimeSpan timeout = 1.Minutes(30.Seconds());
```

Available methods are
- `.Milliseconds()`
- `.Seconds()`
- `.Minutes()`
- `.Hours()`
- `.Days()`
