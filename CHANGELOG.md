# CHANGELOG
## 1.0.0-build.1 (2022-08-04)


### CHORE

* 初始化项目。 ([b380068](https://github.com/eips-solution/runtime/commit/b380068eda9ce34a1c1c888d6cb76f79ac801dae))
* 调整了 StringEqualityComparer.IgnoreCaseEquals 方法的备注信息。 ([4574f5f](https://github.com/eips-solution/runtime/commit/4574f5f26b763b19ae817ef5a14ee6c60779e111))
* 新增 NPM 工具链。 ([95beb0f](https://github.com/eips-solution/runtime/commit/95beb0f252764ce46fe32030d25ddc1e51119ac3))
* 修改了 NuGet 版本号。 ([06a9f17](https://github.com/eips-solution/runtime/commit/06a9f17367554f2d6336b97c2ac9f2bf47146a30))
* 修改了 XML 注释。 ([375e0b2](https://github.com/eips-solution/runtime/commit/375e0b24fbb81743f24b7c4d456a0550b276b55a))


### CODE STYLE

* 修改了成员变量的命名。 ([4e82769](https://github.com/eips-solution/runtime/commit/4e8276941a2353aee733d157dc9c172a9c79768c))


### NEW FEATURE

* 调整了枚举类型 EmptyCompareOptions，增加了 OnlyNull 字段。 ([a44cf19](https://github.com/eips-solution/runtime/commit/a44cf19472a65e29d6b847bd265982f6b4390894))
* 解决方案重命名。 ([bbc70ea](https://github.com/eips-solution/runtime/commit/bbc70eab853fe4f51186a7e42e4efba49249554e))
* 新增 .NET6 System.DateOnly 类型扩展方法类 DateOnlyExtensions。 ([c483469](https://github.com/eips-solution/runtime/commit/c483469eabff526e050b21f987266e9fa877e525))
* 新增 ActivatorUtilities。 ([e33ab9f](https://github.com/eips-solution/runtime/commit/e33ab9f7f153a31d5935d6c3a41b8d6697e8091c))
* 新增 BASE-64 格式字符串工具类 StringUtilities.Base64.cs。 ([0eff939](https://github.com/eips-solution/runtime/commit/0eff9399ece97c76400917127813d60206cba351))
* 新增 Guid 相关的字符串工具 StringUtilities.Guid.cs。 ([c1c5bda](https://github.com/eips-solution/runtime/commit/c1c5bda9bc6bba829cc5d23c169e1b591aa6d7ac))
* 新增 ParameterGuard 类，用于守护方法参数。 ([46138d8](https://github.com/eips-solution/runtime/commit/46138d80d88ea6ad288d952a3668079cfd7f077d))
* 新增 ReferenceTypeEqualityComparer 比较工具类，并调整了 TraceInformation 类中部分对于 null 值的比较方法。 ([f040db2](https://github.com/eips-solution/runtime/commit/f040db288332031803758522ab0db65e4471bf97))
* 新增 TraceInformation 构建器 TraceInformationBuilder。 ([76f7068](https://github.com/eips-solution/runtime/commit/76f70688afbd1b9525cf290729817e5c5083e5a6))
* 新增 Visual Studio 解决方案。 ([07f6062](https://github.com/eips-solution/runtime/commit/07f60623a61793d870cf70b57f3b7375adf5d276))
* 新增调试追踪信息类 TraceInformation。 ([2c3f014](https://github.com/eips-solution/runtime/commit/2c3f01426e7657d83037730ab4bbb1f559d81086))
* 新增公共类库项目。 ([671698d](https://github.com/eips-solution/runtime/commit/671698df25e2a0fccad922ddf40cd55c8fae9625))
* 新增核心抽象项目。 ([f9dd4d5](https://github.com/eips-solution/runtime/commit/f9dd4d5259e9ca25781779299788bca4952cf293))
* 新增基于 Microsoft.Build.Traversal 构建的项目以及说明文档。 ([bdafd6f](https://github.com/eips-solution/runtime/commit/bdafd6fe4fb1321a9a55caeb5128c69062c87f74))
* 新增默认值类型。 ([586b04f](https://github.com/eips-solution/runtime/commit/586b04fb4f7225323248f677c1347ccc9cc3c37c))
* 新增全球化配置类 ContextCultureConfigurator。 ([8366650](https://github.com/eips-solution/runtime/commit/8366650065b7ddc85e8233d7065b1c4c010f2c98))
* 新增全球化支持类库 Eips.Globalization.Supported。 ([fabfa69](https://github.com/eips-solution/runtime/commit/fabfa69a555e6f0f4a3ea9d1e328f75f9b9a4942))
* 新增全球化支持资源字符串 Strings.resx 。 ([98e5193](https://github.com/eips-solution/runtime/commit/98e519317f50da14b78d4cf8a34e1c212c3e53ac)), closes [#3](https://github.com/eips-solution/runtime/issues/3)
* 新增日期时间对比结构体 DateTimeComparer。 ([fec6f01](https://github.com/eips-solution/runtime/commit/fec6f013a06daec22d1f140ca744bf21eb5bf093))
* 新增日期时间描述工具 DateTimeDescriptor。 ([224c7c0](https://github.com/eips-solution/runtime/commit/224c7c040da4ff5af4a61cdd69ed9e50257ddd8c))
* 新增日期时间字符串工具方法。 ([fba112f](https://github.com/eips-solution/runtime/commit/fba112fbe0bf985e37a3e1dcb6eb7a9a5f993477))
* 新增一组数值比较方法。 ([c9d89e4](https://github.com/eips-solution/runtime/commit/c9d89e465a5729c518118cdedcf7296c865bacdc))
* 新增一组与数值相关的字符串工具类。 ([2fe636b](https://github.com/eips-solution/runtime/commit/2fe636b680375aff0ca7e3ab098d571ff7804b4a))
* 新增异常 DynamicCreateObjectInstanceException。 ([066fe5e](https://github.com/eips-solution/runtime/commit/066fe5e964fb69296649523631cb606dd0a1ae2a))
* 新增应用模块设计文档 ApplicationBlocks.md。 ([cb98bbf](https://github.com/eips-solution/runtime/commit/cb98bbfad2504f9db734b37c603c50b7cdf9a50e)), closes [#1](https://github.com/eips-solution/runtime/issues/1)
* 新增字符串编码工具类 StringUtilities.Encoding.cs。 ([2eb0214](https://github.com/eips-solution/runtime/commit/2eb0214a02be88c1deb6a5e982d8de613e899b31))
* 新增字符串对比方法 StringEqualityComparer，并调整了 TraceInformation 中对于 string.IsNullOrWhiteSpace 的验证方法。 ([0c0a4e0](https://github.com/eips-solution/runtime/commit/0c0a4e0a9356b4489c300d077fc3a442e0853f30))
* 修改了程序集 Revision 版本号。 ([33ff6d3](https://github.com/eips-solution/runtime/commit/33ff6d3a0e365c77cd1e66ba9a903a618c89e344)), closes [#4](https://github.com/eips-solution/runtime/issues/4)
