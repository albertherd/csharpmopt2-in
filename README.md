Exploring C# Micro Optimizations Part 2 – In Arguments

Follow the accompanying blog post here - https://albertherd.com/2019/06/20/c-micro-optimizations-part-1-ref-arguments/

Exploring overcoming the mutability issue presented using the ref keyword by using in parameter modifier with readonly structs

When accessing 2 properties in a struct, the performance difference between a ref method and an in method without having a read-only struct, performance is around 10 times slower.

<table>
<thead><tr><th>           Method</th><th>limit</th><th>Mean</th><th>Error</th><th>StdDev</th>
</tr>
</thead><tbody><tr><td>BenchmarkIncrementByRef</td><td>100000000</td><td>23.83 ms</td><td>0.0272 ms</td><td>0.0241 ms</td>
</tr><tr><td>BenchmarkIncrementByIn</td><td>100000000</td><td>238.21 ms</td><td>0.3108 ms</td><td>0.2755 ms</td>
</tr></tbody></table>

When switching the struct to read-only, the performance hit is not evident anymore 

<table>
<thead><tr><th>           Method</th><th>limit</th><th>Mean</th><th>Error</th><th>StdDev</th>
</tr>
</thead><tbody><tr><td>BenchmarkIncrementByRef</td><td>100000000</td><td>23.93 ms</td><td>0.1226 ms</td><td>0.1147 ms</td>
</tr><tr><td>BenchmarkIncrementByIn</td><td>100000000</td><td>24.06 ms</td><td>0.2183 ms</td><td>0.2042 ms</td>
</tr></tbody></table>
