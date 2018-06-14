#include <iostream>
#include <math.h>

using namespace std;
int test,x;
void check(int a)
{
    int g=0;
    for(int i=a;i>0;i--)
    {
        if(a%i==0) g++;
        else continue;
    }
    if(g==2) cout << "TAK" << endl;
    else cout << "NIE" << endl;
}
int main()
{
cin >> test;
for(int i=0;i<test;i++)
{
    cin >> x;
    check(x);
}
    return 0;
}
