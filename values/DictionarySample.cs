using System;
using System.Collections;
using System.Collections.Generic;

namespace CsharpExample.Values
{
    // C#でもTuple型は使える
    public class DictionarySample
    {
        // Dictionary型のサンプル
        public void ExecDictionarySample()
        {
            // Dictionary型を使う場合はKeyとValueの型をジェネリクスで指定する必要がある。
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            
            dictionary.Add("Key1", "Value1");
            dictionary.Add("Key2", "Value2");
            dictionary.Add("Key3", "Value3");

            Console.WriteLine($"辞書の長さ{dictionary.Count}");
            // Keyに対応する値の取得は[]で行う。
            Console.WriteLine($"Key1: {dictionary["Key1"]}");
            // 代入は左辺にKeyに対応する値を指定する。
            dictionary["Key3"] = "Value300";

            // foreachで取り出す場合はKeyValuePair型の値が取り出せる。
            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            {
                Console.WriteLine($"key: {keyValuePair.Key}, value: {keyValuePair.Value}");
            }
            
            // キーだけのコレクションの取得
            Dictionary<string, string>.KeyCollection keyCollection = dictionary.Keys;

            foreach (string key in keyCollection)
            {
                Console.WriteLine($"key: {key}");
            }
        }

        // 非推奨
        // HashTable型のサンプル
        // 格納するキーと値の型を指定せずに使えるが、
        // ジェネリクスを指定できるDictionary型を使うのが推奨されている。
        public void ExecHashTableSample()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("key1", "value1");
            hashtable.Add(2, 200);
            Console.WriteLine(hashtable["key1"]);
            Console.WriteLine(hashtable[2]);

            hashtable["key1"] = "value100";
            Console.WriteLine(hashtable["key1"]);
        }
    }    
}
