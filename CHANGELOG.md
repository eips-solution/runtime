# CHANGELOG
## [1.0.0-build.7](https://github.com/eips-solution/runtime/compare/v1.0.0-build.6...v1.0.0-build.7) (2022-08-16)


### NEW FEATURE

* 新增创建异步哈希算法工厂方法。 ([4e45604](https://github.com/eips-solution/runtime/commit/4e45604c28dda86737e189c607f6a000c7e7eadc))
* 新增依赖注入项目。 ([2e1ba9b](https://github.com/eips-solution/runtime/commit/2e1ba9b41b236fdc30b21d7050f906105946bf25))
* 新增运行时服务注册扩展服务 RuntimeServicesCollectionExtensions。 ([e492d47](https://github.com/eips-solution/runtime/commit/e492d47baa386a2682c0867eb34e234059e5adab))
* 新增组合式 API 接口 IFluentInterface。 ([1079ce1](https://github.com/eips-solution/runtime/commit/1079ce1f6d783de263f8d7e277f2843834aa7bdd))
* 新增组合式 API 实现 FluentInterface。 ([9106442](https://github.com/eips-solution/runtime/commit/910644218083d9bbc6fe1000729a1a1b76196b0f))
* 修改了 RuntimeServicesCollectionExtensions，增加了 ConfigureRuntimeConfigurationOptions 方法。 ([da4ba18](https://github.com/eips-solution/runtime/commit/da4ba18cfb36a7aa92d75185e933154694696b54))

## [1.0.0-build.6](https://github.com/eips-solution/runtime/compare/v1.0.0-build.5...v1.0.0-build.6) (2022-08-15)


### DOCUMENTATION

* 修改了项目自述文档。 ([a0585fe](https://github.com/eips-solution/runtime/commit/a0585fe0b2eb57f83442ff88c5a1fd0ba131c99c))


### NEW FEATURE

* 完成了 NanoId 生成工具。 ([8a57774](https://github.com/eips-solution/runtime/commit/8a57774167edf19aab9c8cd7dbb6677b03dc2ea4))
* 完成了配置选项类库。 ([d4f6dbe](https://github.com/eips-solution/runtime/commit/d4f6dbe990367ef323b8beced18d3fd380e3706d)), closes [#11](https://github.com/eips-solution/runtime/issues/11) [#12](https://github.com/eips-solution/runtime/issues/12)
* 新增 NanoId 配置选项 NanoIdOptions。 ([80ae915](https://github.com/eips-solution/runtime/commit/80ae915f84135389a619d88f51e4bd1b6e8f9907))
* 新增 NanoId 生成程序 NanoidGenerator。 ([6d6d988](https://github.com/eips-solution/runtime/commit/6d6d9886362fc9d71c56be8703653d83a1983825)), closes [#13](https://github.com/eips-solution/runtime/issues/13)
* 新增配置抽象项目 Eips.Configuration.Abstractions.csproj。 ([7a010e1](https://github.com/eips-solution/runtime/commit/7a010e1cc840afb186b91854147bf4d9a22358b3))
* 新增配置选项架构设计 EipsConfigurationOptions-Schema.json。 ([f701120](https://github.com/eips-solution/runtime/commit/f7011208157927a7e068b54ffa921f82bf9b880d))
* 新增适用于 .NET Standard、.NET Core、.NET vNext 的配置实现 OptionsBroker 和 ObservableOptionsBroker。 ([bbfcf22](https://github.com/eips-solution/runtime/commit/bbfcf2260e0739011560034d3385665493702739))

## [1.0.0-build.5](https://github.com/eips-solution/runtime/compare/v1.0.0-build.4...v1.0.0-build.5) (2022-08-13)


### CODE STYLE

* 修改了接口 IAsyncSerializer 和 ISerializer 中错误的参数命名。 ([7d004fc](https://github.com/eips-solution/runtime/commit/7d004fcfd3c092024e43820881afd9ae74848cb6))


### REFACTOR

* 修改了 JsonSerializerProperties 和 XmlSerializerProperties 命名空间。 ([838ef46](https://github.com/eips-solution/runtime/commit/838ef468fc0837fec1ae41de5751a840934f23ce))


### DOCUMENTATION

* 新增 NuGet 包依赖说明 PackageReferences.md。 ([8a1b4c3](https://github.com/eips-solution/runtime/commit/8a1b4c3f777f27ba85e1c0f6528e27f34a539941))


### NEW FEATURE

* 为 JsonSerializerExtensions 增加异步方法实现 JsonSerializerExtensions.Async.cs。 ([15949c2](https://github.com/eips-solution/runtime/commit/15949c2cbc7a1d48af4202f29c5a8960c2ebec06))
* 新增 JSON 序列化程序 JsonSerializer。 ([3c087d7](https://github.com/eips-solution/runtime/commit/3c087d779610f9692c81aed2e28a9511d6beb244))
* 新增 JSON 序列化扩展方法基类 JsonSerializerExtensions。 ([773db68](https://github.com/eips-solution/runtime/commit/773db68c6a7e26fbc49a3f028e46b5bf6a658354))
* 新增 JSON 序列化扩展方法异步接口 IAsyncJsonSerializerExtensions。 ([858726f](https://github.com/eips-solution/runtime/commit/858726fb7567dc43f2d1b6622d14ef1af233757e))
* 新增 Json 序列化扩展接口 IJsonSerializerExtensions。 ([5325064](https://github.com/eips-solution/runtime/commit/532506498212cc2a539d53c39c77950e7c735720))
* 新增 Newtonsoft.Json 序列化默认设置 DefaultJsonSerializerSettings。 ([92457b4](https://github.com/eips-solution/runtime/commit/92457b4fca6719067648fbf00d9a4697e91f4dca))
* 新增 Serializer 的异步方法实现 Serializer.Async。 ([d568dfc](https://github.com/eips-solution/runtime/commit/d568dfcd36b7ba915465a7b47f157b01ccc22f5a))
* 新增 XML 序列化程序 XmlSerializer。 ([642d03a](https://github.com/eips-solution/runtime/commit/642d03a7b69a277c0cbcc6a35aa87015c2af9f16))
* 新增二进制序列化 BinarySerializer。 ([4358013](https://github.com/eips-solution/runtime/commit/43580130a65da066591814bc3bc70a9169995296))
* 新增数据序列化基类 Serializer。 ([769680c](https://github.com/eips-solution/runtime/commit/769680c2f2e9351c30c0d7886e35508f2460fbc8))
* 新增序列化同步方法接口定义 ISerializer。 ([20c57fc](https://github.com/eips-solution/runtime/commit/20c57fcc6e27599afb39e0f42a28594e40e701fa))
* 新增异步序列化接口 IAsyncSerializer。 ([6bf0f41](https://github.com/eips-solution/runtime/commit/6bf0f4120a1e14e40f10ebbbdf7c440208297fcc))


### CHORE

* 修改了 ISerializer 和 IAsyncSerializer 接口的方法注释。 ([7708cfd](https://github.com/eips-solution/runtime/commit/7708cfd680022db51ffd4f8a721a9438de4b39c5))
* 修改了 NuGet 版本号。 ([8cf8851](https://github.com/eips-solution/runtime/commit/8cf8851360010155459251953c101f200f142d40))

## [1.0.0-build.4](https://github.com/eips-solution/runtime/compare/v1.0.0-build.3...v1.0.0-build.4) (2022-08-11)


### CODE STYLE

* 调整了命名。 ([d45f0fe](https://github.com/eips-solution/runtime/commit/d45f0fe63c16a6c672fe8cf9e39849dd9d021478))


### REFACTOR

* 调整了 ConstantStringResolver 为非 Sealed 。 ([02eb656](https://github.com/eips-solution/runtime/commit/02eb6561cc4a91a28c670f1f9352d69acd373b3c))
* 接口 IHashAlgorithm 重命名为 IHashAlgorithms。 ([9923dc4](https://github.com/eips-solution/runtime/commit/9923dc40c9b52a3cf7a6e63fd1a52da0eb5f40f3))


### BUG FIXED

* 删除了无用的接口定义 IStringResolver。 ([ac97005](https://github.com/eips-solution/runtime/commit/ac970053e69ac41688ca1b83a4c660201dec9236))


### NEW FEATURE

* 完成了对称加密算法的同步方法 SymmetricAlgorithms。 ([17a7d73](https://github.com/eips-solution/runtime/commit/17a7d730599e6131300fd0a7dd31faf6ffc47545))
* 完成了密码生成工具 RandomPasswordGenerator。 ([cc368e6](https://github.com/eips-solution/runtime/commit/cc368e6ed0790037cb7cb48e67a0fd3f2af43afe))
* 为 SymmetricAlgorithms 增加异步方法实现。 ([8065024](https://github.com/eips-solution/runtime/commit/8065024d4aff43eb9185cf901ff62db8743b41b3))
* 新增 AES 对称加密算法。 ([1dd2882](https://github.com/eips-solution/runtime/commit/1dd28825931a381889b00276ae1bb3f385600e08)), closes [#10](https://github.com/eips-solution/runtime/issues/10)
* 新增 AES 算法密钥接口 IAESCryptographicKey。 ([42405dc](https://github.com/eips-solution/runtime/commit/42405dcb2f09bfb0d54dd6a6a3141cfaa0625a0b))
* 新增 DES 对称加密算法 DESAlgorithmsProvider。 ([b23425d](https://github.com/eips-solution/runtime/commit/b23425dcb316ffd1af849c0b2ed1e602a419155c))
* 新增 DES 算法密钥生成方法 DESCryptographicKey。 ([27e3e60](https://github.com/eips-solution/runtime/commit/27e3e6064000ec0b77bce70eda885aeddacf9375))
* 新增 HashAlgorithms.Async.cs，为 HashAlgorithms 添加异步方法。 ([61f3112](https://github.com/eips-solution/runtime/commit/61f31122955aa99085474ddb0047dddee34e15a7))
* 新增 Json 序列化属性名称常量类 JsonSerializerProperties。 ([cfad999](https://github.com/eips-solution/runtime/commit/cfad99923cc70b2f176b5886578e1fa0efe7c6b7))
* 新增 MD5 哈希算法 MD5AlgorithmsProvider。 ([4a54675](https://github.com/eips-solution/runtime/commit/4a5467585897f2f8e30bca11e8305172e93949e8))
* 新增 XML 序列化属性常量 XmlSerializerProperties。 ([641c493](https://github.com/eips-solution/runtime/commit/641c4930d5479a9be4f33b54a5bd0d4a7ab8c9e6))
* 新增对称加密接口 ISymmetricAlgorithms & IAsyncSymmetricAlgorithms。 ([663abc8](https://github.com/eips-solution/runtime/commit/663abc88711e7d389cb75a4ea6f14d8bcd22ac8e))
* 新增对称加密密钥接口 ISymmetricCryptographicKey。 ([079a580](https://github.com/eips-solution/runtime/commit/079a580544aca3dfd076909c2a00d399e157f20c))
* 新增访问环境变量的方法 EnvironmentVariableAccessor。 ([1d7d7fc](https://github.com/eips-solution/runtime/commit/1d7d7fcac27715a3591149bb29771bc1b94e6aa6)), closes [#6](https://github.com/eips-solution/runtime/issues/6)
* 新增访问环境变量信息的接口 IEnvironmentVariableAccessor 和 IAsyncEnvironmentVariableAccessor。 ([f31960c](https://github.com/eips-solution/runtime/commit/f31960ca0a0ae4bd017f5fb9df7cee80ce59b5f3))
* 新增哈希算法工厂接口 IHashAlgorithmsFactory。 ([f18f21e](https://github.com/eips-solution/runtime/commit/f18f21ebdba3f3c790db6b0c8f22e9af7102de7e))
* 新增哈希算法工厂类 HashAlgorithmsFactory。 ([396e0a2](https://github.com/eips-solution/runtime/commit/396e0a227f666eb2728a6b68bf23be32a6b63a6f))
* 新增哈希算法基类 HashAlgorithms。 ([d5a8bfb](https://github.com/eips-solution/runtime/commit/d5a8bfb18e6d7b78b5fde23c315174a710b59703))
* 新增哈希算法接口 IHashAlgorithm。 ([52b478b](https://github.com/eips-solution/runtime/commit/52b478baf4dd2317bed9b3a3c957633622d5f298))
* 新增哈希算法接口 IHashAlgorithms & IAsyncHashAlgorithms。 ([c04b47b](https://github.com/eips-solution/runtime/commit/c04b47b26f30d6df0fce3af21d6bbc82d73e8e57))
* 新增哈希算法枚举类型 SupportedHashAlgorithms。 ([8bc68f2](https://github.com/eips-solution/runtime/commit/8bc68f2488d5ac9f6e50179302b722a7b51b8094))
* 新增环境变量接口 IEnvironmentVariable。 ([7f9f618](https://github.com/eips-solution/runtime/commit/7f9f6185a6d7332aaee8658c2e08e172391acb61))
* 新增环境信息类 EnvironmentVariable。 ([aa688af](https://github.com/eips-solution/runtime/commit/aa688afbfd248b61aad9f358a469e5cf279bda96))
* 新增基础身份认证凭据 BasicCredentials。 ([8b09774](https://github.com/eips-solution/runtime/commit/8b09774a19d4e0ae8bf09b4efaedacf6d93205f2))
* 新增加密算法基类 CryptographicAlgorithms。 ([a8dd9de](https://github.com/eips-solution/runtime/commit/a8dd9de15c6e8299e63916f767f87afd178b197d))
* 新增解析字符串的接口 IStringResolver。 ([cce48ef](https://github.com/eips-solution/runtime/commit/cce48ef83afe2ea138697a1988f24ede673e393f))
* 新增密码生成接口 IPasswordGenerateUtilities。 ([78710b0](https://github.com/eips-solution/runtime/commit/78710b0e423c5688b699bf267c56f10772dd3576))
* 新增内置的身份信息点名称 ClaimsName。 ([0a2e27d](https://github.com/eips-solution/runtime/commit/0a2e27d996e2f72d6ec03ae92a1864abdc68c44e)), closes [#7](https://github.com/eips-solution/runtime/issues/7)
* 新增身份认证失败原因枚举类型 AuthenticationFailureReason。 ([16b0ae8](https://github.com/eips-solution/runtime/commit/16b0ae8515a99a43b832653346f38c5fea50923a))
* 新增随机密码生成程序 RandomPasswordGenerator （未完） ([6e9f715](https://github.com/eips-solution/runtime/commit/6e9f71593da6d4cb64bf01712896255e37e3eb4a))
* 新增新的异常类型 IncorrectPasswordAlphabetLengthException。 ([2dd690a](https://github.com/eips-solution/runtime/commit/2dd690af186411892e49c2a1ff8de1d72650a861))
* 新增一组哈希算法 SHA1AlgorithmsProvider 等。 ([954e5d9](https://github.com/eips-solution/runtime/commit/954e5d93f40165bc00c6b0627f3fadcd9b4569a4))
* 修改了 CryptographicAlgorithms 类，新增 WriteToStream 方法。 ([d9c9b2f](https://github.com/eips-solution/runtime/commit/d9c9b2f8547aec0666b8e9c99639a8403c2c814a))
* 修改了 Defaults，增加了 DefaultPasswordAlphabet 常量字段。 ([f6fcd1d](https://github.com/eips-solution/runtime/commit/f6fcd1d537638e798d4e7754bc45de4465261f04))
* 修改了 DESCryptographicKey 的 InternalGetKeyString 方法，增加了 Substring 方法，用以保留 8 位字符串。 ([4cde244](https://github.com/eips-solution/runtime/commit/4cde244121fd47bea35a54180ebc4f2d2f7d2a95))
* 修改了 IEnvironmentVariable，增加了 Exists 属性。 ([54e6818](https://github.com/eips-solution/runtime/commit/54e681824046ad2869a464dd2884e5e4eee75cae))


### CHORE

* 开始编写新的 API。 ([eb935a0](https://github.com/eips-solution/runtime/commit/eb935a017942e64566851f7e651182da98acc6a2))
* 新增 Stream.Seek 方法的异常禁止。 ([15ca515](https://github.com/eips-solution/runtime/commit/15ca51510ad049508666bdf21bf6484f4c778653))
* 修改了 NuGet 版本号。 ([a352e6c](https://github.com/eips-solution/runtime/commit/a352e6cf0f3b90b787b8d9e09dfeb2d6a1ca9a55))

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
