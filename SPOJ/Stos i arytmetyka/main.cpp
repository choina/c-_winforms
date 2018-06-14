#include <iostream>
#include <stack>


using namespace std;
stack <int> stos;
int a;
int b;
char c;
int x,y;
int wynik;
int powt;
int main()
{
    cin >> powt;
    for(int i=0;i<powt;i++)
    {
       cin >> a;
       if(a==1)
       {
        cin >> b;
        stos.push(b);
       }
       else if(a!=1)
       {
       cin >> c;
       x=stos.top();
       stos.pop();
       y=stos.top();
       stos.pop();
       switch(c)
       {
       case '+':
        wynik = y+x;
        break;
       case '*':
        wynik = y*x;
        break;
       case '-':
       wynik = y-x;
       break;
       case '/':
       wynik = y /x;
       break;
       }
       stos.push(wynik);
       }
    }
    cout << stos.top() << endl << "ONP" << endl;
    return 0;
}
