#include <iostream>
using namespace std;
bool spr(int a, int b);
void load(int &m, int &n);
void action(int &m, int &n);
int main()
{
  int m,n;
  load(m,n);
  action(m,n);
  return 0;
}
//---------------------------------------
void load(int &m, int &n)
{
  int condit[3];
  bool check = true;
  while(check)
  {
    cout << "M: "; cin >> m;
    cout << "N: "; cin >> n;
    if(m!=0 && n!=0){
    if((m%2==0 && n%2) || (m%2 && n%2==0)) {condit[0]=1;}
    if(m>n){condit[1]=1;}
    if(spr(m,n)==true) {condit[2]=1;}
    if((condit[0]==1) && (condit[1] == 1) && (condit[2] == 1)) {check = false;}
    else cout << "WPROWADZONE LICZBY SA NIEPRAWIDLOWE" << endl;
    }
  }
}
void action(int &m, int &n)
{
  int a,b,c;
  c = (m*m)+(n*n);
  a = (m*m)-(n*n);
  b = 2*m*n;
  cout << "A: " << a << endl << "B: " << b << endl << "C: " << c << endl;
}

bool spr(int a, int b)
{
  {
    while(a != b){
      if(a < b) b -= a; else a -= b;
    }
    if(a==1) return true;
    else return false;
  }
}
