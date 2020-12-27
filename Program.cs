using System;
using System.Collections;
using System.Collections.Generic;
namespace myproject
{
    class Program
    {
                 
        //1         
       public static bool isPalindrome(string word){
         int lengthOfaString=word.Length;
         for(int i=0;i<lengthOfaString/2;i++)
         {
            if(word[i]!=word[lengthOfaString-i-1]){
                return false;
            }
           
         }
          return true;
       }
        
        //2
      public static void minSplit(int amount){
         int[] changes=new int[]{1,5,10,20,50};
         int[] split= new int[5];
         for(int i=0;i<changes.Length;i++){
             if(amount>changes[i]){
                split[i]= amount/changes[i];
                amount=amount-changes[i]*split[i];
             }
         }
         Console.WriteLine("minimum split change is:");
         for(int i=0;i<5;i++){
            if(split[i]!=0){
                Console.WriteLine(changes[i]+":"+split[i]);
            }
         }
      }


      //3
      public static int notContains(int[] array){
          Array.Sort(array);
           int N = array.Length;
          if(array[N-1]<0){
              return 1;
          }
          if(N==1){
              if(array[0]==1){
                  return 2;
              }
              else{
                  return 1;
              }
          }
         for(int i =0; i<N;i++){
             if(array[i]<=0||array[i]>N)
                 array[i]=1;
         }

          for(int i=0;i<N;i++){
              array[(array[i]-1)%N]+=N;
          }

          for(int i=0;i<N;i++){
              if(array[i]<=N)
              return i+1;
          }
          return N+1;
      }

      //4
      public static bool isProperly(string sequence){
       Stack<char> stack= new Stack<char>();
       char temp;
       for(int i=0;i<sequence.Length;i++){
         if(sequence[i]=='('){
             stack.Push(sequence[i]);
         }  if(stack.Count==0){
             return false;
         }
          if(sequence[i]==')'){
            
                 temp=stack.Peek();
                 stack.Pop();
         }
       }
      
         if(stack.Count==0){
             return true;
         }
         else{
             return false;
         }
         
     
      }

      //5
      public static int fibb(int start ){
          if(start<=1){
              return start;
          }
          else{
              return fibb(start-1)+fibb(start-2);
          }
      }
      public static int countVariants(int stairsCount){
          if(stairsCount ==0){
              return 0;
          }
          else if(stairsCount==1){
              return 1;
          }
          else{
              return fibb(stairsCount+1);
          }

      }
    
      //6

       public static void Swap(ArrayList list, int indexA, int indexB)
   {
    var tmp = list[indexA];
    list[indexA] = list[indexB];
    list[indexB] = tmp;
   }
      class customData{
       
       ArrayList arlist = new ArrayList(); 
         public static  Dictionary<int,int> map= new Dictionary<int,int>();
         int temp;
       public void remove(int x){
             int index= map[x];
             if(index==0){
                 return;
             }
             map.Remove(x);

             int size= arlist.Count;
             int last= arlist.Count-1;
            Swap(arlist,index,size);

            arlist.Remove(size-1);
            map[index]=(int)arlist[last];
         }

      }

      //8
     
        static void Main(string[] args)
        {
            /* 
            //1//
            string inputString;
            Console.WriteLine("write a string:");
            inputString=Console.ReadLine();
            if(isPalindrome(inputString)){
                Console.WriteLine("this string is a palindrome");
            }
            else{
                Console.WriteLine("this string is not a palindrome");
            }

            */


            /*
            //2//
            int[] newarray={0,1,3,4,5,1,2,4,5,6,4};
            Console.WriteLine(notContains(newarray));
            */

           // //3//minSplit(10000);
          
          /*
          //4
           string test="(())";
           if(isProperly(test)){
               Console.WriteLine("this is correct");
           }else{
           Console.WriteLine("incorrect");
           }

           */

       // //5// Console.WriteLine(countVariants(2));
      
        }
    }
}
