/* *************************************************************************************************************************************** *\
 * COPYRIGHT ? 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips.Diagnostics
{
    /// <summary> 提供了构建 <see cref="TraceInformation" /> 类型的对象实例相关的方法。 </summary>
    public class TraceInformationBuilder
    {
        private string _message;
        private string _methodName;
        private Type _target;

        /// <summary> 重置所有字段。 </summary>
        protected virtual void InternalReset()
        {
            _message = default;
            _methodName = default;
            _target = default;
        }

        /// <summary> 用于初始化一个 <see cref="TraceInformationBuilder" /> 类型的对象实例。 </summary>
        public TraceInformationBuilder() => InternalReset();

        /// <summary> 构建 <see cref="TraceInformation" /> 类型的对象实例。 </summary>
        /// <returns> 派生自 <see cref="TraceInformation" /> 类型的对象实例。 </returns>
        /// <seealso cref="TraceInformation" />
        public virtual TraceInformation Build() => new TraceInformation(_target, _methodName, _message);

        /// <summary> 重置 <see cref="TraceInformationBuilder" />。 </summary>
        /// <returns> <see cref="TraceInformationBuilder" /> 类型的对象实例。 </returns>
        public virtual TraceInformationBuilder Reset()
        {
            InternalReset();

            return this;
        }

        /// <summary> 设置调试消息。 </summary>
        /// <param name="message"> 调试消息。 </param>
        /// <returns> <see cref="TraceInformationBuilder" /> 类型的对象实例。 </returns>
        public virtual TraceInformationBuilder WithMessage(string message)
        {
            _message = message;
            return this;
        }

        /// <summary> 设置需要调试的方法名称。 </summary>
        /// <param name="method"> 方法名称。 </param>
        /// <returns> <see cref="TraceInformationBuilder" /> 类型的对象实例。 </returns>
        public virtual TraceInformationBuilder WithMethod(string method)
        {
            _methodName = method;
            return this;
        }

        /// <summary> 设置需要调试的目标类型。 </summary>
        /// <param name="target">
        /// 需要调试的目标类型。
        /// <para> <see cref="Type" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> <see cref="TraceInformationBuilder" /> 类型的对象实例。 </returns>
        public virtual TraceInformationBuilder WithTarget(Type target)
        {
            _target = target;
            return this;
        }

        /// <summary> 设置需要调试的目标类型。 </summary>
        /// <typeparam name="TTarget"> 需要调试的目标类型。 </typeparam>
        /// <returns> <see cref="TraceInformationBuilder" /> 类型的对象实例。 </returns>
        public virtual TraceInformationBuilder WithTarget<TTarget>() => WithTarget(typeof(TTarget));
    }
}