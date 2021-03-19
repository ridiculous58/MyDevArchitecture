using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Utilities.Interceptors
{
    public class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation,System.Exception exception) { }
        protected virtual void OnSuccess(IInvocation invocation) { }

        public override void Intercept(IInvocation invocation)
        {
            base.Intercept(invocation);
        }

    }
}
