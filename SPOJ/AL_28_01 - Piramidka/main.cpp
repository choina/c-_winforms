#include <iostream>
#include <cstdlib>
#include <string>

using namespace std;
string napis;
int liczba;
string nowy;
int med;
string pom;
string pom2;
int main()
{
    cin >> liczba;
    cin >> napis;
    int g=liczba/2;
    nowy = napis.substr(liczba/2,1);
    for(int i=0; i<liczba/2; i++)
    {
        nowy.insert(1,".");
    }
    {
    for(int i=0; i<liczba/2; i++)
        nowy.insert(0,".");
    }
    for(int i=liczba/2; i<nowy.length()+1; i++)
    {
        pom=napis.substr(i,1);
        if(nowy[i]=='.')
        {
            nowy.erase(i,1);
            nowy.insert(i,pom);
        }
        pom2=napis.substr(g,1);
        if(nowy[g]=='.')
        {
         nowy.erase(g,1);
        nowy.insert(g,pom2);
        }
        if(g>0)
        {
        g--;
        cout << nowy << endl;
        }
    }
            cout << nowy << endl;
    return 0;
}
