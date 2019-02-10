using Xunit;

namespace Rot13
{
    public class Tests
    {
        private enum Letters { a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z }
        
        [Theory]
        [InlineData(Letters.a, Letters.n)]
        [InlineData(Letters.b, Letters.o)]
        [InlineData(Letters.c, Letters.p)]
        [InlineData(Letters.d, Letters.q)]
        [InlineData(Letters.e, Letters.r)]
        [InlineData(Letters.f, Letters.s)]
        [InlineData(Letters.g, Letters.t)]
        [InlineData(Letters.h, Letters.u)]
        [InlineData(Letters.i, Letters.v)]
        [InlineData(Letters.j, Letters.w)]
        [InlineData(Letters.k, Letters.x)]
        [InlineData(Letters.l, Letters.y)]
        [InlineData(Letters.m, Letters.z)]
        [InlineData(Letters.n, Letters.a)]
        [InlineData(Letters.o, Letters.b)]
        [InlineData(Letters.p, Letters.c)]
        [InlineData(Letters.q, Letters.d)]
        [InlineData(Letters.r, Letters.e)]
        [InlineData(Letters.s, Letters.f)]
        [InlineData(Letters.t, Letters.g)]
        [InlineData(Letters.u, Letters.h)]
        [InlineData(Letters.v, Letters.i)]
        [InlineData(Letters.w, Letters.j)]
        [InlineData(Letters.x, Letters.k)]
        [InlineData(Letters.y, Letters.l)]
        [InlineData(Letters.z, Letters.m)]
        public void ConvertMessage_ShouldReturnCharacterAtIndex13MoreThanCharacterPassedIn(string letter, string expectedLetter)
        {
            var actualLetter = Rot13.ConvertMessage(letter);
            Assert.Equal(expectedLetter, actualLetter);
        }

        [Theory]
        [InlineData("test", "grfg")]
        public void ConvertMessage_ShouldReturnEncryptedString(string plaintext, string expectedCipherText)
        {
            var actualCipherText = Rot13.ConvertMessage(plaintext);
            Assert.Equal(expectedCipherText, actualCipherText);
        }
        
        [Theory]
        [InlineData("Test", "Grfg")]
        public void ConvertMessage_ShouldReturnEncryptedCaseSensitiveString(string plaintext, string expectedCipherText)
        {
            var actualCipherText = Rot13.ConvertMessage(plaintext);
            Assert.Equal(expectedCipherText, actualCipherText);
        }
        
        [Theory]
        [InlineData("10+2 is twelve.", "10+2 vf gjryir.")]
        public void ConvertMessage_ShouldNotAlterNumbersSymbolsOrSpaces(string plaintext, string expectedCipherText)
        {
            var actualCipherText = Rot13.ConvertMessage(plaintext);
            Assert.Equal(expectedCipherText, actualCipherText);
        }
    }
}