using Xunit;
using Common.Extendsions;

namespace CommonXUnitTest
{
    public class StringExtTest
    {
        [Theory]
        [InlineData("13005331614", true)]
        [InlineData("13105331614", true)]
        [InlineData("13205331614", true)]
        [InlineData("13305331614",true)]
        [InlineData("13405331614", true)]
        [InlineData("13505331614", true)]
        [InlineData("13605331614", true)]
        [InlineData("13705331614", true)]
        [InlineData("13805331614", true)]
        [InlineData("13905331614", true)]
        [InlineData("10312312614", false)]
        [InlineData("11305331614",false)]
        [InlineData("12305331614",false)]
        [InlineData("133053614",false)]
        [InlineData("13305312312614", false)]
        [InlineData("1390a331614", false)]
        [InlineData("03912331614", false)]
        [InlineData("asdaa331614", false)]
        [InlineData("1สี905331614", false)]
        public void IsMobileValid(string strValue,bool isMatch)
        {
            Assert.Equal(strValue.IsMobileValid(), isMatch);
        }




        [Theory]
        [InlineData("0533-6807591", true)]
        [InlineData("033-68075911", true)]
        [InlineData("133-123456", false)]
        [InlineData("111--111112", false)]
        [InlineData("12345678", false)]
        [InlineData("111-12345678", false)]
        [InlineData("1234-12345678", false)]
        [InlineData("0a4-12345678", false)]
        [InlineData("12-1234567", false)]
        [InlineData("123-123456", false)]
        public void IsTelephoneValid(string strValue, bool isMatch)
        {
            Assert.Equal(strValue.IsTelephoneValid(), isMatch);
        }

        [Theory]
        [InlineData("370306198807192010", true)]
        [InlineData("370306198807192", true)]
        [InlineData("370306198807192a", false)]
        [InlineData("37030619880719201X", true)]
        [InlineData("37030619880719201x", true)]
        [InlineData("37030619880719X", false)]
        [InlineData("111-12345678", false)]
        [InlineData("1234asd5678", false)]
        [InlineData("0a4aaa345678", false)]
        [InlineData("123123123123123", true)]
        public void IsChineseIDValid(string strValue, bool isMatch)
        {
            Assert.Equal(strValue.IsChineseIDValid(), isMatch);
        }


        [Theory]
        [InlineData("123@qq.com", true)]
        [InlineData("37asdqq.com", false)]
        [InlineData("aaa@qq.com", true)]
        [InlineData("2aswd2asd2@qq.com", true)]
        [InlineData("asda.com", false)]
        [InlineData("37030asda.asd.com", false)]
        [InlineData("123@2123.com", true)]
        public void IsEmailValid(string strValue, bool isMatch)
        {
            Assert.Equal(strValue.IsEmailValid(), isMatch);
        }

        [Theory]
        [InlineData("1C-B7-2C-EF-BA-3D", true)]
        [InlineData("1C-B7-2C-EF-BA-3", false)]
        [InlineData("1C-B7-2C-EF-BA-", false)]
        [InlineData("1C-B7-2C-EF-", false)]
        [InlineData("1C-B7-2C-EF-BA-3D-1a", false)]
        [InlineData("1C-B7-2C-EF-BA-3D-", false)]
        [InlineData("1C-G7-2C-EF-BA-3D", false)]
        public void IsMacValid(string strValue, bool isMatch)
        {
            Assert.Equal(strValue.IsMacValid(), isMatch);
        }


        [Theory]
        [InlineData("123456", false)]
        [InlineData("a12345", true)]
        [InlineData("a1234", false)]
        [InlineData("aaaaaa", true)]
        [InlineData("aaaaaa_", true)]
        [InlineData("aaaaa_", true)]
        [InlineData("_12345", false)]
        public void IsPasswordWeakValid(string strValue, bool isMatch)
        {
            Assert.Equal(strValue.IsPasswordWeakValid(), isMatch);
        }

        [Theory]
        [InlineData("12345678", false)]
        [InlineData("aaa12345", false)]
        [InlineData("aA123456", true)]
        [InlineData("aA_123456", true)]
        [InlineData("aA123456789", false)]
        [InlineData("aA123456-", true)]
        [InlineData("aA123456_", true)]
        public void IsPasswordStrongValid(string strValue, bool isMatch)
        {
            Assert.Equal(strValue.IsPasswordStrongValid(), isMatch);
        }


    }
}
