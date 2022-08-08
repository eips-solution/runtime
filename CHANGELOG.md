# CHANGELOG
## [1.0.0-build.3](https://github.com/eips-solution/runtime/compare/v1.0.0-build.2...v1.0.0-build.3) (2022-08-08)


### BUG FIXED

* 调整了 XML 注释中的问题。 ([6352540](https://github.com/eips-solution/runtime/commit/6352540fb6aedd5e003549fc34145c644f9bea3e))


### NEW FEATURE

* 完成了数据实体属性接口定义。 ([60fb00d](https://github.com/eips-solution/runtime/commit/60fb00d8e268d9d809ecbfa3ac130a612c2cd649))
* 新增 Gender 数据库类型扩展 DbTypeExtensions.Gender。 ([351c800](https://github.com/eips-solution/runtime/commit/351c800c43efebe9b6e69bb18223954b954f3e76))
* 新增分页参数接口 IPagedParameter。 ([bb3e7f6](https://github.com/eips-solution/runtime/commit/bb3e7f61df4ebc0df39a45aa173dac56da111fee))
* 新增分页列表构建器 PagedListBuilder。 ([ddd96a3](https://github.com/eips-solution/runtime/commit/ddd96a326b65f85bf963e1b8d0f96029072b98ff))
* 新增分页列表集合相关的接口 IPagedList。 ([7cf1c33](https://github.com/eips-solution/runtime/commit/7cf1c3362ba3ccc7cdec18ba2fe77867a345542d))
* 新增了反向属性。 ([b59e066](https://github.com/eips-solution/runtime/commit/b59e066bb7903fa8ac29a6224e9825e72782c1fc))
* 新增数据结果 DbResult。 ([51b0666](https://github.com/eips-solution/runtime/commit/51b06661952e9c4f616e435fdb7894cab46ebf37))
* 新增数据库结果构建程序 DbResultBuilder。 ([fb9d20e](https://github.com/eips-solution/runtime/commit/fb9d20eecd75824ed0fd65635075607b243a431c))
* 新增数据库类型和 C# 类型值相关的扩展方法 DbTypeExtensions。 ([3f53eee](https://github.com/eips-solution/runtime/commit/3f53eee43bc38a7f61ff108017008532bd13f550))
* 新增数据库事务结果接口 IDbResult。 ([7981dc3](https://github.com/eips-solution/runtime/commit/7981dc34190ee99b51d79c78ee295b3d72b1c6bb))
* 新增数据排序相关的参数实体 ISortParameter。 ([1cc8afe](https://github.com/eips-solution/runtime/commit/1cc8afe979df24256fdb43aa17bcf6bb0f91ab14))
* 新增性别枚举类型 Gender。 ([252d6c5](https://github.com/eips-solution/runtime/commit/252d6c5d15e05fdf552f8ec77f0054cc4d1199b7))
* 新增一组标记接口。 ([c40c36e](https://github.com/eips-solution/runtime/commit/c40c36e0d01ca8246586db37ee2543d0062c1d8b))
* 新增一组数据实体标识接口。 ([df33044](https://github.com/eips-solution/runtime/commit/df3304405b737cdb3f09c78ab073e27f8b43adc1))
* 修改了 Defaults，增加了 MinimumPaginationIndex 和 DefaultPerPaginationSize 常量。 ([69fb999](https://github.com/eips-solution/runtime/commit/69fb9995e109ef510f0b3b28d3f25e05f531cb9a))


### CHORE

* 合并了 feature/1.0.0.1 。 ([a639e60](https://github.com/eips-solution/runtime/commit/a639e60d34f1405eb56bbbee1b9fde579dad4b55))
* 修改了 NuGet 版本号。 ([2915ecd](https://github.com/eips-solution/runtime/commit/2915ecdef772c8c5d175ce68d36f3ead017c69c1))
* 修改了 NuGet 版本号。 ([2319c2e](https://github.com/eips-solution/runtime/commit/2319c2e031d5e0d159d70b0da4581a4a14347703))

## [1.0.0-build.2](https://github.com/eips-solution/runtime/compare/v1.0.0-build.1...v1.0.0-build.2) (2022-08-06)


### CHORE

* 修改了 NuGet 版本号。 ([1f52a7e](https://github.com/eips-solution/runtime/commit/1f52a7e90f179421bf76dd1e19ae52a6ded21bcd))


### NEW FEATURE

* 新增 Int32HashFormatter。 ([98136e4](https://github.com/eips-solution/runtime/commit/98136e4da40e83779a7f607a872d86e707cd5999))
* 新增 Int64HashFormatter。 ([5745785](https://github.com/eips-solution/runtime/commit/57457858908e5d0b62219c6c1af3a6f692bb6749)), closes [#5](https://github.com/eips-solution/runtime/issues/5)
* 新增程序集注解实现 AssemblyAttributeHelper。 ([a35d4ca](https://github.com/eips-solution/runtime/commit/a35d4cacb6e414ac887993e485471fb7618eb7e4))
* 新增创建哈希格式 ID 加密密钥的接口 IHashIdCryptographyKeyProvider。 ([dad6c43](https://github.com/eips-solution/runtime/commit/dad6c437fa897c4ed0fa3bfc67bbc8b58f7ce3b3))
* 新增哈希数值接口 IHashIdFormatter。 ([92004f1](https://github.com/eips-solution/runtime/commit/92004f1c51e225c246e2498b5cf0d34298c0f09c))
* 新增核心实现项目。 ([a02b5f7](https://github.com/eips-solution/runtime/commit/a02b5f7ada8a9d5f5edde9e8fdf697902a1cb174))
* 新增获取成员注解信息的方法实现 MemberAttributeHelper。 ([4adf47f](https://github.com/eips-solution/runtime/commit/4adf47f7e194e0cfb6296b40fa5cca9fec4ab28d))
* 新增扩展接口 IStringifyIDGenerateUtilities 等。 ([85a9d89](https://github.com/eips-solution/runtime/commit/85a9d89308c5f2445449f4912892181e41137981))
* 新增配置服务接口和基类 IConfigurationBroker。 ([e7731ee](https://github.com/eips-solution/runtime/commit/e7731ee1e804ba748febae36cdfff6959ddd6045))
* 新增配置选项标记接口 IConfigurableOptions。 ([3b5d50a](https://github.com/eips-solution/runtime/commit/3b5d50ab01f231eafd06a19c39b010420ecd63d1))
* 新增生成 ID 的工具方法 IIDGenerateUtilities。 ([7f2313c](https://github.com/eips-solution/runtime/commit/7f2313c94f6c33cc87b929a086a4ce2cc1dba499))
* 新增数值哈希格式化方法基类 HashIdFormatter。 ([05b8bb6](https://github.com/eips-solution/runtime/commit/05b8bb6adaaabecd6e5592f4642311cf06e2beca))
* 新增异步的注解助手接口 IAsyncAttributeHelper。 ([5402f6a](https://github.com/eips-solution/runtime/commit/5402f6a1c6e573cab93d95cd6781bf9ed810cdd2))
* 新增注解助手抽象类 AttributeHelper.cs 和 AsyncAttributeHelper.cs。 ([2be82b2](https://github.com/eips-solution/runtime/commit/2be82b21d19ff3eb6b02ee602f7e9cc948d62421))
* 新增注解助手接口 IAttributeHelper。 ([c7759db](https://github.com/eips-solution/runtime/commit/c7759db92b8cb9a8cba5c5e8883478097052d09a))
* 新增组合式 API 入口接口 IFluentInterface。 ([598f772](https://github.com/eips-solution/runtime/commit/598f772053c0a54b7e421980d8decd96f4f3e3be))

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
