using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpCollectionType
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组继承自System.Array
            //一维数组
            int[ ] numbers = new int[5];
            //二维数组
            string[ , ] names=new string[5,4];
            //数组的数组
            byte[][] scores = new byte[5][];
            //一维数组的初始化
            int[] numbers2 = new int[5] { 1,2,3,4,5};
            int[] numbers3 = new int[]{1,2,3,4,5};
            int[] numbers4 ={1,2,3,4,5};
            //二维数组初始化
            string[,] name2 = { {"g","d" }, {"h","j" } };
            //数组的数组
            int[][] number5 = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7 } };
            Console.WriteLine(number5[0].Length);
            
            //重要的集合类型，通常都在System.Collection下面
            //ArrayList数组列表,可以存储各种类型，不是强类型。将存入的每个值都当作object，在栈中存储值的引用
            ArrayList a1 = new ArrayList();
            //添加元素
            a1.Add(5);
            a1.Add(5);
            //移除
            a1.Remove(5);
            foreach (var e in a1) {
                Console.WriteLine(e);            
            }

            //List列表，强类型
            List<int> intList = new List<int>();
            intList.Add(5);
            //添加一串数据
            intList.AddRange(new int[] { 4, 2 });
            intList.Remove(5);
            //是否包含一个数值
            intList.Contains(100);
            //查找某个值的位置
            intList.IndexOf(4);
            //可以插入
            intList.Insert(1, 400);

            //哈希表，每一位都有多对应的键和值，通过哈希算法计算出一个值存储到内存中,对类型没有强制规定,如果查找一个不存在的键值，会返回空值，不会报错，字典不行
            Hashtable ht = new Hashtable();
            ht.Add("first",1);
            ht.Add("second", 2);

            //字典类型，是强类型，不是线程安全的,线程安全要用ConcurrentDictionary
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("asd", "asd");
            
            //常用集合类型
            //SortedList经过排序的list，通过key值排序
            SortedList<int, int> sit = new SortedList<int, int>();

            Console.ReadLine();
        }
    }
}
