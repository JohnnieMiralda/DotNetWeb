using DotNetWeb.Core.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetWeb.Core.Statements
{
    public class ForeachStatement : Statement
    {
        public ForeachStatement(TypedExpression expression, Statement statement)
        {
            Expression = expression;
            Statement = statement;
        }

        public TypedExpression Expression { get; }
        public Statement Statement { get; }

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
