# Mind Mock

Mind Mock 提供一套模拟数据的接口，使得客户端游戏开发人员独立于服务器端开发人员进行开发。

## 基础类型

返回一个随机的布尔值

    Mind.Mock.Rand.Bool()

返回一个随机的自然数（大于等于0的整数）

    Mind.Mock.Rand.Natural()

返回一个随机的整数

    Mind.Mock.Rand.Int()

返回一个随机的浮点数

    Mind.Mock.Rand.Char()

返回一个随机字符

    Mind.Mock.Rand.Char()

返回一个随机字符串

    Mind.Mock.Rand.String()

返回一个整型数组

    Mind.Mock.Rand.Range()

## 帮助函数

返回精确的随机数

    Mind.Mock.Rand.GetRandom(int min, int max)

首字母大写

    Mind.Mock.Rand.Capitalize(string word)

转为大写字母

    Mind.Mock.Rand.Upper(string str)

转为小写字母

    Mind.Mock.Rand.Lower(string str)

随机返回List中的一项

    Mind.Mock.Rand.Pick(List<T> list, int min = 0, int max =0)

## 日期函数

随机生成一个日期字符串
    
    Mind.Mock.Rand.Date(string fmt = "yyyy-MM-dd"))

随机生成一个时间字符串

    Mind.Mock.Rand.Time(string fmt = "yyyy-MM-dd"))

随机生成一个具体日期和时间字符串

    Mind.Mock.Rand.DateTime(string fmt = "yyyy-MM-dd"))

返回当前的日期字符串

    Mind.Mock.Rand.Now(string fmt = "yyyy-MM-dd HH:mm:ss"))

## 名字函数

随机生成一个西方人名的名

    Mind.Mock.Rand.FirstName()

随机生成一个西方人名的姓

    Mind.Mock.Rand.LastName()

随机生成一个西方人名全名

    Mind.Mock.Rand.FullName()
    
随机生成一个常见的中文姓

    Mind.Mock.Rand.CFirstName()

随机生成一个常见的中文名

    Mind.Mock.Rand.CLastName()

随机生成一个常见的中文姓名

    Mind.Mock.Rand.CFullName()

## 文本函数

随机生成N段英文文本

    Mind.Mock.Rand.Paragraph(int min = 3, int max = 8)

随机生成N段中文文本

    Mind.Mock.Rand.CParagraph(int min = 3, int max = 8)

随机生成N句英文

    Mind.Mock.Rand.Sentence(int min = 12, int max = 18)

随机生成N句中文文

    Mind.Mock.Rand.CSentence(int min = 12, int max = 18)

随机生成一N个英文单词

    Mind.Mock.Rand.Word(int min = 3, int max = 10)

随机生成N个中文词组

    Mind.Mock.Rand.CWord(int min = 1, int max = 5)

随机生成N个英文标题

    Mind.Mock.Rand.Title(int min = 3, int max = 8)

随机生成N个中文标题

    Mind.Mock.Rand.CTitle(int min = 3, int max = 8)


## 地址函数

随机生成一个大区

    Mind.Mock.Rand.Region()

随机生成一个（中国）省（或直辖市、自治区、特别行政区）

    Mind.Mock.Rand.Province()

随机生成一个（中国）市

    Mind.Mock.Rand.City()

随机生成一个（中国）县

    Mind.Mock.Rand.County()

随机生成一个邮政编码（六位数字）

    Mind.Mock.Rand.Zip()

## Web函数

随机生成一个URL

    Mind.Mock.Rand.URL(string protocol = "", string host = "")

随机生成一个协议

    Mind.Mock.Rand.Protocol()

随机生成一个域名

    Mind.Mock.Rand.Domain(string tld = "")

随机生成一个顶级域名

    Mind.Mock.Rand.TLD()

随机生成一个email地址

    Mind.Mock.Rand.(string host = "")

随机生成一个IP

    Mind.Mock.Rand.IP()

## 其他函数

随机生成一个 GUID

    Mind.Mock.Rand.Guid()

随机生成一个 18 位身份证。

    Mind.Mock.Rand.Id()

生成一个全局的自增整数

    Mind.Mock.Rand.Incr(int step = 1)