using System;
using System.Text;
using NPinyin;
using Xunit;

namespace NPinyinUnitTest
{
    public class PinyinTest
    {
        [Fact]
        public void ToPinyin_Test()
        {
            Assert.Equal("shi chang yu ren wei ， shi zong zai ren wei", Pinyin.GetPinyin("事常与人违，事总在人为"));
            Assert.Equal(". n e t   c o r e   shi kai yuan de ， kua ping tai de", Pinyin.GetPinyin(".net core 是开源的，跨平台的"));

        }

        [Fact]
        public void ToPinyin_Encoding_Test()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding gb2312 = Encoding.GetEncoding("GB2312");
            string s = Pinyin.ConvertEncoding("聚维酮碘溶液", Encoding.UTF8, gb2312);
            Assert.Equal("JWTDRY", Pinyin.GetInitials(s, gb2312));

            string s2 = Pinyin.ConvertEncoding("双氯芬d酸B二乙胺乳膏", Encoding.UTF8, gb2312);
            Assert.Equal("SLFDSBEYARG", Pinyin.GetInitials(s2));

            string s3 = Pinyin.ConvertEncoding("Hello, 大家了解 C# 吗？", Encoding.UTF8, gb2312);
            Assert.Equal("H e l l o ,   da jia le jie   C #   ma ？", Pinyin.GetPinyin(s3));
        }

        [Fact]
        public void ToChinese_Test()
        {
            var s = Pinyin.GetChineseText("zhong");
            Assert.Equal("中种重众钟终忠肿仲盅衷冢锺螽舯踵", s);
        }
    }
}
