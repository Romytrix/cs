using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject1
{
    public class Tank
    {
        public string Model;
        public bool IsWorking;

        public string TypeAmmo { get; set };
        public bool IsLoaded;
        
    }
    void Shoot()
    {
            if(IsWorking){
            if(IsLoaded)
            {
                Console.WriteLine("U shoot!");
                IsLoaded = false;
            }
            else()
                    {
                Console.WriteLine("U must reload!");
            }
        }
            else(){
            Console.WriteLine("Ur Tank is broken!");
        }
    }
    void Reload()
    {
            if(Isloaded){
            Console.WriteLine("U a allready loaded!");
        }
            else(){
            Console.WriteLine("Reloaded!");
        }
    }
    void Forward()
    {
        if (IsWorking)
        {
            Console.WriteLine("U ride forward!");
        }
    }
}
