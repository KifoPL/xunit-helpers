using FluentAssertions;
using Xunit.Helpers.Tests.TestDummies;

namespace Xunit.Helpers.Tests;

public class TheoryDataHelpersTests
{
    [Fact]
    public void TestEnumData_T1()
    {
        var entryData = Enum.GetValues<TestEnum>().ToList();
        var entryObjectData = entryData.Select(entry => new object[] { entry }).ToList();
        var entryTupleData = entryData.Select(entry => Tuple.Create(entry)).ToList();

        var testEnumTheoryData = entryData.ToTheoryData();
        var testEnumTheoryDataObject = entryObjectData.ToTheoryData<TestEnum>();
        var testEnumTheoryDataTuple = entryTupleData.ToTheoryData();

        testEnumTheoryData.Should().NotBeNull();
        testEnumTheoryData.Should().BeOfType<TheoryData<TestEnum>>();
        testEnumTheoryData.Should().HaveCount(entryData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryData.Select(obj => (TestEnum)obj[0])
                                                    .Should()
                                                    .Contain(t));

        testEnumTheoryDataObject.Should().NotBeNull();
        testEnumTheoryDataObject.Should().BeOfType<TheoryData<TestEnum>>();
        testEnumTheoryDataObject.Should().HaveCount(entryObjectData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataObject.Select(obj => (TestEnum)obj[0])
                                                          .Should()
                                                          .Contain(t));

        testEnumTheoryDataTuple.Should().NotBeNull();
        testEnumTheoryDataTuple.Should().BeOfType<TheoryData<TestEnum>>();
        testEnumTheoryDataTuple.Should().HaveCount(entryTupleData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataTuple.Select(obj => (TestEnum)obj[0])
                                                         .Should()
                                                         .Contain(t));
    }

    [Fact]
    public void TestEnumData_T1_T2()
    {
        var entryData = Enum.GetValues<TestEnum>()
                            .Select(testEnum => (testEnum, testEnum.ToString()))
                            .ToList();
        var entryObjectData = entryData
                             .Select(entry => new object[] { entry.Item1, entry.Item2 })
                             .ToList();
        var entryTupleData = entryData.Select(entry => Tuple.Create(entry.Item1, entry.Item2)).ToList();

        var testEnumTheoryData = entryData.ToTheoryData();
        var testEnumTheoryDataObject = entryObjectData.ToTheoryData<TestEnum, string>();
        var testEnumTheoryDataTuple = entryTupleData.ToTheoryData();

        testEnumTheoryData.Should().NotBeNull();
        testEnumTheoryData.Should().BeOfType<TheoryData<TestEnum, string>>();
        testEnumTheoryData.Should().HaveCount(entryData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryData.Select(obj => ((TestEnum)obj[0], (string)obj[1]))
                                                    .Should()
                                                    .Contain(t));

        testEnumTheoryDataObject.Should().NotBeNull();
        testEnumTheoryDataObject.Should().BeOfType<TheoryData<TestEnum, string>>();
        testEnumTheoryDataObject.Should().HaveCount(entryObjectData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataObject.Select(obj => ((TestEnum)obj[0], (string)obj[1]))
                                                          .Should()
                                                          .Contain(t));

        testEnumTheoryDataTuple.Should().NotBeNull();
        testEnumTheoryDataTuple.Should().BeOfType<TheoryData<TestEnum, string>>();
        testEnumTheoryDataTuple.Should().HaveCount(entryTupleData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataTuple.Select(obj => ((TestEnum)obj[0], (string)obj[1]))
                                                         .Should()
                                                         .Contain(t));
    }

    [Fact]
    public void TestEnumData_T1_T3()
    {
        var entryData = Enum.GetValues<TestEnum>()
                            .Select((testEnum, index) => (testEnum, testEnum.ToString(), index))
                            .ToList();
        var entryObjectData = entryData
                             .Select(entry => new object[] { entry.Item1, entry.Item2, entry.Item3 })
                             .ToList();
        var entryTupleData = entryData.Select(entry => Tuple.Create(entry.Item1,
                                                                    entry.Item2,
                                                                    entry.Item3))
                                      .ToList();

        var testEnumTheoryData = entryData.ToTheoryData();
        var testEnumTheoryDataObject = entryObjectData.ToTheoryData<TestEnum, string, int>();
        var testEnumTheoryDataTuple = entryTupleData.ToTheoryData();

        testEnumTheoryData.Should().NotBeNull();
        testEnumTheoryData.Should().BeOfType<TheoryData<TestEnum, string, int>>();
        testEnumTheoryData.Should().HaveCount(entryData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryData.Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2]))
                                                    .Should()
                                                    .Contain(t));

        testEnumTheoryDataObject.Should().NotBeNull();
        testEnumTheoryDataObject.Should().BeOfType<TheoryData<TestEnum, string, int>>();
        testEnumTheoryDataObject.Should().HaveCount(entryObjectData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataObject
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2]))
                                 .Should()
                                 .Contain(t));

        testEnumTheoryDataTuple.Should().NotBeNull();
        testEnumTheoryDataTuple.Should().BeOfType<TheoryData<TestEnum, string, int>>();
        testEnumTheoryDataTuple.Should().HaveCount(entryTupleData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataTuple.Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2]))
                                                         .Should()
                                                         .Contain(t));
    }

    [Fact]
    public void TestEnumData_T1_T4()
    {
        var entryData = Enum.GetValues<TestEnum>()
                            .Select((testEnum, index) => (testEnum, testEnum.ToString(), index, testEnum))
                            .ToList();
        var entryObjectData = entryData
                             .Select(entry => new object[] { entry.Item1, entry.Item2, entry.Item3, entry.Item4 })
                             .ToList();
        var entryTupleData = entryData.Select(entry => Tuple.Create(entry.Item1,
                                                                    entry.Item2,
                                                                    entry.Item3,
                                                                    entry.Item4))
                                      .ToList();

        var testEnumTheoryData = entryData.ToTheoryData();
        var testEnumTheoryDataObject = entryObjectData.ToTheoryData<TestEnum, string, int, TestEnum>();
        var testEnumTheoryDataTuple = entryTupleData.ToTheoryData();

        testEnumTheoryData.Should().NotBeNull();
        testEnumTheoryData.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum>>();
        testEnumTheoryData.Should().HaveCount(entryData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryData
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3]))
                                 .Should()
                                 .Contain(t));

        testEnumTheoryDataObject.Should().NotBeNull();
        testEnumTheoryDataObject.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum>>();
        testEnumTheoryDataObject.Should().HaveCount(entryObjectData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataObject
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3]))
                                 .Should()
                                 .Contain(t));

        testEnumTheoryDataTuple.Should().NotBeNull();
        testEnumTheoryDataTuple.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum>>();
        testEnumTheoryDataTuple.Should().HaveCount(entryTupleData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataTuple
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3]))
                                 .Should()
                                 .Contain(t));
    }

    [Fact]
    public void TestEnumData_T1_T5()
    {
        var entryData = Enum.GetValues<TestEnum>()
                            .Select((testEnum, index)
                                        => (testEnum, testEnum.ToString(), index, testEnum, testEnum.ToString()))
                            .ToList();
        var entryObjectData = entryData
                             .Select(entry => new object[]
                                         { entry.Item1, entry.Item2, entry.Item3, entry.Item4, entry.Item5 })
                             .ToList();
        var entryTupleData = entryData.Select(entry => Tuple.Create(entry.Item1,
                                                                    entry.Item2,
                                                                    entry.Item3,
                                                                    entry.Item4,
                                                                    entry.Item5))
                                      .ToList();

        var testEnumTheoryData = entryData.ToTheoryData();
        var testEnumTheoryDataObject = entryObjectData.ToTheoryData<TestEnum, string, int, TestEnum, string>();
        var testEnumTheoryDataTuple = entryTupleData.ToTheoryData();

        testEnumTheoryData.Should().NotBeNull();
        testEnumTheoryData.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string>>();
        testEnumTheoryData.Should().HaveCount(entryData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryData
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4]))
                                 .Should()
                                 .Contain(t));

        testEnumTheoryDataObject.Should().NotBeNull();
        testEnumTheoryDataObject.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string>>();
        testEnumTheoryDataObject.Should().HaveCount(entryObjectData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataObject
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4]))
                                 .Should()
                                 .Contain(t));

        testEnumTheoryDataTuple.Should().NotBeNull();
        testEnumTheoryDataTuple.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string>>();
        testEnumTheoryDataTuple.Should().HaveCount(entryTupleData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataTuple
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4]))
                                 .Should()
                                 .Contain(t));
    }

    [Fact]
    public void TestEnumData_T1_T6()
    {
        var entryData = Enum.GetValues<TestEnum>()
                            .Select((testEnum, index)
                                        => (testEnum, testEnum.ToString(), index, testEnum, testEnum.ToString(), index))
                            .ToList();
        var entryObjectData = entryData
                             .Select(entry => new object[]
                              {
                                  entry.Item1, entry.Item2, entry.Item3, entry.Item4, entry.Item5, entry.Item6
                              })
                             .ToList();
        var entryTupleData = entryData.Select(entry => Tuple.Create(entry.Item1,
                                                                    entry.Item2,
                                                                    entry.Item3,
                                                                    entry.Item4,
                                                                    entry.Item5,
                                                                    entry.Item6))
                                      .ToList();

        var testEnumTheoryData = entryData.ToTheoryData();
        var testEnumTheoryDataObject = entryObjectData.ToTheoryData<TestEnum, string, int, TestEnum, string, int>();
        var testEnumTheoryDataTuple = entryTupleData.ToTheoryData();

        testEnumTheoryData.Should().NotBeNull();
        testEnumTheoryData.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int>>();
        testEnumTheoryData.Should().HaveCount(entryData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryData
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5]))
                                 .Should()
                                 .Contain(t));

        testEnumTheoryDataObject.Should().NotBeNull();
        testEnumTheoryDataObject.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int>>();
        testEnumTheoryDataObject.Should().HaveCount(entryObjectData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataObject
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5]))
                                 .Should()
                                 .Contain(t));

        testEnumTheoryDataTuple.Should().NotBeNull();
        testEnumTheoryDataTuple.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int>>();
        testEnumTheoryDataTuple.Should().HaveCount(entryTupleData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataTuple
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5]))
                                 .Should()
                                 .Contain(t));
    }

    [Fact]
    public void TestEnumData_T1_T7()
    {
        var entryData = Enum.GetValues<TestEnum>()
                            .Select((testEnum, index) => (testEnum, testEnum.ToString(), index, testEnum,
                                                          testEnum.ToString(), index, testEnum))
                            .ToList();
        var entryObjectData = entryData
                             .Select(entry => new object[]
                              {
                                  entry.Item1, entry.Item2, entry.Item3, entry.Item4, entry.Item5, entry.Item6,
                                  entry.Item7
                              })
                             .ToList();
        var entryTupleData = entryData.Select(entry => Tuple.Create(entry.Item1,
                                                                    entry.Item2,
                                                                    entry.Item3,
                                                                    entry.Item4,
                                                                    entry.Item5,
                                                                    entry.Item6,
                                                                    entry.Item7))
                                      .ToList();

        var testEnumTheoryData = entryData.ToTheoryData();
        var testEnumTheoryDataObject
            = entryObjectData.ToTheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum>();
        var testEnumTheoryDataTuple = entryTupleData.ToTheoryData();

        testEnumTheoryData.Should().NotBeNull();
        testEnumTheoryData.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum>>();
        testEnumTheoryData.Should().HaveCount(entryData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryData
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6]))
                                 .Should()
                                 .Contain(t));

        testEnumTheoryDataObject.Should().NotBeNull();
        testEnumTheoryDataObject.Should()
                                .BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum>>();
        testEnumTheoryDataObject.Should().HaveCount(entryObjectData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataObject
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6]))
                                 .Should()
                                 .Contain(t));

        testEnumTheoryDataTuple.Should().NotBeNull();
        testEnumTheoryDataTuple.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum>>();
        testEnumTheoryDataTuple.Should().HaveCount(entryTupleData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataTuple
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6]))
                                 .Should()
                                 .Contain(t));
    }

    [Fact]
    public void TestEnumData_T1_T8()
    {
        var entryData = Enum.GetValues<TestEnum>()
                            .Select((testEnum, index) => (testEnum, testEnum.ToString(), index, testEnum,
                                                          testEnum.ToString(), index, testEnum, testEnum.ToString()))
                            .ToList();
        var entryObjectData = entryData
                             .Select(entry => new object[]
                              {
                                  entry.Item1, entry.Item2, entry.Item3, entry.Item4, entry.Item5, entry.Item6,
                                  entry.Item7, entry.Item8
                              })
                             .ToList();
        
        var entryTupleData = entryData.Select(entry => Tuple.Create(entry.Item1,
                                                                    entry.Item2,
                                                                    entry.Item3,
                                                                    entry.Item4,
                                                                    entry.Item5,
                                                                    entry.Item6,
                                                                    entry.Item7,
                                                                    entry.Item8))
                                      .ToList();
        
        var testEnumTheoryData = entryData.ToTheoryData();
        var testEnumTheoryDataObject
            = entryObjectData.ToTheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string>();
        var testEnumTheoryDataTuple = entryTupleData.ToTheoryData();
        
        testEnumTheoryData.Should().NotBeNull();
        testEnumTheoryData.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string>>();
        testEnumTheoryData.Should().HaveCount(entryData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryData
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6], (string)obj[7]))
                                 .Should()
                                 .Contain(t));
        
        testEnumTheoryDataObject.Should().NotBeNull();
        testEnumTheoryDataObject.Should()
                                .BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string>>();
        testEnumTheoryDataObject.Should().HaveCount(entryObjectData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataObject
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6], (string)obj[7]))
                                 .Should()
                                 .Contain(t));
        
        testEnumTheoryDataTuple.Should().NotBeNull();
        testEnumTheoryDataTuple.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string>>();
        testEnumTheoryDataTuple.Should().HaveCount(entryTupleData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataTuple
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6], (string)obj[7]))
                                 .Should()
                                 .Contain(t));
    }

    [Fact]
    public void TestEnumData_T1_T9()
    {
        var entryData = Enum.GetValues<TestEnum>()
                            .Select((testEnum, index) => (testEnum, testEnum.ToString(), index, testEnum,
                                                          testEnum.ToString(), index, testEnum, testEnum.ToString(),
                                                          index))
                            .ToList();
        var entryObjectData = entryData
                             .Select(entry => new object[]
                              {
                                  entry.Item1, entry.Item2, entry.Item3, entry.Item4, entry.Item5, entry.Item6,
                                  entry.Item7, entry.Item8, entry.Item9
                              })
                             .ToList();
        var entryTupleData = entryData.Select(entry => new Tuple<TestEnum, string, int, TestEnum, string, int, TestEnum, Tuple<string, int>>
                                                  (entry.Item1,
                                                   entry.Item2,
                                                   entry.Item3,
                                                   entry.Item4,
                                                   entry.Item5,
                                                   entry.Item6,
                                                   entry.Item7,
                                                   new(entry.Item8, entry.Item9)))
                                      .ToList();
        
        var testEnumTheoryData = entryData.ToTheoryData();
        var testEnumTheoryDataObject
            = entryObjectData.ToTheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string, int>();
        var testEnumTheoryDataTuple = entryTupleData.ToTheoryData();
        
        testEnumTheoryData.Should().NotBeNull();
        testEnumTheoryData.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string, int>>();
        testEnumTheoryData.Should().HaveCount(entryData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryData
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6], (string)obj[7],
                                                 (int)obj[8]))
                                 .Should()
                                 .Contain(t));
        
        testEnumTheoryDataObject.Should().NotBeNull();
        testEnumTheoryDataObject.Should()
                                .BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string, int>>();
        testEnumTheoryDataObject.Should().HaveCount(entryObjectData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataObject
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6], (string)obj[7],
                                                 (int)obj[8]))
                                 .Should()
                                 .Contain(t));
        
        testEnumTheoryDataTuple.Should().NotBeNull();
        testEnumTheoryDataTuple.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string, int>>();
        testEnumTheoryDataTuple.Should().HaveCount(entryTupleData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataTuple
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6], (string)obj[7],
                                                 (int)obj[8]))
                                 .Should()
                                 .Contain(t));
    }

    [Fact]
    public void TestEnumData_T1_T10()
    {
        var entryData = Enum.GetValues<TestEnum>()
                            .Select((testEnum, index) => (testEnum, testEnum.ToString(), index, testEnum,
                                                          testEnum.ToString(), index, testEnum, testEnum.ToString(),
                                                          index, testEnum))
                            .ToList();
        var entryObjectData = entryData
                             .Select(entry => new object[]
                              {
                                  entry.Item1, entry.Item2, entry.Item3, entry.Item4, entry.Item5, entry.Item6,
                                  entry.Item7, entry.Item8, entry.Item9, entry.Item10
                              })
                             .ToList();
        var entryTupleData = entryData.Select(entry => new Tuple<TestEnum, string, int, TestEnum, string, int, TestEnum, Tuple<string, int, TestEnum>>
                                                  (entry.Item1,
                                                   entry.Item2,
                                                   entry.Item3,
                                                   entry.Item4,
                                                   entry.Item5,
                                                   entry.Item6,
                                                   entry.Item7,
                                                   new(entry.Item8, entry.Item9, entry.Item10)))
                                      .ToList();
        
        var testEnumTheoryData = entryData.ToTheoryData();
        var testEnumTheoryDataObject
            = entryObjectData.ToTheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string, int, TestEnum>();
        var testEnumTheoryDataTuple = entryTupleData.ToTheoryData();
        
        testEnumTheoryData.Should().NotBeNull();
        testEnumTheoryData.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string, int, TestEnum>>();
        testEnumTheoryData.Should().HaveCount(entryData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryData
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6], (string)obj[7],
                                                 (int)obj[8], (TestEnum)obj[9]))
                                 .Should()
                                 .Contain(t));
        
        testEnumTheoryDataObject.Should().NotBeNull();
        testEnumTheoryDataObject.Should()
                                .BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string, int, TestEnum>>();
        testEnumTheoryDataObject.Should().HaveCount(entryObjectData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataObject
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6], (string)obj[7],
                                                 (int)obj[8], (TestEnum)obj[9]))
                                 .Should()
                                 .Contain(t));
        
        testEnumTheoryDataTuple.Should().NotBeNull();
        testEnumTheoryDataTuple.Should().BeOfType<TheoryData<TestEnum, string, int, TestEnum, string, int, TestEnum, string, int, TestEnum>>();
        testEnumTheoryDataTuple.Should().HaveCount(entryTupleData.Count);
        entryData.Should()
                 .AllSatisfy(t => testEnumTheoryDataTuple
                                 .Select(obj => ((TestEnum)obj[0], (string)obj[1], (int)obj[2], (TestEnum)obj[3],
                                                 (string)obj[4], (int)obj[5], (TestEnum)obj[6], (string)obj[7],
                                                 (int)obj[8], (TestEnum)obj[9]))
                                 .Should()
                                 .Contain(t));
    }
}