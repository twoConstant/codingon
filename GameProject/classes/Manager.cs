using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.interfaces;

namespace GameProject.classes
{
    public class Manager<T> : IManager<T>
    {
        private static Manager<T> _instance; // 싱글톤 인스턴스
        public List<T> list { get; private set; } = new List<T>();
        public int size { get; private set; }

        private Manager()
        {
            this.size = 0;

        }

        // 싱글톤 인스턴스 접근 프로퍼티
        public static Manager<T> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Manager<T>();
                }
                return _instance;
            }
        }

        public void Add(T item)
        {
            list.Add(item);
            this.size++;
            Console.WriteLine($"[Manager - Add] 추가완료 size: {size}");
        }

        public T FindById(int id)
        {
            // 인덱스 유효성 검사
            if(id > size)
            {
                throw new InvalidOperationException($"id: {id}, size: {size} 해당 id는 존재하지 않습니다.");
            }
            // 비어있는 경우
            if (list[id] == null)
            {
                throw new InvalidOperationException($"id: {id}의 item이 비어있습니다.");
            }

            return list[id];
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
            this.size--;
        }

    }
}
