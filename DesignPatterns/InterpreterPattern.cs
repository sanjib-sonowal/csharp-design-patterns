using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     * Let's say you're developing a simple language for evaluating mathematical expressions. 
     * The language can handle basic operations like addition and subtraction. The Interpreter pattern allows 
     * you to define a grammar for these expressions and evaluate them.
    */

    /*Explanation:
     * Abstract Expression (IExpression):
     * This interface declares the Interpret method, which is implemented by all concrete expression classes.
     * 
     * Terminal Expression (NumberExpression):
     * This class represents a number in the expression. It directly returns the number when Interpret is called.
     * 
     * Nonterminal Expression (AddExpression, SubtractExpression):
     * These classes represent operations in the expression (addition and subtraction).
     * They take two expressions (left and right) as arguments and perform the operation when Interpret is called.
     * 
     * Client (Program):
     * The client code builds a complex expression tree using the NumberExpression, AddExpression, and SubtractExpression.
     * It then interprets the expression to calculate the result.
    */

    // Abstract Expression
    interface IExpression
    {
        int Interpret();
    }

    // Terminal Expression for numbers
    class NumberExpression : IExpression
    {
        private int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public int Interpret()
        {
            return _number;
        }
    }

    // Nonterminal Expression for addition
    class AddExpression : IExpression
    {
        private IExpression _leftExpression;
        private IExpression _rightExpression;

        public AddExpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return _leftExpression.Interpret() + _rightExpression.Interpret();
        }
    }

    // Nonterminal Expression for subtraction
    class SubtractExpression : IExpression
    {
        private IExpression _leftExpression;
        private IExpression _rightExpression;

        public SubtractExpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return _leftExpression.Interpret() - _rightExpression.Interpret();
        }
    }

}
