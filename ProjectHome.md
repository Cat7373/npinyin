# v0.2.x的变化 #

  * 1、增加对不同编码格式文本的支持,同时增加编码转换方法Pinyin.ConvertEncoding
  * 2、重构单字符拼音的获取，未找到拼音时返回字符本身.

汪思言 2012年7月23日晚

将中文转换成拼音全文和首字母的.net 组件。示例：

```
using System;
using System.Collections.Generic;
using System.Text;
using NPinyin;

namespace NPinyinTest
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] maxims = new string[]{
        "事常与人违，事总在人为",
        "骏马是跑出来的，强兵是打出来的",
        "驾驭命运的舵是奋斗。不抱有一丝幻想，不放弃一点机会，不停止一日努力。 ",
        "如果惧怕前面跌宕的山岩，生命就永远只能是死水一潭", 
        "懦弱的人只会裹足不前，莽撞的人只能引为烧身，只有真正勇敢的人才能所向披靡"
      };

      string[] medicines = new string[] {
        "聚维酮碘溶液",
        "开塞露",
        "炉甘石洗剂",
        "苯扎氯铵贴",
        "鱼石脂软膏",
        "莫匹罗星软膏",
        "红霉素软膏",
        "氢化可的松软膏",
        "曲安奈德软膏",
        "丁苯羟酸乳膏",
        "双氯芬酸二乙胺乳膏",
        "冻疮膏",
        "克霉唑软膏",
        "特比奈芬软膏",
        "酞丁安软膏",
        "咪康唑软膏、栓剂",
        "甲硝唑栓",
        "复方莪术油栓"
      };

      Console.WriteLine("UTF8句子拼音：");
      foreach (string s in maxims)
      {
        Console.WriteLine("汉字：{0}\n拼音：{1}\n", s, Pinyin.GetPinyin(s));
      }

      Encoding gb2312 = Encoding.GetEncoding("GB2312");
      Console.WriteLine("GB2312拼音简码：");
      foreach (string m in medicines)
      {
        string s = Pinyin.ConvertEncoding(m, Encoding.UTF8, gb2312);
        Console.WriteLine("药品：{0}\n简码：{1}\n", s, Pinyin.GetInitials(s, gb2312));
      }

      Console.ReadKey();
    }
  }
}

```

# 运行结果 #

UTF8句子拼音：
汉字：事常与人违，事总在人为
拼音：shi chang yu ren wei ， shi zong zai ren wei

汉字：骏马是跑出来的，强兵是打出来的
拼音：jun ma shi pao chu lai de ， qiang bing shi da chu lai de

汉字：驾驭命运的舵是奋斗。不抱有一丝幻想，不放弃一点机会，不停止一日努力。
拼音：jia yu ming yun de duo shi fen dou 。 bu bao you yi si huan xiang ， bu fa
ng qi yi dian ji hui ， bu ting zhi yi ri nu li 。

汉字：如果惧怕前面跌宕的山岩，生命就永远只能是死水一潭
拼音：ru guo ju pa qian mian die dang de shan yan ， sheng ming jiu yong yuan zh
i neng shi si shui yi tan

汉字：懦弱的人只会裹足不前，莽撞的人只能引为烧身，只有真正勇敢的人才能所向披靡
拼音：nuo ruo de ren zhi hui guo zu bu qian ， mang zhuang de ren zhi neng yin w
ei shao shen ， zhi you zhen zheng yong gan de ren cai neng suo xiang pi mi

GB2312拼音简码：
药品：聚维酮碘溶液
简码：JWTDRY

药品：开塞露
简码：KSL

药品：炉甘石洗剂
简码：LGSXJ

药品：苯扎氯铵贴
简码：BZLAT

药品：鱼石脂软膏
简码：YSZRG

药品：莫匹罗星软膏
简码：MPLXRG

药品：红霉素软膏
简码：HMSRG

药品：氢化可的松软膏
简码：QHKDSRG

药品：曲安奈德软膏
简码：QANDRG

药品：丁苯羟酸乳膏
简码：DBQSRG

药品：双氯芬酸二乙胺乳膏
简码：SLFSEYARG

药品：冻疮膏
简码：DCG

药品：克霉唑软膏
简码：KMZRG

药品：特比奈芬软膏
简码：TBNFRG

药品：酞丁安软膏
简码：TDARG

药品：咪康唑软膏、栓剂
简码：MKZRG、SJ

药品：甲硝唑栓
简码：JXZS

药品：复方莪术油栓
简码：FFESYS