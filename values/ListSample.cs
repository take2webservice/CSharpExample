using System;
using System.Collections;
using System.Collections.Generic;

namespace CsharpExample.Values
{
    // C#のArrayは固定長の配列で、同じ型の複数の変数を格納できる
    public class ListTypeSample
    {
        // List型のサンプル
        // 要素のランダムアクセスが可能
        // リストの途中に要素を挿入または削除する場合のパフォーマンスが悪い
        public void ExecListSample()
        {
            // using System.Collections.Generic; でインポートが必要
            List<string> stringList = new List<string>();
            // 要素を1つ追加する
            stringList.Add("Alice");
            // 要素を複数まとめて追加する
            stringList.AddRange(new string[] {"Bob", "Charlie"});

            // Listの要素を, 区切りで結合した文字列にする。
            Console.WriteLine(string.Join(",", stringList));

            // 値の存在確認
            Console.WriteLine(stringList.Contains("Alice"));
            Console.WriteLine(stringList.Contains("Dave"));

            // 要素の削除
            stringList.Remove("Bob");
            Console.WriteLine(string.Join(",", stringList));

            // foreachで要素を1つずつ取り出す。
            foreach (string e in stringList)
            {
                Console.WriteLine($"foreach! {e}");
            }

                        // foreachで要素を1つずつ取り出す。
            for (int i=0; i < stringList.Count; i++)
            {
                Console.WriteLine($"for! {stringList[i]}");
            }
        }

        // LinkedListのサンプル
        // 要素のランダムアクセスができない
        // 代わりに要素に順方向または逆方向への順次操作が高速
        // 先頭や末尾への要素の追加や削除も高速
        public void ExecLinkedListSample()
        {
            LinkedList<string> stringLinkedList = new LinkedList<string>(
                new string[]{"Alice", "Bob", "Charlie", "Dave"}
            );
            // stringLinkedList[2]; LinkedListは角かっこ [] 付きインデックスでアクセスできない。

            // ランダムアクセスができないので順次辿っていく必要がある。
            LinkedListNode<string>? first = stringLinkedList.First;
            Console.WriteLine(first?.Value); //Alice
            LinkedListNode<string>? second = first?.Next;
            Console.WriteLine(second?.Value); //Bob
            // 代わりに前後の要素は辿りやすい
            Console.WriteLine(second?.Previous?.Value); //Alice

            // foreachで要素を1つずつ取り出す
            foreach (string e in stringLinkedList)
            {
                Console.WriteLine($"foreach! {e}");
            }

            // forで要素を1つずつ取り出す
            for (LinkedListNode<string>? fnode = stringLinkedList.First; fnode != null; fnode = fnode?.Next)
            {
                Console.WriteLine($"for! {fnode?.Value}");
            }

            // whileを使い要素を1つずつ取り出す
            LinkedListNode<string>? wnode = stringLinkedList.First;
            while(wnode != null)
            {
                Console.WriteLine($"while! {wnode?.Value}");
                wnode = wnode?.Next;
            }
        }

        public void ExecHashSetSample()
        {
            HashSet<int> intHashSet12 = new HashSet<int>();
            // セットへの値の追加
            intHashSet12.Add(1);
            intHashSet12.Add(1);
            intHashSet12.Add(2);
            intHashSet12.Add(2);
            // セットは同じ値は含まれないので、1, 2の2要素が出力される。
            Console.WriteLine(string.Join(",", intHashSet12));
            // 含まれるかはContainsが使える
            Console.WriteLine($"intHashSet12に1は含まれる？{intHashSet12.Contains(1)}");
            Console.WriteLine($"intHashSet12に3は含まれる？{intHashSet12.Contains(3)}");

            // 初期値として値を渡すこともできる。
            HashSet<int> intHashSet23 = new HashSet<int>(
                new int[] {2, 3}
            );

            // 和集合を取ることができる(破壊的操作なので注意が必要)
            HashSet<int> unionHashSet = new HashSet<int>(intHashSet12);
            unionHashSet.UnionWith(intHashSet23);
            Console.WriteLine(string.Join(",", unionHashSet));

            // 差集合を取ることができる(破壊的操作なので注意が必要)
            // ここではintHashSet12に存在しているがintHashSet23に存在しない1だけを持ったHashSet型の値になる。
            HashSet<int> exceptHashSet = new HashSet<int>(intHashSet12);
            exceptHashSet.ExceptWith(intHashSet23);
            Console.WriteLine(string.Join(",", exceptHashSet));
            
            // 積集合を取ることができる(破壊的操作なので注意が必要)
            // ここではintHashSet12とintHashSet23で共通している2だけを持ったHashSet型の値になる。
            HashSet<int> intersectHashSet = new HashSet<int>(intHashSet12);
            intersectHashSet.IntersectWith(intHashSet23);
            Console.WriteLine(string.Join(",", intersectHashSet));
        }

        // 非推奨
        // ArrayListは保存する要素のデータ型を指定する必要がない。
        // ただしC# 2.0以降では、ArrayListの使用は推奨されていません。ジェネリクスで型を指定できる`List`を使いましょう。
        // 取り出した値の型が不明なので、全てのデータ型の基底クラスであるSystem.Objectとして取り出している。
        public void ExecArrayListSample()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Alice");
            arrayList.Add(2);
            arrayList.Add("Bob");
            // foreachで要素を1つずつ取り出す。
            foreach (Object e in arrayList)
            {
                Console.WriteLine($"foreach! {e}");
            }
        }
    }    
}
