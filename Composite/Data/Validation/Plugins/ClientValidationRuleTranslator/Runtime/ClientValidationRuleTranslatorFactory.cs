using Composite.Core.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;


namespace Composite.Data.Validation.Plugins.ClientValidationRuleTranslator.Runtime
{
    internal sealed class ClientValidationRuleTranslatorFactory : NameTypeFactoryBase<IClientValidationRuleTranslator>
	{
        public ClientValidationRuleTranslatorFactory()
            : base(ConfigurationServices.ConfigurationSource)
        {
        }
	}
}
