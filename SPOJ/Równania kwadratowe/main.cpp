#include <iostream>
#include <math.h>
#include <cstdlib>
using namespace std;
float a,b,c,delta,pierwiastek;
float x1,x2,x0;
int main()
{
    while(cin>>a>>b>>c)
    {
     delta=(b*b)-(4*a*c);
     if(delta>0){
        pierwiastek= sqrt( delta );
        x1=(-b-pierwiastek)/(2*a);
        x2=(-b+pierwiastek)/(2*a);
        cout << "Twoje x1= " << x1 << endl << "Twoje x2= " << x2 << endl;
     }
     else if (delta==0)
     {
        x0=-b/(2*a);
        cout << "Twoje x0= " << x0  << endl;
     }
     else if (delta<0)
        cout << "Nie ma miejsc zerowych" << endl;
    }
    return 0;
}
