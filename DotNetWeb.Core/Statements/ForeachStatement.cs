using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetWeb.Core.Statements
{
    public class ForeachStatement : Statement
    {
        public ForeachStatement(TypedExpression expression, Statement statement)
        {
        }

        public override string Generate()
        {
            throw new NotImplementedException();
        }

        public override void Interpret()
        {
            throw new NotImplementedException();
        }

        public override void ValidateSemantic()
        {
            throw new NotImplementedException();
        }
    }
}
