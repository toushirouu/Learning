#include <iostream>

using namespace std;
int srednia,suma=0, oceny[5];
int main()
{
    for(int i=0;i<5;i++)
    {
    cout<<"Podaj ocene "<<i+1<<endl;
    cin>>oceny[i];
    suma+=oceny[i];
    }
    srednia= suma/5;
    cout<<srednia<<endl;

    return 0;
}
