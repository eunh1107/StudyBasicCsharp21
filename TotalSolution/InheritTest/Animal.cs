﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    //Access Modifire : public, protected(상속일때), private
    class Animal
    {
        protected int Age { get; set; }

        protected Animal() { this.Age = 0; }

        protected void Eat() 
        {
            Console.WriteLine("냠냠 먹습니다."); 
        }

        protected void Sleep() 
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }
    }
}
