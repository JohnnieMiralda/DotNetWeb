using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetWeb.Core
{
    public class Type : IEquatable<Type>
    {
        public string Lexeme { get; private set; }

        public TokenType TokenType { get; private set; }
        public Type(string lexeme, TokenType tokenType)
        {
            Lexeme = lexeme;
            TokenType = tokenType;
        }
        public static Type Init => new Type("init", TokenType.InitKeyword);
        public static Type Bool => new Type("bool", TokenType.Bool);
        public static Type Int => new Type("int", TokenType.IntKeyword);
        public static Type Float => new Type("float", TokenType.FloatKeyword);
        public static Type String => new Type("string", TokenType.StringKeyword);
        public static Type IntList => new Type("intlist", TokenType.IntListKeyword);
        public static Type FloatList => new Type("floatlist", TokenType.FloatListKeyword);
        public static Type StringList => new Type("stringlist", TokenType.StringListKeyword);
        public static Type If => new Type("if", TokenType.IfKeyword);
        public static Type Endif => new Type("endif", TokenType.EndIfKeyword);
        public static Type Foreach => new Type("foreach", TokenType.ForEeachKeyword);
        public static Type Endforeach => new Type("endforeach", TokenType.EndForEachKeyword);




        public bool Equals(Type other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Lexeme == other.Lexeme && TokenType == other.TokenType;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Type)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Lexeme, (int)TokenType);
        }

        public static bool operator ==(Type a, Type b) => a.Equals(b);

        public static bool operator !=(Type a, Type b) => !a.Equals(b);
        public static bool operator >(Type a, Type b) => a>b;
        public static bool operator <(Type a, Type b) => a<b;


        public override string ToString()
        {
            return Lexeme;
        }
    }
}
