/* *************************************************************************************************************************************** *\
 * COPYRIGHT ? 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips.Diagnostics
{
    /// <summary> �ṩ�˹��� <see cref="TraceInformation" /> ���͵Ķ���ʵ����صķ����� </summary>
    public class TraceInformationBuilder
    {
        private string _message;
        private string _methodName;
        private Type _target;

        /// <summary> ���������ֶΡ� </summary>
        protected virtual void InternalReset()
        {
            _message = default;
            _methodName = default;
            _target = default;
        }

        /// <summary> ���ڳ�ʼ��һ�� <see cref="TraceInformationBuilder" /> ���͵Ķ���ʵ���� </summary>
        public TraceInformationBuilder() => InternalReset();

        /// <summary> ���� <see cref="TraceInformation" /> ���͵Ķ���ʵ���� </summary>
        /// <returns> ������ <see cref="TraceInformation" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="TraceInformation" />
        public virtual TraceInformation Build() => new TraceInformation(_target, _methodName, _message);

        /// <summary> ���� <see cref="TraceInformationBuilder" />�� </summary>
        /// <returns> <see cref="TraceInformationBuilder" /> ���͵Ķ���ʵ���� </returns>
        public virtual TraceInformationBuilder Reset()
        {
            InternalReset();

            return this;
        }

        /// <summary> ���õ�����Ϣ�� </summary>
        /// <param name="message"> ������Ϣ�� </param>
        /// <returns> <see cref="TraceInformationBuilder" /> ���͵Ķ���ʵ���� </returns>
        public virtual TraceInformationBuilder WithMessage(string message)
        {
            _message = message;
            return this;
        }

        /// <summary> ������Ҫ���Եķ������ơ� </summary>
        /// <param name="method"> �������ơ� </param>
        /// <returns> <see cref="TraceInformationBuilder" /> ���͵Ķ���ʵ���� </returns>
        public virtual TraceInformationBuilder WithMethod(string method)
        {
            _methodName = method;
            return this;
        }

        /// <summary> ������Ҫ���Ե�Ŀ�����͡� </summary>
        /// <param name="target">
        /// ��Ҫ���Ե�Ŀ�����͡�
        /// <para> <see cref="Type" /> ���͵Ķ���ʵ���� </para>
        /// </param>
        /// <returns> <see cref="TraceInformationBuilder" /> ���͵Ķ���ʵ���� </returns>
        public virtual TraceInformationBuilder WithTarget(Type target)
        {
            _target = target;
            return this;
        }

        /// <summary> ������Ҫ���Ե�Ŀ�����͡� </summary>
        /// <typeparam name="TTarget"> ��Ҫ���Ե�Ŀ�����͡� </typeparam>
        /// <returns> <see cref="TraceInformationBuilder" /> ���͵Ķ���ʵ���� </returns>
        public virtual TraceInformationBuilder WithTarget<TTarget>() => WithTarget(typeof(TTarget));
    }
}