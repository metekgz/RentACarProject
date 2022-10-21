using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            // validatorun instancesini oluştur
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            // validatorun çalışma tipini bul (base typeını bul ve onun generic yapısını bul)
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            // methodun parametrelerine bak validatorun tipine eşit olan parametreleri bul
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            // her birini gez ve validation toolu kullanarak validate et
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
