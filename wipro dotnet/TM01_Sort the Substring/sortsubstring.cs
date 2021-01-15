using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
namespace myapp
{

    
	class MyClass
	{
        
		
		static void Main(string[] args)
		{
            ArrayList a=new ArrayList();
			int T=Convert.ToInt32(Console.ReadLine());
			string[] fin=new string[T];
             int k=0;
			while(T-->0)
			{
				string s=Console.ReadLine();
				int M=Convert.ToInt32(Console.ReadLine());
				int N=Convert.ToInt32(Console.ReadLine());
				for(int i=M;i<=N;i++)
				{
					a.Add(s[i]);
				}
             a.Sort();
             a.Reverse();
				string temporary =string.Empty;
				foreach(char ch in a)
				{
					temporary=temporary+ch.ToString();
				}
               string front=string.Empty;
                string back=string.Empty;
                if(M==0)
                {}
                else
                {
                    for(int i=0;i<M;i++)
				{
                        front=front+s[i].ToString();
                }
                }
                if(N==s.Length)
                {}
                else
                {
             for(int i=N+1;i<s.Length;i++)
				{
                        back=back+s[i].ToString();
                }
                    
                }
               
              string final=front+temporary+back;
         
               
                fin[k]=final;

                k++;
					
                    a.Clear();
			}
            for(int i=0;i<k;i++)
            {
                Console.WriteLine(fin[i]);
                
            }
		} 
	}
}