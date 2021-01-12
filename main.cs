using System;
//Значимые
// int - целочисленные,float - дробные
// string/String -строка ("строка"), char - один символ('F')
//
//Ссылочные
// Объекты
//
//

class NumAll{
	 string GetLine(){
		string str = Console.ReadLine();
		int index = str.LastIndexOf('R');
		if(index==-1){
			return str;
		}
		else{
			return str.Substring(index+1);
		}	
	}
	public  double DoubleInput(){
		string str = GetLine();	
		double result =	Convert.ToDouble(str);
		//if (Double.TryParse(str, out result))
		return result;
	}
}

class MainClass {

	#region Methods
  static string GetLine(){
		string str = Console.ReadLine();
		int index = str.LastIndexOf('R');
		if(index==-1){
			return str;
		}
		else{
			return str.Substring(index+1);
		}	
	}
	static void StartGame(){
			Random rand = new Random();
		  int	value = rand.Next(0,100);
			bool isStarted =true;
			do
			{
				int answer = Convert.ToInt32(GetLine());
				if(value == answer){
					Console.WriteLine("Вы угадали"); 
					isStarted=false;				    
				}
				if(value < answer){
					Console.WriteLine("Ваше число больше");
				}
				if(value > answer){
					Console.WriteLine("Ваше число меньше");
				}
			}
			while(isStarted);
	}
	static void Lab1_1(){
		double a = Convert.ToDouble(GetLine());
		double v = a*a*a;
    double s = 6*a*a;
    Console.WriteLine(String.Format("V={0} S={1}",v,s));
	}
	static void Lab1_2(){
		double a = Convert.ToDouble(GetLine());
		double b = Convert.ToDouble(GetLine());
		double s = 0.5*a*b;
		double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
		Console.WriteLine(String.Format("s={0} c={1}",s,c));
	}
  static void Lab1_3(){
		//q = c*m*dt = c*m*(t1-t2)
		//c = 4200
		//t3 -температура смеси
		//c*m1*(t3-t2) = c*m2*(t3-t1)
    double t1 = Convert.ToDouble(GetLine());
    double t2 = Convert.ToDouble(GetLine());
    double v1 = Convert.ToDouble(GetLine());
    double v2 = Convert.ToDouble(GetLine());
		//double p = 1000.0;
		double m1 = v1 * 1000;
		double m2 = v2 * 1000;

		double t3 = (t1*m1+t2*m2) / (m1+m2);
		Console.WriteLine("Температура смеси:"+t3);
  }
	static void Lab2_1(){
    double x = Convert.ToDouble(GetLine());
    double y = Convert.ToDouble(GetLine());
    if(x>y)
			Console.WriteLine("z="+(x-y));
		else
			Console.WriteLine("z="+(y-x+1));
  }
	static void Lab2_2(){
    int a1 = Convert.ToInt32(GetLine());
    int a2 = Convert.ToInt32(GetLine());
    if(a1<=a2)
    	a1 = 0;
    Console.WriteLine("a1="+a1+" a2="+a2);

  }
	static void Lab2_3(){
		int x = Convert.ToInt32(GetLine());
    int y = Convert.ToInt32(GetLine());
    int c = Convert.ToInt32(GetLine());
		if(IsInside(x,-10,50))
			Console.WriteLine(x);
      if(IsInside(y,-10,50))
      	Console.WriteLine(y);
        if(IsInside(c,-10,50))
        	Console.WriteLine(c);
	}
static void Lab2_5(){
  int a = Convert.ToInt32(GetLine());
  int b = Convert.ToInt32(GetLine());
	if (a<0 && b<0)
{
  a = a * -1;
  b = b * -1;
}

  if (a<0|| b<0) 
  {
    a = a + 5;
    b = b + 5;
  }

	if (a >= 0 && b>=0 && !IsInside(a,5,20) && !IsInside(b,5,20))
	{
		a = a * 10;
    b = b * 10;	
	}
  Console.WriteLine(a);
  Console.WriteLine(b);

}

	static void Lab2_6(){
    int a = Convert.ToInt32(GetLine());
    int b = Convert.ToInt32(GetLine());
    int c = Convert.ToInt32(GetLine());
   if(c<b)
	 {
		 int temp =c;
		 c =b;
		 b =temp;
	 }
   if(a>b)
   {
      int temp =a;
		 a =b;
		 b =temp;
   }
   Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

  }
  static void Lab2_8(){
    int a = Convert.ToInt32(GetLine());
    int b = Convert.ToInt32(GetLine());
    int c = Convert.ToInt32(GetLine());
    int num = 1;
		if(b>a)
    { 
      num = 2;
    }
    if(c>b)
    {
      num = 3;
    }
    Console.WriteLine(num);
  }

	static bool IsInside(int value,int start,int end){
//if(a>=-10 && a<=50
		return value>=start && value<=end;
}
//Делали не по заданию, самостоятельно
public static void Lab3_1_1(int rowsCount,int colsCount){
	// int x = 0;
	// //for(;x<=100;)
	// while (x<=100){
  // 	Console.WriteLine(x++);
	// }
	//1 2 3
	//4 5 6
	//7 8 9
	int counter=1;
	int min = counter;
  int max = counter;
	double sum = 0;
	for (int i=0;i<rowsCount;i++){
		for(int j=0;j<colsCount;j++){
			if (counter>max){
        max = counter;
      }
      if (min>counter){
        min = counter;
      }
			sum += counter;
			Console.Write(String.Format("{0,4}",counter++));
		}
		Console.WriteLine();
	}
	Console.WriteLine(min);
  Console.WriteLine(max);
	Console.WriteLine(sum/(double)(rowsCount*colsCount));
}
public static int Lab3_1(int n){
	if(n<0){
		throw new Exception("Некорректное значение!");
	}
	else{
		int result = 1;
		while(n>1){
			result*=n;
			n--;
		}
		return result;
	}
	
}

public static double Lab3_2(double eps){
	if(eps<0){
		throw new Exception("Некорректное значение!");
	}
	else{
		double n=0;
		double item=0;
		double sum=0;
		do{
			sum+=item;
		  item = Math.Pow(-1.0,n)/(2.0*n+1.0);
			n++;
			//Console.WriteLine("ITEM:"+item);
		}
		while(Math.Abs(item) > eps);
		return sum;
	}
}

public static void Lab3_3(){
	NumAll myNumAll = new NumAll();
	Console.WriteLine(myNumAll.DoubleInput());
}

public static double Lab3_5(double x){
	double sum=0;
	int sign=0;
  for(int i=1;i<15;i+=2){
		double item =Math.Pow(x,i)/Lab3_1(i) * Math.Pow(-1,sign);
		sum+= item;
		Console.WriteLine(item);
		sign++;
	}
	return sum;
}
//1024 - 4 разряда
public static int Lab3_6(int n){
	//return n.ToString().Length;
	int result=1;
	while(n>1){
		n=n/10;
		result++;
	}
	return result;
}
public static int Lab3_7(int n){
	//return n.ToString().Length;
	int result=1;
	while(n>10){
		n=n/10;
		result++;
	}
	return n;
}
public static int Lab3_8(int n){
int result=0;
	while(n>0){
		result+=n%10;
		n=n/10;
	}
	return result;
}
#endregion

public static void Main (string[] args) {
	//Console.WriteLine(Lab3_2(0.0001));
	//Console.WriteLine(Lab3_8(7896)); 

}

}