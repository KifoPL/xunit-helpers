namespace Xunit.Helpers;

public static class TheoryDataHelper
{
    public static TheoryData<T> ToTheoryData<T>(this IEnumerable<T> source)
    {
        var data = new TheoryData<T>();
        foreach (T? item in source) data.Add(item);

        return data;
    }

    public static TheoryData<T> ToTheoryData<T>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T>();
        foreach (object[] item in source) data.Add((T)item[0]);

        return data;
    }

    public static TheoryData<T> ToTheoryData<T>(this IEnumerable<Tuple<T>> source)
    {
        var data = new TheoryData<T>();
        foreach (var item in source) data.Add(item.Item1);

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
    
    public static TheoryData<T1, T2> ToTheoryData<T1, T2>(this IEnumerable<Tuple<T1, T2>> source)
    {
        var data = new TheoryData<T1, T2>();
        foreach (var item in source) data.Add(item.Item1, item.Item2);

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
    
    public static TheoryData<T1, T2, T3> ToTheoryData<T1, T2, T3>(this IEnumerable<Tuple<T1, T2, T3>> source)
    {
        var data = new TheoryData<T1, T2, T3>();
        foreach (var item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3);

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
    
    public static TheoryData<T1, T2, T3, T4> ToTheoryData<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3, T4>> source)
    {
        var data = new TheoryData<T1, T2, T3, T4>();
        foreach (var item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4);

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
    
    public static TheoryData<T1, T2, T3, T4, T5> ToTheoryData<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5>();
        foreach (var item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5);

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
        <T1, T2, T3, T4, T5, T6>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6>();
        foreach (var item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5,
                     item.Item6);

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
        <T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7>();
        foreach (var item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5,
                     item.Item6,
                     item.Item7);

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
        <T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8>();
        foreach (var item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5,
                     item.Item6,
                     item.Item7,
                     item.Rest.Item1);

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
        <T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        foreach (var item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5,
                     item.Item6,
                     item.Item7,
                     item.Rest.Item1,
                     item.Rest.Item2);

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
        <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> source)
    {
        var data = new TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        foreach (var item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3,
                     item.Item4,
                     item.Item5,
                     item.Item6,
                     item.Item7,
                     item.Rest.Item1,
                     item.Rest.Item2,
                     item.Rest.Item3);

        return data;
    }
}