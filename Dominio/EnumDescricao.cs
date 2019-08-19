using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcCrudPostgreSQL.Dominio
{
    public class EnumDescricao : Attribute
    {
        public string Value { get; private set; }

        public EnumDescricao(string value)
        {
            Value = value;
        }
    }
}
