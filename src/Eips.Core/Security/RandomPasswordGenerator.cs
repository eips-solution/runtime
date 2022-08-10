/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Security
{
    /// <summary>
    /// 提供了生成随机密码相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IPasswordGenerateUtilities" />
    public sealed class RandomPasswordGenerator : IPasswordGenerateUtilities
    {
        /// <summary> 用于初始化一个 <see cref="RandomPasswordGenerator" /> 类型的对象实例。 </summary>
        /// <seealso cref="Defaults" />
        /// <seealso cref="Defaults.DefaultPasswordAlphabet" />
        public RandomPasswordGenerator() : this(Defaults.DefaultPasswordAlphabet)
        {
        }

        /// <summary> 用于初始化一个 <see cref="RandomPasswordGenerator" /> 类型的对象实例。 </summary>
        /// <param name="alphabet"> 随机密码字母表。 </param>
        /// <exception cref="IncorrectPasswordAlphabetLengthException">
        /// 当 <paramref name="alphabet" /> 长度小于 8 时，将引发此类型的异常。
        /// </exception>
        public RandomPasswordGenerator(string alphabet)
        {
            Alphabet = ParameterGuard.SafeGet(alphabet, Defaults.DefaultPasswordAlphabet, EmptyCompareOptions.IncludeWhiteSpace);
            if (alphabet.Length < 0x8)
                throw new IncorrectPasswordAlphabetLengthException();
        }

        /// <summary> 生成密码的字母表。 </summary>
        /// <value> 设置或获取一个字符串，用于表示生成密码的字母表。 </value>
        public string Alphabet { get; set; }

        /// <summary> 创建新的密码 </summary>
        /// <param name="size"> 密码长度。 </param>
        /// <returns> 新的随机密码。 </returns>
        public string CreateNew(int size = 8)
        {
            throw new System.NotImplementedException();
        }
    }
}