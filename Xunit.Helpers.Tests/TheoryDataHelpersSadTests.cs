using FluentAssertions;

namespace Xunit.Helpers.Tests;

public class TheoryDataHelpersSadTests
{
    [Fact]
    public void T1_InvalidArrayLength_ThrowsIndexOutOfRange()
    {
        var data = new[]
        {
            new object[] { }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int>();

        act.Should().Throw<IndexOutOfRangeException>();
    }

    [Fact]
    public void T1_ArrayItemInvalidCast_ThrowsInvalidCastException()
    {
            var data = new[]
        {
            new object[] { "1" }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int>();

        act.Should().Throw<InvalidCastException>();
    }
    
    [Fact]
    public void T2_InvalidArrayLength_ThrowsIndexOutOfRange()
    {
        var data = new[]
        {
            new object[] { }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int>();

        act.Should().Throw<IndexOutOfRangeException>();
    }
    
    [Fact]
    public void T2_ArrayItemInvalidCast_ThrowsInvalidCastException()
    {
        var data = new[]
        {
            new object[] { "1", "2" }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int>();

        act.Should().Throw<InvalidCastException>();
    }
    
    [Fact]
    public void T3_InvalidArrayLength_ThrowsIndexOutOfRange()
    {
        var data = new[]
        {
            new object[] { }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int>();

        act.Should().Throw<IndexOutOfRangeException>();
    }
    
    [Fact]
    public void T3_ArrayItemInvalidCast_ThrowsInvalidCastException()
    {
        var data = new[]
        {
            new object[] { "1", "2", "3" }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int>();

        act.Should().Throw<InvalidCastException>();
    }
    
    [Fact]
    public void T4_InvalidArrayLength_ThrowsIndexOutOfRange()
    {
        var data = new[]
        {
            new object[] { }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int>();

        act.Should().Throw<IndexOutOfRangeException>();
    }
    
    [Fact]
    public void T4_ArrayItemInvalidCast_ThrowsInvalidCastException()
    {
        var data = new[]
        {
            new object[] { "1", "2", "3", "4" }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int>();

        act.Should().Throw<InvalidCastException>();
    }
    
    [Fact]
    public void T5_InvalidArrayLength_ThrowsIndexOutOfRange()
    {
        var data = new[]
        {
            new object[] { }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int>();

        act.Should().Throw<IndexOutOfRangeException>();
    }
    
    [Fact]
    public void T5_ArrayItemInvalidCast_ThrowsInvalidCastException()
    {
        var data = new[]
        {
            new object[] { "1", "2", "3", "4", "5" }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int>();

        act.Should().Throw<InvalidCastException>();
    }
    
    [Fact]
    public void T6_InvalidArrayLength_ThrowsIndexOutOfRange()
    {
        var data = new[]
        {
            new object[] { }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int, int>();

        act.Should().Throw<IndexOutOfRangeException>();
    }
    
    [Fact]
    public void T6_ArrayItemInvalidCast_ThrowsInvalidCastException()
    {
        var data = new[]
        {
            new object[] { "1", "2", "3", "4", "5", "6" }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int, int>();

        act.Should().Throw<InvalidCastException>();
    }
    
    [Fact]
    public void T7_InvalidArrayLength_ThrowsIndexOutOfRange()
    {
        var data = new[]
        {
            new object[] { }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int, int, int>();

        act.Should().Throw<IndexOutOfRangeException>();
    }
    
    [Fact]
    public void T7_ArrayItemInvalidCast_ThrowsInvalidCastException()
    {
        var data = new[]
        {
            new object[] { "1", "2", "3", "4", "5", "6", "7" }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int, int, int>();

        act.Should().Throw<InvalidCastException>();
    }
    
    [Fact]
    public void T8_InvalidArrayLength_ThrowsIndexOutOfRange()
    {
        var data = new[]
        {
            new object[] { }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int, int, int, int>();

        act.Should().Throw<IndexOutOfRangeException>();
    }
    
    [Fact]
    public void T8_ArrayItemInvalidCast_ThrowsInvalidCastException()
    {
        var data = new[]
        {
            new object[] { "1", "2", "3", "4", "5", "6", "7", "8" }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int, int, int, int>();

        act.Should().Throw<InvalidCastException>();
    }
    
    [Fact]
    public void T9_InvalidArrayLength_ThrowsIndexOutOfRange()
    {
        var data = new[]
        {
            new object[] { }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int, int, int, int, int>();

        act.Should().Throw<IndexOutOfRangeException>();
    }
    
    [Fact]
    public void T9_ArrayItemInvalidCast_ThrowsInvalidCastException()
    {
        var data = new[]
        {
            new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int, int, int, int, int>();

        act.Should().Throw<InvalidCastException>();
    }
    
    [Fact]
    public void T10_InvalidArrayLength_ThrowsIndexOutOfRange()
    {
        var data = new[]
        {
            new object[] { }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int, int, int, int, int, int>();

        act.Should().Throw<IndexOutOfRangeException>();
    }
    
    [Fact]
    public void T10_ArrayItemInvalidCast_ThrowsInvalidCastException()
    {
        var data = new[]
        {
            new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" }
        }.AsEnumerable();
        
        Action act = () => data.ToTheoryData<int, int, int, int, int, int, int, int, int, int>();

        act.Should().Throw<InvalidCastException>();
    }
}