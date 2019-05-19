#include <iostream>
#include <math.h>
using namespace std;
float a,b,c,d,e,m,srednia;
int main()
{
    cin>>a>>b>>c>>d>>e;
    srednia=(a+b+c+d+e)/5;
    m=a;
    if(fabs(srednia-b)<(srednia-a)) m=b;
    if(fabs(srednia-c)<(srednia-m)) m=c;
    if(fabs(srednia-d)<(srednia-m)) m=d;
    if(fabs(srednia-e)<(srednia-m)) m=e;
    cout<<m;
    return 0;
}
