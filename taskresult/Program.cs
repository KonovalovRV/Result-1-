string [] mass = {"Hello","world",":-)","5"};

void SortArray(string[]mas)
 {
  string text=string.Empty;
  int i=0;
  int length=mas.Length;
  for(i=0;i<length;i++)
   {
        text = mas[i];
    if (text.Length<4)
    {
    Console.Write ($"[{mas[i]}]  ");   
    }
   }
    Console.WriteLine();   
 }

SortArray(mass);
