using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCounter.Tests
{
    class InlineTestData
    {
        public const string StrToTestWithoutDublicates = "abcd efgh";
        public const string ExpectedWithoutDublicates = "a:1, b:1, c:1, d:1, e:1, f:1, g:1, h:1";

        public const string StrToTestWithDublicates = "Test";
        public const string ExpectedWithDublicates = "t:2, e:1, s:1";

        public const string StrToTestWithOtherChars = "a1bcd efgth";
        public const string ExpectedWithOtherChars = "a:1, b:1, c:1, d:1, e:1, f:1, g:1, t:1, h:1";
    }
}
