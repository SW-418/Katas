using System;
using System.Linq;
using Xunit;

namespace Rot13
{
    public class Tests
    {
        private enum Letters { a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z }
        
        [Theory]
        [InlineData(Letters.a)]
//        [InlineData(Letters.b)]
//        [InlineData(Letters.c)]
//        [InlineData(Letters.d)]
//        [InlineData(Letters.e)]
//        [InlineData(Letters.f)]
//        [InlineData(Letters.g)]
//        [InlineData(Letters.h)]
//        [InlineData(Letters.i)]
//        [InlineData(Letters.j)]
//        [InlineData(Letters.k)]
//        [InlineData(Letters.l)]
//        [InlineData(Letters.m)]
//        [InlineData(Letters.n)]
//        [InlineData(Letters.o)]
//        [InlineData(Letters.p)]
//        [InlineData(Letters.q)]
//        [InlineData(Letters.r)]
//        [InlineData(Letters.s)]
//        [InlineData(Letters.t)]
//        [InlineData(Letters.u)]
//        [InlineData(Letters.v)]
//        [InlineData(Letters.w)]
//        [InlineData(Letters.x)]
//        [InlineData(Letters.y)]
//        [InlineData(Letters.z)]
        public void ConvertMessage_ShouldReturnCharacterAtIndex13MoreThanCharacterPassedIn(string character)
        {
            var actualResult = Rot13.ConvertMessage(character);
            Assert.Equal(Letters.m.ToString(), actualResult);
        }
    }
}