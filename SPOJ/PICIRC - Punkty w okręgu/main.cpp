#include <iostream>

using namespace std;
int x0; int y0; int r;
int xi; int yi;
int lewa; int prawa;
int liczba;
int main()
{
    cin >> x0 >> y0 >> r;
    prawa = r*r;
    cin >> liczba;
    for(int i=0;i<liczba;i++)
    {
      cin >> xi >> yi;
      lewa = ((xi-x0)*(xi-x0)) + ((yi-y0) * (yi-y0));
      if(lewa==prawa) cout << "E" << endl;
      else if(lewa<prawa) cout << "I" << endl;
      else cout << "O" << endl;
    }
    return 0;
}
