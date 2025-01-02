using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Practice_01_02_2
    {
        public static void Main(string[] args)
        {
            // 텍스트 파일의 컨탠츠를 불러온다.
            string path = @"C:\projects\codingon\TextFile1.txt";
            string errorPath = @"/dfjsl";
            string[] contents;
            TryReadTxtAndConvertToArray(path, out contents);
            string[] result = AppendNumTypeItemFormStringArray(contents);
            PrintArray(result);
        }

        // out을 이용해 파일 경로 및 배열을 입력, 파일의 내용을 각 줄마다 배열의 요소에 저장하는 메서드 작성
        private static void TryReadTxtAndConvertToArray(string path, out string[] contents)
        {
            contents = new string[1];

            try
            {
                string content = File.ReadAllText(path);
                contents = content.Split("\r\n");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("파일이 존재하지 않습니다.");
            }
        }

        private static string[] AppendNumTypeItemFormStringArray(string[] stringArr)
        {
            int size = 0;
            int length = stringArr.Length;
            string[] strings = new string[length];

            for(int i = 0; i < length; i++)
            {
                if (int.TryParse(stringArr[i], out int result))
                {
                    strings[size] = stringArr[i];
                    size++;
                }
            }
            Array.Resize(ref strings, size);
            return strings;

        }
 


        private static void PrintArray(string[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }


    }
}
