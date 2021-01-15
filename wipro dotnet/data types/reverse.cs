using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
           string a;
		  
           string rev="";
		   string edit="";
           a=Console.ReadLine();
         for(int i=a.Length-1;i>=0;i--)
            {
                rev=rev+a[i];
            }
			Console.WriteLine(rev);

//==================================================
//	========================================


			for(int i=1;i<a.Length;i++)
            {
                edit=edit+a[i];
            }
			Console.WriteLine(edit);
			
//======================================================
//	======================================
           char[] n=a.ToCharArray();

          for(int i=0;i<a.Length;i++)
            {
			  int z='a'.CompareTo(n[i]);
				  if(z==0)
				{
					n[i]='$';
                    Console.Write(n[i]);

				}
                else
                {
                    Console.Write(n[i]);

                }
			}
			Console.WriteLine();

//=========================================================
//	======================================
          char[] m=a.ToCharArray(); 
          
		  for(int i=0;i<a.Length;i++)
            {
				int z='a'.CompareTo(m[i]);
				  if(z==0)
				{
					m[i]='*';
                    Console.Write(m[i]);

				}
                else
                {
                    Console.Write(m[i]);

                }
			}
			Console.WriteLine();
            Console.WriteLine(a);

			

            
        }
    }
}
