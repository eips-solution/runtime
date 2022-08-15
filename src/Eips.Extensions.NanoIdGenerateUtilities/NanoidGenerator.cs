/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Configuration;
using Niacomsoft.Eips.Options;

namespace Niacomsoft.Eips.Extensions
{
    /// <summary>
    /// 提供了生成 NanoId 相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IIDGenerateUtilities{T}" />
    /// <seealso cref="IStringifyIDGenerateUtilities" />
    /// <seealso cref="Nanoid" href="https://www.nuget.org/packages/Nanoid" />
    public sealed class NanoidGenerator : IStringifyIDGenerateUtilities
    {
        private readonly IObservableOptionsBroker<NanoIdOptions> m_configuration;

        private readonly NanoIdOptions m_options;

        /// <summary> 用于初始化一个 <see cref="NanoidGenerator" /> 类型的对象实例。 </summary>
        /// <param name="configuration">
        /// 实现了 <see cref="IObservableOptionsBroker{TOptions}" /> 类型接口的对象实例。
        /// </param>
        public NanoidGenerator(IObservableOptionsBroker<NanoIdOptions> configuration)
        {
            m_configuration = configuration;
            m_options = ParameterGuard.SafeGet(configuration?.Options.CurrentValue, () => new NanoIdOptions());
        }

        /// <summary> 产生一个新的 <see cref="string" /> 类型的 NanoId。 </summary>
        /// <param name="args"> 生成新的 ID 所需的扩展参数。 </param>
        /// <returns> <see cref="string" /> 类型的 NanoId。 </returns>
        public string NewId(params object[] args) => Nanoid.Nanoid.Generate(m_options.Alphabet, m_options.Size);
    }
}