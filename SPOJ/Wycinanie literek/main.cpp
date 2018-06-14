#include <iostream>
using namespace std;
char c;
char tab[101];
int main()
{
    while(cin >> c >> tab){
    for(int i=0;i<100;i++)
    {
        if(tab[i]==c)
        {
            tab[i]=NULL;
        }
    }
    for(int i=0;i<100;i++){
        if(tab[i]!=NULL) cout << tab[i];
    }
    cout << endl;
    }
    return 0;
}
