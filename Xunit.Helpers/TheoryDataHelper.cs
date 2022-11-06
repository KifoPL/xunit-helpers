namespace Xunit.Helpers;

public static class TheoryDataHelper
{
    public static TheoryData<T> ToTheoryData<T>(this IEnumerable<T> source)
    {
        var data = new TheoryData<T>();
        foreach (T? item in source) data.Add(item);

        return data;
    }

    public static TheoryData<T1, T2> ToTheoryData<T1, T2>(this IEnumerable<(T1, T2)> source)
    {
        var data = new TheoryData<T1, T2>();
        foreach ((T1, T2) item in source) data.Add(item.Item1, item.Item2);

        return data;
    }

    public static TheoryData<T1, T2> ToTheoryData<T1, T2>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T1, T2>();
        foreach (object[] item in source) data.Add((T1)item[0], (T2)item[1]);

        return data;
    }

    public static TheoryData<T1, T2> ToTheoryData<T1, T2>(this (T1, T2) source)
    {
        var data = new TheoryData<T1, T2> { { source.Item1, source.Item2 } };

        return data;
    }

    public static TheoryData<T1, T2> ToTheoryData<T1, T2>(this object[] source)
    {
        var data = new TheoryData<T1, T2> { { (T1)source[0], (T2)source[1] } };

        return data;
    }

    public static TheoryData<T1, T2, T3> ToTheoryData<T1, T2, T3>(this IEnumerable<(T1, T2, T3)> source)
    {
        var data = new TheoryData<T1, T2, T3>();
        foreach ((T1, T2, T3) item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3);

        return data;
    }

    public static TheoryData<T1, T2, T3> ToTheoryData<T1, T2, T3>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T1, T2, T3>();
        foreach (object[] item in source)
            data.Add((T1)item[0],
                     (T2)item[1],
                     (T3)item[2]);

        return data;
    }

    public static TheoryData<T1, T2, T3> ToTheoryData<T1, T2, T3>(this (T1, T2, T3) source)
    {
        var data = new TheoryData<T1, T2, T3> { { source.Item1, source.Item2, source.Item3 } };

        return data;
    }

    public static TheoryData<T1, T2, T3> ToTheoryData<T1, T2, T3>(this object[] source)
    {
        var data = new TheoryData<T1, T2, T3> { { (T1)source[0], (T2)source[1], (T3)source[2] } };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4> ToTheoryData<T1, T2, T3, T4>(this IEnumerable<(T1, T2, T3, T4)> source)
    {
        var data = new TheoryData<T1, T2, T3, T4>();
        foreach ((T1, T2, T3, T4) item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4> ToTheoryData<T1, T2, T3, T4>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T1, T2, T3, T4>();
        foreach (object[] item in source)
            data.Add((T1)item[0],
                     (T2)item[1],
                     (T3)item[2],
                     (T4)item[3]);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4> ToTheoryData<T1, T2, T3, T4>(this (T1, T2, T3, T4) source)
    {
        var data = new TheoryData<T1, T2, T3, T4> { { source.Item1, source.Item2, source.Item3, source.Item4 } };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4> ToTheoryData<T1, T2, T3, T4>(this object[] source)
    {
        var data = new TheoryData<T1, T2, T3, T4> { { (T1)source[0], (T2)source[1], (T3)source[2], (T4)source[3] } };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5> ToTheoryData
        <T1, T2, T3, T4, T5>(this IEnumerable<(T1, T2, T3, T4, T5)> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5>();
        foreach ((T1, T2, T3, T4, T5) item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5> ToTheoryData<T1, T2, T3, T4, T5>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5>();
        foreach (object[] item in source)
            data.Add((T1)item[0],
                     (T2)item[1],
                     (T3)item[2],
                     (T4)item[3],
                     (T5)item[4]);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5> ToTheoryData<T1, T2, T3, T4, T5>(this (T1, T2, T3, T4, T5) source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5>
            { { source.Item1, source.Item2, source.Item3, source.Item4, source.Item5 } };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5> ToTheoryData<T1, T2, T3, T4, T5>(this object[] source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5>
            { { (T1)source[0], (T2)source[1], (T3)source[2], (T4)source[3], (T5)source[4] } };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6> ToTheoryData
        <T1, T2, T3, T4, T5, T6>(this IEnumerable<(T1, T2, T3, T4, T5, T6)> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6>();
        foreach ((T1, T2, T3, T4, T5, T6) item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5,
                     item.Item6);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6> ToTheoryData
        <T1, T2, T3, T4, T5, T6>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6>();
        foreach (object[] item in source)
            data.Add((T1)item[0],
                     (T2)item[1],
                     (T3)item[2],
                     (T4)item[3],
                     (T5)item[4],
                     (T6)item[5]);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6> ToTheoryData
        <T1, T2, T3, T4, T5, T6>(this (T1, T2, T3, T4, T5, T6) source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6>
            { { source.Item1, source.Item2, source.Item3, source.Item4, source.Item5, source.Item6 } };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6> ToTheoryData<T1, T2, T3, T4, T5, T6>(this object[] source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6>
            { { (T1)source[0], (T2)source[1], (T3)source[2], (T4)source[3], (T5)source[4], (T6)source[5] } };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<(T1, T2, T3, T4, T5, T6, T7)> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7>();
        foreach ((T1, T2, T3, T4, T5, T6, T7) item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5,
                     item.Item6,
                     item.Item7);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7>();
        foreach (object[] item in source)
            data.Add((T1)item[0],
                     (T2)item[1],
                     (T3)item[2],
                     (T4)item[3],
                     (T5)item[4],
                     (T6)item[5],
                     (T7)item[6]);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4, T5, T6, T7) source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7>
            { { source.Item1, source.Item2, source.Item3, source.Item4, source.Item5, source.Item6, source.Item7 } };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7> ToTheoryData<T1, T2, T3, T4, T5, T6, T7>(this object[] source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7>
        {
            { (T1)source[0], (T2)source[1], (T3)source[2], (T4)source[3], (T5)source[4], (T6)source[5], (T7)source[6] }
        };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8>();
        foreach ((T1, T2, T3, T4, T5, T6, T7, T8) item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5,
                     item.Item6,
                     item.Item7,
                     item.Item8);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8>();
        foreach (object[] item in source)
            data.Add((T1)item[0],
                     (T2)item[1],
                     (T3)item[2],
                     (T4)item[3],
                     (T5)item[4],
                     (T6)item[5],
                     (T7)item[6],
                     (T8)item[7]);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8>(this (T1, T2, T3, T4, T5, T6, T7, T8) source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            {
                source.Item1, source.Item2, source.Item3, source.Item4, source.Item5, source.Item6, source.Item7,
                source.Item8
            }
        };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8>(this object[] source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            {
                (T1)source[0], (T2)source[1], (T3)source[2], (T4)source[3], (T5)source[4], (T6)source[5], (T7)source[6],
                (T8)source[7]
            }
        };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        foreach ((T1, T2, T3, T4, T5, T6, T7, T8, T9) item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5,
                     item.Item6,
                     item.Item7,
                     item.Item8,
                     item.Item9);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        foreach (object[] item in source)
            data.Add((T1)item[0],
                     (T2)item[1],
                     (T3)item[2],
                     (T4)item[3],
                     (T5)item[4],
                     (T6)item[5],
                     (T7)item[6],
                     (T8)item[7],
                     (T9)item[8]);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8, T9>(this (T1, T2, T3, T4, T5, T6, T7, T8, T9) source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        {
            {
                source.Item1, source.Item2, source.Item3, source.Item4, source.Item5, source.Item6, source.Item7,
                source.Item8, source.Item9
            }
        };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8, T9>(this object[] source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        {
            {
                (T1)source[0], (T2)source[1], (T3)source[2], (T4)source[3], (T5)source[4], (T6)source[5], (T7)source[6],
                (T8)source[7], (T9)source[8]
            }
        };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        foreach ((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5,
                     item.Item6,
                     item.Item7,
                     item.Item8,
                     item.Item9,
                     item.Item10);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        foreach (object[] item in source)
            data.Add((T1)item[0],
                     (T2)item[1],
                     (T3)item[2],
                     (T4)item[3],
                     (T5)item[4],
                     (T6)item[5],
                     (T7)item[6],
                     (T8)item[7],
                     (T9)item[8],
                     (T10)item[9]);

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            {
                source.Item1, source.Item2, source.Item3, source.Item4, source.Item5, source.Item6, source.Item7,
                source.Item8, source.Item9, source.Item10
            }
        };

        return data;
    }

    public static TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ToTheoryData
        <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this object[] source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            {
                (T1)source[0], (T2)source[1], (T3)source[2], (T4)source[3], (T5)source[4], (T6)source[5], (T7)source[6],
                (T8)source[7], (T9)source[8], (T10)source[9]
            }
        };

        return data;
    }
}