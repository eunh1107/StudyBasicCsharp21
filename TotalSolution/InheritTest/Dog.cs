using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Dog : Animal //Animal을 상속받는다.
    {
        //특성 -> 속성
        public string Color { get; set; }
        
        //기본생성자
        public Dog() { this.Age = 0; this.Color = "흰색"; }

        //액션 -> 메서드
        public void Bark() 
        {
            Console.WriteLine  ("왕왕!"); 
        }
    }
}
