/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Diagnostics;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Niacomsoft.Eips.Globalization
{
    /// <summary> 提供了配置上下文文化区域相关的方法。 </summary>
    public class ContextCultureConfigurator
    {
        /// <summary>
        /// 用于初始化一个 <see cref="ContextCultureConfigurator" /> 类型的对象实例。
        /// </summary>
        private ContextCultureConfigurator()
        {
        }

        /// <summary> 设置应用程序域中线程默认文化区域。 </summary>
        /// <param name="lcid"> 文化区域标识。 </param>
        public static void SetDefaultThreadCurrentCulture(int lcid)
        {
#if NET45_OR_GREATER || NETCOREAPP || NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            if (ReferenceTypeEqualityComparer.None(CultureInfo.DefaultThreadCurrentCulture)
                || !ValueTypeComparer.Compare(CultureInfo.DefaultThreadCurrentCulture.LCID, lcid))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget<ContextCultureConfigurator>()
                                                             .WithMethod(nameof(SetDefaultThreadCurrentCulture))
                                                             .WithMessage($"当前应用程序域的线程默认文化区域变更为：{lcid}。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);
                CultureInfo.DefaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo(lcid);
            }
#endif
#if NET20 || NET30 || NET35 || NET40
            Debug.WriteLine(new TraceInformationBuilder().WithTarget<ContextCultureConfigurator>()
                                                         .WithMethod(nameof(SetDefaultThreadCurrentCulture))
                                                         .WithMessage($"您使用的是低版本 Microsoft .NET Framework，不支持 {nameof(CultureInfo)}.DefaultThreadCurrentCulture 属性。")
                                                         .Build(),
                            Defaults.DefaultDiagnosticCategory);
#endif
        }

        /// <summary> 设置应用程序域中线程默认文化区域。 </summary>
        /// <param name="supported">
        /// Enterprise InPrivate SaaS - EIPS 提供的文化区域信息。
        /// <para> <see cref="SupportedCultures" /> 类型的值。 </para>
        /// </param>
        /// <seealso cref="SupportedCultures" />
        public static void SetDefaultThreadCurrentCulture(SupportedCultures supported = SupportedCultures.Default)
            => SetDefaultThreadCurrentCulture((int)supported);

        /// <summary> 设置当前线程的文化区域信息。 </summary>
        /// <param name="lcid"> 文化区域标识。 </param>
        public static void SetThreadCurrentCulture(int lcid)
        {
            if (ReferenceTypeEqualityComparer.None(CultureInfo.CurrentCulture)
                || !ValueTypeComparer.Compare(CultureInfo.CurrentCulture.LCID, lcid))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget<ContextCultureConfigurator>()
                                                             .WithMethod(nameof(SetThreadCurrentCulture))
                                                             .WithMessage($"当前线程的文化区域将变更为：“{lcid}”。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);

                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lcid);
            }

            SetDefaultThreadCurrentCulture(lcid);
        }

        /// <summary> 设置当前线程的文化区域信息。 </summary>
        /// <param name="supported">
        /// Enterprise InPrivate SaaS - EIPS 提供的文化区域信息。
        /// <para> <see cref="SupportedCultures" /> 类型的值。 </para>
        /// </param>
        /// <seealso cref="SupportedCultures" />
        public static void SetThreadCurrentCulture(SupportedCultures supported = SupportedCultures.Default)
            => SetThreadCurrentCulture((int)supported);
    }
}