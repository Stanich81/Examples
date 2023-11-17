int a = 6;
int b = a*(-1);

if (a>b){
    int max = a; int min = b;
    Console.WriteLine($"max = {max}, min = {min}");
}
else {
    int max = b; int min = a;
    Console.WriteLine($"max = {max}, min = {min}");
}
while(b < a){
    Console.Write($"{b}, ");
    b = b + 1; 
}
Console.Write($"{b}"); //убираем запятую после последней цифры

//while(min < max){
//    Console.Write($"{min}, ");
//    int min = min + 1; 
//}
//Console.Write($"{min}");
