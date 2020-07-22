using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace MultiBracketValidationTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("{}(){}	")]
        [InlineData("()[[Extra Characters]]	")]
        [InlineData("(){}[[]]	")]
        [InlineData("{}{Code}[Fellows](())	")]

        public void HappyPathSuccessful(string input)
        {
            bool result = MultiBracketValidator(input);
            Assert.True(result);
        }
    }
}
