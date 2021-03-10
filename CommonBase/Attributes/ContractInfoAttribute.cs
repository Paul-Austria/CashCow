//@BaseCode
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBase.Attributes
{
    [AttributeUsage(AttributeTargets.Interface)]
    public partial class ContractInfoAttribute : Attribute
    {
        public ContextType ContextType { get; set; } = ContextType.Table;
        public string SchemaName { get; set; }
        public string ContextName { get; set; }
        public string KeyName { get; set; }
        public string Description { get; set; }
    }
}