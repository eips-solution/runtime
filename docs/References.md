# References

- 一次性构建所有的项目 _**(*.proj 文件的使用)**_
  - [Microsoft.Build.Traversal](https://github.com/microsoft/MSBuildSdks/blob/main/src/Traversal)
  - [Microsoft.Build.Traversal in .NET SDK](https://github.com/dotnet/runtime/blob/main/src/libraries/oob-all.proj)
  - Reference Documentations
    - [https://docs.microsoft.com/zh-cn/visualstudio/msbuild/errors/msb4236?view=vs-2022](/visualstudio/msbuild/errors/msb4236?view=vs-2022)
    - [https://docs.microsoft.com/zh-cn/dotnet/core/tools/global-json#msbuild-sdks](/dotnet/core/tools/global-json)

       ```xml
       <!--
         Microsoft.Build.Traversal 示例
       -->
       
       <Project Sdk="Microsoft.Build.Traversal/3.1.6">
           <ItemGroup>
               <ProjectReference Include="../**/*.csproj" />
           </ItemGroup>
       </Project>
       ```