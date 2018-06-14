#include <iostream>
#include <cstdlib>
#include <cstdio>
void load(int &p1, int &p2, float &a, float &b, float &c);
void x(float a,float  b, float c);
int main()
{
    int p1, p2;
    float a, b, c;
    load(p1,p2, a, b, c);
    x(a, b, c);

return 0;
}
void load(int &p1, int &p2, float &a, float &b, float &c)
{
    const char * getException( 0 );
    for(;; )
    {
        std::cout << "Przedzial[ p1, p2: (2,1) ]" << std::endl;
        std::cin >> p1 >> p2;
        std::cout << "ax^2="; std::cin >> a;
        std::cout << "bx="; std::cin >> b;
        std::cout << "c="; std::cin >> c;
        try
        {
            if( std::cin.fail() ) throw "Input error.";
            if( p2 > p1 || p2 == p1 ) throw "Input error.";

        }
        catch( const char * getException )
        {
            std::cout << getException << std::endl;
            std::cin.clear();
            std::cin.sync();
            continue;
        }
        break;
    }
}
void x(float a,float  b, float c)
{
    int d = (b*b) - 4 * a * c;
    std::cout << d << std::endl;
}
