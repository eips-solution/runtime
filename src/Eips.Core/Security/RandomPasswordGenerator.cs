/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.Text;

namespace Niacomsoft.Eips.Security
{
    /// <summary>
    /// 提供了生成随机密码相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IPasswordGenerateUtilities" />
    public sealed class RandomPasswordGenerator : IPasswordGenerateUtilities
    {
        private readonly char[] m_alphabet;
        private readonly int m_maxRandomNum;
        private readonly Random m_random = new Random(0);

        /// <summary> 打乱字母表数组顺序。 </summary>
        private void MessUpAlphabetOrder()
        {
            for (var i = 0; i < m_alphabet.Length; i++)
            {
                var randomIdx = m_random.Next(m_alphabet.Length);
                var currentChar = m_alphabet[i];
                m_alphabet[i] = m_alphabet[randomIdx];
                m_alphabet[randomIdx] = currentChar;
            }
        }

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
            m_maxRandomNum = (m_alphabet = Alphabet.ToCharArray()).Length;

            MessUpAlphabetOrder();
        }

        /// <summary> 生成密码的字母表。 </summary>
        /// <value> 设置或获取一个字符串，用于表示生成密码的字母表。 </value>
        public string Alphabet { get; set; }

        /// <summary> 创建新的密码 </summary>
        /// <param name="size"> 密码长度。 </param>
        /// <returns> 新的随机密码。 </returns>
        public string CreateNew(int size = 8)
        {
            var pwdBuilder = new StringBuilder();
            for (var i = 0; i < size; i++)
            {
                pwdBuilder.Append(m_alphabet[i % m_alphabet.Length]);
                MessUpAlphabetOrder();
            }

            return pwdBuilder.ToString();
        }
    }
}