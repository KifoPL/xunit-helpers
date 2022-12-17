namespace Xunit.Helpers;

/// <summary>
/// A helper class containing extension methods for converting <see cref="IEnumerable{T}"/> to <see cref="TheoryData"/>.
/// </summary>
public static class TheoryDataHelper
{
    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T">Type of items.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int&gt; data = new[] { 1, 2, 3 }.ToTheoryData();
    /// </code>
    /// </example>
    /// <remarks>
    /// If your source param is of type <c>IEnumerable&lt;object[]&gt;</c>,
    /// then you want to use <see cref="ToTheoryData{T}(System.Collections.Generic.IEnumerable{object[]})"/> overload instead. <br/>
    /// To use that, specify type params explicitly.
    /// </remarks>
    public static TheoryData<T> ToTheoryData<T>(this IEnumerable<T> source)
    {
        var data = new TheoryData<T>();
        foreach (T? item in source) data.Add(item);

        return data;
    }

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from 1st items from arrays in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T">Type of items.</typeparam>
    /// <returns>Theory data containing 1st items from arrays in <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int&gt; data = new[]
    /// {
    ///     new object[] { 1 },
    ///     new object[] { 2 },
    ///     new object[] { 3 }
    /// }
    /// .ToTheoryData&lt;int&gt;();
    /// </code>
    /// </example>
    /// <exception cref="InvalidCastException">1st item in at least one array is not of type <typeparamref name="T"/>.</exception>
    /// <exception cref="IndexOutOfRangeException">At least one of the arrays do not contain 1st element.</exception>
    public static TheoryData<T> ToTheoryData<T>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T>();
        foreach (object[] item in source) data.Add((T)item[0]);

        return data;
    }

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all 1st items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T">Type of items.</typeparam>
    /// <returns>Theory data containing all 1st items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int&gt; data = new[]
    /// {
    ///     Tuple.Create(1),
    ///     Tuple.Create(2),
    ///     Tuple.Create(3)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
    public static TheoryData<T> ToTheoryData<T>(this IEnumerable<Tuple<T>> source)
    {
        var data = new TheoryData<T>();
        foreach (var item in source) data.Add(item.Item1);

        return data;
    }
    
    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int&gt; data = new[]
    /// {
    ///     (1, 2),
    ///     (2, 3),
    ///     (3, 4)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
    public static TheoryData<T1, T2> ToTheoryData<T1, T2>(this IEnumerable<(T1, T2)> source)
    {
        var data = new TheoryData<T1, T2>();
        foreach ((T1, T2) item in source) data.Add(item.Item1, item.Item2);

        return data;
    }

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all 1st and 2nd items from object arrays in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in an array.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in an array.</typeparam>
    /// <returns>Theory data containing all 1st and 2nd items from object arrays from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int&gt; data = new[]
    /// {
    ///     new object[] { 1, 2 },
    ///     new object[] { 2, 3 },
    ///     new object[] { 3, 4 }
    /// }
    /// .ToTheoryData&lt;int, int&gt;();
    /// </code>
    /// </example>
    /// <exception cref="InvalidCastException">In at least one array, 1st item is not of type <typeparamref name="T1"/>,
    /// or 2nd item is not of type <typeparamref name="T2"/>.</exception>
    /// <exception cref="IndexOutOfRangeException">At least one of the arrays do not contain 2 elements.</exception>
    public static TheoryData<T1, T2> ToTheoryData<T1, T2>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T1, T2>();
        foreach (object[] item in source) data.Add((T1)item[0], (T2)item[1]);

        return data;
    }
    
    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int&gt; data = new[]
    /// {
    ///     Tuple.Create(1, 2),
    ///     Tuple.Create(2, 3),
    ///     Tuple.Create(3, 4)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
    public static TheoryData<T1, T2> ToTheoryData<T1, T2>(this IEnumerable<Tuple<T1, T2>> source)
    {
        var data = new TheoryData<T1, T2>();
        foreach (var item in source) data.Add(item.Item1, item.Item2);

        return data;
    }

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int&gt; data = new[]
    /// {
    ///     (1, 2, 3),
    ///     (2, 3, 4),
    ///     (3, 4, 5)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
    public static TheoryData<T1, T2, T3> ToTheoryData<T1, T2, T3>(this IEnumerable<(T1, T2, T3)> source)
    {
        var data = new TheoryData<T1, T2, T3>();
        foreach ((T1, T2, T3) item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3);

        return data;
    }

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all 1st, 2nd and 3rd items from object arrays in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in an array.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in an array.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in an array.</typeparam>
    /// <returns>Theory data containing all 1st, 2nd and 3rd items from object arrays from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int&gt; data = new[]
    /// {
    ///     new object[] { 1, 2, 3 },
    ///     new object[] { 2, 3, 4 },
    ///     new object[] { 3, 4, 5 }
    /// }
    /// .ToTheoryData&lt;int, int, int&gt;();
    /// </code>
    /// </example>
    /// <exception cref="InvalidCastException">In at least one array, 1st item is not of type <typeparamref name="T1"/>,
    /// or 2nd item is not of type <typeparamref name="T2"/>,
    /// or 3rd item is not of type <typeparamref name="T3"/>.</exception>
    /// <exception cref="IndexOutOfRangeException">At least one of the arrays do not contain 3 elements.</exception>
    public static TheoryData<T1, T2, T3> ToTheoryData<T1, T2, T3>(this IEnumerable<object[]> source)
    {
        var data = new TheoryData<T1, T2, T3>();
        foreach (object[] item in source)
            data.Add((T1)item[0],
                     (T2)item[1],
                     (T3)item[2]);

        return data;
    }
    
    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int&gt; data = new[]
    /// {
    ///     Tuple.Create(1, 2, 3),
    ///     Tuple.Create(2, 3, 4),
    ///     Tuple.Create(3, 4, 5)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
    public static TheoryData<T1, T2, T3> ToTheoryData<T1, T2, T3>(this IEnumerable<Tuple<T1, T2, T3>> source)
    {
        var data = new TheoryData<T1, T2, T3>();
        foreach (var item in source)
            data.Add(item.Item1,
                     item.Item2,
                     item.Item3);

        return data;
    }

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int&gt; data = new[]
    /// {
    ///     (1, 2, 3, 4),
    ///     (2, 3, 4, 5),
    ///     (3, 4, 5, 6)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all 1st, 2nd, 3rd and 4th items from object arrays in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in an array.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in an array.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in an array.</typeparam>
    /// <typeparam name="T4">Type of 4th item in an array.</typeparam>
    /// <returns>Theory data containing all 1st, 2nd, 3rd and 4th items from object arrays from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int&gt; data = new[]
    /// {
    ///     new object[] { 1, 2, 3, 4 },
    ///     new object[] { 2, 3, 4, 5 },
    ///     new object[] { 3, 4, 5, 6 }
    /// }
    /// .ToTheoryData&lt;int, int, int, int&gt;();
    /// </code>
    /// </example>
    /// <exception cref="InvalidCastException">In at least one array, 1st item is not of type <typeparamref name="T1"/>,
    /// or 2nd item is not of type <typeparamref name="T2"/>,
    /// or 3rd item is not of type <typeparamref name="T3"/>,
    /// or 4th item is not of type <typeparamref name="T4"/>.</exception>
    /// <exception cref="IndexOutOfRangeException">At least one of the arrays do not contain 4 elements.</exception>
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
    
    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int&gt; data = new[]
    /// {
    ///     Tuple.Create(1, 2, 3, 4),
    ///     Tuple.Create(2, 3, 4, 5),
    ///     Tuple.Create(3, 4, 5, 6)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int&gt; data = new[]
    /// {
    ///     (1, 2, 3, 4, 5),
    ///     (2, 3, 4, 5, 6),
    ///     (3, 4, 5, 6, 7)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all 1st, 2nd, 3rd, 4th and 5th items from object arrays in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in an array.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in an array.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in an array.</typeparam>
    /// <typeparam name="T4">Type of 4th item in an array.</typeparam>
    /// <typeparam name="T5">Type of 5th item in an array.</typeparam>
    /// <returns>Theory data containing all 1st, 2nd, 3rd, 4th and 5th items from object arrays from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int&gt; data = new[]
    /// {
    ///     new object[] { 1, 2, 3, 4, 5 },
    ///     new object[] { 2, 3, 4, 5, 6 },
    ///     new object[] { 3, 4, 5, 6, 7 }
    /// }
    /// .ToTheoryData&lt;int, int, int, int, int&gt;();
    /// </code>
    /// </example>
    /// <exception cref="InvalidCastException">In at least one array, 1st item is not of type <typeparamref name="T1"/>,
    /// or 2nd item is not of type <typeparamref name="T2"/>,
    /// or 3rd item is not of type <typeparamref name="T3"/>,
    /// or 4th item is not of type <typeparamref name="T4"/>,
    /// or 5th item is not of type <typeparamref name="T5"/>.</exception>
    /// <exception cref="IndexOutOfRangeException">At least one of the arrays do not contain 5 elements.</exception>
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
    
    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int&gt; data = new[]
    /// {
    ///     Tuple.Create(1, 2, 3, 4, 5),
    ///     Tuple.Create(2, 3, 4, 5, 6),
    ///     Tuple.Create(3, 4, 5, 6, 7)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <typeparam name="T6">Type of 6th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     (1, 2, 3, 4, 5, 6),
    ///     (2, 3, 4, 5, 6, 7),
    ///     (3, 4, 5, 6, 7, 8)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all 1st, 2nd, 3rd, 4th, 5th and 6th items from object arrays in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in an array.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in an array.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in an array.</typeparam>
    /// <typeparam name="T4">Type of 4th item in an array.</typeparam>
    /// <typeparam name="T5">Type of 5th item in an array.</typeparam>
    /// <typeparam name="T6">Type of 6th item in an array.</typeparam>
    /// <returns>Theory data containing all 1st, 2nd, 3rd, 4th, 5th and 6th items from object arrays from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     new object[] { 1, 2, 3, 4, 5, 6 },
    ///     new object[] { 2, 3, 4, 5, 6, 7 },
    ///     new object[] { 3, 4, 5, 6, 7, 8 }
    /// }
    /// .ToTheoryData&lt;int, int, int, int, int, int&gt;();
    /// </code>
    /// </example>
    /// <exception cref="InvalidCastException">In at least one array, 1st item is not of type <typeparamref name="T1"/>,
    /// or 2nd item is not of type <typeparamref name="T2"/>,
    /// or 3rd item is not of type <typeparamref name="T3"/>,
    /// or 4th item is not of type <typeparamref name="T4"/>,
    /// or 5th item is not of type <typeparamref name="T5"/>,
    /// or 6th item is not of type <typeparamref name="T6"/>.</exception>
    /// <exception cref="IndexOutOfRangeException">At least one of the arrays do not contain 6 elements.</exception>
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
    
    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <typeparam name="T6">Type of 6th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     Tuple.Create(1, 2, 3, 4, 5, 6),
    ///     Tuple.Create(2, 3, 4, 5, 6, 7),
    ///     Tuple.Create(3, 4, 5, 6, 7, 8)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <typeparam name="T6">Type of 6th item in a tuple.</typeparam>
    /// <typeparam name="T7">Type of 7th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     (1, 2, 3, 4, 5, 6, 7),
    ///     (2, 3, 4, 5, 6, 7, 8),
    ///     (3, 4, 5, 6, 7, 8, 9)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all 1st, 2nd, 3rd, 4th, 5th, 6th and 7th items from object arrays in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in an array.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in an array.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in an array.</typeparam>
    /// <typeparam name="T4">Type of 4th item in an array.</typeparam>
    /// <typeparam name="T5">Type of 5th item in an array.</typeparam>
    /// <typeparam name="T6">Type of 6th item in an array.</typeparam>
    /// <typeparam name="T7">Type of 7th item in an array.</typeparam>
    /// <returns>Theory data containing all 1st, 2nd, 3rd, 4th, 5th, 6th and 7th items from object arrays from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     new object[] { 1, 2, 3, 4, 5, 6, 7 },
    ///     new object[] { 2, 3, 4, 5, 6, 7, 8 },
    ///     new object[] { 3, 4, 5, 6, 7, 8, 9 }
    /// }
    /// .ToTheoryData&lt;int, int, int, int, int, int, int&gt;();
    /// </code>
    /// </example>
    /// <exception cref="InvalidCastException">In at least one array, 1st item is not of type <typeparamref name="T1"/>,
    /// or 2nd item is not of type <typeparamref name="T2"/>,
    /// or 3rd item is not of type <typeparamref name="T3"/>,
    /// or 4th item is not of type <typeparamref name="T4"/>,
    /// or 5th item is not of type <typeparamref name="T5"/>,
    /// or 6th item is not of type <typeparamref name="T6"/>,
    /// or 7th item is not of type <typeparamref name="T7"/>.</exception>
    /// <exception cref="IndexOutOfRangeException">At least one of the arrays do not contain 7 elements.</exception>
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
    
    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <typeparam name="T6">Type of 6th item in a tuple.</typeparam>
    /// <typeparam name="T7">Type of 7th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     Tuple.Create(1, 2, 3, 4, 5, 6, 7),
    ///     Tuple.Create(2, 3, 4, 5, 6, 7, 8),
    ///     Tuple.Create(3, 4, 5, 6, 7, 8, 9)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <typeparam name="T6">Type of 6th item in a tuple.</typeparam>
    /// <typeparam name="T7">Type of 7th item in a tuple.</typeparam>
    /// <typeparam name="T8">Type of 8th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     (1, 2, 3, 4, 5, 6, 7, 8),
    ///     (2, 3, 4, 5, 6, 7, 8, 9),
    ///     (3, 4, 5, 6, 7, 8, 9, 10)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all 1st, 2nd, 3rd, 4th, 5th, 6th, 7th and 8th items from object arrays in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in an array.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in an array.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in an array.</typeparam>
    /// <typeparam name="T4">Type of 4th item in an array.</typeparam>
    /// <typeparam name="T5">Type of 5th item in an array.</typeparam>
    /// <typeparam name="T6">Type of 6th item in an array.</typeparam>
    /// <typeparam name="T7">Type of 7th item in an array.</typeparam>
    /// <typeparam name="T8">Type of 8th item in an array.</typeparam>
    /// <returns>Theory data containing all 1st, 2nd, 3rd, 4th, 5th, 6th, 7th and 8th items from object arrays from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     new object[] { 1, 2, 3, 4, 5, 6, 7, 8 },
    ///     new object[] { 2, 3, 4, 5, 6, 7, 8, 9 },
    ///     new object[] { 3, 4, 5, 6, 7, 8, 9, 10 }
    /// }
    /// .ToTheoryData&lt;int, int, int, int, int, int, int, int&gt;();
    /// </code>
    /// </example>
    /// <exception cref="InvalidCastException">In at least one array, 1st item is not of type <typeparamref name="T1"/>,
    /// or 2nd item is not of type <typeparamref name="T2"/>,
    /// or 3rd item is not of type <typeparamref name="T3"/>,
    /// or 4th item is not of type <typeparamref name="T4"/>,
    /// or 5th item is not of type <typeparamref name="T5"/>,
    /// or 6th item is not of type <typeparamref name="T6"/>,
    /// or 7th item is not of type <typeparamref name="T7"/>,
    /// or 8th item is not of type <typeparamref name="T8"/>.</exception>
    /// <exception cref="IndexOutOfRangeException">At least one of the arrays do not contain 8 elements.</exception>
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
    
    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <typeparam name="T6">Type of 6th item in a tuple.</typeparam>
    /// <typeparam name="T7">Type of 7th item in a tuple.</typeparam>
    /// <typeparam name="T8">Type of 8th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8),
    ///     Tuple.Create(2, 3, 4, 5, 6, 7, 8, 9),
    ///     Tuple.Create(3, 4, 5, 6, 7, 8, 9, 10)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <typeparam name="T6">Type of 6th item in a tuple.</typeparam>
    /// <typeparam name="T7">Type of 7th item in a tuple.</typeparam>
    /// <typeparam name="T8">Type of 8th item in a tuple.</typeparam>
    /// <typeparam name="T9">Type of 9th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     (1, 2, 3, 4, 5, 6, 7, 8, 9),
    ///     (2, 3, 4, 5, 6, 7, 8, 9, 10),
    ///     (3, 4, 5, 6, 7, 8, 9, 10, 11)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all 1st, 2nd, 3rd, 4th, 5th, 6th, 7th, 8th and 9th items from object arrays in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in an array.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in an array.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in an array.</typeparam>
    /// <typeparam name="T4">Type of 4th item in an array.</typeparam>
    /// <typeparam name="T5">Type of 5th item in an array.</typeparam>
    /// <typeparam name="T6">Type of 6th item in an array.</typeparam>
    /// <typeparam name="T7">Type of 7th item in an array.</typeparam>
    /// <typeparam name="T8">Type of 8th item in an array.</typeparam>
    /// <typeparam name="T9">Type of 9th item in an array.</typeparam>
    /// <returns>Theory data containing all 1st, 2nd, 3rd, 4th, 5th, 6th, 7th, 8th and 9th items from object arrays from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
    ///     new object[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 },
    ///     new object[] { 3, 4, 5, 6, 7, 8, 9, 10, 11 }
    /// }
    /// .ToTheoryData&lt;int, int, int, int, int, int, int, int, int&gt;();
    /// </code>
    /// </example>
    /// <exception cref="InvalidCastException">In at least one array, 1st item is not of type <typeparamref name="T1"/>,
    /// or 2nd item is not of type <typeparamref name="T2"/>,
    /// or 3rd item is not of type <typeparamref name="T3"/>,
    /// or 4th item is not of type <typeparamref name="T4"/>,
    /// or 5th item is not of type <typeparamref name="T5"/>,
    /// or 6th item is not of type <typeparamref name="T6"/>,
    /// or 7th item is not of type <typeparamref name="T7"/>,
    /// or 8th item is not of type <typeparamref name="T8"/>,
    /// or 9th item is not of type <typeparamref name="T9"/>.</exception>
    /// <exception cref="IndexOutOfRangeException">At least one of the arrays do not contain 9 elements.</exception>
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
    
    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <typeparam name="T6">Type of 6th item in a tuple.</typeparam>
    /// <typeparam name="T7">Type of 7th item in a tuple.</typeparam>
    /// <typeparam name="T8">Type of 8th item in a tuple.</typeparam>
    /// <typeparam name="T9">Type of 9th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8, 9),
    ///     Tuple.Create(2, 3, 4, 5, 6, 7, 8, 9, 10),
    ///     Tuple.Create(3, 4, 5, 6, 7, 8, 9, 10, 11)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <typeparam name="T6">Type of 6th item in a tuple.</typeparam>
    /// <typeparam name="T7">Type of 7th item in a tuple.</typeparam>
    /// <typeparam name="T8">Type of 8th item in a tuple.</typeparam>
    /// <typeparam name="T9">Type of 9th item in a tuple.</typeparam>
    /// <typeparam name="T10">Type of 10th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     (1, 2, 3, 4, 5, 6, 7, 8, 9, 10),
    ///     (2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
    ///     (3, 4, 5, 6, 7, 8, 9, 10, 11, 12)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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

    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all 1st, 2nd, 3rd, 4th, 5th, 6th, 7th, 8th, 9th and 10th items from object arrays in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in an array.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in an array.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in an array.</typeparam>
    /// <typeparam name="T4">Type of 4th item in an array.</typeparam>
    /// <typeparam name="T5">Type of 5th item in an array.</typeparam>
    /// <typeparam name="T6">Type of 6th item in an array.</typeparam>
    /// <typeparam name="T7">Type of 7th item in an array.</typeparam>
    /// <typeparam name="T8">Type of 8th item in an array.</typeparam>
    /// <typeparam name="T9">Type of 9th item in an array.</typeparam>
    /// <typeparam name="T10">Type of 10th item in an array.</typeparam>
    /// <returns>Theory data containing all 1st, 2nd, 3rd, 4th, 5th, 6th, 7th, 8th, 9th and 10th items from object arrays from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
    ///     new object[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
    ///     new object[] { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }
    /// }
    /// .ToTheoryData&lt;int, int, int, int, int, int, int, int, int, int&gt;();
    /// </code>
    /// </example>
    /// <exception cref="InvalidCastException">In at least one array, 1st item is not of type <typeparamref name="T1"/>,
    /// or 2nd item is not of type <typeparamref name="T2"/>,
    /// or 3rd item is not of type <typeparamref name="T3"/>,
    /// or 4th item is not of type <typeparamref name="T4"/>,
    /// or 5th item is not of type <typeparamref name="T5"/>,
    /// or 6th item is not of type <typeparamref name="T6"/>,
    /// or 7th item is not of type <typeparamref name="T7"/>,
    /// or 8th item is not of type <typeparamref name="T8"/>,
    /// or 9th item is not of type <typeparamref name="T9"/>,
    /// or 10th item is not of type <typeparamref name="T10"/>.</exception>
    /// <exception cref="IndexOutOfRangeException">At least one of the arrays do not contain 10 elements.</exception>
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
    
    /// <summary>
    /// Creates a new <see cref="TheoryData"/> from all items in <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source enumerator.</param>
    /// <typeparam name="T1">Type of 1st item in a tuple.</typeparam>
    /// <typeparam name="T2">Type of 2nd item in a tuple.</typeparam>
    /// <typeparam name="T3">Type of 3rd item in a tuple.</typeparam>
    /// <typeparam name="T4">Type of 4th item in a tuple.</typeparam>
    /// <typeparam name="T5">Type of 5th item in a tuple.</typeparam>
    /// <typeparam name="T6">Type of 6th item in a tuple.</typeparam>
    /// <typeparam name="T7">Type of 7th item in a tuple.</typeparam>
    /// <typeparam name="T8">Type of 8th item in a tuple.</typeparam>
    /// <typeparam name="T9">Type of 9th item in a tuple.</typeparam>
    /// <typeparam name="T10">Type of 10th item in a tuple.</typeparam>
    /// <returns>Theory data containing all items from <paramref name="source"/>.</returns>
    /// <example>
    /// <code>
    /// TheoryData&lt;int, int, int, int, int, int, int, int, int, int&gt; data = new[]
    /// {
    ///     Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8, 9, 10),
    ///     Tuple.Create(2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
    ///     Tuple.Create(3, 4, 5, 6, 7, 8, 9, 10, 11, 12)
    /// }
    /// .ToTheoryData();
    /// </code>
    /// </example>
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